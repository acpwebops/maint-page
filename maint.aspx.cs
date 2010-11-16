using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 * This page will display a "down for maintenance" message with appropriate 503 status.
 * 
 * This assumes that all traffic from ACP-hosted web sites is channeled to a single IIS server
 * which does not have any virtual hosting set up -- the default site will respond to all requests
 * for all hosts.
 * 
 * Set this page as the 404 handler and it should show the maint page at the requested URL with
 * the correct 503 status.
 * 
 * When updating page copy, remember to update Retry-After header below with expected end of 
 * maintenance window.
 * 
 */
public partial class Scripts_maint : System.Web.UI.Page
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        Response.AddHeader("Retry-After", "Wed, 17 Nov 2010 12:00:00 GMT");
        Response.StatusCode = 503;
        Response.StatusDescription = "Service Unavailable";
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}