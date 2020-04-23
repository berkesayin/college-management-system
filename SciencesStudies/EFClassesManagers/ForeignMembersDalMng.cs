using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class ForeignMembersDalMng
    {
        //Listeleme fonksiyonunu yazalım :
        public List<ForeignMembers> GetAllForeignMembers()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.ForeignMembers.ToList();
            }
        }

        //Ekleme fonksiyonunu yazalım :
        public void Add(ForeignMembers foreignMembers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                //context.ForeignMembers.Add(foreignMembers);
                //context.SaveChanges();

                var entity = context.Entry(foreignMembers);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        //Güncelleme fonksiyonunu yazalım:
        public void Update(ForeignMembers foreignMembers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(foreignMembers);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Silme fonksiyonunu yazalım :
        public void Delete(ForeignMembers foreignMembers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(foreignMembers);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


    }
}
