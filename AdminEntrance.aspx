<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEntrance.aspx.cs" Inherits="_2.Sequence.AdminPanel.AdminEntrance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/Entrance.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="holder">
            <div class="topic">
                <h3>Admin Entrance</h3>
            </div>
            <div class="content">
                <asp:Panel ID="pnl_error" runat="server" CssClass="errorbox" Visible="false">
                        <asp:Label ID="lbl_message" runat="server"></asp:Label>
                    </asp:Panel>
                <div class="row">
                    <label>Email</label><br />
                    <asp:TextBox ID="tb_mail" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Password</label><br />
                    <asp:TextBox ID="tb_password" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Button ID="btn_enter" runat="server" Text="Login" OnClick="btn_enter_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
