using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace proj
{
    public partial class Fees : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox status = (row.Cells[3].FindControl("CheckBox1") as CheckBox);
                int id = Convert.ToInt32(row.Cells[0].Text);
                DropDownList stat = (row.Cells[2].FindControl("DropDownList3") as DropDownList);
                Label st = (row.Cells[1].FindControl("Label1") as Label);
                decimal fees = Convert.ToDecimal(row.Cells[1].Text);
                if (status.Checked)
                {
                    updaterow(id, "paid", stat.SelectedItem.Text,fees);
                }
                else
                {
                    updaterow(id, "unpaid", stat.SelectedItem.Text,fees);

                }

                if(stat.SelectedValue=="15")
                {
                    this.Label1.Text = (fees+3).ToString();

                }
                else if(stat.SelectedValue=="30")
                {
                    this.Label1.Text = (fees + 3).ToString();
                }


            }
        }
    
            
            private void updaterow(int id, String markstatus,String markstat,decimal fees)
            {
           
            
                String mycon = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\aspnet-proj-20181214081609.mdf;Initial Catalog=aspnet-proj-20181214081609;Integrated Security=True";
                String updatedata = "Update Stud set Statuspay='" + markstatus + "', Overmin='"+markstat+"',TotalFees='"+fees+"' where Id=" + id;
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label2.Text = "Data Has Been Saved Successfully";
            }
        
    }
}
   