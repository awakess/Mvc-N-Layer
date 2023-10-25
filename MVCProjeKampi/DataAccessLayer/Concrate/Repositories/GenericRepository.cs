using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();
        DbSet<T> _object;                        //_objectt değerine karşılık gelen sınıfı tutar

        public GenericRepository()          //contstructure metodu oluşturduk (ilgili t calssını çağırabilmek için)
        {
            _object = c.Set<T>(); 
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;   //silme işleminide entity state üzerinde gerçekleştiriyoruz 
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);                 //bir dizide veya listede sadece 1 tane değer  döndğrmek için kullanılan EF linq metodudur
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;   //ekleme işlemini entity state üzerinde gerçekleştiriyoruz 
           // _object.Add(p);                           //bu sayede _object.add(p) komutuna gerek kalmıyor.
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();    
        }

        public List<T> List(Expression<Func<T, bool>> fitler)
        {
            return _object.Where(fitler).ToList();  
        }
        public void Update(T p)
        {
            var updatedEntity = c.Entry(p); 
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges(); 
        }



        //public void Update(T p)
        //{
        //    c.SaveChanges(); //istediğimiz sonucu vermedi
        //}

        /* 
           burada writer repo category repo da olduğu gibi tek tek yazmaya gerek kalmadan
           tüm kodaları generic repo üzerinden almış olduk.
        */

        //MİMARİ YAPISI BUDUR
    }
}
