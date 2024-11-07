using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; 
using System.ComponentModel.DataAnnotations;
 
namespace CarAndAllProject.Pages
{
    public class CreateAccountModel : PageModel
    {
        [BindProperty]
        public UserInputModel User { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            return RedirectToPage("/Index");
        }

        public class UserInputModel
        {
            [Required]
            [StringLength(100)]
            [Display(Name = "Naam")]
            public string Name { get; set; }

            [Required]
            [StringLength(200)]
            [Display(Name = "Adres")]
            public string Address { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "06Nummer")]
            [RegularExpression(@"^(\+31|0)[6]{1}[1-9]\d{7}$", ErrorMessage = "Ongeldig telefoonnummer formaat.")]
            public string PhoneNumber { get; set; }
        }
    }
}