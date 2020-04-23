using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class JournalsDalMng
    {   
        //listeleme
        public List<Journals> GetAllJournals()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Journals.ToList();
            }
        }

        //ekleme
        public void Add(Journals journals)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(journals);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //güncelleme
        public void Update(Journals journals)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(journals);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //silme
        public void Delete(Journals journals)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(journals);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
