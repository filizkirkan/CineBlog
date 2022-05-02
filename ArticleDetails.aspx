<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="_2.Sequence.ArticleDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DetailsHolder">
        <h3 class="ArticleTopic">
            <asp:Literal ID="ltrl_topic" runat="server"></asp:Literal></h3>
        <div class="makaleResim">
            <asp:Image ID="img_resim" runat="server" />
        </div>
        <div class="ArticleSummary">
             <asp:Literal ID="ltrl_summary" runat="server"></asp:Literal>
        </div>
        <div style="clear:both"></div>
        <div class="AdditionalInformation">
            <label style="float: left">
                Category 
                <asp:Literal ID="ltrl_category" runat="server"></asp:Literal>
                Yazar:<asp:Literal ID="ltrl_author" runat="server"></asp:Literal>
            </label>
            <label style="float: right">
                <asp:Literal ID="ltrl_numberofviews" runat="server"></asp:Literal>
                View
            </label>
            <div style="clear: both"></div>
        </div>
        <div class="ArticleContent">
            <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
        </div>
        <br />
        <div style="min-height=500px;">
            <div class="commentTitle">
                <h2>Comments</h2>
            </div>
            <asp:Panel ID="pnl_entrancesuccessful" runat="server" Visible="false">
                <br />
                <h3>Add Comment</h3>
                <asp:TextBox ID="tb_comment" TextMode="MultiLine" runat="server" CssClass="area"></asp:TextBox>
                <br />
                <asp:LinkButton ID="lbtn_addcomment" runat="server" Text="Add Comment" OnClick="lbtn_addcomment_Click" CssClass="CommentBut"></asp:LinkButton>
            </asp:Panel>
            <asp:Panel ID="pnl_entranceunsuccessful" runat="server" CssClass="entranceLink" Style ="20px 0;">
                <h2>Please Login<a href="UserEntrance.aspx"> to post comment.</a></h2>
            </asp:Panel>
            <asp:Repeater ID="rp_comments" runat="server">
                <ItemTemplate>
                    <div class="CommentItem">
                        <label><%# Eval("User") %></label>   <label><%# Eval("Date") %></label>
                        <br />
                        <p><%# Eval("Content") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
