using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class MathematicalBooksDalMng
    {   
        //Listeleme fonksiyonu
        public List<MathematicalBooks> GetAllMathematicalBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.MathematicalBooks.ToList();
            }
        }

        //Ekleme fonksiyonu :
        public void Add(MathematicalBooks mathematicalBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(mathematicalBooks);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //Güncelleme fonksiyonu :
        public void Update(MathematicalBooks mathematicalBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(mathematicalBooks);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Silme fonksiyonu :
        public void Delete(MathematicalBooks mathematicalBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(mathematicalBooks);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
