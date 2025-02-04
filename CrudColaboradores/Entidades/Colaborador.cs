using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudColaboradores.Entidades
{
    public class Colaborador
    {

        private static Random random = new Random();

        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public string Situacao { get; set; } 
        public string Categoria { get; set; } 
        public DateTime DataCadastro { get; private set; }


        public Colaborador(string nome, string situacao, string categoria)
        {
            Codigo = GerarCodigoUnico();
            Nome = nome;
            Situacao = situacao;
            Categoria = categoria;
            DataCadastro = DateTime.Now;
        }


        private static int GerarCodigoUnico()
        {
            return random.Next(100000, 999999);
        }
    }


}
