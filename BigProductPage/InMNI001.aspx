<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InMNI001.aspx.cs" Inherits="BigProductPage_InMNI001" %>
<html>
<head>
<title>index</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../mni.css" rel="stylesheet" type="text/css" />
<style type="text/css">
<!--

-->
</style></head>
<body>
<form id="form1" runat="server">
<table class="brdr" align="center" width="466" border="0" cellspacing="0" cellpadding="0">
  <tr>
  <td align="center" class="titletext" style="background-color:#CCC; height:25px;">MNI001</td>
  </tr>
  <tr>
    <td>
    
    
    <table style="padding:2px;" width="466" border="1" cellspacing="0" cellpadding="0" align="center">
  <tr class="text">
    <td valign="top" colspan="2" height="61">
      <div align="center"><img src="images/MNI001_big.jpg" width="337" height="257" /></div>
    </td>
  </tr>
  <tr class="text"> 
    <td height="51" colspan="2" valign="top" class="bodytext">These type of seals are widely used 
      in water pumps as well as oil pumps &amp;<br>
      in generators. The seal face Combination are carbon vs ceramic, Tc etc.rubber 
      parts are available in various elastomers like buna-v, Viton,Neoprene etc 
      depending on application.</td>
  </tr>
  <tr class="text"> 
    <td valign="top" width="27%" height="39"><b class="bodytext">Features</b></td>
    <td width="73%" height="39" align="left"> 
      <ul>
        <li class="bodytext">Single Acting </li>
        <li class="bodytext">Independent Direction Of Rotation</li>
        <li class="bodytext">Internal mounting</li>
      </ul>
    </td>
  </tr>
  <tr class="text"> 
    <td valign="top" width="27%"><b class="bodytext">Seal Faces:-</b></td>

    <td width="73%" class="bodytext"><b>Stationery </b>:-Ceramic,Silicon Carbide,Carbon,Tungsten 
      Carbide Etc.<br>
      <b>Rotary </b>:- Carbon,Tungsten Carbide,Silicon Carbide,S.S,Stellite Etc</td>
  </tr>
  <tr class="text"> 
    <td valign="top" width="27%"><b class="bodytext">Operating Limits</b></td>
    <td width="73%" class="bodytext"><b>Pressure </b>:-10 Bar<br>
        <b>Temperature </b>:- 200 DEG C</td>
  </tr>
</table>
</td>
  </tr>
  <%--<tr>
  <td align="center"><asp:Button ID="btninquiry" runat="server" Text="Click Here for Product Inquiry" /></td>
  </tr>--%>
</table>
<table cellpadding="2" width="100%" cellspacing="2" border="0">
<tr>
<td align="center"><asp:Button PostBackUrl="ProductInquiry.aspx?_PN=MNI001" ID="btninquiry" runat="server" Text="Click Here for Product Inquiry" OnClick="btninquiry_Click"  /></td>
</tr>
</table>
</form>
</body>
</html>