using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices.AccountManagement;

public partial class Contact : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null)
        {
            Response.Redirect("default.aspx");
        }

    }
    public void login_click(object sender, EventArgs e)
    {
        using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "DSPAUTOMATION.be","dummy.viewer", "vpJSqS5aLPTFGvw3fyCsKBh4"))
        {
            bool isValid = pc.ValidateCredentials(UserName.Text, Password.Text);
            if(isValid)
            {
                UserPrincipal up = UserPrincipal.FindByIdentity(pc, UserName.Text);
                PrincipalSearchResult<Principal> Groups;
                List<string> GroupsStringList = new List<string>();
                int permissionLevel = 2;

                Groups = up.GetGroups();
                foreach(Principal group in Groups)
                {
                    GroupsStringList.Add(group.Name);
                    if(group.Name == "Domain Admins")
                    {
                        permissionLevel = 1;
                    }
                }
                 
                Session["Groups"] = GroupsStringList;
                Session["PermissionLevel"] = permissionLevel;
                Session["LoggedIn"] = true;
                Session["userName"] = UserName.Text;
                Response.Redirect("default.aspx");

            }
            else
            {
                message.Visible = true;
            }
        }

    }
}