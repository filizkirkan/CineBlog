<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_2.Sequence.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="lv_articles" runat="server">
        <LayoutTemplate>
            <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="article">
                <div class="topic">
                    <h3><%# Eval("Topic") %></h3>
                </div>
                <img src='Assets/AticlePhotos/<%# Eval("CoverPhoto") %>' />
                <div class="addinformation">
                    <label style="float:left">
                        Kategori : <%# Eval("Category") %>
                    Yazar: <%# Eval("Author") %>
                    </label>
                    <label style="float:right">
                        <%# Eval("Numberofviews") %> Görüntüleme
                    </label>
                    <div style="clear:both"></div>
                </div>
                <div class="summary">
                     <%# Eval("Summary") %>
                </div>
               
                <div >
                    <a href="#" class="continuebutton">Continue reading...</a>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>