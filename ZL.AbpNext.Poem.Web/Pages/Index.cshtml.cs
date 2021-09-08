using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ZL.AbpNext.Poem.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        //public IActionResult OnGet()
        //{
        //    return new JsonResult(new { Age = 18 });
        //}

        public IActionResult Get()
        {
            return new JsonResult(new { Age = 19 });
        }

        public IActionResult ToOther()
        {
            return new RedirectResult(Url.Action("Index", "Other"));
        }
    }
}
