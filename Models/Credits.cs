

using System.Collections.Generic;

namespace MovieSamurai.Models {

        public class Credits {
            
        public int id { get; set; }
        public List<Cast> cast { get; set; }
        public List<Crew> crew { get; set; }
    }
}