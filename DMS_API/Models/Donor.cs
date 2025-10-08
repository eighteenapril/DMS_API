namespace DMS_API.Models
{
    public class Donor
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }

        public string? description { get; set; }

        public string? img { get; set; }

        public string? banner_img { get; set; }
    }
}
