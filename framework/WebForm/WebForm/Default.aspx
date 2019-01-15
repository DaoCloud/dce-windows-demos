<%@ Page Language="C#" Inherits="WebForm.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
            
        <br />
        
        <textarea id="txtArea" runat="server" style="height:400px;width:800px;margin-top:50px;"></textarea>
	</form>
</body>
</html>
