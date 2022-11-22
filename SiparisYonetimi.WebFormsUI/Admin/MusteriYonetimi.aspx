<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriYonetimi.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.MusteriYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Müşteri Yönetimi</h1>

    <asp:GridView ID="dgvMusteriler" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvMusteriler_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True"></asp:CommandField>
        </Columns>
    </asp:GridView>

    <table class="table table-hover">
        <tr>
            <td>Adı</td>
            <td>
                <asp:TextBox ID="txtAdi" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Soyadı</td>
            <td>
                <asp:TextBox ID="txtSoyadi" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Telefon</td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Adres</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Durum</td>
            <td>
                <asp:CheckBox ID="chbDurum" runat="server" Text="Aktif" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnEkle_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="btnGuncelle_Click" Enabled="false" />
                <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn-danger" OnClick="btnSil_Click" Enabled="false" />
            </td>
        </tr>
    </table>

</asp:Content>
