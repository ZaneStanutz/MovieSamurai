
using System.Collections.Generic;

namespace MovieSamurai.Models {

    public class ActorAppearsOn {

            public List<MoviesAsActor> cast { get; set; }
            public List<MoviesAsCrew> crew { get; set; }
            public int id { get; set; }

        }
    
}