<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WebApp_MBANF.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
    <title>Principal</title>
</head>
<body>
    <form id="form_home" class="form-control" runat="server">
        <div>
            <asp:Label CssClass="h3" ID="lbl_welcome" runat="server" Text="Label"></asp:Label>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-4">
                <asp:Button CssClass="btn btn-dark btn-sm" ID="btn_closeSession" runat="server" Text="Cerrar Sesion" OnClick="BtnCloseSession_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
