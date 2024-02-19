using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStoreV1;
using MediatR;

namespace BarcaStoreV1.Queries
{
    public record GetAllTshirtsQuery : IRequest<IEnumerable<Tshirt>>;

}