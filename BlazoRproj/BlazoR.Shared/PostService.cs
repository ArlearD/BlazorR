using BlazoR.Data;
using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

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
            return repository.GetAlElements();
        }

        public void CreatePost(Post post)
        {
            post.Sender = _accessor.HttpContext.User.Identity.Name;
            repository.Create(post);
        }
    }
}
