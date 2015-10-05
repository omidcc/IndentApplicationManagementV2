using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class Department : IndentApplicationManagement.Bll.Base.DepartmentBase
	{
		private static IndentApplicationManagement.Dal.DepartmentDal Dal = new IndentApplicationManagement.Dal.DepartmentDal();
		public Department() : base()
		{
		}
	}
}
