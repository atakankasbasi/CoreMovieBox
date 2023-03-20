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
    public class Top10MovieListManager : IGenericService<Top10MovieList>
    {
        private readonly ITop10MovieListDal _top10MovieListDal;

        public Top10MovieListManager(ITop10MovieListDal top10MovieListDal)
        {
            _top10MovieListDal = top10MovieListDal;
        }

        public void TDelete(Top10MovieList t)
        {
            _top10MovieListDal.Delete(t);
        }

        public Top10MovieList TGetByID(int id)
        {
            return _top10MovieListDal.GetByID(id);
        }

        public List<Top10MovieList> TGetList()
        {
            return _top10MovieListDal.GetList();
        }

        public List<Top10MovieList> TGetListByFilter(Expression<Func<Top10MovieList, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Top10MovieList t)
        {
            _top10MovieListDal.Insert(t);
        }

        public void TUpdate(Top10MovieList t)
        {
            _top10MovieListDal.Update(t);
        }


    }
}
