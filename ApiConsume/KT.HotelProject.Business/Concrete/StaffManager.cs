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
    public class StaffManager : IStaffService
    {
        private readonly IStaffRepository _staffRepository;

        public StaffManager(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public void TDelete(Staff entity)
        {
            _staffRepository.Delete(entity);
        }

        public List<Staff> TGetAll()
        {
            return _staffRepository.GetAll();
        }

        public Staff TGetById(int id)
        {
            return _staffRepository.GetById(id);
        }

        public void TInsert(Staff entity)
        {
            _staffRepository.Insert(entity);    
        }

        public void TUpdate(Staff entity)
        {
            _staffRepository.Update(entity);
        }
    }
}
