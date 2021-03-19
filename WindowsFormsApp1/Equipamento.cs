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
    public partial class Equipamento : Form
    {
        public Equipamento()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            if(txtID.Text == "")
            {
                MessageBox.Show("ID é um campo obrigatório.");
                txtID.Focus();
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome é um campo obrigatório.");
                txtNome.Focus();
                return;
            }
            if (txtDataFabricacao.Text == "")
            {
                MessageBox.Show("Data de Fabricação é um campo obrigatório.");
                txtDataFabricacao.Focus();
                return;
            }
            if (txtNumeroSerie.Text == "")
            {
                MessageBox.Show("Nº de Série é um campo obrigatório.");
                txtNumeroSerie.Focus();
                return;
            }
            if (txtPreco.Text == "")
            {
                MessageBox.Show("Preço é um campo obrigatório.");
                txtPreco.Focus();
                return;
            }
            if (txtFabricante.Text == "")
            {
                MessageBox.Show("Fabricante é um campo obrigatório.");
                txtFabricante.Focus();
                return;
            }

            if (txtNome.TextLength < 6)
            {
                MessageBox.Show("O nome precisa ter no mínimo 6 letras.");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("insert into EQUIPAMENTO values (@ID, @Nome, @NumeroSerie, @DataFabricacao, @Fabricante, @Preco)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@NumeroSerie", int.Parse(txtNumeroSerie.Text));
                cmd.Parameters.AddWithValue("@DataFabricacao", DateTime.Parse(txtDataFabricacao.Text));
                cmd.Parameters.AddWithValue("@Fabricante", txtFabricante.Text);
                cmd.Parameters.AddWithValue("@Preco", double.Parse(txtPreco.Text));
                cmd.ExecuteNonQuery();
                txtID.Text = ("");
                txtNome.Text = ("");
                txtNumeroSerie.Text = ("");
                txtDataFabricacao.Text = ("");
                txtFabricante.Text = ("");
                txtPreco.Text = ("");
                con.Close();
                MessageBox.Show("Salvo com sucesso!");
            }

           
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("É necessário informar o ID para atualizar.");
                txtID.Focus();
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("É necessário informar o Nome para atualizar.");
                txtNome.Focus();
                return;
            }
            if (txtDataFabricacao.Text == "")
            {
                MessageBox.Show("É necessário informar a Data de Fabricação para atualizar.");
                txtDataFabricacao.Focus();
                return;
            }
            if (txtNumeroSerie.Text == "")
            {
                MessageBox.Show("É necessário informar o Nº de Série para atualizar.");
                txtNumeroSerie.Focus();
                return;
            }
            if (txtPreco.Text == "")
            {
                MessageBox.Show("É necessário informar o Preço para atualizar.");
                txtPreco.Focus();
                return;
            }
            if (txtFabricante.Text == "")
            {
                MessageBox.Show("É necessário informar o Fabricante para atualizar.");
                txtFabricante.Focus();
                return;
            }
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("update EQUIPAMENTO set Nome=@Nome, NumeroSerie=@NumeroSerie, DataFabricacao=@DataFabricacao, Fabricante=@Fabricante, Preco=@Preco where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@NumeroSerie", int.Parse(txtNumeroSerie.Text));
            cmd.Parameters.AddWithValue("@DataFabricacao", DateTime.Parse(txtDataFabricacao.Text));
            cmd.Parameters.AddWithValue("@Fabricante", txtFabricante.Text);
            cmd.Parameters.AddWithValue("@Preco", double.Parse(txtPreco.Text));
            cmd.ExecuteNonQuery();
            txtID.Text = ("");
            txtNome.Text = ("");
            txtNumeroSerie.Text = ("");
            txtDataFabricacao.Text = ("");
            txtFabricante.Text = ("");
            txtPreco.Text = ("");
            con.Close();
            MessageBox.Show("Alterado com sucesso!");
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("É necessário informar somente o ID para atualizar.");
                txtID.Focus();
                return;
            }
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("delete from EQUIPAMENTO where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.ExecuteNonQuery();
            txtID.Text = ("");
            con.Close();
            MessageBox.Show("Deletado com sucesso!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select ID, Nome, NumeroSerie, Fabricante from EQUIPAMENTO where ID = @ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(txtID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEquipamento.DataSource = dt;
            }
            catch
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select ID, Nome, NumeroSerie, Fabricante from EQUIPAMENTO", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEquipamento.DataSource = dt;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            try
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = bdcrud; Uid = root; Pwd = Dr4g000n;");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select ID, Nome, NumeroSerie, Fabricante from EQUIPAMENTO", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEquipamento.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chamadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado Equipamento = new Chamado();
            Equipamento.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

    }

}
