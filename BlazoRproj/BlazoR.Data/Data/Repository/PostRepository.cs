using BlazoR.Domain.Models;
using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<Post> GetAlElements()
        {
            throw new System.NotImplementedException();
        }

        public Post GetElementById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Post obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
