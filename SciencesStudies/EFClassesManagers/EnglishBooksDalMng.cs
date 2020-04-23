using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class EnglishBooksDalMng
    {   
        //Listeleme fonksiyonu
        public List<EnglishBooks> GetAllEnglishBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.EnglishBooks.ToList();
            }
        }

        //Ekleme fonksiyonu
        public void Add(EnglishBooks englishBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(englishBooks);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //Güncelleme fonksiyonu
        public void Update(EnglishBooks englishBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(englishBooks);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Silme fonksiyonu
        public void Delete(EnglishBooks englishBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(englishBooks);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


    }
}
