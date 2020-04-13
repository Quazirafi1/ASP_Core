using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.ViewModels
{
    public class CakesListViewModel
    {
        public IEnumerable<Cakes> Cakes { get; set; }

        public string CurrentCategory { get; set; }
    }
}
