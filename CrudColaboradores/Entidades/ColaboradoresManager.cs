using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudColaboradores.Entidades
{
    public class ColaboradoresManager
    {

        private static ColaboradoresManager _instance;

        public List<Colaborador> colaboradores { get; private set; }

        private ColaboradoresManager()
        {
            colaboradores = new List<Colaborador>();
        }

        public static ColaboradoresManager GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ColaboradoresManager();
            }

            return _instance;


        }

        public void AdicionarColaborador(Colaborador colaborador)
        {
            colaboradores.Add(colaborador);
        }
    }
}
