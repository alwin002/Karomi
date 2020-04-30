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

//This code is written by Shruti Shrivastava.
//shru27@hotmail.com 

namespace Shopping
{
	/// <summary>
	/// Summary description for Contents.
	/// </summary>
	public class Contents : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink HlinkShowProducts;
		protected System.Web.UI.WebControls.HyperLink HlLogin;
		protected System.Web.UI.WebControls.HyperLink HlHome;
		protected System.Web.UI.WebControls.HyperLink HlContactUs;
		protected System.Web.UI.WebControls.HyperLink HlNewUser;
	
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
