using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan10.Controller
{
    internal class Kelas:Model.Connection
    {
        public DataTable tampilKelas()
        {
            DataTable data = new DataTable();

            try
            {
                string tampil = "select * from kelas";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

    }
}
