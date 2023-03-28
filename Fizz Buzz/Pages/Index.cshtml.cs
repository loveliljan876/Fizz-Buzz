using Fizz_Buzz.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fizz_Buzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
        public FizzBuzzForm FizzBuzz { set; get; }

        [BindProperty]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
               
            }
            UpdateResponse();
            return Page();
        }
        public void UpdateResponse()
        {
            if (FizzBuzz.Number % 3 == 0)
            {
                FizzBuzz.Response = "Fizz";
            }
            if (FizzBuzz.Number % 5 == 0)
            {
                FizzBuzz.Response = "Buzz";
            }
            if (FizzBuzz.Number % 3 == 0 && FizzBuzz.Number % 5 == 0)
            {
                FizzBuzz.Response = "FizzBuzz";
            }
            else
            {
                FizzBuzz.Response = "Liczba: " + FizzBuzz.Number.ToString() + " nie spełnia kryteriów FizzBuzz";
            }
        }

    }
}