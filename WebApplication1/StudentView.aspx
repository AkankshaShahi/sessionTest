<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="WebApplication1.StudentView" %>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Mainform.Master" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="WebApplication1.StudentView" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <%-- <script type="text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to delete data?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
</script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="border:double">
       
        <table>
            <tr>
                <td>
                    Search ID:
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
                <td>
                    Search By Name:
                </td>
                <td>
                     <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
                </tr>
            <tr>
                <td>
                    Search By Email ID:
                </td>
                <td>
                     <asp:TextBox ID="txtEID" runat="server"></asp:TextBox>
                </td>
                 <td>
                    Search By Contact number:
                </td>
                <td>
                     <asp:TextBox ID="txtcntnum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>
                    <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
                </td>
            </tr>
        </table>
           
    </div>
    <br />
    <div > <asp:Literal ID="ltrlerror" runat="server"></asp:Literal> <asp:Button ID="btnclose" runat="server" Text="X" BorderStyle="None" BackColor="WhiteSmoke" OnClick="btnclose_Click" /></div>
     <div>
         <b>Student Record</b>
        <asp:GridView ID="grdStudent" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" AllowPaging="true" PageSize="2" 
            RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" runat = "server"  
            AllowSorting="true" AutoGenerateColumns="false" OnPageIndexChanging="grdStudent_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="EmailID" HeaderText="Email ID" />
                <asp:BoundField DataField="ContactNum" HeaderText="Contact Number" />
                <asp:BoundField DataField="DOB" HeaderText="Date Of Birth" />
                <asp:BoundField DataField="Age" HeaderText="Age" />             
               <%-- <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/student.aspx?id={0}" Text="Edit"  HeaderImageUrl="~/images/edit.jpg" ControlStyle-CssClass="edit"/>
                 <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/StudentView.aspx?id1={0}" Text="Delete" HeaderImageUrl="~/images/delete.jpg" />--%>
                <asp:TemplateField HeaderImageUrl="~/images/edit.jpg">
                    <ItemTemplate >
                       <asp:LinkButton ID="lnkedit" Text="Edit" runat="server"   PostBackUrl= '<%#"~/student.aspx?id="+Eval("Id")%>'></asp:LinkButton>

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderImageUrl="~/images/delete.jpg" >
                    <ItemTemplate >
                         <asp:LinkButton ID="lnkdelete" Text="Delete" runat="server" OnClientClick="return confirm('Do you want to delete this record?');"  PostBackUrl= '<%#"~/StudentView.aspx?id1="+Eval("Id")%>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
             
            </Columns>
            <PagerSettings Mode="Numeric" Position="Bottom" Visible="true" />
        </asp:GridView>
    </div>


  
</asp:Content>
   
 