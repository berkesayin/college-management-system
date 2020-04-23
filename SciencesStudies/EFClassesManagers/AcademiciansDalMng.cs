using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class AcademiciansDalMng
    {
        //Listeleme işlemi için fonksiyonu yazalım
        public List<Academicians> GetAllAcademicians()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Academicians.ToList();
            }
        }

        //Ekleme fonksiyonunu yazalım :
        public void Add(Academicians academicians)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                context.Academicians.Add(academicians);
                context.SaveChanges();

                //Biz entity framework'de şu şekildede ekleme yapabilirdik:
                //Fakat bu yöntemi kullanmak için yukarıya şu kütüphane eklenmelidir :
                //using System.Data.Entity; //fakat biz burada bu yöntemi kullanmayacağız.O yüzden yorum satırına alalım
                //var entity = context.Entry(generalMembers);
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }
        //Güncelleme fonksiyonunu yazalım :
        public void Update(Academicians academicians)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(academicians);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Silme işlemini yapacak fonksiyonu yazalım :
        public void Delete(Academicians academicians)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(academicians);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
