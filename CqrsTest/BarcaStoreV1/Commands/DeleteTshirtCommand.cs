using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BarcaStoreV1.Commands
{
    public record DeleteTshirtCommand (int Id): IRequest<int>;
}