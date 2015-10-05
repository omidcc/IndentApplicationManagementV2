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

            newCompany.CompanyName = companyNameTextBox.Text;
            newCompany.Address = addressTextBox.Text;
            newCompany.Phone = phoneNoTextBox.Text;
            newCompany.Email = emailTextBox.Text;
            newCompany.Web = webTextBox.Text;
            newCompany.LogoPath = logopathTextBox.Text;
            newCompany.UpdateBy = int.Parse(updateByTextBox.Text);
            newCompany.UpdateDate = DateTime.Parse(RadDatePicker1.SelectedDate.ToString());
            newCompany.IsActive = isActiveCheckBox.Checked;
            if (!isNewEntry)
                newCompany.CompanyId = int.Parse(lblId.Text);
           
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
            companyNameTextBox.Text =
                addressTextBox.Text =
                    emailTextBox.Text =
                        webTextBox.Text = phoneNoTextBox.Text = logopathTextBox.Text = updateByTextBox.Text = "";
            RadDatePicker1.Clear();
            isActiveCheckBox.Checked = false;

        }
    }
}