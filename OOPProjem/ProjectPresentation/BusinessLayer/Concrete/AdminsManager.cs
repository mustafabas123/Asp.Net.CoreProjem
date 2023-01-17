using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AdminsManager : IAdminsService
	{
		private readonly IAdminsDAL _adminsDal;
		public AdminsManager(IAdminsDAL adminsDAL)
		{
			_adminsDal= adminsDAL;
		}
		public void Delete(Admins t)
		{
			_adminsDal.Delete(t);
		}

		public List<Admins> GetAll()
		{
			return _adminsDal.GetAll();
		}

		public Admins GetById(int id)
		{
			return _adminsDal.GetById(id);
		}

		public void Insert(Admins t)
		{
			_adminsDal.Insert(t);
		}

		public void Update(Admins t)
		{
			_adminsDal.Update(t);
		}
	}
}
