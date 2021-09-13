<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SampleDefault.aspx.cs" Inherits="SampleDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Label ID="lblDept" runat="server"></asp:Label>
        &nbsp;<br />
        </div>
        <asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="Get Data" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnGetEmployeesByDeparment" runat="server" OnClick="btnGetEmployeesByDeparment_Click" Text="Get Employees By Departement" />
    </form>
</body>
</html>
