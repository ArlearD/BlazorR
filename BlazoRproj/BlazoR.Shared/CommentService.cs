using BlazoR.Data;
using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BlazoR.Shared
{
    public class CommentService
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly CommentRepository repository;

        public CommentService(IHttpContextAccessor accessor, ApplicationDbContext context)
        {
            _accessor = accessor;
            repository = new CommentRepository(context);
        }

        public List<Comment> GetComments(Post post)
        {
            return repository.GetPostComments(post);
        }

        public void AddNewComment(string text, Post post)
        {
            Comment comment = new Comment()
            {
                Post = post,
                Sender = _accessor.HttpContext.User.Identity.Name,
                Text = text
            };

            repository.Create(comment);
        }
    }
}
