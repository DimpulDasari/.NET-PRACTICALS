<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="PR5.Leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>

<body>


<form id="form1" runat="server">

    <div>

        <h1>Leave Application</h1>

        <table>

           

            <tr>
                <td>

                    <asp:Label 
                        ID="en" 
                        runat="server"
                        Text="Employee Name:">
                    </asp:Label>

                </td>

                <td>

                    <asp:TextBox 
                        ID="txt1" 
                        runat="server">
                    </asp:TextBox>

                </td>
            </tr>


            

            <tr>
                <td>

                    <asp:Label 
                        ID="ld" 
                        runat="server"
                        Text="Leave Date:">
                    </asp:Label>

                </td>

                <td>

                    <asp:TextBox 
                        ID="txt2" 
                        runat="server"
                        ReadOnly="true">
                    </asp:TextBox>

                </td>
            </tr>



            <tr>
                <td>

                    <asp:Label 
                        ID="lt" 
                        runat="server"
                        Text="Leave Type:">
                    </asp:Label>

                </td>

                <td>

                    <asp:DropDownList 
                        ID="d1" 
                        runat="server">

                        <asp:ListItem 
                            Text="Select Leave Type"
                            Value="">
                        </asp:ListItem>

                        <asp:ListItem 
                            Text="Cough Leave"
                            Value="Cough Leave">
                        </asp:ListItem>

                        <asp:ListItem 
                            Text="Occasion Leave"
                            Value="Occasion Leave">
                        </asp:ListItem>

                        <asp:ListItem 
                            Text="Fever Leave"
                            Value="Fever Leave">
                        </asp:ListItem>

                        <asp:ListItem 
                            Text="Emergency Leave"
                            Value="Emergency Leave">
                        </asp:ListItem>

                    </asp:DropDownList>

                </td>
            </tr>


            <tr>
                <td>

                    <asp:Label 
                        ID="r" 
                        runat="server"
                        Text="Reason:">
                    </asp:Label>

                </td>

                <td>

                    <asp:TextBox 
                        ID="TextArea1" 
                        runat="server"
                        TextMode="MultiLine"
                        Rows="3"
                        Columns="30">
                    </asp:TextBox>

                </td>
            </tr>


         

            <tr>
                <td>

                    <asp:Label 
                        ID="load" 
                        runat="server"
                        Text="Load Adjusted With:">
                    </asp:Label>

                </td>

                <td>

                    <asp:TextBox 
                        ID="txt3" 
                        runat="server">
                    </asp:TextBox>

                </td>
            </tr>


            <tr>
                <td colspan="2">

                    <asp:Button 
                        ID="btn2" 
                        runat="server"
                        Text="Submit Leave Application"
                        OnClick="btn2_Click" />

                </td>
            </tr>



            <tr>
                <td colspan="2">

                    <asp:Button 
                        ID="btnLogout" 
                        runat="server"
                        Text="Logout"
                        OnClick="btnLogout_Click" />

                </td>
            </tr>

        </table>


        <br />



        <asp:Panel 
            ID="pnlResult" 
            runat="server"
            Visible="false">

            <h2>

                <asp:Label 
                    ID="lblMessage" 
                    runat="server">
                </asp:Label>

            </h2>


            <p>

                <b>Employee Name:</b>

                <asp:Label 
                    ID="lblEmployee" 
                    runat="server">
                </asp:Label>

            </p>


            <p>

                <b>Leave Date:</b>

                <asp:Label 
                    ID="lblDate" 
                    runat="server">
                </asp:Label>

            </p>


            <p>

                <b>Leave Type:</b>

                <asp:Label 
                    ID="lblLeaveType" 
                    runat="server">
                </asp:Label>

            </p>


            <p>

                <b>Reason:</b>

                <asp:Label 
                    ID="lblReason" 
                    runat="server">
                </asp:Label>

            </p>


            <p>

                <b>Load Adjusted With:</b>

                <asp:Label 
                    ID="lblLoad" 
                    runat="server">
                </asp:Label>

            </p>

        </asp:Panel>

    </div>

</form>
```

</body>
</html>
