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
    public class Top10TvSerieListManager : IGenericService<Top10TvSerieList>
    {
        private readonly ITop10TvSerieListDal _top10TvSerieListDal;

        public Top10TvSerieListManager(ITop10TvSerieListDal top10TvSerieListDal)
        {
            _top10TvSerieListDal = top10TvSerieListDal;
        }

        public void TDelete(Top10TvSerieList t)
        {
            _top10TvSerieListDal.Delete(t);
        }

        public Top10TvSerieList TGetByID(int id)
        {
            return _top10TvSerieListDal.GetByID(id);
        }

        public List<Top10TvSerieList> TGetList()
        {
            return _top10TvSerieListDal.GetList();
        }

        public List<Top10TvSerieList> TGetListByFilter(Expression<Func<Top10TvSerieList, bool>> filter)
        {
            return _top10TvSerieListDal.GetListByFilter(filter);
        }

        public void TInsert(Top10TvSerieList t)
        {
            _top10TvSerieListDal.Insert(t);
        }

        public void TUpdate(Top10TvSerieList t)
        {
            _top10TvSerieListDal.Update(t);
        }
    }
}
