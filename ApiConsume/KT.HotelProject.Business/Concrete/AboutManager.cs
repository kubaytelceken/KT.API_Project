using KT.HotelProject.Business.Abstract;
using KT.HotelProject.DataAccess.Abstract;
using KT.HotelProject.DataAccess.EntityFramework;
using KT.HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.HotelProject.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void TDelete(About entity)
        {
            _aboutRepository.Delete(entity);
        }

        public List<About> TGetAll()
        {
            return _aboutRepository.GetAll();
        }

        public About TGetById(int id)
        {
            return _aboutRepository.GetById(id);
        }

        public void TInsert(About entity)
        {
            _aboutRepository.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutRepository.Update(entity);
        }
    }
}
