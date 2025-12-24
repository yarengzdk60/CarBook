using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Commend.BrandCommand
{
    public class UpdateBrandCommand
    {
      public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
