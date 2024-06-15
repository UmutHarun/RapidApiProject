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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Delete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> GetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff GetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public void Insert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public void Update(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
