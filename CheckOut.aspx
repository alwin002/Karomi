<%@ Page language="c#" Codebehind="CheckOut.aspx.cs" AutoEventWireup="false" Inherits="Shopping.CheckOut" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CheckOut</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ff9966">
		<form id="Form1" method="post" runat="server">
			<asp:table id="Table1" style="Z-INDEX: 101; LEFT: 448px; POSITION: absolute; TOP: 152px" runat="server"
				CellSpacing="5" GridLines="Both" BackColor="#FFFF80" BorderColor="OrangeRed" BorderStyle="Outset"
				ForeColor="Navy" Height="128px" Width="392px"></asp:table>
			<asp:RangeValidator id="RangeValidator1" style="Z-INDEX: 124; LEFT: 352px; POSITION: absolute; TOP: 48px"
				runat="server" ErrorMessage="*" MaximumValue="999999999999" MinimumValue="1000000000000" ControlToValidate="txtCreditCardNo"></asp:RangeValidator>
			<asp:RegularExpressionValidator id="RegularExpressionValidator2" style="Z-INDEX: 123; LEFT: 352px; POSITION: absolute; TOP: 96px"
				runat="server" ErrorMessage="*" ControlToValidate="txtBillPinCode" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator2" style="Z-INDEX: 122; LEFT: 352px; POSITION: absolute; TOP: 136px"
				runat="server" Width="22px" ErrorMessage="*" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator id="RegularExpressionValidator1" style="Z-INDEX: 121; LEFT: 352px; POSITION: absolute; TOP: 136px"
				runat="server" ErrorMessage="*" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
			<asp:TextBox id="txtEmail" style="Z-INDEX: 120; LEFT: 176px; POSITION: absolute; TOP: 136px"
				runat="server" Width="156" Height="24"></asp:TextBox>
			<asp:Label id="Label8" style="Z-INDEX: 119; LEFT: 40px; POSITION: absolute; TOP: 136px" runat="server"
				Width="122px" Height="19px">E Mail </asp:Label>
			<asp:RequiredFieldValidator id="RequiredFieldValidator1" style="Z-INDEX: 118; LEFT: 352px; POSITION: absolute; TOP: 96px"
				runat="server" Width="22px" ErrorMessage="*" ControlToValidate="txtBillPinCode"></asp:RequiredFieldValidator>
			<asp:TextBox id="txtBillPinCode" style="Z-INDEX: 117; LEFT: 176px; POSITION: absolute; TOP: 93px"
				runat="server" Width="156" Height="24"></asp:TextBox>
			<asp:Label id="Label7" style="Z-INDEX: 116; LEFT: 40px; POSITION: absolute; TOP: 96px" runat="server"
				Width="122" Height="19">Billing PinCode</asp:Label>
			<asp:Label id="lblMsg" style="Z-INDEX: 115; LEFT: 56px; POSITION: absolute; TOP: 376px" runat="server"
				Height="38px" Width="305px"></asp:Label>
			<asp:Label id="Label11" style="Z-INDEX: 114; LEFT: 56px; POSITION: absolute; TOP: 304px" runat="server"
				Width="352px" Visible="False" Height="38">Thankyou for placing and order.you have been sent an e-mail regarding your order number.</asp:Label><asp:button id="Button1" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 240px" runat="server"
				Height="24px" Width="52px" Text="OK"></asp:button><asp:requiredfieldvalidator id="RequiredFieldValidator6" style="Z-INDEX: 111; LEFT: 352px; POSITION: absolute; TOP: 48px"
				runat="server" Height="24px" Width="24px" ErrorMessage="*" ControlToValidate="txtCreditCardNo"></asp:requiredfieldvalidator><asp:textbox id="txtCreditCardNo" style="Z-INDEX: 110; LEFT: 176px; POSITION: absolute; TOP: 48px"
				runat="server" Height="24px" Width="156px"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 109; LEFT: 40px; POSITION: absolute; TOP: 56px" runat="server"
				Height="19px" Width="122px">CreditCardNo</asp:label>
			<asp:Label id="Label1" style="Z-INDEX: 107; LEFT: 448px; POSITION: absolute; TOP: 96px" runat="server"
				BackColor="#FFFF80" BorderColor="OrangeRed" BorderStyle="Outset" ForeColor="Blue" Height="27px"
				Width="72px" Font-Bold="True" Font-Size="Small">Total $</asp:Label>
			<asp:Label id="LabelTotal" style="Z-INDEX: 102; LEFT: 528px; POSITION: absolute; TOP: 96px"
				runat="server" BackColor="#FFFF80" BorderColor="OrangeRed" BorderStyle="Inset" ForeColor="Red"
				Height="27px" Width="92px" Font-Bold="True" Font-Size="Medium">0.0</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 448px; POSITION: absolute; TOP: 128px" runat="server"
				Width="40px" Height="19px" ForeColor="Blue" BorderStyle="Outset" BorderColor="OrangeRed"
				BackColor="#FFFF80" Font-Bold="True">ID</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 488px; POSITION: absolute; TOP: 128px" runat="server"
				Width="222px" Height="19" ForeColor="Blue" BorderStyle="Outset" BorderColor="OrangeRed"
				BackColor="#FFFF80" Font-Bold="True">Product Name</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 704px; POSITION: absolute; TOP: 128px" runat="server"
				Width="61px" Height="19px" ForeColor="Blue" BorderStyle="Outset" BorderColor="OrangeRed"
				BackColor="#FFFF80" Font-Bold="True">Price</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 105; LEFT: 760px; POSITION: absolute; TOP: 128px" runat="server"
				Width="80px" Height="19px" ForeColor="Blue" BorderStyle="Outset" BorderColor="White" BackColor="#C0C0FF"
				Font-Bold="True">Quantity</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 108; LEFT: 456px; POSITION: absolute; TOP: 56px" runat="server"
				ForeColor="Blue" Width="225px" Font-Size="Small" Font-Bold="True">Item Information</asp:Label>
			<asp:Button id="btnReset" style="Z-INDEX: 113; LEFT: 216px; POSITION: absolute; TOP: 240px"
				runat="server" Text="Reset" Height="24" Width="52"></asp:Button>
		</form>
	</body>
</HTML>
