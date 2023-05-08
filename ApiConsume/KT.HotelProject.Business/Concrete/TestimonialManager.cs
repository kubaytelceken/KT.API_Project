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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialRepository.Delete(entity);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonialRepository.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialRepository.GetById(id);
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialRepository.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialRepository.Update(entity);
        }
    }
}
