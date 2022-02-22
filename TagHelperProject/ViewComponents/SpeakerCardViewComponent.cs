using Microsoft.AspNetCore.Mvc;
using TagHelperProject.Models;

namespace TagHelperProject.ViewComponents
{
    public class SpeakerCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Speaker speaker)
        {
            return View(speaker);
        }
    }
}
