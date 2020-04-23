using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class NewspapersDalMng
    {   
        //listeleme
        public List<Newspapers> GetAllNewspapers()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Newspapers.ToList();
            }
        }

        //ekleme
        public void Add(Newspapers newspapers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(newspapers);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //güncelleme
        public void Update(Newspapers newspapers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(newspapers);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //silme 
        public void Delete(Newspapers newspapers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(newspapers);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
