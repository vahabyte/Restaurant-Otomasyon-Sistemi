using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Exa_restaurant
{
    internal class Fonksiyonlar
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string constr;

        public Fonksiyonlar()
        {
            constr = @"Data Source=DESKTOP-C7QRC56\BARTENDER;Initial Catalog=exarestaurant;Integrated Security=True";
            conn = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = conn;

        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query,constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {

            int cnt = 0;
            if(conn.State == ConnectionState.Closed) 
            {
                conn.Open();
            }
            
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            conn.Close();
            return cnt;


        }

        

    }
}
