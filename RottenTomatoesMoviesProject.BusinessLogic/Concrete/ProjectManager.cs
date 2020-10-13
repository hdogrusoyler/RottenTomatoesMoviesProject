using RottenTomatoesMoviesProject.ApiAccess.Abstract;
using RottenTomatoesMoviesProject.BusinessLogic.Abstract;
using RottenTomatoesMoviesProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RottenTomatoesMoviesProject.BusinessLogic.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectAAL projectAAL;
        public ProjectManager(IProjectAAL _projectAAL)
        {
            projectAAL = _projectAAL;
        }

        public async Task<MovieDetail> Get(int id)
        {
            MovieDetail movieDetail = new MovieDetail();

            movieDetail = await projectAAL.Get(id);

            return movieDetail;
        }

        public async Task<MoviesResponse> GetList(string q, int page_limit, int page)
        {
            MoviesResponse movies = new MoviesResponse();

            movies = await projectAAL.GetList(q, page_limit, page);

            return movies;
        }

        public async Task<MoviesResponse> GetListBySearch(string q)
        {
            MoviesResponse movies = new MoviesResponse();

            movies =  await projectAAL.GetListBySearch(q);

            return movies;
        }
    }
}
