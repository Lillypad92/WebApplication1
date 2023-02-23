using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Animals
{
    public class TestModel : PageModel
    {
        private readonly AnimalContext _context;

        public TestModel(AnimalContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public void OnPost(string name, string image, string link)
        {
            var animal = new WebApplication1.Models.Animal
            {
                Image = image,
                Link = link,
                Name = name,
            };

            _context.Add(animal);
            _context.SaveChanges();
        }
    }
}
