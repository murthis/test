using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CRUD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Save(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("DefaultConnection");
            SqlCommand cmd = new SqlCommand("pc_AddEditAddress", con);
            cmd.Parameters.AddWithValue("@PersonName", txt_Name);
            cmd.Parameters.AddWithValue("@ContactNumber", txt_No);
            cmd.Parameters.AddWithValue("@AddressLine", txt_Add);
            cmd.Parameters.AddWithValue("@CityID", txt_City);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand.ExecuteNonQuery();
         
        }

        protected void Button1_Search(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("DefaultConnection");
            SqlCommand cmd = new SqlCommand("pc_ViewAddress", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.Enabled = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Delete(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection("DefaultConnection");
            SqlCommand cmd = new SqlCommand("pc_DeleteAddress", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand.ExecuteNonQuery();
        }
    }
}