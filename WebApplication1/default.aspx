﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%=HttpContext.Current.Request.ServerVariables["REMOTE_PORT"]%><br />
            <%=HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]%>
        </div>
    </form>
</body>
</html>
