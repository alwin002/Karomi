<%@ Page language="c#" Codebehind="NewUser.aspx.cs" AutoEventWireup="false" Inherits="Shopping.NewUser" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>NewUser</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ff9966">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 100; LEFT: 176px; POSITION: absolute; TOP: 101px" runat="server"
				Width="129px" ForeColor="Navy" Font-Bold="True" Height="19px" Font-Size="Small">First Name</asp:Label>
			<asp:Button id="btnCancel" style="Z-INDEX: 125; LEFT: 456px; POSITION: absolute; TOP: 528px"
				runat="server" Width="83" Height="24" Text="Cancel"></asp:Button>
			<asp:Button id="btnSubmit" style="Z-INDEX: 124; LEFT: 320px; POSITION: absolute; TOP: 528px"
				runat="server" Width="83px" Height="24px" Text="Submit"></asp:Button>
			<asp:RequiredFieldValidator id="RequiredFieldValidator7" style="Z-INDEX: 123; LEFT: 616px; POSITION: absolute; TOP: 424px"
				runat="server" ErrorMessage="*" ControlToValidate="txtPassword" Width="9" Height="19"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator6" style="Z-INDEX: 122; LEFT: 616px; POSITION: absolute; TOP: 360px"
				runat="server" ErrorMessage="*" ControlToValidate="txtUserName" Width="9" Height="19"></asp:RequiredFieldValidator>
			<asp:Label id="Label8" style="Z-INDEX: 121; LEFT: 176px; POSITION: absolute; TOP: 361px" runat="server"
				Width="129" Height="19" ForeColor="Navy" Font-Bold="True" Font-Size="Small">UserName</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 120; LEFT: 176px; POSITION: absolute; TOP: 416px" runat="server"
				Width="129" Height="19" ForeColor="Navy" Font-Bold="True" Font-Size="Small">Password</asp:Label>
			<asp:TextBox id="txtPassword" style="Z-INDEX: 119; LEFT: 320px; POSITION: absolute; TOP: 407px"
				runat="server" Width="273px" Height="26px"></asp:TextBox>
			<asp:TextBox id="txtUserName" style="Z-INDEX: 118; LEFT: 320px; POSITION: absolute; TOP: 350px"
				runat="server" Width="273px" Height="26px"></asp:TextBox>
			<asp:RegularExpressionValidator id="RegularExpressionValidator2" style="Z-INDEX: 117; LEFT: 616px; POSITION: absolute; TOP: 248px"
				runat="server" Width="9px" ErrorMessage="*" ControlToValidate="txtPNumber" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"
				Height="19px"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="RegularExpressionValidator1" style="Z-INDEX: 116; LEFT: 616px; POSITION: absolute; TOP: 200px"
				runat="server" Width="9px" ErrorMessage="*" ControlToValidate="txtEMail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
				Height="19px"></asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator5" style="Z-INDEX: 115; LEFT: 616px; POSITION: absolute; TOP: 304px"
				runat="server" ErrorMessage="*" ControlToValidate="txtAddress" Width="9" Height="19"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator4" style="Z-INDEX: 114; LEFT: 616px; POSITION: absolute; TOP: 150px"
				runat="server" ErrorMessage="*" ControlToValidate="txtLName" Width="9" Height="19"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator3" style="Z-INDEX: 113; LEFT: 616px; POSITION: absolute; TOP: 248px"
				runat="server" ErrorMessage="*" ControlToValidate="txtPNumber"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator2" style="Z-INDEX: 112; LEFT: 616px; POSITION: absolute; TOP: 200px"
				runat="server" ErrorMessage="*" ControlToValidate="txtEMail"></asp:RequiredFieldValidator>
			<asp:Label id="Label6" style="Z-INDEX: 110; LEFT: 176px; POSITION: absolute; TOP: 40px" runat="server"
				Width="480px" Font-Bold="True" Font-Size="Large" ForeColor="Navy" Font-Underline="True">Please Enter Your Information below.</asp:Label>
			<asp:TextBox id="txtAddress" style="Z-INDEX: 109; LEFT: 320px; POSITION: absolute; TOP: 296px"
				runat="server" Width="273" Height="26"></asp:TextBox>
			<asp:Label id="Label5" style="Z-INDEX: 108; LEFT: 176px; POSITION: absolute; TOP: 309px" runat="server"
				Width="129" Height="19" ForeColor="Navy" Font-Bold="True" Font-Size="Small">Address</asp:Label>
			<asp:TextBox id="txtEMail" style="Z-INDEX: 107; LEFT: 320px; POSITION: absolute; TOP: 196px"
				runat="server" Width="272px"></asp:TextBox>
			<asp:TextBox id="txtPNumber" style="Z-INDEX: 106; LEFT: 320px; POSITION: absolute; TOP: 246px"
				runat="server" Width="272px"></asp:TextBox>
			<asp:TextBox id="txtLName" style="Z-INDEX: 105; LEFT: 320px; POSITION: absolute; TOP: 146px"
				runat="server" Width="272px"></asp:TextBox>
			<asp:TextBox id="txtFName" style="Z-INDEX: 104; LEFT: 320px; POSITION: absolute; TOP: 96px" runat="server"
				Width="272px"></asp:TextBox>
			<asp:Label id="Label4" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 257px" runat="server"
				Width="129" Height="19" ForeColor="Navy" Font-Bold="True" Font-Size="Small">Phone Number</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 176px; POSITION: absolute; TOP: 205px" runat="server"
				Width="129px" ForeColor="Navy" Font-Bold="True" Height="19px" Font-Size="Small">E-Mail</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 153px" runat="server"
				Width="129px" ForeColor="Navy" Font-Bold="True" Height="19px" Font-Size="Small">Last Name</asp:Label>
			<asp:RequiredFieldValidator id="RequiredFieldValidator1" style="Z-INDEX: 111; LEFT: 616px; POSITION: absolute; TOP: 96px"
				runat="server" ErrorMessage="*" ControlToValidate="txtFName" Width="9" Height="19"></asp:RequiredFieldValidator>
		</form>
	</body>
</HTML>
