using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Client.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            var myConnection = new CrmConnection("Xrm");
            using (var myService = new OrganizationService(myConnection))
            using (var myContext = new Xrm.XRMServiceContext(myService))
            {
                var accounts = myContext.bro_managetemplateSet.ToList();
            }
        }

    }
}
