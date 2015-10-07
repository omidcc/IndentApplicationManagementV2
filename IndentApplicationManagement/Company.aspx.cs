using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BillingApplication;
using IndentApplicationManagement.Bll.Base;

namespace IndentApplicationManagement
{
    public partial class Company : System.Web.UI.Page
    {
        public static bool isNewEntry;
        public static int userId;


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CompanyBase newCompany=new CompanyBase();

            newCompany.CompanyName = companyNameTextBox.Value;
            newCompany.Address = addressTextBox.Value;
            newCompany.Phone = phoneNoTextBox.Value;
            newCompany.Email = emailTextBox.Value;
            newCompany.Web = webTextBox.Value;
            newCompany.LogoPath = logopathTextBox.Value;
            newCompany.UpdateBy = int.Parse(updateByTextBox.Value);
            newCompany.UpdateDate = DateTime.Parse(datetimepicker.Value);
            newCompany.IsActive = isActiveCheckBox.Checked;
          
           
            newCompany.InsertCompany();
            
            Alert.Show("Saved Company Information Successfully!");
            this.Clear();


        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
            isNewEntry = true;

        }
        protected void btnNext_Click(object sender, EventArgs e)
        {

        }
        
        protected void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            companyNameTextBox.Value =
                addressTextBox.Value =
                    emailTextBox.Value =
                        webTextBox.Value = phoneNoTextBox.Value = logopathTextBox.Value = updateByTextBox.Value = "";
            
            isActiveCheckBox.Checked = false;

        }
    }
}