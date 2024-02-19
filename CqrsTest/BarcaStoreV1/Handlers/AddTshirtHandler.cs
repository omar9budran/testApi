using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStore.Commands;
using BarcaStoreV1;
using MediatR;

namespace BarcaStoreV1.Handlers
{
    public class AddTshirtHandler : IRequestHandler<AddTshirtCommand, Unit>
    {
        public readonly  DataStore _dataStore;
        public AddTshirtHandler(DataStore dataStore) => _dataStore = dataStore;

    // TODO: Implement business rule validation here if needed
        public async Task<Unit> Handle(AddTshirtCommand request, CancellationToken cancellationToken)
        {
        await _dataStore.AddTshirt(request.Tshirt);
        return  Unit.Value;
        }
    }
}
