using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Commands.PricingCommand
{
    public class UpdatePricingCommand : IRequest
    {
        public int PricingID { get; set; }  
        public string Name { get; set; }
    }
}
