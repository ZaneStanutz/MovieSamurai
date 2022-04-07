using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MovieSamurai.Models;
using MovieSamurai.Models.Twitter;
using MovieSamurai.Models.Pexels;

namespace MovieSamurai
{
    public class Program
    {   
        // TmDB
        public static Fetch fetch = new Fetch(); 
        public static UpcommingSet upcommingSet = new UpcommingSet();
        public static PosterSet posterSet = new PosterSet();
        public static Movie movie =  new Movie();
        public static Credits credits = new Credits();
        public static VideoSet videoSet = new VideoSet();
        public static Person person = new Person();
        public static ActorExternal actorexternal = new ActorExternal();
        public static ActorImages actorImages = new ActorImages();
        public static ActorAppearsOn actorAppearsOn = new ActorAppearsOn();

        // twitter
        public static TwitterFetch twitterFetch = new TwitterFetch();
        public static TwitterId twitterId = new TwitterId();
        public static ActorTweets actorTweets = new ActorTweets();

        //pexels
        public static PexelsFetch pexelsFetch = new PexelsFetch();
        public static PexelsData pexelsData = new PexelsData();
    
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
