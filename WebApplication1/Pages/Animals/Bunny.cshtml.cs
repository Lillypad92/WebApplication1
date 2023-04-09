using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models.Components;

namespace WebApplication1.Pages.Animals
{
    public class BunnyModel : PageModel
    {
        public List<Card> Cards { get; set; }
        public BunnyModel() {
            Cards = new List<Card> {
            
            new Card()
            {

                Description = "HELLO BUNBUN",
                FooterText = "HEJDÅ",
                ImgSrc ="",
                Title = "Bunny´s story",
                ImgAlt = "Alt text"
                
        
            }
            };
        
        }
        public void OnGet()
        {
        }
    }
}
