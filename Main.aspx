<%@ Page language="c#" Codebehind="Main.aspx.cs" AutoEventWireup="false" Inherits="Shopping.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ff9966">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id=DataGridProduct style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 48px" runat="server" DataSource="<%# dsProduct1 %>" DataKeyField="ProductID" DataMember="Products" AutoGenerateColumns="False" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" BackColor="#DEBA84" CellPadding="3" CellSpacing="2" Font-Size="X-Small">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="ProductID" SortExpression="ProductID" HeaderText="ProductID"></asp:BoundColumn>
					<asp:BoundColumn DataField="ProductName" SortExpression="ProductName" HeaderText="ProductName"></asp:BoundColumn>
					<asp:BoundColumn DataField="UnitPrice" SortExpression="UnitPrice" HeaderText="UnitPrice"></asp:BoundColumn>
					<asp:ButtonColumn Text="Add" CommandName="Select"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<TABLE id="TableItem" style="Z-INDEX: 105; LEFT: 456px; WIDTH: 377px; POSITION: absolute; TOP: 152px; HEIGHT: 27px"
				cellSpacing="0" cellPadding="0" width="377" bgColor="#ffff80" border="1" borderColor="#333399">
				<TR>
					<TD style="WIDTH: 30px" vAlign="bottom" align="center">
						<asp:Label id="Label2" runat="server" BorderColor="White" BackColor="#FFFF80" Width="34px"
							Height="19px" ForeColor="Blue" Font-Bold="True" Font-Size="X-Small">ID</asp:Label></TD>
					<TD style="WIDTH: 192px" vAlign="bottom" align="left">
						<asp:Label id="Label3" runat="server" BorderColor="White" BackColor="#FFFF80" Width="121px"
							Height="19" ForeColor="Blue" Font-Bold="True" Font-Size="X-Small">Product Name</asp:Label></TD>
					<TD style="WIDTH: 102px" vAlign="bottom" align="left">
						<asp:Label id="Label4" runat="server" BackColor="#FFFF80" BorderColor="White" Font-Bold="True"
							ForeColor="Blue" Height="19px" Width="54px" Font-Size="X-Small">Price</asp:Label></TD>
					<TD vAlign="bottom" align="left">
						<asp:Label id="Label5" runat="server" BorderColor="White" BackColor="#FFFF80" Width="33px"
							Height="19px" ForeColor="Blue" Font-Bold="True" Font-Size="X-Small">Qty</asp:Label></TD>
					<TD></TD>
				</TR>
			</TABLE>
			<asp:Panel id="Pan" style="Z-INDEX: 102; LEFT: 456px; POSITION: absolute; TOP: 184px" runat="server"
				BorderColor="Blue" BorderStyle="Groove" BackColor="#FFFF80" Width="378px" Height="120px"
				ForeColor="Blue">Panel 
<asp:Table id="Table1" runat="server" BorderStyle="Outset" Height="26px" Width="370px" GridLines="Both"></asp:Table></asp:Panel>
			<asp:Button id="BtnCheckout" style="Z-INDEX: 103; LEFT: 728px; POSITION: absolute; TOP: 64px"
				runat="server" BackColor="Blue" BorderStyle="Ridge" BorderColor="White" Height="32" Width="71"
				Font-Size="X-Small" Text="CheckOut" ForeColor="#FFFF80"></asp:Button>
			<asp:Button id="btnEmpty" style="Z-INDEX: 104; LEFT: 656px; POSITION: absolute; TOP: 64px" runat="server"
				BackColor="Blue" Height="32" Width="71" Font-Size="X-Small" Text="Clear Cart" BorderStyle="Ridge"
				ForeColor="#FFFF80"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 106; LEFT: 456px; POSITION: absolute; TOP: 64px" runat="server"
				Width="106px" Height="30px" ForeColor="Blue" Font-Size="X-Small"> Total Amount($)</asp:Label>
			<asp:Label id="LabelTotal" style="Z-INDEX: 107; LEFT: 584px; WIDTH: 71px; POSITION: absolute; TOP: 64px; HEIGHT: 32px"
				runat="server" BorderColor="White" BorderStyle="Ridge" BackColor="Blue" Width="70px" Height="32"
				ForeColor="WhiteSmoke" Font-Size="Small">0.0</asp:Label>
			<asp:Label id="lblEmptyCart" style="Z-INDEX: 108; LEFT: 456px; POSITION: absolute; TOP: 8px"
				runat="server" ForeColor="#C04000" Width="387" Font-Bold="True">Error!!!!!Your cart is empty.</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 109; LEFT: 456px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Bold="True" ForeColor="#C00000" Width="387px" Font-Size="X-Small">Items In Your Cart..</asp:Label></form>
	</body>
</HTML>
