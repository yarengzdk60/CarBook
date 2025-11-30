using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbookDomian.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
    }
}

/*CarFeature sınıfı şu şekilde düşün 4 tane araban var 6 tane de özellik alanın var 
 * 
 * 1 numaralı arabada 1 nuramalı özellik var ya da 2 numaralı arabada 3 numaralı özellik var
 *  işte bu ilişkiyi kuran sınıf CarFeature sınıfıdır. bu yüzden de ihtiyacımız vardır.
 
 
 */