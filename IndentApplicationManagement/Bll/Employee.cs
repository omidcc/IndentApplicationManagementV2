using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class Employee : IndentApplicationManagement.Bll.Base.EmployeeBase
	{
		private static IndentApplicationManagement.Dal.EmployeeDal Dal = new IndentApplicationManagement.Dal.EmployeeDal();
		public Employee() : base()
		{
		}
	}
}
