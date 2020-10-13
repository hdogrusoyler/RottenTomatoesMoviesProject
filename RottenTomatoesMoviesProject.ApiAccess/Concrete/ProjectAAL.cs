using RottenTomatoesMoviesProject.ApiAccess.Abstract;
using RottenTomatoesMoviesProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace RottenTomatoesMoviesProject.ApiAccess.Concrete
{
    public class ProjectAAL : IProjectAAL
    {
        private readonly IHttpClientFactory clientFactory;
        public ProjectAAL(IHttpClientFactory _clientFactory)
        {
            clientFactory = _clientFactory;
        }
        public async Task<MovieDetail> Get(int id)
        {
            MovieDetail movieDetail = new MovieDetail();

            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://www.rottentomatoes.com/api/private/v1.0/movies/" + id);
            request.Headers.Add("Accept", "application/json");
            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                movieDetail = await JsonSerializer.DeserializeAsync<MovieDetail>(responseStream);
            }
            else
            {
                //GetBranchesError = true;
                //movieDetail = Array.Empty<MovieDetail>();
            }

            return movieDetail;
        }

        public async Task<MoviesResponse> GetList(string q, int page_limit, int page)
        {
            q.Replace(" ","%20");
            MoviesResponse movies = new MoviesResponse();

            var request = new HttpRequestMessage(HttpMethod.Get,
            //"https: //www.rottentomatoes.com/api/private/v1.0/movies/box_office");
            "https://www.rottentomatoes.com/api/private/v1.0/movies.json?q='" + q + "'&page_limit=" + page_limit +"&page=" + page);
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");
            //request.Headers.Add("Accept", "*/*");
            //request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            //request.Headers.Add("Connection", "keep-alive");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                //using var responseStream = await response.Content.ReadAsStreamAsync();
                using var responseStream = await response.Content.ReadAsStreamAsync();
                movies = await JsonSerializer.DeserializeAsync<MoviesResponse>(responseStream);
            }
            else
            {
                //GetBranchesError = true;
                //movies = Array.Empty<List<Movie>>();
            }

            return movies;
        }

        public async Task<MoviesResponse> GetListBySearch(string q)
        {
            MoviesResponse movies = new MoviesResponse();

            return movies;
        }
    }

}
