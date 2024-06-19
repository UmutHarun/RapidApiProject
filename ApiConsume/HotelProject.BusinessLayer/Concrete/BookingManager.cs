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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Delete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public List<Booking> GetAll()
        {
            return _bookingDal.GetAll();
        }

        public Booking GetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public void Insert(Booking entity)
        {
            _bookingDal.Insert(entity);
        }

        public void Update(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
