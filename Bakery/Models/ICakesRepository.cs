using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface ICakesRepository
    {
        IEnumerable<Cakes> AllCakes { get; }

        IEnumerable<Cakes> CakesOfTheWeek { get; }

        Cakes GetCakesById(int cakeId);

    }
}
