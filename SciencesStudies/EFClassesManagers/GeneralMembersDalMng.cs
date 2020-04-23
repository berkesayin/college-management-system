using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class GeneralMembersDalMng
    {
        //ürünleri listelemek için gerekli olan kodu yazalım.
        public List<GeneralMembers> GetAllGeneralMembers()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.GeneralMembers.ToList();
            }
        }

        //Ekleme operasyonunu yazalım :
        public void Add(GeneralMembers generalMembers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                context.GeneralMembers.Add(generalMembers);
                context.SaveChanges();

                //Biz entity framework'de şu şekildede ekleme yapabilirdik:
                //Fakat bu yöntemi kullanmak için yukarıya şu kütüphane eklenmelidir :
                //using System.Data.Entity; //fakat biz burada bu yöntemi kullanmayacağız.O yüzden yorum satırına alalım
                //var entity = context.Entry(generalMembers);
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }

        //Güncelleme işlemini gerçekleştirecek olan kodu yazalım :
        public void Update(GeneralMembers generalMembers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                //Bizim güncellencek olan ürünü bulup verilerini değiştirip kaydetme işlemini yapmamız gerekiyor.
                //Bu işlem entity framework'de şu şekilde yapılır:
                var entity = context.Entry(generalMembers); //bu generalMembers için context üzerinden abone ol demek
                //Yani bizim gönderdğimiz generalMembers'ı vt'deki generalMembers ile eşitliyor

                entity.State = EntityState.Modified;  //Güncelle
                context.SaveChanges();//Değişiklikleri kaydedelim.
            }
        }

        //Silme işlemini gerçekleştirecek kodu yazalım :
        public void Delete(GeneralMembers generalMembers)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(generalMembers);
                entity.State = EntityState.Deleted;  //Sil
                context.SaveChanges(); //Değişiklikleri kaydet
            }
        }

    }
}
