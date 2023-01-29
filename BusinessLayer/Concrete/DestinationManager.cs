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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetList();
        }

        public Destination GetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TRemove(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
