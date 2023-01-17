﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDAL _aboutDal;
		public AboutManager(IAboutDAL aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void Delete(About t)
		{
			_aboutDal.Delete(t);
		}

		public List<About> GetAll()
		{
			return _aboutDal.GetAll();
		}

		public About GetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public void Insert(About t)
		{
			_aboutDal.Insert(t);
		}

		public void Update(About t)
		{
			_aboutDal.Update(t);
		}
	}
}
