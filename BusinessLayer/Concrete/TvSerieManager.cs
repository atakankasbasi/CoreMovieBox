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
    public class TvSerieManager : IGenericService<TvSerie>
    {
        private readonly ITvSerieDal _tvSerieDal;
        public TvSerieManager(ITvSerieDal tvSerieDal)
        {
            _tvSerieDal = tvSerieDal;
        }
        public void TDelete(TvSerie t)
        {
           _tvSerieDal.Delete(t);
        }

        public TvSerie TGetByID(int id)
        {
           return _tvSerieDal.GetByID(id);
        }

        public List<TvSerie> TGetList()
        {
            return _tvSerieDal.GetList();
        }

        public List<TvSerie> TGetListByFilter(Expression<Func<TvSerie, bool>> filter)
        {
            return _tvSerieDal.GetListByFilter(filter);
        }

        public void TInsert(TvSerie t)
        {
            _tvSerieDal.Insert(t);
        }

        public void TUpdate(TvSerie t)
        {
            _tvSerieDal.Update(t);
        }
    }
}
