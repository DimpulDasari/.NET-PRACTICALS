<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PR5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h1>Academic Calendar & Leave Management System</h1>

        <table>

            <tr>
                <td>
                    <asp:Calendar 
                        ID="Cal1" 
                        runat="server"
                        OnSelectionChanged="Cal1_SelectionChanged">
                    </asp:Calendar>
                </td>
            </tr>


            <tr>
                <td>

                    <asp:Label 
                        ID="lblSelectedDate" 
                        runat="server"
                        Text="Selected Date:">
                    </asp:Label>

                </td>
            </tr>


            <tr>
                <td>

                    <asp:TextBox 
                        ID="TextBox1" 
                        runat="server"
                        ReadOnly="true">
                    </asp:TextBox>

                </td>
            </tr>


            <tr>
                <td>

                    <asp:Button 
                        ID="btn1" 
                        runat="server"
                        Text="Apply Leave"
                        OnClick="btn1_Click" />

                </td>
            </tr>

        </table>

    </div>

</form>


</body>
</html>
