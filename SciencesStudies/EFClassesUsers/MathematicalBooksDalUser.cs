using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class MathematicalBooksDalUser
    {
        //Listeleme fonksiyonu
        public List<MathematicalBooks> GetAllMathematicalBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.MathematicalBooks.ToList();
            }
        }
    }
}
