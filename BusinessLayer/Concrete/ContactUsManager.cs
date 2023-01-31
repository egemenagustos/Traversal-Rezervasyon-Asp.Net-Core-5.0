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
    public class ContactUsManager : IContactUsService
    {
        IContacUsDal _contacUsDal;

        public ContactUsManager(IContacUsDal contacUsDal)
        {
            _contacUsDal = contacUsDal;
        }

        public List<ContactUs> GetAll()
        {
            return _contacUsDal.GetList();
        }

        public ContactUs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contacUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _contacUsDal.GetListContactUsByTrue();
        }

        public void TRemove(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
