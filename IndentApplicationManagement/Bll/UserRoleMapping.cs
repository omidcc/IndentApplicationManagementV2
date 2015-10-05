using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class UserRoleMapping : IndentApplicationManagement.Bll.Base.UserRoleMappingBase
	{
		private static IndentApplicationManagement.Dal.UserRoleMappingDal Dal = new IndentApplicationManagement.Dal.UserRoleMappingDal();
		public UserRoleMapping() : base()
		{
		}
	}
}
