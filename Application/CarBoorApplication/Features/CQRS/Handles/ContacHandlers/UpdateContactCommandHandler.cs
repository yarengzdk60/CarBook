using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.CategoryCommand;
using CarBoorApplication.Features.CQRS.Commend.ContacCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.ContacHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository=repository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Name = command.Name;
            values.Email = command.Email;
            values.Message = command.Message;
            values.SendDate = command.SendDate;
            values.Subject = command.Subject;
            await _repository.UpdateAsync(values);
        }

    }
}
