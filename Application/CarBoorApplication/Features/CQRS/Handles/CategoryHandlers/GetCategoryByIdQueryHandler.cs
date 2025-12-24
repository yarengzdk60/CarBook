using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Queries.CategoryQueries;
using CarBoorApplication.Features.CQRS.Result.CategoryResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository=repository;
        }

        public async Task<GetCatogeryByIdQuaryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCatogeryByIdQuaryResult
            {
                CategoryID = values.CategoryID,
                Name = values.Name
            };
        }
    }
}
