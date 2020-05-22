using BlazoR.Data;
using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BlazoR.Shared
{
    public class PostService
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly PostRepository repository;
        public PostService(IHttpContextAccessor accessor, ApplicationDbContext context)
        {
            _accessor = accessor;
            repository = new PostRepository(context);
        }
        public List<Post> GetPosts()
        {
            return repository.GetAllElements();
        }

        public void CreatePost(Post post)
        {
            post.Sender = _accessor.HttpContext.User.Identity.Name;
            repository.Create(post);
        }
    }
}
