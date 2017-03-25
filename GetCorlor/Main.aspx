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
        &nbsp;<asp:Button ID="btn_Analysis" runat="server" OnClick="btn_Analysis_Click" Text="Analysis" />
        </div>
        <div>
            <asp:Image ID="imgOri" runat="server" Height="440px" Width="410px" />
&nbsp;
            <asp:Image ID="imgGrey" runat="server" Height="441px" Width="395px" />
&nbsp;
            <asp:Image ID="imgPixel" runat="server" Height="442px" Width="383px" />
            <br />
            <asp:Label ID="labAll" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="tbColor" runat="server" Height="421px" ReadOnly="True" TextMode="MultiLine" Width="409px"></asp:TextBox>
        </div>       
    </form>
</body>
</html>
