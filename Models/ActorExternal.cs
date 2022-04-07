

namespace MovieSamurai.Models {

     public class ActorExternal {

        public int id { get; set; }
        public string freebase_mid { get; set; }
        public string freebase_id { get; set; }
        public string imdb_id { get; set; }
        //public string tvrage_id { get; set; } // issue cannot set null as a number but cannot set number to a string
        public string facebook_id { get; set; }
        public string instagram_id { get; set; }
        public string twitter_id { get; set; }

     }

}