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

            string date = DropDownList2.SelectedItem.Value;
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox status = (row.Cells[3].FindControl("CheckBox1") as CheckBox);
                int id = Convert.ToInt32(row.Cells[0].Text);
                Label st = (row.Cells[2].FindControl("Label1") as Label);
                TextBox sa = (row.Cells[4].FindControl("TextBox5") as TextBox);


            
                    if (status.Checked)
                    {
                        updaterow(id, "paid",sa.Text, date);
                    }
                    else
                    {
                        updaterow(id, "unpaid",sa.Text, date);
                    }
                

            }
            }
    
            
            private void updaterow(int id, String markstatus,String a,string date)
            {
           
            
                String mycon = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\aspnet-proj-20181214081609.mdf;Initial Catalog=aspnet-proj-20181214081609;Integrated Security=True";
                String updatedata = "Update Stud set Statuspay='" + markstatus + "',Datepay='"+a+"',Monthpay='"+date+"' where Id=" + id;
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
   