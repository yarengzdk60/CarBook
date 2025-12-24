using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Commend.CategoryCommand
{
    public class UpdateCategoryCommand
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
