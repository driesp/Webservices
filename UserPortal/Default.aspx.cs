using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MainPanel.BorderWidth = 20;
        MainPanel.BorderColor = System.Drawing.Color.Transparent;
        Panel panelContent = new Panel();
        panelContent.Visible = true;
        panelContent.Height = 200;
        panelContent.CssClass = "btn btn-danger col-md-4";

        Label simplelabel = new Label();
        simplelabel.Text = "test label";
        panelContent.Controls.Add(simplelabel);

        MainPanel.Controls.Add(panelContent);
    }
}