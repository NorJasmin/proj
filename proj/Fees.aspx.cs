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
                Label st = (row.Cells[2].FindControl("Label1") as Label);
                string fees = Convert.ToString(row.Cells[2].Text);
                TextBox sa = (row.Cells[4].FindControl("TextBox1") as TextBox);
                string a = Convert.ToString(row.Cells[4].Text);
               // string b = (row.Cells[2].Text);


                if (stat.SelectedValue == "15")
                {
                    st.Text = (200 + 3).ToString();
                    fees = "203";
                    if (status.Checked)
                    {
                        updaterow(id, "paid", stat.SelectedItem.Text, fees,a);
                    }
                    else
                    {
                        updaterow(id, "unpaid", stat.SelectedItem.Text, fees, a);
                    }
                }
                else if (stat.SelectedValue == "30")
                {
                    st.Text = (200 + 6).ToString();
                    fees = "206";
                    if (status.Checked)
                    {
                        updaterow(id, "paid", stat.SelectedItem.Text, fees,a);
                    }
                    else
                    {
                        updaterow(id, "unpaid", stat.SelectedItem.Text, fees, a);
                    }
                }
                else if (stat.SelectedValue == "45")
                {
                    st.Text = (200 + 9).ToString();
                    fees = "209";
                    if (status.Checked)
                    {
                        updaterow(id, "paid", stat.SelectedItem.Text, fees, a);
                    }
                    else
                    {
                        updaterow(id, "unpaid", stat.SelectedItem.Text, fees, a);
                    }
                }
                else if (stat.SelectedValue == "60")
                {
                    st.Text = (200 + 12).ToString();
                    fees = "212";
                    if (status.Checked)
                    {
                        updaterow(id, "paid", stat.SelectedItem.Text, fees, a);
                    }
                    else
                    {
                        updaterow(id, "unpaid", stat.SelectedItem.Text, fees, a);
                    }
                }
                else if (stat.SelectedValue == "75")
                {
                    st.Text = (200 + 15).ToString();
                    fees = "215";
                    if (status.Checked)
                    {
                        updaterow(id, "paid", stat.SelectedItem.Text, fees, a);
                    }
                    else
                    {
                        updaterow(id, "unpaid", stat.SelectedItem.Text, fees, a);
                    }
                }

            }
            }
    
            
            private void updaterow(int id, String markstatus,String markstat,string fees,String a)
            {
           
            
                String mycon = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\aspnet-proj-20181214081609.mdf;Initial Catalog=aspnet-proj-20181214081609;Integrated Security=True";
                String updatedata = "Update Stud set Statuspay='" + markstatus + "', Overmin='"+markstat+"',TotalFees='"+fees+"',Datepay='"+a+"' where Id=" + id;
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
   