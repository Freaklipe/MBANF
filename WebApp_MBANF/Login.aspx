<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_MBANF.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
    <link href="CSS/styles.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="form_login" runat="server">
                <div class="form-control">
                    <div class="col-md-6 offset-md-3 text-center  mb-4">
                        <asp:Label class="h2" ID="lbl_welcome" runat="server" Text="Bienvenido al Sistema"></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="lbl_user" runat="server" Text="Usuario"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="tx_user" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbl_password" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox CssClass="form-control" TextMode="Password" ID="tx_password" runat="server" ></asp:TextBox>
                    </div>
                    <hr />
                    <div class="row">
                        <asp:Label CssClass="alert alert-danger" ID="lbl_error" runat="server" Visible="false"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button CssClass="btn btn-primary btn-dark" ID="btn_login" runat="server" Text="Ingresar" OnClick="BtnLogin_Click"/>
                    </div>
                    <br />
                    <div>
                        <asp:Button ID="Btn_register" Text="Regristarse" CssClass="btn btn-primary btn-info" runat="server" OnClick="BtnRegister_Click"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
    
</body>
</html>
