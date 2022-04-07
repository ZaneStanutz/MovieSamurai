
namespace MovieSamurai.Models.Twitter {
    
    public class TwitterId {

        public Data data { get; set; }
    
    }

    public class Data {
        
        public string url { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string profile_image_url { get; set; }
        public string description { get; set; }
        public string username { get; set; }
    
    }
}