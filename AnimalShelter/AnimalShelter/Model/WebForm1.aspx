<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AnimalShelter.Model.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
     <form id="form1" runat="server"> 
         <div> 
             <asp:GridView ID="GridView1" runat="server" CellPadding="4" Width="55%" ForeColor="#333333" GridLines="None" style="margin-top: 0px; text-align: left;">
                  <RowStyle BackColor="#F7F6F3" ForeColor="#333333" /> 
                  <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" /> 
                  <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" /> 
                  <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                  <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                  <EditRowStyle BackColor="#999999" />
                  <AlternatingRowStyle BackColor="White" ForeColor="#284775" /> 

             </asp:GridView> 

         </div>

            <table width="100px" border="1">
                        <th><asp:TextBox runat="server" ID="textID" value="" TextMode="SingleLine" ></asp:TextBox></th> 
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage=""
                             ControlToValidate="textID"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                             </asp:RegularExpressionValidator>

                        <th><asp:TextBox runat="server" ID="txtBreed" value="" TextMode="SingleLine" ></asp:TextBox> </th>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage=""
                             ControlToValidate="txtBreed"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                             </asp:RegularExpressionValidator>

                        <th><asp:TextBox runat="server" ID="weight" TextMode="SingleLine"></asp:TextBox></th>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage=""
                             ControlToValidate="weight"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                             </asp:RegularExpressionValidator>
                             
                        <th><asp:TextBox runat="server" ID="age" TextMode="SingleLine"></asp:TextBox></th>
                         <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="age"
                            ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{0,3}$" runat="server"
                            ErrorMessage="">
                         </asp:RegularExpressionValidator>
                            
                        
                       </table> 

                         <asp:Button runat="server" ID="button_Insert" Text="Insert" OnClick="Button_Insert" />
                         <asp:Button runat="server" ID="button_Update" Text="Update" OnClick="Button_Update" />
                         <asp:Button runat="server" ID="button_Delete" Text="Delete" OnClick="Button_Delete" />

             
        </form>        
    </body>
</html>

