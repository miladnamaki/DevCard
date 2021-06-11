using System.Collections.Generic;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace DevCard_Mvc.ViewComponet
{
    public class LetsArticleViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1, "آموزش Mvc Core  ", "کاملترین پکیج به زبان فارسی ", "blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش Git&Github  ","کاملترین پکیج به زبان فارسی Git&Github  ","blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش Onion Architecture  ","کاملترین پکیج به زبان فارسی Onion Architecture","blog-post-thumb-card-3.jpg"),


            };
            return View("_LatesArticles", article);

        }
    }
}
