using KT.HotelProject.DataAccess.Abstract;
using KT.HotelProject.DataAccess.Concrete;
using KT.HotelProject.DataAccess.Repositories;
using KT.HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.HotelProject.DataAccess.EntityFramework
{
    public class EfSubscribeRepository : GenericRepository<Subscribe>,ISubscribeRepository
    {
        public EfSubscribeRepository(HotelContext hotelContext) : base(hotelContext)
        {

        }
    }
}
