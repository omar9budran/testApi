using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcaStoreV1;
using BarcaStoreV1.Queries;
using MediatR;

namespace BarcaStoreV1.Handlers
{
    public class GetAllTshirtsHandler : IRequestHandler<GetAllTshirtsQuery, IEnumerable<Tshirt>>
    {
        private readonly DataStore _dataStore;

        public GetAllTshirtsHandler(DataStore dataStore) => _dataStore = dataStore;

        public async Task<IEnumerable<Tshirt>> Handle(GetAllTshirtsQuery request, CancellationToken cancellationToken) =>
         await _dataStore.GetAllTshirts();
    }
}