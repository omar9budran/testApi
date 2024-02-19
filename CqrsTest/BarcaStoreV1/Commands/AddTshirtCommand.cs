using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStoreV1;
using MediatR;

namespace BarcaStore.Commands
{
    public record AddTshirtCommand(Tshirt Tshirt) : IRequest<Unit>;
}