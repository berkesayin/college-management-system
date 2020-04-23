using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class LiteratureBooksDalUser
    {
        //Listeleme fonksiyonu
        public List<LiteratureBooks> GetAllLiteratureBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.LiteratureBooks.ToList();
            }
        }
    }
}
