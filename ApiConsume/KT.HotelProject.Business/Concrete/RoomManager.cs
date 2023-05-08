using KT.HotelProject.Business.Abstract;
using KT.HotelProject.DataAccess.Abstract;
using KT.HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.HotelProject.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomManager(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void TDelete(Room entity)
        {
            _roomRepository.Delete(entity);
        }

        public List<Room> TGetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room TGetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public void TInsert(Room entity)
        {
            _roomRepository.Insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _roomRepository.Update(entity); 
        }
    }
}
