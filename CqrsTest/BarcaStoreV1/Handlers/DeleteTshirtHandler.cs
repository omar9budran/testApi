using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStoreV1.Commands;
using MediatR;

namespace BarcaStoreV1.Handlers
{
    public class DeleteTshirtHandler : IRequestHandler<DeleteTshirtCommand, Unit>
    {
        private readonly DataStore _dataStore;

        public DeleteTshirtHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Task<Unit> Handle(DeleteTshirtCommand request, CancellationToken cancellationToken)
        {
            var tshirtToDelete = _dataStore.FirstOrDefaultAsync(tshirt => tshirt.Id == request.TshirtId);
            if (tshirtToDelete == null)
            {
                // You might want to throw an exception if the t-shirt to delete is not found
                throw new Exception("T-shirt not found.");
            }

            _dataStore.Remove(tshirtToDelete);
            return Task.FromResult(Unit.Value);
        }
    }
}
/*
public class DeleteTshirtCommandHandler : IRequestHandler<DeleteTshirtCommand>
{
    private readonly ITshirtDataStore _dataStore;

    public DeleteTshirtCommandHandler(ITshirtDataStore dataStore)
    {
        _dataStore = dataStore;
    }

    public async Task<Unit> Handle(DeleteTshirtCommand request, CancellationToken cancellationToken)
    {
        await _dataStore.DeleteTshirt(request.TshirtId);
        return Unit.Value;
    }
}
*/