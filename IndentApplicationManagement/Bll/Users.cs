using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class Users : IndentApplicationManagement.Bll.Base.UsersBase
	{
		private static IndentApplicationManagement.Dal.UsersDal Dal = new IndentApplicationManagement.Dal.UsersDal();
		public Users() : base()
		{
		}
	}
}
