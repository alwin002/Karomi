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
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		public class CartRow
		{
			public string id;
			public string name;
			public string price;
			public string items;
		};
		public class Cart
		{
			public System.Collections.ArrayList list = new ArrayList(20);
		};

		protected System.Web.UI.WebControls.DataGrid DataGridProduct;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected Shopping.dsProduct dsProduct1;
		protected System.Web.UI.WebControls.Panel Pan;
		protected System.Web.UI.WebControls.Label labelart;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label LabelTotal;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Button BtnCheckout;
		protected System.Web.UI.WebControls.Table Table1;
		protected System.Web.UI.WebControls.Button btnEmpty;
		protected System.Web.UI.WebControls.Label lblEmptyCart;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label4;
		public Cart myCart = new Cart();
		public Cart GetCart() { return myCart; }
		
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			lblEmptyCart.Visible = false;
			if ((Session["cart"]==null))
			{
				Session["cart"] = myCart;
			}
			else
			{
				myCart = (Cart)(Session["cart"]);
			}
			
			sqlDataAdapter1.Fill(dsProduct1);
			DataGridProduct.DataBind();
			if (!IsPostBack)
			{
				
				int nTotalItem = myCart.list.Count;
				double dTotal = 0.0;
				double dPrice = 0.0;
				for (int nItem = 0; nItem < nTotalItem; nItem++)
				{
					TableRow trow = new TableRow();

					CartRow row = new CartRow();
					row = (CartRow)myCart.list[nItem];			
					
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
					dTotal += dPrice;

				}
				LabelTotal.Text = dTotal.ToString();		
			}

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
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.dsProduct1 = new Shopping.dsProduct();
			((System.ComponentModel.ISupportInitialize)(this.dsProduct1)).BeginInit();
			this.DataGridProduct.SelectedIndexChanged += new System.EventHandler(this.DataGridProduct_SelectedIndexChanged);
			this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
			this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" +
				", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=GUDDU;packet size=4096;user id=sa;data source=guddu;persist securi" +
				"ty info=False;initial catalog=Northwind";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @ProductID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																				  new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																				  new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																				  new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																				  new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
																																																				  new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
																																																				  new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
																																																				  new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
																																																				  new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
																																																				  new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dsProduct1
			// 
			this.dsProduct1.DataSetName = "dsProduct";
			this.dsProduct1.Locale = new System.Globalization.CultureInfo("en-US");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsProduct1)).EndInit();

		}
		#endregion

		private void DataGridProduct_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int nIdx = DataGridProduct.SelectedIndex;
			string id = dsProduct1.Tables["Products"].Rows[nIdx][0].ToString();
			string name = dsProduct1.Tables["Products"].Rows[nIdx][1].ToString();
			string price = dsProduct1.Tables["Products"].Rows[nIdx][5].ToString();
			
			CartRow row = new CartRow();
			CartRow testrow = new CartRow();
			row.id = id;
			row.name = name;
			row.price = price;
			row.items = "1";

			int nTotalItem = myCart.list.Count;
			double dTotal = 0.0;
			double dPrice = 0.0;

			for (int nItem = 0; nItem < nTotalItem; nItem++)
			{
				testrow = (CartRow)myCart.list[nItem];	
				if (testrow.id == id)
				{
					int nItems = Int32.Parse(testrow.items);
					nItems += 1;
					testrow.items = nItems.ToString();
					myCart.list.RemoveAt(nItem);
					row = testrow;
					break;
				}
			}
			myCart.list.Add(row);
			nTotalItem = myCart.list.Count;

			for (int nItem = 0; nItem < nTotalItem; nItem++)
			{
				TableRow trow = new TableRow();

				//CartRow row = new CartRow();
				row = (CartRow)myCart.list[nItem];			
				
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

		private void BtnCheckout_Click(object sender, System.EventArgs e)
		{
			if(!(myCart.list.Count == 0))
				//Response.Redirect("CheckOut.aspx");
				Response.Redirect("Login.aspx");
			else
				lblEmptyCart.Visible = true;
		   
		}

		private void btnEmpty_Click(object sender, System.EventArgs e)
		{
			myCart.list.Clear();	
			int nTotalItem = myCart.list.Count;
			double dTotal = 0.0;
			double dPrice = 0.0;
			for (int nItem = 0; nItem < nTotalItem; nItem++)
			{
				TableRow trow = new TableRow();

				CartRow row = new CartRow();
				row = (CartRow)myCart.list[nItem];			
				
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
				dTotal += dPrice;

			}
			LabelTotal.Text = dTotal.ToString();				
		}
	}
}
