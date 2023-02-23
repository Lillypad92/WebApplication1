using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class AnimalsModel : PageModel
    {
        private readonly AnimalContext _context;

        public AnimalsModel(AnimalContext context)
        {
            _context = context;
        }

        public List<Animal> Animals { get; set; }

        public void OnGet()
        {
            //new Animal{ImageSrc = "images/computer-code.jpg", Name = "Blåsfisk", Age = 1, Link = "/Animals/Dog"},
            Animals = _context.Animal.ToList();
        }
    }
}

