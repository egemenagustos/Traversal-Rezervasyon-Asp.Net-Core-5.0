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
            throw new NotImplementedException();
        }

        public void TAdd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TRemove(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
