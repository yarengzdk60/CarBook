using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Queries.ContacQueries
{
    public class GetContactByIdQuery
    {
        public GetContactByIdQuery(int id)
        {
            Id=id;
        }

        public int Id { get; set; }
    }
}
