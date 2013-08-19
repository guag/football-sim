<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FootballSim.Draft.Default" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:GridView ID="GrdPlayers" runat="server" AutoGenerateColumns="False" CellPadding="5" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="GrdPlayers_PageIndexChanging" OnSorting="GrdPlayers_Sorting" PageSize="50">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="FullName" HeaderText="Name" ReadOnly="True" SortExpression="FullName" />
            <asp:BoundField DataField="Position.Name" HeaderText="Position" ReadOnly="True" SortExpression="Position.Name" />
            <asp:BoundField DataField="Caliber" HeaderText="Rating" ReadOnly="True" SortExpression="Rating" />
            <asp:BoundField DataField="Measurables.HeightForDisplay" HeaderText="Height" />
            <asp:BoundField DataField="Measurables.Weight" HeaderText="Weight" />
            <asp:BoundField DataField="College" HeaderText="College" />
            <asp:BoundField DataField="Hometown" HeaderText="Hometown" />
            <asp:BoundField DataField="BirthDateForDisplay" HeaderText="DOB" />
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

</asp:Content>
