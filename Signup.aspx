<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="_2.Sequence.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <link href="Assets/UserEntrance.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
      
<div class ="UserEntrance">
    <div class="topic">
        kayit icn doldur
    </div>
    <div class ="formcontent">
        <asp:Panel ID="pnl_unsuccessful" runat="server" CssClass="pnlunsuccessful"  Visible="false">
            <asp:Label ID ="lbl_unsuccessful" runat="server"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlsuccessful" Visible="false">
            <asp:Label ID="lbl_successful" runat="server"></asp:Label>
        </asp:Panel>
        <div class="form">
            <div class="content">
                <div class="row">
                    <label>Name</label><br />
                    <asp:TextBox ID="tb_name" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Lastname</label><br />
                    <asp:TextBox ID="tb_lastname" runat="server" CssClass="textbox"></asp:TextBox>
               </div>
                <div class="row">
                    <label>Username</label><br />
                    <asp:TextBox ID="tb_username" runat="server" CssClass="textbox" ></asp:TextBox>
                </div>
                <div class="row">
                    <label>E-mail</label><br />
                    <asp:TextBox ID="tb_email" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Password</label><br />
                    <asp:TextBox ID="tb_password" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Confirm Password</label><br />
                    <asp:TextBox ID="tb_confirmpassword" runat="server" CssClass="textbox"></asp:TextBox>
       
                </div>
                <div class="row">
                    <asp:LinkButton ID="btn_enter" runat="server" OnClick="btn_enter_Click" CssClass="enterbutton">Sign up</asp:LinkButton>


                </div>

            </div>
        </div>
    </div>
</div>
    </asp:Content>
