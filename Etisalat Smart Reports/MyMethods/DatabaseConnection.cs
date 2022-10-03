using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etisalat_Smart_Reports.MyMethods
{
    public class DatabaseConnection
    {
        //connect to database
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ETIS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //read data from database
        public DataTable ReadData(string statement, string msg)
        {
            DataTable tbl = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = statement;
                conn.Open();
                //load data from database to datatable
                tbl.Load(cmd.ExecuteReader());
                conn.Close();
                if (msg != "")
                {
                    MyMessageBox.Show(msg, "DONE", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.accept);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message + "", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.error);
            }
            return tbl;
        }

        //insert, update and delete
        public bool ExecuteData(string statement, string msg)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = statement;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (msg != "")
                {
                    MyMessageBox.Show(msg, "DONE", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.accept);
                }
                return true;

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message + "", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.error);
            }
            return false;
        }
    }
}
