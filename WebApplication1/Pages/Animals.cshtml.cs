using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Animal
    {
        public string ImageSrc { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class AnimalsModel : PageModel
    {

        public List<Animal> Animals { get; set; }

        public AnimalsModel()
        {
            Animals = new List<Animal>()
            {
                new Animal{ImageSrc = "images/computer-code.jpg", Name = "Blåsfisk", Age = 1},
                new Animal{ImageSrc = "images/computer-code.jpg", Name = "Katt", Age = 2},
                //new Animal{ImageSrc = "images/computer-code.jpg", Name = "Hund", Age = 3},
                //new Animal{ImageSrc = "images/computer-code.jpg", Name = "Mask", Age = 4},
                //new Animal{ImageSrc = "images/computer-code.jpg", Name = "Blåmes", Age = 5},
                //new Animal{ImageSrc = "images/computer-code.jpg", Name = "Kråka", Age = 6},
            };
        }

        public void OnGet()
        {
        }
    }
}

