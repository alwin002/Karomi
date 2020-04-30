using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.Mail;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Shopping;

//This code is written by Shruti Shrivastava.
//shru27@hotmail.com 

namespace Shopping
{
	/// <summary>
	/// Summary description for CheckOut.
	/// </summary>
	public class CheckOut : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label LabelTotal;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label13;
		protected System.Web.UI.WebControls.TextBox txtCreditNo;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator6;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button btnReset;
		protected System.Web.UI.WebControls.TextBox txtCreditCardNo;
		protected System.Web.UI.WebControls.Label Label11;
		protected System.Web.UI.WebControls.Label Label14;
		protected System.Web.UI.WebControls.Label lblMsg;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.TextBox txtBillPinCode;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator2;
		protected System.Web.UI.WebControls.RangeValidator RangeValidator1;
		protected System.Web.UI.WebControls.Table Table1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			WebForm1.Cart cart = new WebForm1.Cart();

			if ((Session["cart"]==null))
			{
				Response.Write("Cart is Empty");
				return;
				//Session["cart"] = WebForm1.GetCart();
			}
			else
			{
				cart = (WebForm1.Cart)(Session["cart"]);
			}
			//cart = WebForm1.myCart;
			int nTotalItem = cart.list.Count;
			double dTotal = 0.0;
			double dPrice = 0.0;
			for (int nItem = 0; nItem < nTotalItem; nItem++)
			{
				TableRow trow = new TableRow();

				WebForm1.CartRow row = new WebForm1.CartRow();
				row = (WebForm1.CartRow)cart.list[nItem];
				string str = row.id + " " + row.name+  " " + row.price +  " " + row.items;

				// Put user code to initialize the page here
				
				
				TableCell c1 = new TableCell();
				TableCell c2 = new TableCell();
				TableCell c3 = new TableCell();
				TableCell c4 = new TableCell();
			
				c1.Text = row.id;
				c2.Text = row.name;
				c3.Text = row.price;
				c4.Text = row.items;

				trow.Cells.Add(c1);
				trow.Cells.Add(c2);
				trow.Cells.Add(c3);
				trow.Cells.Add(c4);

				Table1.Rows.Add(trow);
				dPrice = Double.Parse(row.price);
				int nNum = Int32.Parse(row.items);
				dPrice *= nNum;
				dTotal += dPrice;

			}
			LabelTotal.Text = dTotal.ToString();
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
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=GUDDU;packet size=4096;user id=sa;data source=guddu;persist securi" +
				"ty info=False;initial catalog=Northwind";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Order Details", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
																																																					   new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																					   new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
																																																					   new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
																																																					   new System.Data.Common.DataColumnMapping("Discount", "Discount")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM [Order Details] WHERE (OrderID = @Original_OrderID) AND (ProductID = " +
				"@Original_ProductID) AND (Discount = @Original_Discount) AND (Quantity = @Origin" +
				"al_Quantity) AND (UnitPrice = @Original_UnitPrice)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discount", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount); SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE (OrderID = @OrderID) AND (ProductID = @ProductID)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE [Order Details] SET OrderID = @OrderID, ProductID = @ProductID, UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount WHERE (OrderID = @Original_OrderID) AND (ProductID = @Original_ProductID) AND (Discount = @Original_Discount) AND (Quantity = @Original_Quantity) AND (UnitPrice = @Original_UnitPrice); SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE (OrderID = @OrderID) AND (ProductID = @ProductID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discount", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnReset_Click(object sender, System.EventArgs e)
		{
			txtBillPinCode.Text="";
			txtCreditCardNo.Text = "";
			txtEmail.Text = "";
			
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			
				//store cart items in Order Deatails table.

				//sqlDataAdapter1.Fill(dataSet11);
				//DataRow row1 = dataSet11.Tables["Order Details"].NewRow();
			
				Label11.Visible = true;
				Application["OrderNumber"] = (int)Application["OrderNumber"] + 1;
				lblMsg.Text = "Your Order Number is " + Application["OrderNumber"].ToString();
				MailMessage msgMail = new MailMessage();
				msgMail.From = "Shopping@Cart.com";
				msgMail.To = txtEmail.Text;
				msgMail.Subject = "Order Number:"+Application["OrderNumber"].ToString();
				msgMail.Body = "You have successfully placed and order for item(s).Your item(s)will be shipped in 8 working days";
			
			}

			

		
	}
}
