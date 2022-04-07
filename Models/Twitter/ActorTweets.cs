
using System.Collections.Generic;
using System;

namespace MovieSamurai.Models.Twitter {

    public class ActorTweets {

        public List<Tweets> data { get; set; }
        public Meta meta { get; set; }

    }

    public class Tweets {
        
        public DateTime created_at { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    
    }

    public class Meta {

        public string oldest_id { get; set; }
        public string newest_id { get; set; }
        public int result_count { get; set; }
        public string next_token { get; set; }
    
    }

}