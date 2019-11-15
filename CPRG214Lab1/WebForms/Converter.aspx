<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Converter.aspx.cs" Inherits="WebForms_Converter" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="/css/StyleSheet.css"/>
</head>

<body>
    <form id="form1" runat="server">
        <header>
            <div>
                <h2>Temperatures Converter:</h2>
            </div>
        </header>

        <div class="column-layout">
            <div class="call-out pimg1">
                <%--<img src="smiley.gif" alt="Smiley face" height="42" width="42">--%>
                <img src="../img/thermo.jpg" />
            </div> 

             <div class="call-out">
                 <h3>Select of list temperatures to convert</h3>
                 From     
                 <asp:DropDownList ID="FromTmp" runat="server">
                <asp:ListItem Selected="True" Value="1">Celsius</asp:ListItem>
                <asp:ListItem Value="2">Fahrenheit</asp:ListItem>
                <asp:ListItem Value="3">Kelvin</asp:ListItem>
            </asp:DropDownList>
                 To
                 <asp:DropDownList ID="ToTmp" runat="server">
                <asp:ListItem Value="1">Celsius</asp:ListItem>
                <asp:ListItem Selected="True" Value="2">Fahrenheit</asp:ListItem>
                <asp:ListItem Value="3">Kelvin</asp:ListItem>
            </asp:DropDownList>

                 <p>Type a value in the field to convert between temperature</p>
                 <asp:TextBox ID="TxtValTmp" runat="server" ToolTip="Enter value" ValidateRequestMode="Enabled" MaxLength="5" CausesValidation="True">0</asp:TextBox>
                 <br />
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtValTmp" Display="Dynamic" ErrorMessage="Require a value to convert" ForeColor="Red" SetFocusOnError="True">Type a value to convert</asp:RequiredFieldValidator>
                 <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtValTmp" Display="Dynamic" ErrorMessage="This field is a range between -1000 and 1000 grades" ForeColor="Red" MaximumValue="1000" MinimumValue="-1000" SetFocusOnError="True" Type="Double"></asp:RangeValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtValTmp" ErrorMessage="It just acept numbers" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[-+]?\d*$"></asp:RegularExpressionValidator>
            
                 <div>
                        <asp:Button ID="BtnConvert" runat="server" Text="Convert" />
                        <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />
                 </div>
            </div>

             <div class="call-out">
                 
                 <h3>Output Temperature</h3>
                 
                 <p class="size">
                    <asp:Label ID="LblResult" runat="server" BorderColor="#FFFF66"></asp:Label>
                 </p>
             
             </div>

        </div>  
       
    </form>
</body>
</html>
