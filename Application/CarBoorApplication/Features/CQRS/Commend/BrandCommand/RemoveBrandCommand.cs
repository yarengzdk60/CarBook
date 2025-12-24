using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Commend.BrandCommand
{
    public class RemoveBrandCommand
    {
        public RemoveBrandCommand(int ıd)
        {
            Id=ıd;
        }

        public int Id { get; set; }

    }
}
