<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Ara.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Ara" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        <asp:Literal ID="ltBaslik" runat="server"></asp:Literal>
    </h1>

    <div class="row row-cols-3">
        <asp:Repeater ID="rptUrunler" runat="server">
            <ItemTemplate>
                <div class="col">
                    <a href="/UrunDetay.aspx?id=<%#Eval("Id")%>">
                        <img class="img-fluid" src="/Img/<%#Eval("Image")%>" alt="<%#Eval("Name")%>" />
                        <h3><%#Eval("Name")%> <%#Eval("Price")%> ₺</h3>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
