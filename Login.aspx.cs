using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

//This code is written by Shruti Shrivastava.
//shru27@hotmail.com 

namespace Shopping
{
	/// <summary>
	/// Summary description for Login.
	/// </summary>
	public class Login : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label LabelError;
		protected System.Web.UI.WebControls.Button btnLogin;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox txtLogin;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			try
			{
				LabelError.Visible=false; 
				string uid, pwd;
				uid=txtLogin.Text;
				pwd=txtPassword.Text;
				string accessLevel=CheckPassword(uid,pwd);
				if(accessLevel !=  "")
				{
					Session["UID"]=uid;
					Session["AccessLevel"]=accessLevel;
					//FormsAuthentication.RedirectFromLoginPage (uid, false);
					//string str = (string)(Session["RequestedPage"]);
					Response.Redirect("CheckOut.aspx");
				
				}
				else
				{
					LabelError.Visible=true;
				}
			}
			catch (Exception ex)
			{
				ex.ToString();
			}
		}
		private string CheckPassword( string uid, string pwd)
		{	return "1";
			// Following is the code if you want to add username and password in a database for checking the credentials.

			/*string connStr="server=guddu;uid=sa;pwd=;database=university";
			SqlConnection conn=new SqlConnection(connStr);

			string sql = "select userid from registereduser where name='" +
				uid + "' and password='"+pwd+"'";
			SqlCommand comm=new SqlCommand(sql, conn);
			conn.Open();
			Object obj = comm.ExecuteScalar();// returns one row
			string userid = "";
			if (obj != null)
				userid = obj.ToString();  // AccessLevel column

			string strRole = "";
			sql = "select role from role where roleid='" +
				userid + "'";
			SqlConnection conn2 = new SqlConnection(connStr);
			SqlCommand comm2 =new SqlCommand(sql, conn2);
			conn2.Open();
			obj = comm2.ExecuteScalar();// returns one row
			if (obj != null)
				strRole = obj.ToString();  // AccessLevel column
			conn2.Close();
			conn.Close();
			return strRole;
*/
		}
		private void btnNewUser_Click(object sender, System.EventArgs e)
		{
			//RequiredFieldValidator1.Enabled = false;
			//RequiredFieldValidator2.Enabled = false;
			Response.Redirect("NewUser.aspx");
		}
	}
}
