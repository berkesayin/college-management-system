using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class GeneralBooksDalUser
    {
        public List<GeneralBooks> GetAllGeneralBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.GeneralBooks.ToList();
            }
        }
    }
}
