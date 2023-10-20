using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan10.Controller;
using MySqlConnector;

namespace TugasPertemuan10
{
    public partial class Form1 : Form
    {
       

        private Kereta kereta;
        private Stasiun stasiun;
        private Penumpang penumpang;
        private Kelas kelas;
       
        public Form1()
        {
           
            kereta = new Kereta();
            stasiun = new Stasiun();
            penumpang = new Penumpang();
            kelas = new Kelas();
            
            InitializeComponent();
        }

        public void tampilKereta()
        {
            dataGridView1.DataSource = kereta.tampilKereta();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tampilStasiun()
        {
            dataGridView1.DataSource = stasiun.tampilStasiun();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tampilPenumpang()
        {
            dataGridView1.DataSource = penumpang.tampilPenumpang();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tampilKelas()
        {
            dataGridView1.DataSource = kelas.tampilKelas();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPenumpang_Click(object sender, EventArgs e)
        {
            tampilPenumpang();
        }

        private void btnKereta_Click(object sender, EventArgs e)
        {
            tampilKereta();
        }

        private void btnStasiun_Click(object sender, EventArgs e)
        {
            tampilStasiun();
        }

        private void btnKelas_Click(object sender, EventArgs e)
        {
            tampilKelas();
        }
    }
}
