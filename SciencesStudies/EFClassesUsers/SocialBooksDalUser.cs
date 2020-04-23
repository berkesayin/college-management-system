using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class SocialBooksDalUser
    {
        //Listeleme fonksiyonu :
        public List<SocialBooks> GetAllSocialBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.SocialBooks.ToList();
            }
        }
    }
}
