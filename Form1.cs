using Siemens.MES.Net.CommonService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdataTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtToken.ReadOnly = true;       
        }

        private string GetToken()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string baseURL = txtBaseURL.Text;
            string domain = txtDomain.Text;
            OAuth2Token.Initialize(userName, password, domain, baseURL);
            OData4.Initialize(baseURL);

            return OAuth2Token.Token;
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            try
            {
                txtToken.Text = this.GetToken();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                string message = OData4.SendCmd(txtToken.Text, txtMethod.Text.Trim(), txtParams.Text,DataScope.AtlPoc);
                txtResponse.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
