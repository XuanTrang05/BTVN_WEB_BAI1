<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppDemo.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xử lý chuỗi nhập vào</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f0f2f5;
        }
        .container {
            max-width: 500px;
            margin: 50px auto;
            background: #fff;
            border-radius: 8px;
            padding: 20px;
            box-shadow: 0 2px 8px rgba(0,0,0,0.2);
        }
        h2 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
        }
        table {
            width: 100%;
        }
        td {
            padding: 8px;
        }
        .btn {
            background: #007bff;
            color: #fff;
            border: none;
            padding: 8px 16px;
            border-radius: 4px;
            cursor: pointer;
        }
        .btn:hover {
            background: #0056b3;
        }
        .result {
            margin-top: 20px;
            padding: 10px;
            border: 1px solid #ddd;
            background: #f9f9f9;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Xử lý chuỗi nhập vào</h2>
            <table>
                <tr>
                    <td><b>Nhập chuỗi:</b></td>
                    <td>
                        <asp:TextBox ID="txtInput" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnProcess" runat="server" Text="Xử lý" CssClass="btn" OnClick="btnProcess_Click" />
                    </td>
                </tr>
            </table>

            <asp:Literal ID="litOutput" runat="server" Mode="PassThrough"></asp:Literal>
        </div>
    </form>
</body>
</html>
