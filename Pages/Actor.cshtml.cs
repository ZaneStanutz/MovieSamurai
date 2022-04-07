
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages; 
using System.Threading.Tasks;
using MovieSamurai.Models.Twitter;
using System;
using MovieSamurai.Models;

namespace MovieSamurai.Pages {

    public class ActorModel : PageModel {

        // GetActorDetails()
        public string castID;
        public string name;    
        public string bio;
        public string birthday;
        public string deathday;
        public string birthplace;
        public string picPath;

        public DateTime currentdate = DateTime.Now;

        // GetActorImageGallery()
        public List<string> photoGalleryUrl = new List<string>();
        public List<int> photoGalleryHeight = new List<int>();
        public List<int> photoGalleryWidth = new List<int>();

        public int  MAX_ACTOR_IMAGES = 0;
                
        // GetActorAppearsOn()
        public List<string> posterPaths = new List<string>();
        public List<string> overviews = new List<string>();
        public List<int> appearsOnMovieIDs = new List<int>();
        public List<string> appearsOnMovieTitles = new List<string>(); 

        public int ACTOR_APPEARSON_MAX_RESULTS = 0;
        
        // GetActorExternal()
        public string twitterName; 


        //GetTwitteruser()
        public string twitterID;
        public string twitterProfilePath;

        //GetTweets()
        public List<DateTime> tweetTimes = new List<DateTime>();
        public List<string> tweetText = new List<string>();
        public List<string> renderedTweetText = new List<string>();

        public async Task OnGet(string id) { // alot going on in this OnGet()
            
            castID = id;
            
            await Program.fetch.GetActorDetails(castID);
            
            name = Program.person.name;
            bio = Program.person.biography;
            birthday = Program.person.birthday;
            deathday = Program.person.deathday;
            birthplace = Program.person.place_of_birth;
            picPath =  Program.person.profile_path;

            //Actor Image Gallery
            await Program.fetch.GetActorImageGallery(castID);
            foreach(Profile P in Program.actorImages.profiles) {
                photoGalleryUrl.Add(P.file_path);
                photoGalleryHeight.Add(P.height);
                photoGalleryWidth.Add(P.width);
            }
            if(Program.actorImages.profiles.Count > 4) {
                MAX_ACTOR_IMAGES = 4;
            }
            else {
                MAX_ACTOR_IMAGES = Program.actorImages.profiles.Count;
            }
            
            //Get Actor Appears On
            await Program.fetch.GetActorAppearsOn(castID);
            foreach(MoviesAsActor M in Program.actorAppearsOn.cast) {
                posterPaths.Add(M.poster_path);
                overviews.Add(M.overview);
                appearsOnMovieIDs.Add(M.id);
                appearsOnMovieTitles.Add(M.title);
            }
            if(Program.actorAppearsOn.cast.Count > 10) {
                
                ACTOR_APPEARSON_MAX_RESULTS = 10;
            }
            else {
                ACTOR_APPEARSON_MAX_RESULTS = Program.actorAppearsOn.cast.Count;
            }
            
            // get twitter ID  Then Call Twitter ID
            await Program.fetch.GetActorExternal(castID);

            twitterName = Program.actorexternal.twitter_id;

            if(twitterName != null && twitterName != "" ) { // inconsistent Data. Sometimes Json returns null for this field.. somtimes it is ""
                Program.twitterFetch.GetTwitterUser(twitterName);
                twitterID = Program.twitterId.data.id;  // issues with this need nested if so program doesnt crash
                twitterProfilePath = Program.twitterId.data.profile_image_url;
                Program.twitterFetch.GetTweets(twitterID);

                foreach(Tweets T in Program.actorTweets.data) {
                    tweetTimes.Add(T.created_at);
                    tweetText.Add(T.text);
                }
            } // if
        } // OnGet() Actor.cs

        public void OnPostShowMovie(string movieID) {  //does not work, having issues. Saaaad panda....
            Redirect("./Index?id=" + movieID);
        }
    } // ActorModel
} // namespace
