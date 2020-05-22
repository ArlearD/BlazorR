using BlazoR.Data;
using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BlazoR.Shared
{
    public class PostService
    {
        private readonly PostRepository repository;

        public PostService(ApplicationDbContext sharedDatabase)
        {
            repository = new PostRepository(sharedDatabase);
        }

        public List<Post> GetPosts()
        {
            return repository.GetAllElements();
        }

        public void CreatePost(Post post)
        {
            repository.Create(post);
        }

        public void DeletePost(Post post)
        {
            repository.DeleteById(post.Id);
        }
    }
}
