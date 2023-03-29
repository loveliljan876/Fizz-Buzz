using FizzBuzz.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace Fizz_Buzz.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public FizzBuzzForm FizzBuzz { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzzForm>(Data);

        }
    }
}
