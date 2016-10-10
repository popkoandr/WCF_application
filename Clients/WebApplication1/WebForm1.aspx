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
            <legend>EmployeeService</legend>
            <div>
                <table style="font-family: Arial; border: 1px solid black;">
                    <tr>
                        <td>
                            <b>ID</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtID" runat="server">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Name</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Gender</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtGender" runat="server">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Date Of Birth</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDateOfBirth" runat="server">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnGetEmployee" runat="server"
                                Text="Get Employee"
                                OnClick="btnGetEmployee_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnSave" runat="server"
                                Text="Save Employee"
                                OnClick="btnSave_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblMessage" runat="server"
                                ForeColor="Green" Font-Bold="true">
                            </asp:Label>
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
            </div>
            <br />
            <hr />
        </fieldset>

    </form>
</body>
</html>
