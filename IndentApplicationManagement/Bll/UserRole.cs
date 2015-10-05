using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class UserRole : IndentApplicationManagement.Bll.Base.UserRoleBase
	{
		private static IndentApplicationManagement.Dal.UserRoleDal Dal = new IndentApplicationManagement.Dal.UserRoleDal();
		public UserRole() : base()
		{
		}
	}
}
