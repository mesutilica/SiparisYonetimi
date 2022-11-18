<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UrunYonetimi.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.UrunYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>
        Ürün Yönetimi
    </h1>

    <asp:GridView ID="dgvUrunler" runat="server" CssClass="table table-striped table-hover">
        <Columns>
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
            </Columns>
    </asp:GridView>

    <asp:Literal ID="ltMesaj" runat="server"></asp:Literal>

    <table class="table table-hover">
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
    </table>

</asp:Content>
