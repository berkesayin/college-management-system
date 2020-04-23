using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class TeachersDalMng
    {   
        //Listeleme fonksiyonu
        public List<Teachers> GetAllTeachers()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Teachers.ToList();
            }
        }
        //Ekleme fonksiyonu
        public void Add(Teachers teachers)
        {
            using (InstituteDbEntities context= new InstituteDbEntities())
            {
                context.Teachers.Add(teachers);
                context.SaveChanges();
                
                //var entity = context.Entry(teachers);
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }
        //Güncelleme fonksiyonu :
        public void Update(Teachers teachers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(teachers);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Silme fonksiyonu :
        public void Delete(Teachers teachers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(teachers);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }



    }
}
