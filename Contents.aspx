<%@ Page language="c#" Codebehind="Contents.aspx.cs" AutoEventWireup="false" Inherits="Shopping.Contents" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Contents</title>
		<base target="main">
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ff9966" aLink="#330066">
		<form id="Form1" method="post" runat="server">
			<asp:HyperLink id="HlinkShowProducts" style="Z-INDEX: 100; LEFT: 24px; POSITION: absolute; TOP: 70px"
				runat="server" NavigateUrl="Main.aspx" Width="139" Height="19">Show Products</asp:HyperLink>
			<asp:HyperLink id="HlContactUs" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 162px"
				runat="server" Height="19px" Width="139px" NavigateUrl="ContactUs.aspx">ContactUs</asp:HyperLink>
			<asp:HyperLink id="HlHome" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server"
				Height="19" Width="139" NavigateUrl="Index.aspx">Home</asp:HyperLink>
			<asp:HyperLink id="HlNewUser" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 116px"
				runat="server" Width="139px" NavigateUrl="NewUser.aspx" Height="19px">NewUser</asp:HyperLink>
			<asp:HyperLink id="HlLogin" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 208px" runat="server"
				NavigateUrl="Index.aspx" Width="139px" Height="19px">LogOut</asp:HyperLink>
		</form>
	</body>
</HTML>
