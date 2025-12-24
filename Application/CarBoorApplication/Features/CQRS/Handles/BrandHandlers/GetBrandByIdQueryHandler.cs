using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Queries.BrandQuery;

using CarBoorApplication.Features.CQRS.Result.BrandResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;
        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }


        public async Task<GetBrandByIdQuaryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQuaryResult
            {
                BrandID = values.BrandID,
                Name = values.Name

            };
        }   
        }
    }