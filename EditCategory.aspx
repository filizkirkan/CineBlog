<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="_2.Sequence.AdminPanel.EditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="Css/FormDesign.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formholder">
        <div class="topic">
            Update Category
        </div>
        <div class="formcontent">
            <asp:Panel ID="pnl_unsuccessful" runat="server" CssClass="pnlsuccessful" Visible="false">
                <asp:Label ID="lbl_message" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlsuccessful" Visible="false">
                Process is successful.
            </asp:Panel>
            <div class="row">
                <label>Category Name</label><br />
                <asp:TextBox ID="tb_name" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="row">
                <asp:CheckBox ID="cb_statu" runat="server" Text="Publish Category" Checked="true"></asp:CheckBox>
            </div>
            <div class="row">
                <asp:LinkButton ID="lbtn_edit" runat="server" OnClick="lbtn_edit_Click" CssClass="button">Update Category</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
