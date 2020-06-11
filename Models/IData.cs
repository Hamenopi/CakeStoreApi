using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeStoreApi.Models
{
    public interface IData
    {
        public List<CakeStore> CakesList { get; set; }
        public List<CakeStore> CakesInitializeData();
        public CakeStore GetCakeById(int? id);
    }
}
