using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Commend.BannerCommand
{
    public class RemoveBannerCommand
    {
        public int Id { get; set; }
        

        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
    }
}
