using MVC_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEST.Controllers
{
    public class CardController : Controller
    {
        // GET: Card
        public ActionResult ManCard()
        {
            List<Card> cards = new List<Card>()
            {
                new Card{ Name = "Elon Musk", Brief="特斯拉創辦人 伊隆·馬斯克", Photo="ElonMusk.jpg", linkUrl="https://goo.gl/46xeXx" },
                new Card{ Name = "Mark Zuckerberg", Brief="Facebook創辦人 馬克·祖伯克", Photo="MarkZuckerberg.jpg", linkUrl="https://goo.gl/BktGGA" },
                new Card{ Name = "Steve Jobs", Brief="蘋果創辦人 史提夫·賈伯斯", Photo="SteveJobs.jpg", linkUrl="https://goo.gl/nAiX0y" },
                new Card{ Name = "Vader", Brief="帝國元帥  維達", Photo="Vader.jpg", linkUrl="https://en.wikipedia.org/wiki/Darth_Vader" },
                new Card{ Name = "Darth Mual", Brief="星際大戰 達斯摩", Photo="DarthMual.jpg", linkUrl="https://goo.gl/5obLhX"},
                new Card{ Name = "White Twilek", Brief="星際大戰 女絕地武士Twilek", Photo="WhiteTwilek.jpg", linkUrl="https://goo.gl/reKzAu" }
            };

            return View(cards);
        }
    }
}