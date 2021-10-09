using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asprazor06;
using Microsoft.AspNetCore.Authorization;

namespace asprazor06.Pages_Blog
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly asprazor06.NewsDBContext _context;

        public IndexModel(asprazor06.NewsDBContext context)
        {
            _context = context;
        }
        public const int NUMBER_PAGE=1;
        public IList<Article> Article { get;set; }
        [BindProperty(SupportsGet =true, Name="p")]
        public int currentPage{get; set;}
        public int countPages{get; set;}
        public async Task OnGetAsync(string Search)
        {
            int totalArticl= await _context.articles.CountAsync();
            var count= totalArticl/NUMBER_PAGE;
            Console.Write("count="+count);
            if( totalArticl%NUMBER_PAGE==0)
            {
                countPages=count;
            }else{
                countPages=count+1;
            }
            if(currentPage<1)
            {
                currentPage=1;
            }
            if(currentPage>countPages)
            {
                currentPage=countPages;
            }

            var articleToDate=(from article in _context.articles orderby article.Created descending select article).Skip((currentPage-1)).Take(NUMBER_PAGE);
            // Search to name article
            if(string.IsNullOrEmpty(Search))
            {
               Article=await articleToDate.ToListAsync(); 
            }else{
                var articleToTitle= from article in _context.articles where article.Title.Contains(Search) select article;
                Article=await articleToTitle.ToListAsync();
            }
            
            
        }
    }
}
