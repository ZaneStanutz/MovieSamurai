
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; 
using MovieSamurai.Models;


namespace MovieSamurai.Pages {

    public class IndexModel : PageModel {

        // Search
        public List<String> posterURLs = new List<string>();
        public List<String> overviews = new List<string>();
        public List<String> movieIDs = new List<string>();
        public int  UPCOMMING_MAX_RESULTS = 0;
        public int MAX_RESULTS = 0;  // if we do not set this to 0 we will get idx OOB error on pageload
        public int CAST_MAX_RESULTS = 0;
        public int VIDEO_MAX_RESULTS = 0;

        // GetDetails
        public string movieTitle = "";
        public string tagline = "";
        public string homepage = "";
        public int budget;
        public string backdropPath = "";
        public string posterPath = "";
        public long revenue = 0;
        public string releaseDate;
        public string overview;
        
        // Cast
        public List<string> castNames = new List<string>();
        public List<string> castIds = new List<string>();
        public List<string> castPics = new List<string>();

        // Video
        public List<string> videoKey = new List<string>();
        public List<string> videoName = new List<string>();
        
        
        public async Task OnGet(string id) {
            if(id != null) {
                await OnPostGetDetails(id);
            }
            else { 
                await Program.fetch.Upcomming();
                foreach(Poster U in  Program.upcommingSet.results) {
                    posterURLs.Add(U.poster_path); 
                    overviews.Add(U.overview);
                    movieIDs.Add(U.id.ToString());
                }
                if(Program.upcommingSet.results.Count >= 10) {
                    UPCOMMING_MAX_RESULTS = 10;
                }
                else {
                    UPCOMMING_MAX_RESULTS = Program.upcommingSet.results.Count;
                }
            }    
        } // OnGet()

        public async Task OnPostSearch(string search) {
            await Program.fetch.Search(search);
            foreach(Poster poster in  Program.posterSet.results) {
                posterURLs.Add(poster.poster_path); 
                overviews.Add(poster.overview);
                movieIDs.Add(poster.id.ToString());
            } // foreach
            if(Program.posterSet.results.Count() >= 10){
                MAX_RESULTS = 10;
            }
            else {
                MAX_RESULTS = Program.posterSet.results.Count();
            } 
        } // OnPostSearch ()

        public async Task OnPostGetDetails(string movieID) {
            await Program.fetch.GetDetails(movieID); 
            movieTitle = Program.movie.title;
            tagline = Program.movie.tagline;
            homepage = Program.movie.homepage;
            budget = Program.movie.budget;
            backdropPath = Program.movie.backdrop_path;
            posterPath = Program.movie.poster_path;
            releaseDate = Program.movie.release_date.Substring(0, 4);
            revenue = Program.movie.revenue;
            overview = Program.movie.overview;
            await GetCast(movieID);
            await GetVideo(movieID);
            //await Program.pexelsFetch.GetMovieGallery(movieTitle); // --> optional pexels call!!!
        } // OnPostGetDetails

        public async Task GetCast(string movieID) {
            await Program.fetch.GetCast(movieID);
            foreach(Cast cast in  Program.credits.cast) { // Cast refers to object type
                castNames.Add(cast.name); 
                castIds.Add(cast.id.ToString());
                castPics.Add(cast.profile_path);
            }
            if(Program.credits.cast.Count >= 10){
                CAST_MAX_RESULTS = 10;
            }
            else {
                CAST_MAX_RESULTS = Program.credits.cast.Count();
            }      
        } // GetCast() 

        public async Task GetVideo(string movieID) {
            await Program.fetch.GetVideo(movieID);
            foreach(Video v in Program.videoSet.results) {
                videoKey.Add(v.key);
                videoName.Add(v.name);
            }
            VIDEO_MAX_RESULTS = 1;
        } // GetVideo()
        
        public void OnPostGetActorDetails(string castID) {
            Response.Redirect("./Actor?id=" + castID);
        } // OnPostGetActorDetails
    
    } // IndexModel

} // namespace
