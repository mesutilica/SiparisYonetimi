<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="SiparisYonetimi.WebFormsUI.Moduller.Header" %>

<header class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow">
    <a class="navbar-brand col-md-3 col-lg-2 me-0 px-3 fs-6" href="#">Sipariş Yönetim Admin</a>
    <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>
    <input class="form-control form-control-dark w-100 rounded-0 border-0" type="text" placeholder="Ara" aria-label="Search">
    <div class="navbar-nav">
        <div class="nav-item text-nowrap">
            <asp:LinkButton ID="lbCikis" runat="server" CssClass="nav-link px-3" OnClick="lbCikis_Click">Oturumu Kapat</asp:LinkButton>
        </div>
    </div>
</header>
