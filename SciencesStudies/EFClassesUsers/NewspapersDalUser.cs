using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class NewspapersDalUser
    {
        //Listeleme fonksiyonu :
        public List<Newspapers> GetAllNewspapers()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Newspapers.ToList();
            }
        }
    }
}
