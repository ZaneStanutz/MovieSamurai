
using System.Net.Http;
using System.Threading.Tasks;  // async and await
using System.Text.Json;
using MovieSamurai.Models;


namespace MovieSamurai {
    public class Fetch {
        public HttpClient client = new HttpClient(); // headless browser asking for data.
        public const string API_KEY = "dec0d7edd7776585283e7e337bbc16ce"; // my key
        public string Data { get; set; }
        public string Videos { get; set; }
        public string Details { get; set; }
        public string Credits { get; set; }

        public async Task Upcomming() {
            ClearHeaders();
            // gets new releases
            HttpResponseMessage response = await client.GetAsync(  // async in function header needs await to work
                "https://api.themoviedb.org/3/movie/upcoming?api_key=" 
                + API_KEY + "&language=en-CA&page=1");
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.upcommingSet = JsonSerializer.Deserialize<UpcommingSet>(Data);
            }
            else {
                Data = null;
            }
        } //Upcomming()

        public async Task Search(string search) {
            ClearHeaders();
            // does a movie search
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/search/movie?api_key=" + API_KEY + "&query=" + search);
            if(response.IsSuccessStatusCode) { // 200 
                Data = await response.Content.ReadAsStringAsync();
                Program.posterSet = JsonSerializer.Deserialize<PosterSet>(Data);
            }
            else {
                Data = null;
            }
        } //Search
        public async Task GetDetails(string movieID) {
            ClearHeaders(); 
            // Get details for a single film
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/movie/" + movieID + "?api_key=" + API_KEY
            );
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.movie = JsonSerializer.Deserialize<Movie>(Data);
            }
            else {
                Data = null;
            }
        } // GetDetails()

        public async Task GetCast(string movieID) {
            ClearHeaders();
            // Get cast members
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/movie/" + movieID + "/credits" + 
                "?api_key=" + API_KEY);
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.credits = JsonSerializer.Deserialize<Credits>(Data);
            }
            else {
                Data = null;
            }
        } // GetCast();

        public async Task GetVideo(string movieID) {
            ClearHeaders();
            // Get Video
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/movie/" + movieID + 
                "/videos?" + "api_key=" + API_KEY + "&language=en-CA");
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.videoSet = JsonSerializer.Deserialize<VideoSet>(Data);
            }
            else{
                Data = null;
            }
            
        } // GetVideo()

        public async Task GetActorDetails(string castID) {
            ClearHeaders();
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/person/" + castID + "?api_key=" +
                API_KEY + "&language=en-CA");
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.person = JsonSerializer.Deserialize<Person>(Data);
            }
            else {
                Data = null;
            }
            
        }

        public async Task GetActorExternal(string castID) {
            ClearHeaders();
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/person/" + castID + "/external_ids?api_key=" +
                API_KEY + "&language=en-US");
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.actorexternal = JsonSerializer.Deserialize<ActorExternal>(Data);
            }
            else {
                Data = null;
            }
        }

        public async Task GetActorImageGallery(string castID) {
            ClearHeaders();
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/person/" + castID + 
                    "/images?api_key=" + API_KEY);
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.actorImages = JsonSerializer.Deserialize<ActorImages>(Data);            
            }
            else {
                Data = null;
            }
        }

        public async Task GetActorAppearsOn(string castID) {
            ClearHeaders();
            HttpResponseMessage response = await client.GetAsync(
                "https://api.themoviedb.org/3/person/" + castID + "/movie_credits?api_key=" +
                API_KEY + "&language=en-US"
            );
            if(response.IsSuccessStatusCode) {
                Data = await response.Content.ReadAsStringAsync();
                Program.actorAppearsOn = JsonSerializer.Deserialize<ActorAppearsOn>(Data);
            }
        }


        public void ClearHeaders() {
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));

        } // ClearHearders()
    } //class
} // namespace