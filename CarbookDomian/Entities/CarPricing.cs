using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbookDomian.Entities
{
    public class CarPricing
    {
        public int CarPricingID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int PricingID { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Amount { get; set; }
    }
}

/* Arabalar ve Ödeme Yöntemleri olarak ayrılan kısımlar vardır
 Haftalık ödeme günlük aylık gibi. Her araba için farklı ödeme 
yöntemleri ve fiyatlandırmalar olabilir. Bu yüzden CarPricing 
adında bir ara tablo oluşturulmuştur. Bu tablo CarID ve PricingID ile navigation
 property'leri aracılığıyla Car ve Pricing tablolarına bağlanır.
 
 */