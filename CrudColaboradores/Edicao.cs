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
    public partial class Edicao : Form
    {

        private Colaborador colaborador;
        public Edicao(Colaborador colaborador)
        {
            InitializeComponent();
            this.colaborador = colaborador;

            txtNome.Text= colaborador.Nome;

            if(colaborador.Situacao == "Ativo")
                radioAtivo.Checked = true;
            else radioInativo.Checked = true;

            switch(colaborador.Categoria)
            {
                case "Desenvolvedor":
                    radioDesenvolvedor.Checked = true;
                    break;
                case "Gerente":
                    radioGerente.Checked = true;
                    break;
                case "Tester":
                    radioTester.Checked = true;
                    break;
                case "Suporte":
                    radioSuporte.Checked = true;
                    break;
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            colaborador.Nome = txtNome.Text.Trim();
          
            colaborador.Situacao = radioAtivo.Checked ? "Ativo" : "Inativo";

            if (radioDesenvolvedor.Checked) colaborador.Categoria = "Desenvolvedor";
            else if (radioGerente.Checked) colaborador.Categoria = "Gerente";
            else if (radioTester.Checked) colaborador.Categoria = "Tester";
            else if (radioSuporte.Checked) colaborador.Categoria = "Suporte";

            MessageBox.Show("Alterado");

            
            this.Close();
        }
    }
}
