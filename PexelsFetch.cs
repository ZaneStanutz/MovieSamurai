
using PexelsDotNetSDK.Api;
using System.Text.Json;
using System.Threading.Tasks;
using MovieSamurai.Models.Pexels;
using System.Collections.Generic;
using System.Text;
using System;

namespace MovieSamurai {
    
    

    public class PexelsFetch {

        public string Data {get; set;}
        public List<String> photoGalleryUrl = new List<string>();
        

        public async Task GetMovieGallery(string movieTitle) {

            var pexelsClient = new PexelsClient("563492ad6f9170000100000136f2aaa4d8764344be2d026fa8b1cc5a");
            var result = await pexelsClient.SearchPhotosAsync(movieTitle); 
            // returns a PexelsDotNetSDK.Models.Photopage Object type
        


         
            /*
            
            if(result.totalResults > 0) {
                
               
                // We Have no way of converting this object to string 
                Program.pexelsData = JsonSerializer.Deserialize<PexelsData>(result); 
                
            }
            else {
                // do nothing
            }
            
            */
            
        } // GetMovieGallery()
    }
}