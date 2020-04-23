using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class SocialBooksDalMng
    {
        //Listeleme fonksiyonu
        public List<SocialBooks> GetAllSocialBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.SocialBooks.ToList();
            }
        }

        //Ekleme fonksiyonu
        public void Add(SocialBooks socialBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(socialBooks);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //Güncelleme fonksiyonu
        public void Update(SocialBooks socialBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(socialBooks);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Silme fonksiyonu
        public void Delete(SocialBooks socialBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(socialBooks);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }    
        }



    }
}
