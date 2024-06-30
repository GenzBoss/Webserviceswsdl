<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Solution3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Temperature Converter:</h4>

   <p> <asp:Label ID="Label1" runat="server" Text="Enter Temperature in Celcius:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Width="236px"></asp:TextBox>
    <span>Temp in fahrenheit--> <asp:Label ID="F" runat="server" Text=""></asp:Label></span>
    <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" /></p>

    <p><asp:Label ID="Label3" runat="server" Text="Enter Temperature in fahrenheit:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" Width="236px"></asp:TextBox>
    <span>Temp in Celcius--></span><asp:Label ID="C" runat="server" Text=""></asp:Label>
    <asp:Button ID="Button2" runat="server" Text="Convert" OnClick="Button2_Click" /></p>
    <br /> <br />

    <h4>Number Sorter:</h4>

    <br />

    <p><span>Enter Comma seperated Numbers:</span> <asp:TextBox ID="TextBox3" runat="server" Width="568px"></asp:TextBox>
        
         <asp:Button ID="Button3" runat="server" Text="Sort!" OnClick="Button3_Click" />
        
         <p>  Your Sorted Numbers are as follows--><asp:Label ID="sortednums" runat="server" Text=""></asp:Label> </p> </p> 



    

    

</asp:Content>
