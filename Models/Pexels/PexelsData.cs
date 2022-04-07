
using System.Collections.Generic;

namespace MovieSamurai.Models.Pexels {

    public class PexelsData {

        public int total_results { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
        public List<Photo> photos { get; set; }
        public string next_page { get; set; }
        
    }
}