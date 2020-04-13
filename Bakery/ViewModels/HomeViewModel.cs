using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cakes> CakesOfTheWeek { get; set; } 
    }
}
