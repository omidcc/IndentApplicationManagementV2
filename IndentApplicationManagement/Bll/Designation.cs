using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class Designation : IndentApplicationManagement.Bll.Base.DesignationBase
	{
		private static IndentApplicationManagement.Dal.DesignationDal Dal = new IndentApplicationManagement.Dal.DesignationDal();
		public Designation() : base()
		{
		}
	}
}
