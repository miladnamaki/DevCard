namespace DevCard_Mvc.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set;  }
        public string Description { get; set; }
        public string Image { get; set;  }

        public Article(int id, string title, string description, string image)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Image = image;
        
        }








    }
}