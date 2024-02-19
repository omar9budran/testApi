using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStoreV1.Queries;
using MediatR;

namespace BarcaStoreV1.Handlers
{
    public class GeTshirtsByIdHandler : IRequestHandler<GetTshirtsByIdQuery, Tshirt>
    {
        private readonly DataStore _dataStore;
        public GeTshirtsByIdHandler(DataStore dataStore) => _dataStore = dataStore;
        public async Task<Tshirt> Handle(GetTshirtsByIdQuery request, CancellationToken cancellationToken) =>
         await _dataStore.GetTshirtsById(request.Id);
    }
}