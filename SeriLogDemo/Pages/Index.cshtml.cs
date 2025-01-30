using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeriLogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("My Logger message");

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i==4)
                    {
                        throw new Exception("This is DEMO app");
                    }
                    else
                    {
                        _logger.LogInformation("val of i is {loopCountValue}", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "We caught this exeception, at index get call");
            }
        }
    }
}
