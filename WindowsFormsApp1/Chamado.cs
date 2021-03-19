using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1
{
    public partial class Chamado : Form
    {
        
        public Chamado()
        {
            InitializeComponent();
        }

        private void Chamado_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                string selectQuery = "SELECT * FROM equipamento";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    cBoxEquipamentos.Items.Add(reader.GetString("Nome"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            if (txtID1.Text == "")
            {
                MessageBox.Show("ID é um campo obrigatório.");
                txtID1.Focus();
                return;
            }
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Título é um campo obrigatório.");
                txtTitulo.Focus();
                return;
            }
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Descrição é um campo obrigatório.");
                txtDescricao.Focus();
                return;
            }
            if (cBoxEquipamentos.Text == "")
            {
                MessageBox.Show("Equipamentos é um campo obrigatório.");
                cBoxEquipamentos.Focus();
                return;
            }
            if (mskDataAbertura.Text == "")
            {
                MessageBox.Show("Data de Abertura é um campo obrigatório.");
                mskDataAbertura.Focus();
                return;
            }
            
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("insert into CHAMADO values (@ID, @Titulo, @Descricao, @Equipamento, @DataAbertura)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID1.Text));
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@Equipamento", cBoxEquipamentos.Text);
            cmd.Parameters.AddWithValue("@DataAbertura", DateTime.Parse (mskDataAbertura.Text));
            
            cmd.ExecuteNonQuery();
            txtID1.Text = ("");
            txtTitulo.Text = ("");
            txtDescricao.Text = ("");
            cBoxEquipamentos.Text = ("");
            mskDataAbertura.Text = ("");
            con.Close();
            MessageBox.Show("Salvo com sucesso!");
        }

        private void btnAtualizar1_Click(object sender, EventArgs e)
        {
            if (txtID1.Text == "")
            {
                MessageBox.Show("ID é um campo obrigatório.");
                txtID1.Focus();
                return;
            }
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Título é um campo obrigatório.");
                txtTitulo.Focus();
                return;
            }
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Descrição é um campo obrigatório.");
                txtDescricao.Focus();
                return;
            }
            if (cBoxEquipamentos.Text == "")
            {
                MessageBox.Show("Equipamentos é um campo obrigatório.");
                cBoxEquipamentos.Focus();
                return;
            }
            if (mskDataAbertura.Text == "")
            {
                MessageBox.Show("Data de Abertura é um campo obrigatório.");
                mskDataAbertura.Focus();
                return;
            }
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("update CHAMADO set Titulo=@Titulo, Descricao=@Descricao, DataAbertura=@DataAbertura where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID1.Text));
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@DataAbertura", DateTime.Parse(mskDataAbertura.Text));
            cmd.Parameters.AddWithValue("@Equipamento", cBoxEquipamentos.Text);
            cmd.ExecuteNonQuery();
            txtID1.Text = "";
            txtTitulo.Text = "";
            txtDescricao.Text = "";
            mskDataAbertura.Text = "";
            cBoxEquipamentos.Text = "";

            con.Close();
            MessageBox.Show("Alterado com sucesso!");
        }

        private void btnDeletar1_Click(object sender, EventArgs e)
        {
            if (txtID1.Text == "")
            {
                MessageBox.Show("É necessário informar somente o ID para atualizar.");
                txtID1.Focus();
                return;
            }
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("delete from CHAMADO where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID1.Text));
            cmd.ExecuteNonQuery();
            txtID1.Text = ("");
            con.Close();
            MessageBox.Show("Deletado com sucesso!");
        }

        private void btnPesquisar1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select ID, Titulo, Equipamento, DataAbertura, DATEDIFF(CURDATE(), DataAbertura) AS DiasAberto from CHAMADO where ID=ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(txtID1.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvChamado.DataSource = dt;
            }
            catch
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select ID, Titulo, Equipamento, DataAbertura, DATEDIFF(CURDATE(), DataAbertura) AS DiasAberto from CHAMADO", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvChamado.DataSource = dt;
            }
        }

        private void Chamado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }
    }
}
