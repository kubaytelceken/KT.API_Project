﻿using KT.HotelProject.DataAccess.Abstract;
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
    public class EfRoomRepository : GenericRepository<Room>,IRoomRepository
    {
        public EfRoomRepository(HotelContext hotelContext) : base(hotelContext)
        {

        }
    }
}
