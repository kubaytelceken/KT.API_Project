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
    public class BookingManager : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public void TDelete(Booking entity)
        {
            _bookingRepository.Delete(entity);
        }

        public List<Booking> TGetAll()
        {
            return _bookingRepository.GetAll();
        }

        public Booking TGetById(int id)
        {
            return _bookingRepository.GetById(id);
        }

        public void TInsert(Booking entity)
        {
            _bookingRepository.Insert(entity);
        }

        public void TUpdate(Booking entity)
        {
            _bookingRepository.Update(entity);
        }
    }
}
