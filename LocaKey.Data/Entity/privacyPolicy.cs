using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class privacyPolicy:BaseEntity
    {

        public string nameAr { get; set; }
        public string nameEn { get; set; }
        public string nameFr { get; set; }
        public string descriptionAr { get; set; }
        public string descriptionEn { get; set; }
        public string descriptionFr { get; set; }

    }
}
