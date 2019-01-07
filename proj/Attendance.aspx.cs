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
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string date = TextBox1.Text;
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox status = (row.Cells[3].FindControl("CheckBox1") as CheckBox);
                int id = Convert.ToInt32(row.Cells[0].Text);
                string fees;
                DropDownList stat = (row.Cells[4].FindControl("DropDownList1") as DropDownList);

                if (stat.SelectedValue == "15")
                {
                    fees = "203";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }
                else if (stat.SelectedValue == "None")
                {
                    fees = "200";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }
                else if (stat.SelectedValue == "30")
                {
                    fees = "206";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }
                else if (stat.SelectedValue == "45")
                {
                    fees = "209";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }
                else if (stat.SelectedValue == "60")
                {
                    fees = "212";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }
                else if (stat.SelectedValue == "75")
                {
                    fees = "215";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }
                else if (stat.SelectedValue == "90")
                {
                    fees = "218";
                    if (status.Checked)
                    {
                        updaterow(id, "attend", date, fees, stat.SelectedItem.Text);
                    }
                    else
                    {
                        updaterow(id, "absent", date, fees, stat.SelectedItem.Text);
                    }
                }

            }
        }

    
        private void updaterow(int id, String markstatus,String date,string fees,String a)
        {
            String mycon = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\aspnet-proj-20181214081609.mdf;Initial Catalog=aspnet-proj-20181214081609;Integrated Security=True";
            String updatedata = "Update Stud set StatusAttend='" + markstatus + "',DateAttend='"+date+"',TotalFees='"+fees+"',Overmin='"+a+"' where Id=" + id;
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label4.Text = "Data Has Been Saved Successfully";
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
       