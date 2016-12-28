using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for dal
/// </summary>
public class dal
{
     SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    DataTable dt;
	public dal()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable select_country()
    {
        da = new SqlDataAdapter("select * from tblcountry",con);
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public DataTable select_state(bal b)
    {
        da = new SqlDataAdapter("select * from tblstate where refc_id=@id", con);
        da.SelectCommand.Parameters.AddWithValue("@id",b.refcountry_id);
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public void INSERT_COUNTRY(bal b)
    {
        con.Open();
        cmd = new SqlCommand("insert into tblcountry values(@cnm,@isactive)",con);
        cmd.Parameters.AddWithValue("@cnm",b.country_name);
        cmd.Parameters.AddWithValue("@isactive", b.isactivecountry);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void update_COUNTRY(bal b)
    {
        con.Open();
        cmd = new SqlCommand("update tblcountry set country_name=@cnm,isactive=@isactive where Id=@id", con);
        cmd.Parameters.AddWithValue("@cnm", b.country_name);
        cmd.Parameters.AddWithValue("@isactive", b.isactivecountry);
        cmd.Parameters.AddWithValue("@id", b.country_id); 
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void delete_COUNTRY(bal b)
    {
        con.Open();
        cmd = new SqlCommand("delete from tblcountry where Id=@id", con);
      
        cmd.Parameters.AddWithValue("@id", b.country_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}