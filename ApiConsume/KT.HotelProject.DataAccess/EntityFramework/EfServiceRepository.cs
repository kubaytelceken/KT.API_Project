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
    public class EfServiceRepository : GenericRepository<Service>,IServiceRepository
    {
        public EfServiceRepository(HotelContext hotelContext) : base(hotelContext)
        {

        }
    }
}
