<%@ Page language="c#" Codebehind="Login.aspx.cs" AutoEventWireup="false" Inherits="Shopping.Login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Login</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ff9966">
		<FORM id="Form1" method="post" runat="server">
			<asp:Label id="Label2" style="Z-INDEX: 103; LEFT: 112px; POSITION: absolute; TOP: 112px" runat="server">Password</asp:Label>
			<asp:TextBox id="txtLogin" style="Z-INDEX: 109; LEFT: 192px; POSITION: absolute; TOP: 56px" runat="server"
				Width="152px"></asp:TextBox>
			<asp:TextBox id="txtPassword" style="Z-INDEX: 102; LEFT: 192px; POSITION: absolute; TOP: 104px"
				runat="server" TextMode="Password" Width="152px"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 100; LEFT: 112px; POSITION: absolute; TOP: 56px" runat="server">Login</asp:Label>
			<asp:RequiredFieldValidator id="RequiredFieldValidator1" style="Z-INDEX: 104; LEFT: 368px; POSITION: absolute; TOP: 64px"
				runat="server" ErrorMessage="Please enter Login Name" ControlToValidate="txtLogin" Width="153" Height="19"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator2" style="Z-INDEX: 105; LEFT: 368px; POSITION: absolute; TOP: 104px"
				runat="server" ErrorMessage="Please enter password" ControlToValidate="txtPassword" Width="153px" Height="19px"></asp:RequiredFieldValidator>
			<asp:Button id="btnLogin" style="Z-INDEX: 106; LEFT: 216px; POSITION: absolute; TOP: 168px"
				runat="server" Width="72px" Text="Sign In" Height="24px"></asp:Button>
			<asp:Label id="LabelError" style="Z-INDEX: 107; LEFT: 176px; POSITION: absolute; TOP: 272px"
				runat="server" Visible="False" Width="456px" Height="48px" Font-Bold="True" Font-Size="Medium"
				ForeColor="#0000C0">Oops!! Wrong login/password.</asp:Label></FORM>
	</body>
</HTML>
