using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Doctor_Finder_Windows_App
{
    class dbcontrol
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\hhk\source\repos\Doctor Finder Windows App\Doctor Finder Windows App\Databasenew.mdf;Integrated Security=True");
        SqlCommand cm;
        public SqlDataAdapter da;
        List<SqlParameter> Params = new List<SqlParameter>();
        public DataTable dt;
        public int recordcount;
        public string exception;
        public void query (string name)
        {
            recordcount = 0;
            exception = null;
            try
            {
                cn.Open();
                cm = new SqlCommand(name, cn);
                Params.ForEach(p => cm.Parameters.Add(p));
                Params.Clear();
                dt = new DataTable();
                da = new SqlDataAdapter();
                recordcount = da.Fill(dt);
            }
            catch (Exception e)
            {

               exception = "Problem : "+ e.Message;

            }
            finally
            {
                if(cn.State==ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    public void Param (string name , object value)
        {
            SqlParameter newparam = new SqlParameter(name, value);
            Params.Add(newparam);
        }
        public bool Check4Error(bool err = false)
        {
            if (string.IsNullOrEmpty(exception))
            {
                return false;
            }
            if (err==true)
            {
                MessageBox.Show(exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
            }
}
