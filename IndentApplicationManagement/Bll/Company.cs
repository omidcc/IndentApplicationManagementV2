using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class Company : IndentApplicationManagement.Bll.Base.CompanyBase
	{
		private static IndentApplicationManagement.Dal.CompanyDal Dal = new IndentApplicationManagement.Dal.CompanyDal();
		public Company() : base()
		{
		}
	}
}
