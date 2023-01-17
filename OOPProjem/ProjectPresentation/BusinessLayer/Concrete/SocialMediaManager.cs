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
	public class SocialMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDAL _socialMediaDAL;
		public SocialMediaManager (ISocialMediaDAL socialMediaDAL)
		{
			_socialMediaDAL= socialMediaDAL;
		}
		public void Delete(SocialMedia t)
		{
			_socialMediaDAL.Delete(t);
		}

		public List<SocialMedia> GetAll()
		{
			return _socialMediaDAL.GetAll();
		}

		public SocialMedia GetById(int id)
		{
			return _socialMediaDAL.GetById(id);
		}

		public void Insert(SocialMedia t)
		{
			_socialMediaDAL.Insert(t);
		}

		public void Update(SocialMedia t)
		{
			_socialMediaDAL.Update(t);
		}
	}
}
