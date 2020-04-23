using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class LiteratureBooksDalMng
    {   
        //Listeleme fonksiyonu
        public List<LiteratureBooks> GetAllLiteratureBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.LiteratureBooks.ToList();
            }
        }
       
        //Ekleme fonksiyonu
        public void Add(LiteratureBooks literatureBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(literatureBooks);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        
        //Güncelleme fonksiyonu
        public void Update(LiteratureBooks literatureBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(literatureBooks);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Silme fonksiyonu
        public void Delete(LiteratureBooks literatureBooks)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(literatureBooks);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
