 
using System.Collections.Generic;

namespace MovieSamurai.Models {
    
    public class PosterSet {  // PosterSet is a containter object for a list of poster objects
                            
        public int page { get; set; }
        public List<Poster> results { get; set; } // list of Poster
        public int total_pages { get; set; }
        public int total_results { get; set; }
    
    } // PosterSet

} // Namespace