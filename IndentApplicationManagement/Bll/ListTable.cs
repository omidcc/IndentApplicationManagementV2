using System;
using System.Text;
using System.Data;
using System.Collections;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement.Bll
{
	public class ListTable : IndentApplicationManagement.Bll.Base.ListTableBase
	{
		private static IndentApplicationManagement.Dal.ListTableDal Dal = new IndentApplicationManagement.Dal.ListTableDal();
		public ListTable() : base()
		{
		}
	}
}
