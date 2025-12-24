using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.ContacCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.ContacHandlers
{
    public class RemoveContactCommandHandler
    {
        private readonly IRepository<Contact> _contacRepository;

        public RemoveContactCommandHandler(IRepository<Contact> contacRepository)
        {
            _contacRepository=contacRepository;
        }

        public async Task Handle(RemoveContactCommand command )
        {
           var contact = await _contacRepository.GetByIdAsync(command.Id);
            if (contact != null)
                throw new Exception("hata yoktur");
            {
                await _contacRepository.RemoveAsync(command.Id);
            }
        }



    }
}
