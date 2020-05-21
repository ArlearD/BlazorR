using BlazoR.Data;
using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
