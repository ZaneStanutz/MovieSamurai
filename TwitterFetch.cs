
using RestSharp;
using System.Threading.Tasks;
using System;
using MovieSamurai.Models.Twitter;
using System.Text.Json;

namespace MovieSamurai {
    
    public class TwitterFetch {
        
        public string Data { get; set; }
            
        public void GetTwitterUser(string twitterName) {
            
            var client = new RestClient("https://api.twitter.com/2/users/by/username/" + twitterName + 
                "?user.fields=created_at,description,entities,id,location,name,pinned_tweet_id,profile_image_url,protected,public_metrics,url,username,verified,withheld&expansions=pinned_tweet_id&tweet.fields=id,text");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer AAAAAAAAAAAAAAAAAAAAAKFBKAEAAAAAN7BcYXhXL1FhmbJwhxDN7OD71LY%3DSZS2MzEY7lJrrxubuEWdhCQeFpP64vSgTBkSydcxotJ8H3Tt6n");
            request.AddHeader("Cookie", "guest_id=v1%3A163035976632273497; personalization_id=\"v1_NF1qetOf/7Znp5BbmphURA==\"");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            if(response.IsSuccessful) {
                Data = response.Content;
                Program.twitterId = JsonSerializer.Deserialize<TwitterId>(Data);
            }
            else {
                Data = null;
                //Program.twitterId.data.id = " ";
                //Program.twitterId.data.profile_image_url = " ";
            }

        } //GetTwitterUser()

        public void GetTweets(string twitterID) {
            
            var client = new RestClient("https://api.twitter.com/2/users/" + twitterID + 
                "/tweets?tweet.fields=created_at");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer AAAAAAAAAAAAAAAAAAAAAKFBKAEAAAAAN7BcYXhXL1FhmbJwhxDN7OD71LY%3DSZS2MzEY7lJrrxubuEWdhCQeFpP64vSgTBkSydcxotJ8H3Tt6n");
            request.AddHeader("Cookie", "guest_id=v1%3A163035976632273497; personalization_id=\"v1_NF1qetOf/7Znp5BbmphURA==\"");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            if(response.IsSuccessful) {
                Data = response.Content;
                Program.actorTweets = JsonSerializer.Deserialize<ActorTweets>(Data);
            }
            else {
                Data = null;
                //Program.twitterId.data.id = " ";
                //Program.twitterId.data.profile_image_url = " ";
            }

        } // GetTweets()
    
    }

}