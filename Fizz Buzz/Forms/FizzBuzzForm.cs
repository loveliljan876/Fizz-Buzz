using System.ComponentModel.DataAnnotations;

namespace Fizz_Buzz.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Twój szczęsliwy numerek")]
        [Required, Range(1, 20, ErrorMessage = "Oczekiwana wartość{0} z zakredu {1} i {2}.")]
   
        public int? Number { get; set; }
        public string? Response { get; set; } = "";
    }
}
