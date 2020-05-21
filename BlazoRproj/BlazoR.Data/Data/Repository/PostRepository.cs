using BlazoR.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlazoR.Data.Data.Repository
{
    public class PostRepository : IRepository<Post>
    {
        private readonly ApplicationDbContext _dbContext;

        public PostRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Post obj)
        {
            _dbContext.Posts.Add(obj);
            _dbContext.SaveChanges();
        }

        public void DeleteById(long id)
        {
            var obj = GetElementById(id);
            if (obj != null)
                _dbContext.Posts.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Post> GetAllElements()
        {
            return _dbContext.Posts.ToList();
        }

        public Post GetElementById(long id)
        {
            return _dbContext.Posts.Find(id);
        }

        public void Update(Post obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
        }
    }
}
