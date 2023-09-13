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
                    Description = "Att alla hundraser är en domesticerad underart av vargen, som alla har framavlats utav människan. ",
                    FooterText = "Last updated 3 mins ago",
                    ImgSrc = "/images/dog-icon.png",
                    Title = "Visste du..",
                    ImgAlt = "Alt text"
                },
                new Card
                {
                    Description = "Sommaren är kort, det mesta regnar bort......",
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
