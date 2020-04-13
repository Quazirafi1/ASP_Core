using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class CakesRepository: ICakesRepository
    {
        private readonly AppDbContext _appDbContext;

        public CakesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cakes> AllCakes
        {
            get
            {
                return _appDbContext.Cakes.Include(c => c.Category);
            }
        }

        public IEnumerable<Cakes> CakesOfTheWeek
        {
            get
            {
                return _appDbContext.Cakes.Include(c => c.Category).Where(p => p.IsCakeOfTheWeek);
            }
        }


        public Cakes GetCakesById(int cakeId)
        {
            return _appDbContext.Cakes.FirstOrDefault(c => c.CakesId == cakeId);

        }
    }
}
