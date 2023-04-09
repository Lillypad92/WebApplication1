using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models.Components;

namespace WebApplication1.Pages.Animals
{
    public class DogModel : PageModel
    {
        public List<Card> Cards { get; set; }

        public DogModel() 
        {
            Cards = new List<Card>
            {
                new Card
                {
                    Description = "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
                    FooterText = "Last updated 3 mins ago",
                    ImgSrc = "",
                    Title = "Card title",
                    ImgAlt = "Alt text"
                },
                new Card
                {
                    Description = "Sommaren är kort, det mesta regnar bort.......",
                    FooterText = "Ledins greatest",
                    ImgSrc = "",
                    Title = "Thomas Ledin",
                    ImgAlt = "Bild på Thomas Leding"
                }
            };
        }


        public void OnGet()
        {
        }
    }
}
