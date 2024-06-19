using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void Delete(AboutUs entity)
        {
            _aboutUsDal.Delete(entity);
        }

        public List<AboutUs> GetAll()
        {
            return _aboutUsDal.GetAll();
        }

        public AboutUs GetById(int id)
        {
            return _aboutUsDal.GetById(id);
        }

        public void Insert(AboutUs entity)
        {
            _aboutUsDal.Insert(entity);
        }

        public void Update(AboutUs entity)
        {
            _aboutUsDal.Update(entity);
        }
    }
}
