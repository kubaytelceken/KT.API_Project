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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeRepository _subRepository;

        public SubscribeManager(ISubscribeRepository subRepository)
        {
            _subRepository = subRepository;
        }

        public void TDelete(Subscribe entity)
        {
            _subRepository.Delete(entity);
        }

        public List<Subscribe> TGetAll()
        {
            return _subRepository.GetAll();
        }

        public Subscribe TGetById(int id)
        {
            return _subRepository.GetById(id);
        }

        public void TInsert(Subscribe entity)
        {
            _subRepository.Insert(entity);
        }

        public void TUpdate(Subscribe entity)
        {
            _subRepository.Update(entity);
        }
    }
}
