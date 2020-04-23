using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class CollegeStudentsDalMng
    {
        //Listeleme fonksiyonunu yazalım :
        public List<CollegeStudents> GetAllCollegeStudents()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.CollegeStudents.ToList();
            }
        }
        //Ekleme fonksiyounu yazalım
        public void Add(CollegeStudents collegeStudents)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                context.CollegeStudents.Add(collegeStudents);
                context.SaveChanges();
                
                //var entity = context.Entry(collegeStudents);
                //entity.State = EntityState.Added;
                //context.SaveChanges();

            }
        }
        //Güncelleme fonksiyonunu yazalım :
        public void Update(CollegeStudents collegeStudents)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(collegeStudents);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Silme fonksiyonunu yazalım :
        public void Delete(CollegeStudents collegeStudents)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(collegeStudents);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
