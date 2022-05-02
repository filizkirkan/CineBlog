<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserEntrance.aspx.cs" Inherits="_2.Sequence.UserEntrance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Assets/UserEntrance.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="content" >

        <img src="Assets/SEQUENCE!.png" alt="logo" />

    <h1>Sequence<br><br></h1>

    <p class="par">“The internet connects your film to the entire world.
        All you need are subtitles.”<br>

        — Andrew Allen, Short of the Week</p>

        <%--<div class="sizing">
            <img src="the lobster.png" />
        </div>--%>

        <button class="cn"><a href="#">JOIN US</a></button>

        <div class="form">

            <h2>Login</h2>

            <asp:Panel ID="pnl_error" runat="server" CssClass="errorbox" Visible="false">
                        <asp:Label ID="lbl_message" runat="server"></asp:Label>
                    </asp:Panel>

                    <div class="row">

                    <label>Email</label><br />

            <asp:TextBox ID="tb_mail" runat="server" CssClass="textbox"  placeholder="Enter Email"></asp:TextBox>

                    <div class="row">

                    <label>Password</label><br />

            <asp:TextBox ID="tb_password" runat="server" CssClass="textbox" TextMode="Password"  placeholder="Enter Password"></asp:TextBox>

                    <div class="row">
                        
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="btn_login_Click" />

                    <div class="row">
                   

            <a href="signup.aspx"><input class="button2" id="button2" type="button" value="Sign Up" /></a>

                      </div>

           <%-- <p class="link">Don't have an account<br>
            <a href="#"> Sign up </a> here</a></p>
            <p class="liw">Log in with</p>




            <p class="link">Don't have an account<br>
            <a href="#"> Sign up </a> here</a></p>--%>
            

 </div>           

</div> 
        
</div> 

</div>  

        
    </div>
</asp:Content>


