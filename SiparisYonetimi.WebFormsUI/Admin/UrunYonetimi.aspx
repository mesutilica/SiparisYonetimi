<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UrunYonetimi.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.UrunYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Ürün Yönetimi
    </h1>

    <asp:GridView ID="dgvUrunler" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvUrunler_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True"></asp:CommandField>
        </Columns>
    </asp:GridView>

    <asp:Literal ID="ltMesaj" runat="server"></asp:Literal>

    <table class="table table-hover">
        <tr>
            <td>Ürün Adı</td>
            <td>
                <asp:TextBox ID="txtUrunAdi" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Açıklama</td>
            <td>
                <asp:TextBox ID="txtAciklama" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fiyat</td>
            <td>
                <asp:TextBox ID="txtFiyat" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Stok</td>
            <td>
                <asp:TextBox ID="txtStok" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Resim
            </td>
            <td>
                <asp:FileUpload ID="fuResim" runat="server" CssClass="form-control" />
            </td>
        </tr>
        <tr>
            <td>Durum</td>
            <td>
                <asp:CheckBox ID="chbDurum" runat="server" Text="Aktif" />
            </td>
        </tr>
        <tr>
            <td>Kategori</td>
            <td>
                <asp:DropDownList ID="cbKategoriler" runat="server" CssClass="form-select" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Marka</td>
            <td>
                <asp:DropDownList ID="cbMarkalar" runat="server" CssClass="form-select" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
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
