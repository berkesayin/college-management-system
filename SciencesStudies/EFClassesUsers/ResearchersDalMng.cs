using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class ResearchersDalMng
    {   
        //Listeleme fonksiyonunu yazalım.
        public List<Researchers> GetAllResearchers()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Researchers.ToList();
            }
        }

        //Ekleme fonksiyonunu yazalım
        public void Add(Researchers researchers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                context.Researchers.Add(researchers);
                context.SaveChanges();

                //var entity = context.Entry(researchers);
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }

        //Update-güncelleme fonksiyonunu yazalım
        public void Update(Researchers researchers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(researchers);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Silme fonksiyonunu yazalım
        public void Delete(Researchers researchers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(researchers);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
