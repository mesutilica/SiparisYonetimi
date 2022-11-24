<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        html,
        body { height: 100%; }

        body { display: flex; align-items: center; padding-top: 40px; padding-bottom: 40px; background-color: #f5f5f5; }

        .form-signin { max-width: 330px; padding: 15px; }

        .form-signin .form-floating:focus-within { z-index: 2; }

        .form-signin input[type="email"] { margin-bottom: -1px; border-bottom-right-radius: 0; border-bottom-left-radius: 0; }

        .form-signin input[type="password"] { margin-bottom: 10px; border-top-left-radius: 0; border-top-right-radius: 0; }
    </style>
</head>
<body class="text-center">
    <main class="form-signin w-100 m-auto">

        <form id="form1" runat="server">
            <img class="mb-4" src="../Img/lock-300x300.png" alt="" width="72" height="72">
            <h1 class="h3 mb-3 fw-normal">Admin Login</h1>

            <div class="form-floating">
                <input type="text" class="form-control" id="floatingInput" runat="server" placeholder="Kullanıcı Adı">
                <label for="floatingInput">Kullanıcı Adı</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" id="floatingPassword" placeholder="Şifre" runat="server">
                <label for="floatingPassword">Şifre</label>
            </div>

            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me">
                    Beni Hatırla
                </label>
            </div>
            <asp:Button ID="btnGiris" runat="server" Text="Giriş" CssClass="w-100 btn btn-lg btn-primary" OnClick="btnGiris_Click" />

            <p class="mt-5 mb-3 text-muted">© 2017–2022</p>
        </form>

    </main>
</body>
</html>
