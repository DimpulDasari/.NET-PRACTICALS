<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="PR_4.reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Event Registration</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        .container {
            width: 750px;
            margin: 30px auto;
            background-color: white;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        h1 {
            text-align: center;
            color: #333;
        }

        table {
            width: 100%;
        }

        td {
            padding: 8px;
        }

        .label {
            font-weight: bold;
        }

        .textbox {
            width: 250px;
            padding: 6px;
        }

        .button {
            padding: 10px 25px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .banner {
            width: 454px;
            height: 350px;
            object-fit: fill;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <h1>Online Event Registration Portal</h1>
            <asp:ValidationSummary
                ID="ValidationSummary1"
                runat="server"
                ForeColor="Red"
                HeaderText="Please correct the following errors:" />
            <table>
                <tr>
                    <td class="label">Enter Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"
                            CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RqrName"
                            runat="server"
                            ControlToValidate="txtName"
                            ErrorMessage="Name is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Enter Gr.no:</td>
                    <td>
                        <asp:TextBox ID="txtGrno" runat="server"
                            CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredGrno"
                            runat="server"
                            ControlToValidate="txtGrno"
                            ErrorMessage="GR Number is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Enter Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"
                            CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredEmail"
                            runat="server"
                            ControlToValidate="txtEmail"
                            ErrorMessage="Email is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator
                            ID="EmailValidator"
                            runat="server"
                            ControlToValidate="txtEmail"
                            ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
                            ErrorMessage="Enter a valid email"
                            ForeColor="Red">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Enter Age:</td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"
                            CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredAge"
                            runat="server"
                            ControlToValidate="txtAge"
                            ErrorMessage="Age is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator
                            ID="AgeValidator"
                            runat="server"
                            ControlToValidate="txtAge"
                            MinimumValue="18"
                            MaximumValue="60"
                            Type="Integer"
                            ErrorMessage="Age must be between 18 and 60"
                            ForeColor="Red">
                        </asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Enter Password:</td>
                    <td>
                        <asp:TextBox
                            ID="txtpass"
                            runat="server"
                            TextMode="Password"
                            CssClass="textbox">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredPassword"
                            runat="server"
                            ControlToValidate="txtpass"
                            ErrorMessage="Password is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Confirm Password:</td>
                    <td>
                        <asp:TextBox
                            ID="txtcnfpass"
                            runat="server"
                            TextMode="Password"
                            CssClass="textbox">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredConfirmPassword"
                            runat="server"
                            ControlToValidate="txtcnfpass"
                            ErrorMessage="Confirm Password is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator
                            ID="ComparePassword"
                            runat="server"
                            ControlToValidate="txtcnfpass"
                            ControlToCompare="txtpass"
                            ErrorMessage="Passwords do not match"
                            ForeColor="Red">
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Gender:</td>
                    <td>
                        <asp:RadioButton ID="rbMale" runat="server" Text="Male"
                            GroupName="Gender" />
                        &nbsp;&nbsp;
                        <asp:RadioButton ID="rbFemale" runat="server" Text="Female"
                            GroupName="Gender" />
                    </td>
                </tr>
                <tr>
                    <td class="label">Select Branch:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="-- Select Branch --"
                                Value=""></asp:ListItem>
                            <asp:ListItem>CE</asp:ListItem>
                            <asp:ListItem>CSE</asp:ListItem>
                            <asp:ListItem>CSE-AI</asp:ListItem>
                            <asp:ListItem>CSE-AI/ML</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="BranchValidator"
                            runat="server"
                            ControlToValidate="DropDownList1"
                            InitialValue=""
                            ErrorMessage="Please select a branch"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label">Select Event:</td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Poster
Presentation" />
                        <br />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Paper
Presentation" />
                    </td>
                </tr>
                <tr>
                    <td class="label">Select Event Date:</td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="label">Banner:</td>
                    <td>
                        <asp:Image
                            ID="imgBanner"
                            runat="server"
                            ImageUrl="images.jpg"
                            CssClass="banner"
                            AlternateText="Event Banner" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center;">
                        <asp:Button
                            ID="btnRegister"
                            runat="server"
                            Text="Register"
                            CssClass="button"
                            OnClick="btnRegister_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center;">
                        <asp:Label
                            ID="lblMessage"
                            runat="server"
                            ForeColor="Green">
                        </asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
