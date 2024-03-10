﻿using AspNetMvc_Cv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc_Cv.Repositories
{
    public class GenericRepository<T> where T : class,new()
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

    }
}