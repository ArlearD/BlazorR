using BlazoR.Data;
using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BlazoR.Shared
{
    public class CommentService
    {
        private readonly CommentRepository repository;

        public CommentService(ApplicationDbContext context)
        {
            repository = new CommentRepository(context);
        }

        public List<Comment> GetComments(Post post)
        {
            return repository.GetPostComments(post);
        }

        public void AddNewComment(string text, Post post, string userName)
        {
            Comment comment = new Comment()
            {
                Post = post,
                Sender = userName,
                Text = text
            };

            repository.Create(comment);
        }
    }
}
