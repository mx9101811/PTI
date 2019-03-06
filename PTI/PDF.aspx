<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PDF.aspx.cs" Inherits="PDF_to_Images.PDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:FileUpload ID="UpPdf" runat="server" /></td>
            </tr>
            <tr>
                <td style="text-align:center;"><asp:Button ID="btnUp" runat="server" Text="转换" OnClick="btnUp_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
