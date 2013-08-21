<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FootballSim.Draft.Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:GridView ID="grdPlayers" runat="server" AutoGenerateColumns="False" CellPadding="5" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" OnSorting="GrdPlayers_Sorting" PageSize="50" DataSourceID="odsPlayers" AllowSorting="True" ShowHeaderWhenEmpty="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="FullName" HeaderText="Name" ReadOnly="True" SortExpression="FullName" />
            <asp:BoundField DataField="Position" HeaderText="Position" ReadOnly="True" SortExpression="Position" />
            <asp:BoundField DataField="Caliber" HeaderText="Rating" SortExpression="Caliber" />
            <asp:BoundField DataField="College" HeaderText="College" ReadOnly="True" />
            <asp:BoundField DataField="BirthDateForDisplay" HeaderText="DOB" ReadOnly="True" />
            <asp:BoundField DataField="Hometown" HeaderText="Hometown" ReadOnly="True" />
            <asp:BoundField DataField="CurrentOverallRating" Visible="false" HeaderText="Rating" ReadOnly="True" SortExpression="CurrentOverallRating" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>   

    <asp:ObjectDataSource ID="odsPlayers" runat="server" 
        SelectMethod="GetPlayers" 
        TypeName="FootballSim.Draft.Default"
        SortParameterName="sortExpr">
    </asp:ObjectDataSource>

</asp:Content>
