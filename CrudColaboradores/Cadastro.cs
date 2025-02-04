using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudColaboradores.Entidades;

namespace CrudColaboradores
{
    public partial class Cadastro : Form
    {

        public List<Colaborador> colaboradores = new List<Colaborador>();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string situacao = ObterRadioSelecionado(groupEstado);
            string categoria = ObterRadioSelecionado(groupCategoria);

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(situacao) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Colaborador novoColaborador = new Colaborador(nome,situacao,categoria);

            ColaboradoresManager.GetInstance().AdicionarColaborador(novoColaborador);

            colaboradores.Add(novoColaborador);

            MessageBox.Show("Cadastrado");

            ImprimirLista();

        }

        private void ImprimirLista()
        {
         
            foreach (var colaborador in colaboradores)
            {
                Console.WriteLine($"Codigo: {colaborador.Codigo}, Nome: {colaborador.Nome}, Situacao: {colaborador.Situacao}, Categoria: {colaborador.Categoria}, Data: {colaborador.DataCadastro}");
            }
        }

        private string ObterRadioSelecionado(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
        }
    }
}
