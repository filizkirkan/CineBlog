<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="_2.Sequence.AdminPanel.AddArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/FormDesign.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formholder">
        <div class="topic">
            Add Article
        </div>
        <div class="formcontent">
            <asp:Panel ID="pnl_unsuccessful" runat="server" CssClass="pnlunsuccessful" Visible="false">
                <asp:Label ID="lbl_message" runat="server"></asp:Label>
                <%--Article addition process failed.--%>
            </asp:Panel>
            <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlsuccessful" Visible="false">
                Article addition process completed.
            </asp:Panel>
            <div class="half" style="margin-right:20px;">
                <div class="row">
                    <label>Article Topic</label><br />
                    <asp:TextBox ID="tb_name" runat="server" CssClass="textbox"></asp:TextBox>
                </div>
                <div class="row">
                    <label>Article Category</label><br />
                    <asp:DropDownList ID="ddl_categories" runat="server" CssClass="textbox" DataTextField="Name" DataValueField="ID"></asp:DropDownList>
                </div>
                 <div class="row">
                    <label>Article Photo</label><br />
                   <asp:FileUpload ID="fu_photo" runat="server" CssClass="textbox" />
                </div>
                <div class="row">
                    <asp:CheckBox ID="cb_statu" runat="server" Text="Publish article" Checked="true"></asp:CheckBox>
                </div>
                <div class="row">
                    <asp:LinkButton ID="lbtn_add" runat="server" OnClick="lbtn_add_Click" CssClass="button BEFORE-SUNSET-2-hex" >Add Article</asp:LinkButton>
                </div>
                
            </div>
            <div class="half">
                <div class="row">
                   <label>Article Summary</label><br />
                    <asp:TextBox ID="tb_summary" runat="server" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
                </div>
                 <div class="row">
                   <label>Article content</label><br />
                    <asp:TextBox ID="tb_content" runat="server" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
