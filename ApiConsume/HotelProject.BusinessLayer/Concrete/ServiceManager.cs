﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal) 
        {
            _serviceDal = serviceDal;
        } 
        public void Delete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void Insert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void Update(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
