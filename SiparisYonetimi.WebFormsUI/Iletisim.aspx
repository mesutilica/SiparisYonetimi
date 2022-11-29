<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>İletişim</h1>

    <div class="row">
        <div class="col">
            <h3>Bize Mesaj Gönderin</h3>
            <table>
                <tr>
                    <td>Adınız</td>
                    <td>
                        <asp:TextBox ID="txtAd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Soyadınız</td>
                    <td><asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email Adresiniz</td>
                    <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mesajınız</td>
                    <td><asp:TextBox ID="txtMesaj" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnGonder" runat="server" Text="Gönder" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="col">
            <h3>Adres Bilgilerimiz</h3>
            <div>
                Adresimiz : Doğu mah. batı sk. Pendik / İstanbul
            </div>
            <div>
                Email : info@siteadi.com
            </div>
            <div>
                Telefon : 0216 444 04 44
            </div>
        </div>
        <div class="col">
            <h3>Harita</h3>
            <div>

            </div>
        </div>
    </div>
</asp:Content>
