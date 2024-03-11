using AspNetMvc_Cv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AspNetMvc_Cv.Repositories
{
    public class GenericRepository<T> where T : class, new()//constraint belirleme
    {
        //T = generik bir tür
        //T bir sınıf olmalı ve sınıfın özelliklerini almalı = where T : class
        //new() = newlenebilir olmalı

        DbCvEntities db = new DbCvEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete (T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet (int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            //LINQ sorgularını temsil eden bir ifadedir. Bu ifade, aranan nesnelerin belirli bir koşulu sağlaması gerektiğini belirtir. Func<T, bool> kısmı, bu ifadenin bir işlev olduğunu belirtir; yani T türünden bir nesne alır ve bool türünde bir değer döndürür.
            return db.Set<T>().FirstOrDefault(where);
            //FirstOrDefault metodu, belirtilen koşulu sağlayan ilk öğeyi döndürür veya eğer öyle bir öğe bulunamazsa varsayılan değeri (null gibi) döndürür. 
        }

    }
}