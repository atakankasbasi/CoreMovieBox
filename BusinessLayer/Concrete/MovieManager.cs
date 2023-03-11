using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MovieManager : IGenericService<Movie>
    {
        private readonly IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void TDelete(Movie t)
        {
            _movieDal.Delete(t);
        }

        public Movie TGetByID(int id)
        {
           return _movieDal.GetByID(id);
        }

        public List<Movie> TGetList()
        {
           return _movieDal.GetList();
        }

        public List<Movie> TGetListByFilter(Expression<Func<Movie, bool>> filter)
        {
           return _movieDal.GetListByFilter(filter);
        }

        public void TInsert(Movie t)
        {
            _movieDal.Insert(t);
        }

        public void TUpdate(Movie t)
        {
           _movieDal.Update(t);
        }
    }
}
