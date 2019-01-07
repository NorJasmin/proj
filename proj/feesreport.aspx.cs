using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.DataVisualization.Charting;

namespace proj
{
    public partial class feesreport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (!IsPostBack)
                {
                    PopulateReport();
                }
            }

        
    private void PopulateReport()
    {
        using (Model1 dc = new Model1())
        {
            var v = dc.Studs.ToList();


            GridView1.DataSource = v;
            GridView1.DataBind();

            Chart1.DataBind();
        }
    }
}


}