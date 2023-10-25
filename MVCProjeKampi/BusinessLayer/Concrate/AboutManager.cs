using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutManager : IAboutService
    {
        IAboutDal _abuotDal;

        public AboutManager(IAboutDal abuotDal)
        {
            _abuotDal = abuotDal;
        }       

        public void AboutAdd(About about)
        {
            _abuotDal.Insert(about);
            
        }

        public void AboutDelete(About about)
        {
            _abuotDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _abuotDal.Update(about);
        }

        public About GetByID(int id)
        {
            return _abuotDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _abuotDal.List();
        }
    }
}
