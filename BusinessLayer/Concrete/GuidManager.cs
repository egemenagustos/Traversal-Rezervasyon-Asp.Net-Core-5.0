using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuidManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuidManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetList();
        }

        public Guide GetById(int id)
        {
           return _guideDal.GetById(id);
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TChangeToFalse(int id)
        {
            _guideDal.ChangeToFalse(id);
        }

        public void TChangeToTrue(int id)
        {
            _guideDal.ChangeToTrue(id);
        }

        public void TRemove(Guide t)
        {
            _guideDal.Delete(t);
        }

        public void TUpdate(Guide t)
        {
           _guideDal.Update(t);
        }
    }
}
