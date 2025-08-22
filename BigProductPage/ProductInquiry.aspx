<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductInquiry.aspx.cs" Inherits="BigProductPage_ProductInquiry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../mni.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>
    <td align="center"><img src="images/images.jpg" /></td>
    </tr>
    <tr>
    <td align="center" class="temp"><asp:Label ID="lblStatus" runat="server" CssClass="bodytextbold" ForeColor="Red"></asp:Label></td>
    </tr>
    <tr>
    <td style="height:10px;"></td>
    </tr>
    </table>
    <table class="brdr" align="center" width="500" border="1" cellspacing="0" cellpadding="0">
  <tr>
  <td align="center" class="titletext" style="background-color:#CCC; height:35px;">Inquiry</td>
  </tr>
  <%--<tr>
  <td style="height:3px;"></td>
  </tr>--%>
  <tr>
    <td align="center">
    <table style="padding:2px;"  width="500" border="0" cellspacing="1" cellpadding="1" align="center">
  <tr>
  <td style="width:250px;"></td>
  <td style="width:250px;"></td>
  </tr>
  <tr>
  <td align="right" class="bodytext">Product Name :</td>
  <td align="left"><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr>
  <td></td>
  <td align="left">
      <asp:RequiredFieldValidator CssClass="bodytext" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductName"
          ErrorMessage="Cannot be blank"></asp:RequiredFieldValidator></td>
  </tr>
  <tr>
  <td align="right" class="bodytext">Customer Name :</td>
  <td align="left"><asp:TextBox ID="txtCustomer" runat="server"></asp:TextBox>&nbsp;
  </td>
  </tr>
  <tr>
  <td></td>
  <td align="left">
  <asp:RequiredFieldValidator CssClass="bodytext" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCustomer"
          ErrorMessage="Cannot be blank"></asp:RequiredFieldValidator></td>
  </tr>
  <tr>
  <td align="right" class="bodytext">City :</td>
  <td align="left"><asp:TextBox ID="txtCity" runat="server"></asp:TextBox>&nbsp;
  </td>
  </tr>
  <tr>
  <td></td>
  <td align="left">
  <asp:RequiredFieldValidator CssClass="bodytext" ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCity"
          ErrorMessage="Cannot be blank"></asp:RequiredFieldValidator></td>
  </tr>
  <tr>
  <td align="right" class="bodytext">Mobile :</td>
  <td align="left"><asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>&nbsp;
  </td>
  </tr>
  <tr>
  <td></td>
  <td align="left">
  <asp:RequiredFieldValidator 
  CssClass="bodytext" 
  ID="RequiredFieldValidator4" 
  runat="server" 
  ControlToValidate="txtMobile"
  ErrorMessage="Cannot be blank"></asp:RequiredFieldValidator></td>
  </tr>
  <tr>
  <td align="right" class="bodytext">Email :</td>
  <td align="left"><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
  </tr>
  <tr>
  <td></td>
  <td align="left"><asp:RegularExpressionValidator id="valRegEx" runat="server"
    CssClass="bodytext" 
    ControlToValidate="txtEmail"
    ValidationExpression=".*@.*\..*"
    ErrorMessage="InValid e-mail address.">
</asp:RegularExpressionValidator></td>
  </tr>
  <tr>
  <td align="right" class="bodytext" valign="top">Enquiry / Suggestion :</td>
  <td align="left"><asp:TextBox TextMode="MultiLine" ID="txtInquiry" runat="server"></asp:TextBox></td>
  </tr>
  <tr>
  <td colspan="2" align="center"><asp:Button ID="cmdSubmit" runat="server" Text="Submit" OnClick="cmdSubmit_Click" /></td>
  </tr>
</table>
</td>
  </tr>
  <%--<tr>
  <td align="center"><asp:Button ID="btninquiry" runat="server" Text="Click Here for Product Inquiry" /></td>
  </tr>--%>
</table>
    </div>
    </form>
</body>
</html>
