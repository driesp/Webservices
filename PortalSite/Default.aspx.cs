using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class _Default : Page
{
    public int count = 0;
    public string drawString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            createContent();
        }
        
    }
    protected void createContent()
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT name, url, permission FROM websites where permission >= "+Session["PermissionLevel"].ToString(), connection))
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        drawContent(dr["name"].ToString(), dr["url"].ToString(), dr["permission"].ToString());
                    }

                    dr.Close();
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            Response.Write("An error occured: " + ex.Message);
        }
    }
    protected void addContent(string name, string url, string permission)
    {

        //drawString += "<div class='col-md-3 panel-tall'><iframe class='frame' src='"+ url +"' width='100%' height='100%' scrolling='no'> < p >"+ name +"</ p ></ iframe > </div>";
        drawString += "<div class='col-md-3 panel-tall panel panel-info'><div class='panel-heading'>"+ name +"</div></div>";
        
        count++;
    }
    protected void drawContent(string name, string url, string permission)
    {
        HtmlButton button = new HtmlButton();
        HtmlIframe frame = new HtmlIframe();
        frame.Src = url;
        frame.InnerHtml = name;
        frame.Attributes["class"] = "col-md-3 panel-tall frame";
        frame.Attributes["width"] = "100%";
        frame.Attributes["heighth"] = "100%";
        frame.Attributes["scrolling"] = "no";

        button.Controls.Add(new LiteralControl("<div class='name' vertical-allign='middle'>" + name + "</div>"));
        button.Controls.Add(frame);
        
        button.Attributes["type"] = "button";
        button.Attributes["class"] = "btn btn-special";
        button.Attributes["onClick"] = "location.href='"+ url +"'";
        panelContent.Controls.Add(button);
    }
}

