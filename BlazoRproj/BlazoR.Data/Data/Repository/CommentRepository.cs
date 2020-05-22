using BlazoR.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlazoR.Data.Data.Repository
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly ApplicationDbContext _dbContext;

        public CommentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Comment obj)
        {
            _dbContext.Comments.Add(obj);
            _dbContext.SaveChanges();
        }

        public void DeleteById(long id)
        {
            var obj = GetElementById(id);
            if (obj != null)
                _dbContext.Comments.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Comment> GetAllElements()
        {
            return _dbContext.Comments.ToList();
        }

        public Comment GetElementById(long id)
        {
            return _dbContext.Comments.Find(id);
        }

        public void Update(Comment obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        public List<Comment> GetPostComments(Post post)
        {
            var a = _dbContext.Posts
                .SelectMany(p => p.Comments)
                .Where(c => c.Post.Id == post.Id)
                .ToList();
            return a;
        }
    }
}
