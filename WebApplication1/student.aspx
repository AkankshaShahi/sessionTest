<%-- <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="WebApplication1.student" %>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Mainform.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="WebApplication1.student" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%--<!DOCTYPE html>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="scriptManager1" runat="server"></asp:ScriptManager>
       <div > <asp:Literal ID="ltrlerror" runat="server"></asp:Literal> <asp:Button ID="btnclose" runat="server" Text="X" BorderStyle="None" BackColor="WhiteSmoke" OnClick="btnclose_Click" /></div>
    <div>
       <%--  <asp:Literal ID="ltrlerror" runat="server"></asp:Literal>--%>
        <div style="align-items:center;font:italic,large">Student Record Entry:</div>
        <table>
            <tr>
                <td colspan="25">Name:
                </td>
                <td colspan="25">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td colspan="25">
                    <asp:RequiredFieldValidator ID="reqname" runat="server" ControlToValidate="txtName" ErrorMessage="*" ForeColor="Red" ValidationGroup="valid"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rename" runat="server" ControlToValidate="txtName" ForeColor="Red" ErrorMessage="Only Letters" ValidationExpression="^[a-zA-Z ]+$" ValidationGroup="valid"></asp:RegularExpressionValidator>
                </td>

            </tr>
            <tr>
                <td colspan="25">Age:
                </td>
                <td colspan="25">
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
                <td colspan="25">
                     <asp:RequiredFieldValidator ID="rqawe" runat="server" ControlToValidate="txtAge" ErrorMessage="*" ForeColor="Red" ValidationGroup="valid"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ID="reAge" runat="server" ControlToValidate="txtAge" ErrorMessage="Only Numbers" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="valid"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="25">Gender:
                </td>
                <td colspan="25">
                    <asp:RadioButton ID="rdMale" runat="server" GroupName="grpgender" Text="Male"  Checked="true"/>
                    <asp:RadioButton ID="rdFemale" runat="server" GroupName="grpgender" Text="Female" />
                </td>
                <td colspan="25">
                     
                </td>
            </tr>
            <tr>
                <td colspan="25">Address:
                </td>
                <td colspan="25">
                    <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td colspan="25">
                      <asp:RequiredFieldValidator ID="rqAddress" runat="server" ControlToValidate="txtaddress" ErrorMessage="*" ForeColor="Red" ValidationGroup="valid"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="25">Email:
                </td>
                <td colspan="25">
                    <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                </td>
                <td colspan="25">
                       <asp:RequiredFieldValidator ID="rqemail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="Red" ValidationGroup="valid"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ID="reemail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is not in correct Format " ForeColor="Red" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" ValidationGroup="valid"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="25">DOB:
                </td>
                <td colspan="25">
                    <asp:TextBox ID="clddate" runat="server" ></asp:TextBox>
                    <asp:CalendarExtender ID="txtdate" runat="server" TargetControlID="clddate"></asp:CalendarExtender>

                </td>
                <td colspan="25">
                    <asp:RequiredFieldValidator ID="rqDOB" runat="server" ControlToValidate="clddate" ErrorMessage="*" ForeColor="Red" ValidationGroup="valid"></asp:RequiredFieldValidator>
                </td>
            </tr>
              <tr>
                <td colspan="25">Contact Number:
                </td>
                <td colspan="25">
                    <asp:TextBox ID="txtcntnum" runat="server" ></asp:TextBox>

                </td>
                <td colspan="25">
                      <asp:RequiredFieldValidator ID="rqcntnum" runat="server" ControlToValidate="txtcntnum" ErrorMessage="*" ForeColor="Red" ValidationGroup="valid"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ID="recntnum" runat="server" ControlToValidate="txtcntnum" ErrorMessage="Only Numbers with 10 digits" ForeColor="Red" ValidationExpression="[0-9]{10}" ValidationGroup="valid"></asp:RegularExpressionValidator>
                </td>
            </tr>
              <tr>
                <td colspan="25">
                </td>
                <td colspan="25">
                   <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" ValidationGroup="valid" />

                </td>
                <td colspan="25"></td>
            </tr>
        </table>
    
    </div>
</asp:Content>
<%--<html xmlns="">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
       
  <%--  </form>
</body>
</html>--%>
