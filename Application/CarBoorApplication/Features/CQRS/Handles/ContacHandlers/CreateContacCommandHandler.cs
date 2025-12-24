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
    public class CreateContacCommandHandler
    {
        private readonly IRepository<Contact> _contacRepository;

        public CreateContacCommandHandler(IRepository<Contact> contacRepository)
        {
            _contacRepository=contacRepository;
        }
        public async Task Handle(CreateContactCommand command)
        {
            await _contacRepository.CreateAsync(new Contact
            {
                Name = command.Name,
                Email = command.Email,
                Subject = command.Subject,
                Message = command.Message,
                SendDate = command.SendDate
            });
        }

    }
}

/*Handle metodu çalıştı.
Command içindeki verileri aldım.
Bunlarla yeni bir Contact entity oluşturdum.
Repository.CreateAsync ile bu entity’yi veritabanına ekledim.”*/