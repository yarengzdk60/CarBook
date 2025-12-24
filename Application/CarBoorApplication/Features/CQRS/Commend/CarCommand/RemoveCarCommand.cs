using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Commend.CarCommand
{
    public class RemoveCarCommand
    {
        public RemoveCarCommand(int id)
        {
            Id=id;
        }
        public int  Id { get; set; }
    }
}
