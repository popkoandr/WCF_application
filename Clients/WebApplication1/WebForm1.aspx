<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <fieldset style="border: 2px solid green;">
            <legend>HelloService</legend>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Label" />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Get Hello" OnClick="Button1_Click" />
                <asp:TextBox ID="TextBox1" runat="server" />
            </div>
            <br />
            <hr />
        </fieldset>

        <fieldset style="border: 2px solid green;">
            <legend>CompanyService</legend>
            <div style="font-family: Arial">
                <table style="border: 1px solid black">
                    <tr>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Get Public Information"
                                OnClick="Button2_Click" Width="300px" />
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Font-Bold="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="Get Confidential Information"
                                OnClick="Button3_Click" Width="300px" />
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Font-Bold="true"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <hr />
        </fieldset>

        <fieldset style="border: 2px solid green;">
            <legend>HelloService</legend>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Label" />
                <br />
                <asp:Button ID="Button4" runat="server" Text="Get Hello" />
                <asp:TextBox ID="TextBox4" runat="server" />
            </div>
            <br />
            <hr />
        </fieldset>

    </form>
</body>
</html>
