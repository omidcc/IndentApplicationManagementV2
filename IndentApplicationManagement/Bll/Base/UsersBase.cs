using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Globalization;
using System.Collections;
using IndentApplicationManagement.Dal;

namespace IndentApplicationManagement.Bll.Base
{
	public class UsersBase
	{
		protected static IndentApplicationManagement.Dal.UsersDal dal = new IndentApplicationManagement.Dal.UsersDal();

		public System.Int32 UserId		{ get ; set; }

		public System.String UserName		{ get ; set; }

		public System.String UserPassword		{ get ; set; }

		public System.Boolean IsActive		{ get ; set; }

		public System.Int32 UpdateBy		{ get ; set; }

		public System.DateTime UpdateDate		{ get ; set; }

		public System.Int32 CompanyId		{ get ; set; }


		public  Int32 InsertUsers()
		{
			Hashtable lstItems = new Hashtable();
			lstItems.Add("@UserId", UserId.ToString(CultureInfo.InvariantCulture));
			lstItems.Add("@UserName", UserName);
			lstItems.Add("@UserPassword", UserPassword);
			lstItems.Add("@IsActive", IsActive);
			lstItems.Add("@UpdateBy", UpdateBy.ToString(CultureInfo.InvariantCulture));
			lstItems.Add("@UpdateDate", UpdateDate.ToString(CultureInfo.InvariantCulture));
			lstItems.Add("@CompanyId", CompanyId.ToString(CultureInfo.InvariantCulture));

			return dal.InsertUsers(lstItems);
		}

		public  Int32 UpdateUsers()
		{
			Hashtable lstItems = new Hashtable();
			lstItems.Add("@UserId", UserId.ToString());
			lstItems.Add("@UserName", UserName);
			lstItems.Add("@UserPassword", UserPassword);
			lstItems.Add("@IsActive", IsActive);
			lstItems.Add("@UpdateBy", UpdateBy.ToString());
			lstItems.Add("@UpdateDate", UpdateDate.ToString(CultureInfo.InvariantCulture));
			lstItems.Add("@CompanyId", CompanyId.ToString());

			return dal.UpdateUsers(lstItems);
		}

		public  Int32 DeleteUsersByUserId(Int32 UserId)
		{
			Hashtable lstItems = new Hashtable();
			lstItems.Add("@UserId", UserId);

			return dal.DeleteUsersByUserId(lstItems);
		}

		public List<Users> GetAllUsers(int CompanyId)
		{
			Hashtable lstItems = new Hashtable();
			lstItems.Add("@CompanyId", CompanyId);
			DataTable dt = dal.GetAllUsers(lstItems);
			List<Users> UsersList = new List<Users>();
			foreach (DataRow dr in dt.Rows)
			{
				UsersList.Add(GetObject(dr));
			}
			return UsersList;
		}

		public Users GetUsersByUserId(int _UserId,int _CompanyId)
		{
			Hashtable lstItems = new Hashtable();
			lstItems.Add("@UserId", _UserId);
			lstItems.Add("@CompanyId", _CompanyId);

			DataTable dt = dal.GetUsersByUserId(lstItems);
			DataRow dr = dt.Rows[0];
			return GetObject(dr);
		}

		protected  Users GetObject(DataRow dr)
		{

			Users objUsers = new Users();
			objUsers.UserId = (dr["UserId"] == DBNull.Value) ? 0 : (Int32)dr["UserId"];
			objUsers.UserName = (dr["UserName"] == DBNull.Value) ? "" : (String)dr["UserName"];
			objUsers.UserPassword = (dr["UserPassword"] == DBNull.Value) ? "" : (String)dr["UserPassword"];
			objUsers.IsActive = (dr["IsActive"] == DBNull.Value) ? false : (Boolean)dr["IsActive"];
			objUsers.UpdateBy = (dr["UpdateBy"] == DBNull.Value) ? 0 : (Int32)dr["UpdateBy"];
			objUsers.UpdateDate = (dr["UpdateDate"] == DBNull.Value) ? DateTime.MinValue : (DateTime)dr["UpdateDate"];
			objUsers.CompanyId = (dr["CompanyId"] == DBNull.Value) ? 0 : (Int32)dr["CompanyId"];

			return objUsers;
		}
	}
}
