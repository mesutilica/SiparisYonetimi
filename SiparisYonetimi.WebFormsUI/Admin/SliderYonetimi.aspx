<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SliderYonetimi.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.SliderYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Slider Yönetimi</h1>

    <asp:GridView runat="server" ID="dgvSlides" CssClass="table table-hover table-striped" OnSelectedIndexChanged="dgvSlides_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True"></asp:CommandField>
        </Columns>
    </asp:GridView>

    <hr />

    <h3>Slide Bilgileri</h3>

    <table class="table table-hover table-striped">
        <tr>
            <td>Resim</td>
            <td>
                <asp:FileUpload ID="fuImage" runat="server" CssClass="form-control" />
                <asp:Image ID="Image1" runat="server" Height="50" />
            </td>
        </tr>
        <tr>
            <td>
                Başlık
            </td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Açıklama</td>
            <td><asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Link</td>
            <td><asp:TextBox ID="txtLink" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnEkle_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" Enabled="false" OnClick="btnGuncelle_Click" />
                <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn-danger" Enabled="false" OnClick="btnSil_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
