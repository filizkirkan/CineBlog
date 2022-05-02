<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="CategoryListList.aspx.cs" Inherits="_2.Sequence.AdminPanel.CategoryListList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/FormDesign.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formholder">
        <div class="topic">
            List Category
        </div>
        <asp:ListView ID="lv_categories" runat="server" OnItemCommand="lv_categories_ItemCommand">
            <LayoutTemplate>
                <table cellspacing="0" cellpadding="0" class="section">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Category Name</th>
                            <th>Statu</th>
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Name")%></td>
                    <td><%# Eval("Statu")%></td>
                    <td>
                        <a href='EditCategory.aspx?kid=<%# Eval("ID") %>' class="listbutton edit Deep-Teal-Sea-4-bg">Edit</a>
                        <asp:LinkButton ID="lbtn_statu" runat="server" CommandName="statu" CommandArgument='<%# Eval("ID") %>' CssClass="listbutton statu">Change the statu</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_delete" runat="server" CommandName="delete" CommandArgument='<%# Eval("ID") %>' CssClass="listbutton delete">Delete</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr class="alt">
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Name")%></td>
                    <td><%# Eval("Statu")%></td>
                    <td>
                        <a href='EditCategory.aspx?kid=<%# Eval("ID") %>' class="listbutton edit Deep-Teal-Sea-4-bg">Edit</a>
                        <asp:LinkButton ID="lbtn_statu" runat="server" CommandName="statu" CommandArgument='<%# Eval("ID") %>' CssClass="listbutton statu">Change the statu</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_delete" runat="server" CommandName="delete" CommandArgument='<%# Eval("ID") %>' CssClass="listbutton delete">Delete</asp:LinkButton>
                    </td>
                </tr>
            </AlternatingItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
