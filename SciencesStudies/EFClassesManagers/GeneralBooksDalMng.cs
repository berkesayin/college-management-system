using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class GeneralBooksDalMng
    {   
        //Listeleme fonksiyonu
        public List<GeneralBooks> GetAllGeneralBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities() )
            {
                return context.GeneralBooks.ToList();
            }
        }
        //Ekleme fonksiyonu
        public void Add(GeneralBooks generalBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(generalBooks);
                entity.State = EntityState.Added;
                context.SaveChanges();

                //context.GeneralBooks.Add(generalBooks);
                //context.SaveChanges(); 

            }
        }
        //Güncelleme fonksiyonu
        public void Update(GeneralBooks generalBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(generalBooks);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Silme fonksiyonu
        public void Delete(GeneralBooks generalBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(generalBooks);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
