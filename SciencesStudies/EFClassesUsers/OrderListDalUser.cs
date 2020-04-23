using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class OrderListDalUser
    {
        //Listeleme fonksiyonu
        public List<OrderList> GetAllOrderLists()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.OrderList.ToList();
            }
        }

        //Ekleme fonksiyonunu yazalım :
        public void Add(OrderList orderList)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(orderList);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //Güncelleme fonskiyonu : 
        public void Update(OrderList orderList)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(orderList);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Silme fonksiyonu 
        public void Delete(OrderList orderList)
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                var entity = context.Entry(orderList);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
