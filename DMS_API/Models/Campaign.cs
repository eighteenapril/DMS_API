namespace DMS_API.Models
{
    public class Campaign
    {

        public int id { get; set; }
        
        public int cause_id { get; set; }

        public string? cause_name { get; set; }

        public string? name { get; set; }

        public string? sub_title { get; set; }

        public string? img { get; set; }

        public decimal? raised { get; set; }

        public decimal? goal { get; set; }

        public string? description { get; set; }

        public int donors_count { get; set; }      

       
    }
}
