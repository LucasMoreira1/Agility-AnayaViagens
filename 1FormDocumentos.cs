using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ANAYA_VIAGENS
{
    public partial class FormDocumentos : Form
    {
        public FormDocumentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRelatorioTransporte formRelatorioTransporte = new FormRelatorioTransporte();
            formRelatorioTransporte.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM CLIENTES";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);


            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = true;
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
