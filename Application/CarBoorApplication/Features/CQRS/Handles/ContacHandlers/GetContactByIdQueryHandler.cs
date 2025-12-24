using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.ContactResult;
using CarBoorApplication.Features.CQRS.Queries.ContacQueries;
using CarBoorApplication.Interfaces;

namespace CarBoorApplication.Features.CQRS.Handles.ContacHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);

            return new GetContactByIdQueryResult
            {
                ContactID = values.ContactID,
                Name = values.Name,
                Email = values.Email,
                Subject = values.Subject,
                SendDate = values.SendDate,
                Message = values.Message
            };
        }
    }
}
