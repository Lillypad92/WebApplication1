using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Animal
    {
        public string ImageSrc { get; set; }
        public string Name { get; set; }
    }

    public class AnimalsModel : PageModel
    {

        public List<Animal> Animals { get; set; }

        public AnimalsModel() 
        {
            Animals = new List<Animal>()
            {
                new Animal{ImageSrc = "images/computer-code.jpg", Name = "Blåsfisk"},
                new Animal{ImageSrc = "images/computer-code.jpg", Name = "Katt"},
                new Animal{ImageSrc = "images/computer-code.jpg", Name = "Hund"},
                new Animal{ImageSrc = "images/computer-code.jpg", Name = "Mask"}
            };
        }

        public void OnGet()
        {
        }
    }
}
