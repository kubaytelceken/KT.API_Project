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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceManager(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public void TDelete(Service entity)
        {
            _serviceRepository.Delete(entity);
        }

        public List<Service> TGetAll()
        {
           return _serviceRepository.GetAll();
        }

        public Service TGetById(int id)
        {
            return _serviceRepository.GetById(id);
        }

        public void TInsert(Service entity)
        {
            _serviceRepository.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceRepository.Update(entity);
        }
    }
}
