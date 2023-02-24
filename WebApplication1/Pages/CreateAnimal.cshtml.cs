using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Animals
{
    public class CreateAnimalModel : PageModel
    {
        private readonly AnimalContext _context;

        public List<Animal> Animals { get; set; }

        public CreateAnimalModel(AnimalContext context)
        {
            _context = context;

            Animals = context.Animal.ToList();
        }

        public void OnPostCreate(string type, string image, string link)
        {
            var animal = new Animal
            {
                Image = image,
                Link = link,
                Type = type,
            };

            _context.Add(animal);
            _context.SaveChanges();
        }

        public IActionResult OnPostGetAnimalData(int id)
        {
            var animal = _context.Animal.Find(id);

            return new JsonResult(animal);
        }

        public void OnPostUpdate(string type, string image, string link, int id)
        {
            var animal = _context.Animal.Find(id);
            if (animal == null) return;

            animal.Image = image;
            animal.Link = link;
            animal.Type = type;

            _context.SaveChanges();
        }

        public void OnPostDelete(int id)
        {
            var animal = _context.Animal.Find(id);
            if (animal == null) return;

            _context.Animal.Remove(animal);
            _context.SaveChanges();
        }
    }
}
