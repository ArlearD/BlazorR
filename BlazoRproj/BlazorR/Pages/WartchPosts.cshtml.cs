using BlazoR.Data;
using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazoR.Pages
{
    public class WartchPostsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public WartchPostsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Posts.ToListAsync();
        }
    }
}
