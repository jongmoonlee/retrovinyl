namespace RetroVynyl.API.Models
{
    public class Carts
    {
       public int Id { get; set; } 
       public int Quatity { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public int Rank { get; set; }
        public int Stock { get; set; }
        public int Year { get; set; }
    }
}