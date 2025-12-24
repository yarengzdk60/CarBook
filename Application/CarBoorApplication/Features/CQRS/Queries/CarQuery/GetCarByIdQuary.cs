using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Queries.CarQuery
{
    public class GetCarByIdQuary
    {
        public GetCarByIdQuary(int ıd)
        {
            Id=ıd;
        }

        public int  Id { get; set; }
    }
}
