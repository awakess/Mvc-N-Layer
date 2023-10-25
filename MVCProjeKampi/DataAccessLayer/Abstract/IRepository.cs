using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository <T>            //db den tabloları tek tek insert delete update yapmak yerine
                                                //t ye gönderip t üzerinden işlem yapmak için 

    {
        List<T> List ();
        void Insert(T p);
        T Get(Expression<Func<T, bool>> filter);        //idsi 5 olan yazarı listelemek için (tek değer döndürme)
        void Delete(T p);
        void Update(T p);

        //ICategoryDal gibi tüm tablolara Interface oluşturmak yerine ana bir interface üzerinden yaptık
         
        List<T> List(Expression<Func<T, bool>> fitler);        //Lambda yapısı (şartlı listeleme metodu)
    }
}
