using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DataAccess;
using Utility;
using System.IO;
using System.Net.Mail;

public partial class BigProductPage_ProductInquiry : System.Web.UI.Page
{
    protected Send_Email CSSendEmail = new Send_Email();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request["_PN"] != null)
            {
                txtProductName.Text = Request["_PN"].ToString();
            }
        }
    }

    public void clearfrom()
    {
        txtCustomer.Text = "";
        txtCity.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
        txtEmail.Text = "";
        txtInquiry.Text = "";
    }

    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        if (sendEmail(txtEmail.Text.Trim()) == true)
        {
            sendEmailInquiry(txtEmail.Text.Trim());
            lblStatus.Text = "Thank You for your inquiry!!!";
            clearfrom();
        }
        else
        {
            sendEmailInquiry(txtEmail.Text.Trim());
            lblStatus.Text = "Thank You for your inquiry!!!";
            clearfrom();
        }
    }

    private bool sendEmailInquiry(string strEmail)
    {
        bool blnReturn = true;
        try
        {
            string strContent = "";
            string strCCTo = "";
            string strBCTo = "";
            //strBCTo = cnn.get_All_DefaultAgentAdministrator(Session("CompanyId"));

            strContent = "<html><head><title>MNIndustries</title>";
            strContent = strContent + "<style type='text/css'><!--body {margin-left: 0px;margin-top: 0px;margin-right: 0px;margin-bottom: 0px;}a:link {color: #26a7e8;text-decoration:none;}a:visited {color: #26a7e8;text-decoration:none;}a:hover {color: #990000;text-decoration: underline;font-size:14px;}a:active {color: #26a7e8;text-decoration:none;}.style2 {font-size: 10px;font-weight: bold;}--></style>";
            strContent = strContent + "</head><body><table width='700' align='center' cellpadding='0' cellspacing='0' style='border: 2px solid #104f6e;'>";

            strContent = strContent + "<tr><td>";
            strContent = strContent + "<table width='700px'><tr><td align='left'><table width='700px'>";
            strContent = strContent + "<tr><td style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:normal; color:#000000; line-height:15px; padding-left:20px'>M.N.Industries<br />G-3, “PRATHAMESH”,<br />60 Feet Road, Opp. Jain Temple,Bhayandar (w),<br />Mumbai – 401101.<br />Tel: 022-65872018  Fax:022-28170881<br />Cell: 98672 77003 * 9224647254<br />email :- mnindustries@sify.com</td><td align='right'><h2>MNIndustries</h2></td></tr>";
            strContent = strContent + "</table></td></tr>";
            strContent = strContent + "<tr><td style='height:1px; background-color:Black;'></td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>Product Name : " + txtProductName.Text.Trim() + "</td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>Customer Name : " + txtCustomer.Text.Trim() + "</td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>City : " + txtCity.Text.Trim() + "</td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>Mobile : " + txtMobile.Text.Trim() + "</td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>Email : " + txtEmail.Text.Trim() + "</td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>Enquiry/Suggestion : " + txtInquiry.Text.Trim() + "</td></tr>";
            strContent = strContent + "<tr><td></td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>We will Revert back you soon!!</td></tr>";
            strContent = strContent + "<tr><td></td></tr>";
            strContent = strContent + "<tr><td style='height:1px; background-color:Black;'></td></tr>";
            strContent = strContent + "<tr><td align='left'><table width='700px' border='0' cellspacing='0' cellpadding='0'>";
            strContent = strContent + "<tr><td width='350px' height='46' valign='middle' class='footerlinks' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'><a href='http://mnindustries.net/Index.aspx'>Home</a> | <a href='http://mnindustries.net/CompanyProfile.aspx'>Company profile</a> | <a href='http://mnindustries.net/Product_MechanicalShaft.aspx'>Products</a> | <a href='http://mnindustries.net/ContactUs.aspx'>Contact Us</a></td><td width='350px' align='right' class='footerlinks' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>&copy; Copyright © 2010 M N Industries. All Rights Reserved</td></tr>";
            strContent = strContent + "</table></td></tr></table>";

            strContent = strContent + "</td></tr></table>";
            strContent = strContent + "</body></html>";

            //Sending Email
            sendMailNew("mnindustries@sify.com", "MNIndustries Inquiry !", strContent, strCCTo, strBCTo, strEmail);

            ViewState["Status"] = "EmailSent";
            blnReturn = true;
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message.ToString();
            blnReturn = false;
            ViewState["Status"] = "EmailNotSent";
            return blnReturn;
        }
        return blnReturn;
    }


    private bool sendEmail(string strEmail)
    {
        bool blnReturn = true;
        try
        {
            string strContent = "";
            string strCCTo = "";
            string strBCTo = "";
            //strBCTo = cnn.get_All_DefaultAgentAdministrator(Session("CompanyId"));

            strContent = "<html><head><title>Nutan Travels</title>";
            strContent = strContent + "<style type='text/css'><!--body {margin-left: 0px;margin-top: 0px;margin-right: 0px;margin-bottom: 0px;}a:link {color: #26a7e8;text-decoration:none;}a:visited {color: #26a7e8;text-decoration:none;}a:hover {color: #990000;text-decoration: underline;font-size:14px;}a:active {color: #26a7e8;text-decoration:none;}.style2 {font-size: 10px;font-weight: bold;}--></style>";
            strContent = strContent + "</head><body><table width='700' align='center' cellpadding='0' cellspacing='0' style='border: 2px solid #104f6e;'>";

            strContent = strContent + "<tr><td>";
            strContent = strContent + "<table width='700px'><tr><td align='left'><table width='700px'>";
            strContent = strContent + "<tr><td style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:normal; color:#000000; line-height:15px; padding-left:20px'>M.N.Industries<br />G-3, “PRATHAMESH”,<br />60 Feet Road, Opp. Jain Temple,Bhayandar (w),<br />Mumbai – 401101.<br />Tel: 022-65872018  Fax:022-28170881<br />Cell: 98672 77003 * 9224647254<br />email :- mnindustries@sify.com</td><td align='right'><h2>MNIndustries</h2></td></tr>";
            strContent = strContent + "</table></td></tr>";
            strContent = strContent + "<tr><td style='height:1px; background-color:Black;'></td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>Thank you for your inquiry..</td></tr>";
            strContent = strContent + "<tr><td></td></tr>";
            strContent = strContent + "<tr><td align='left' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>We will Revert back you soon!!</td></tr>";
            strContent = strContent + "<tr><td></td></tr>";
            strContent = strContent + "<tr><td style='height:1px; background-color:Black;'></td></tr>";
            strContent = strContent + "<tr><td align='left'><table width='700px' border='0' cellspacing='0' cellpadding='0'>";
            strContent = strContent + "<tr><td width='350px' height='46' valign='middle' class='footerlinks' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'><a href='http://mnindustries.net/Index.aspx'>Home</a> | <a href='http://mnindustries.net/CompanyProfile.aspx'>Company profile</a> | <a href='http://mnindustries.net/Product_MechanicalShaft.aspx'>Products</a> | <a href='http://mnindustries.net/ContactUs.aspx'>Contact Us</a></td><td width='350px' align='right' class='footerlinks' style='font-size:12px; font-style:normal; font-family: Arial, Helvetica, sans-serif;, Arial, Helvetica, sans-serif; font-weight:bold; color:#000000; line-height:15px; padding-left:20px'>&copy; Copyright © 2010 M N Industries. All Rights Reserved</td></tr>";
            strContent = strContent + "</table></td></tr></table>";

            strContent = strContent + "</td></tr></table>";
            strContent = strContent + "</body></html>";
            
            //Sending Email
            sendMailNew(strEmail, "MNIndustries Inquiry !", strContent, strCCTo, strBCTo, "mnindustries@sify.com");
            
            ViewState["Status"] = "EmailSent";
            blnReturn = true;
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message.ToString();
            blnReturn = false;
            ViewState["Status"] = "EmailNotSent";
            return blnReturn;
        }
        return blnReturn;
    }

    public bool sendMailNew(string strTo, string strSubject, string strBody, string strCCTo, string strBCCTo, string strFromEmail)
    {
        bool blnReturn = false;
        // Dim Mail As MailMessage = Nothing
        try
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(strTo);
            //mail.CC = strCCTo.ToString();
            //mail.Bcc = strBCCTo.ToString();
            mail.From = new MailAddress("MNIndustries" + "<" + strFromEmail + ">");
            mail.Body = strBody;
            mail.Subject = strSubject;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Credentials = new System.Net.NetworkCredential("industriesmn@gmail.com", "mnindustries");
            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);
            blnReturn = true;
        }
        catch (Exception ex)
        {
            throw new BadUserInputException(ex.Message.ToString());
        }
        return blnReturn;
    }

}
