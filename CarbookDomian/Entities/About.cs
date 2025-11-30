using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbookDomian.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
/*
Sadece CarID ile arabanın bilgilerine erişemeyiz.
Bu yüzden ilişkiyi temsil eden Car navigation property’sini ekliyoruz.
Böylece CarFeature üzerinden arabaya ait tüm verilere ulaşabiliriz.
 */