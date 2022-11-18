<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="MarkaYonetimi.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.MarkaYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>
        Marka Yönetimi
    </h1>

    <asp:GridView ID="dgvMarkalar" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvMarkalar_SelectedIndexChanged">
        <Columns>
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
            </Columns>
    </asp:GridView>

    <asp:Literal ID="ltMesaj" runat="server"></asp:Literal>

    <table class="table table-hover">
        <tr>
            <td>
                Marka Adı
            </td>
            <td>
                <asp:TextBox ID="txtMarkaAdi" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Logo
            </td>
            <td>
                <asp:FileUpload ID="fuLogo" runat="server" CssClass="form-control"></asp:FileUpload>
                <asp:HiddenField ID="hfResimAdi" runat="server" />
            </td>
        </tr>
         <tr>
            <td>
                Açıklama
            </td>
            <td>
                <asp:TextBox ID="txtAciklama" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>

            </td>
            <td>
                <asp:CheckBox ID="chbDurum" runat="server" CssClass="form-control" Text="Durum" />
            </td>
        </tr>
         <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnEkle_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="btnGuncelle_Click" Enabled="False" />
                <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn-danger" OnClick="btnSil_Click" Enabled="False" />
            </td>
        </tr>
    </table>

</asp:Content>
