using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BarcaStoreV1.Queries
{
    public record GetTshirtsByIdQuery(int Id) : IRequest<Tshirt>;
}