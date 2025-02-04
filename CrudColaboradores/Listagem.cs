using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudColaboradores.Entidades;

namespace CrudColaboradores
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listagem_Load(object sender, EventArgs e)
        {
            var colaboradores = ColaboradoresManager.GetInstance().colaboradores;


            dataColaboradores.Rows.Clear();

            foreach (var colaborador in colaboradores)
            {

                dataColaboradores.Rows.Add(colaborador.Codigo, colaborador.Categoria, colaborador.Situacao);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomePesquisa = txtNomePesquisa.Text;
            if (string.IsNullOrEmpty(nomePesquisa))
            {
                MessageBox.Show("Insira um nome");
                return;
            }
            FiltrarLista("Nome", nomePesquisa);
        }

        private void FiltrarLista(string tipoPesquisa, string valorPesquisa)
        {
            var colaboradores = ColaboradoresManager.GetInstance().colaboradores;

            dataColaboradores.Rows.Clear();

            var colaboradoresFiltrados = colaboradores.Where(c => c.Nome == valorPesquisa).ToList();



            foreach (var colaborador in colaboradoresFiltrados)
            {
                dataColaboradores.Rows.Add(colaborador.Codigo, colaborador.Situacao, colaborador.Categoria);
            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (dataColaboradores.SelectedRows.Count == 0)
            {
                MessageBox.Show("É preciso selecionar o colaborador antes de excluir.");
                return;
            }

            int codigoSelecionado = Convert.ToInt32(dataColaboradores.SelectedRows[0].Cells[0].Value);

            var colaborador = ColaboradoresManager.GetInstance()
                .colaboradores
                .FirstOrDefault(c=> c.Codigo == codigoSelecionado);
            if(colaborador == null)
            {
                MessageBox.Show("Colaborador não encontrado");
                return;

            }
            if(colaborador.Categoria == "Gerente")
            {
                MessageBox.Show("Gerentes não podem ser excluidos!");
                return;
            }

            ColaboradoresManager.GetInstance().colaboradores.Remove(colaborador);

           

            MessageBox.Show("Colaborador removido.");

            AtualizarTabela(ColaboradoresManager.GetInstance().colaboradores);
        }

        private void AtualizarTabela(List<Colaborador> lista)
        {
            dataColaboradores.Rows.Clear();
            
            foreach(var colaborador in lista)
            {
                dataColaboradores.Rows.Add(
                    colaborador.Codigo,
                    colaborador.Categoria,
                    colaborador.Situacao);
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

            if (dataColaboradores.SelectedRows.Count == 0)
            {
                MessageBox.Show("É preciso selecionar o colaborador antes de editar.");
                return;
            }

            int codigoSelecionado = Convert.ToInt32(dataColaboradores.SelectedRows[0].Cells[0].Value);

            var colaborador = ColaboradoresManager.GetInstance()
                .colaboradores
                .FirstOrDefault(c => c.Codigo == codigoSelecionado);

            if (colaborador == null)
            {
                MessageBox.Show("Colaborador não encontrado");
                return;

            }

            Edicao edicao = new Edicao(colaborador);
            edicao.ShowDialog();

            AtualizarTabela(ColaboradoresManager.GetInstance().colaboradores);

            

        }

        private void botaoFiltrar_Click(object sender, EventArgs e)
        {
            // Obtém a lista original de colaboradores
            var listaFiltrada = ColaboradoresManager.GetInstance().colaboradores;

            // Obtém as categorias selecionadas
            var categoriasSelecionadas = checkCategoria.CheckedItems.Cast<string>().ToList();
            if (categoriasSelecionadas.Any())
            {
                listaFiltrada = listaFiltrada.Where(c => categoriasSelecionadas.Contains(c.Categoria)).ToList();
            }

            // Obtém as situações selecionadas
            var situacoesSelecionadas = checkSituacao.CheckedItems.Cast<string>().ToList();
            if (situacoesSelecionadas.Any())
            {
                listaFiltrada = listaFiltrada.Where(c => situacoesSelecionadas.Contains(c.Situacao)).ToList();
            }

            // Atualiza a DataGridView com os dados filtrados
            AtualizarTabela(listaFiltrada);
        }
    }
}
