using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace BarcaStoreV1
{
    public class DataStore
    {
         private static List<Tshirt> _tshirts;
        public DataStore()
        {
            _tshirts = new List<Tshirt>()
            {
            new Tshirt {Id =1, Name = "Messi", Number ="10"},
            new Tshirt {Id =2, Name = "XAVI", Number ="6"},
            new Tshirt {Id =3, Name = "Iniesta", Number ="8"}
            };
        }
        public async Task AddTshirt(Tshirt tshirt)
        {
            _tshirts.Add(tshirt);
            await Task.CompletedTask;
        }

        public async Task DeleteTshirt(int id)
        {
            var tshirtToDelete = _tshirts.FirstOrDefault(tshirt => tshirt.Id == id);
            if (tshirtToDelete != null)
            {
                _tshirts.Remove(tshirtToDelete);
                await Task.CompletedTask;
            }
            else
            {
                throw new Exception("Tshirt not found");
            }
        }
        public async Task<IEnumerable<Tshirt>> GetAllTshirts() => await Task.FromResult(_tshirts);

        public async Task<Tshirt> GetTshirtsById(int id) =>
         await Task.FromResult(_tshirts.Single(p=>p.Id == id));

    }
}