namespace artshop.lppa.equipo._3.DATA.Model
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ArtistId { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int QuantitySold { get; set; }
        public double AvgStars { get; set; }

        public virtual Artist Artist { get; set; }


    }
}