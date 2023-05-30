using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication31.Models
{
    public class Repositary
    {
        public void AddCatagory(Catagory cat)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", cat.cid);
            cmd.Parameters.AddWithValue("@cname", cat.cname);

            cmd.ExecuteNonQuery();
            con.Close();



        }
        public List<Catagory> GetAllCatagory()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            List<Catagory> obj = new List<Catagory>();
            SqlCommand cmd = new SqlCommand("proc_view", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                obj.Add(new Catagory
                {
                    cid = Convert.ToInt32(dr["cid"]),
                    cname = Convert.ToString(dr["cname"])

                });


            }
            return obj;
        }
        public void UpdateCatagory(Catagory cat)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_update1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", cat.cid);
            cmd.Parameters.AddWithValue("@cname", cat.cname);

            cmd.ExecuteNonQuery();
            con.Close();



        }
        public void DeleteCatagory(int id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", id);

            cmd.ExecuteNonQuery();
            con.Close();



        }
        public void AddProduct(Product pat)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_padd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pat.pid);
            cmd.Parameters.AddWithValue("@pname", pat.pname);
            cmd.Parameters.AddWithValue("@cid", pat.cid);

            cmd.ExecuteNonQuery();
            con.Close();



        }
        public List<Product> GetAllProduct()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            List<Product> obj = new List<Product>();
            SqlCommand cmd = new SqlCommand("proc_pview1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                obj.Add(new Product
                {
                    pid = Convert.ToInt32(dr["pid"]),
                    pname = Convert.ToString(dr["pname"]),
                    cid = Convert.ToInt32(dr["cid"]),
                    cname = Convert.ToString(dr["cname"])

                });


            }
            return obj;
        }
        public void UpdateProduct(Product pat)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_pupdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pat.pid);
            cmd.Parameters.AddWithValue("@pname", pat.pname);
            cmd.Parameters.AddWithValue("@cid", pat.cid);

            cmd.ExecuteNonQuery();
            con.Close();



        }
        public void DeleteProduct(int id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ps"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_pdelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", id);

            cmd.ExecuteNonQuery();
            con.Close();



        }

    }
}