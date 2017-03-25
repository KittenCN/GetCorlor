<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="GetCorlor.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="file" id="OriDataFile" name="OriDataFile" runat="server" />
            <asp:Button ID="btn_submit" Text="Upload" runat="server" onclick="btn_submit_Click" />           
        </div>
        <div>
            <asp:Label ID="labAll" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="tbColor" runat="server" Height="421px" ReadOnly="True" TextMode="MultiLine" Width="409px"></asp:TextBox>
        </div>       
    </form>
</body>
</html>
