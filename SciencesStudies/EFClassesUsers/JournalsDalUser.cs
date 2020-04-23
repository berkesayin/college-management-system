using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class JournalsDalUser
    {
        //Listeleme fonksiyonu
        public List<Journals> GetAllJournals()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.Journals.ToList();
            }
        }
    }
}
