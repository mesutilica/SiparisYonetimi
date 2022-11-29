<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="UrunDetay.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.UrunDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <asp:Image ID="urunResmi" runat="server" CssClass="img-fluid" />
        </div>
        <div class="col">
            <h1>
                <asp:Literal ID="ltUrunAdi" runat="server"></asp:Literal>
            </h1>

            <table>
                <tr>
                    <th>Ürün Fiyatı</th>
                    <td>
                       : <asp:Literal ID="ltUrunFiyati" runat="server"></asp:Literal> ₺
                    </td>
                </tr>
                <tr>
                    <th>Ürün Stok</th>
                    <td>
                       : <asp:Label ID="lblUrunStok" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>

            <h2>Ürün Bilgileri</h2>

            <p>
                <asp:Literal ID="ltUrunAciklama" runat="server"></asp:Literal>
            </p>

        </div>
    </div>
</asp:Content>
