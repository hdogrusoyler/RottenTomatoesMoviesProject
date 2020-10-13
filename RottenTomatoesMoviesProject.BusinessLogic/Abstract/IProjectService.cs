using RottenTomatoesMoviesProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RottenTomatoesMoviesProject.BusinessLogic.Abstract
{
    public interface IProjectService
    {
        Task<MovieDetail> Get(int id);
        Task<MoviesResponse> GetList(string q, int page_limit, int page);
        Task<MoviesResponse> GetListBySearch(string q);
    }
}
