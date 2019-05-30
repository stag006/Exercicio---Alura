using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionario
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        private int _tipo;

        public string Nome { get; set; }
        public  string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }


        public double GetBonificao()
        {
            if (_tipo == 1)
            return Salario * 10;

            return Salario * 0.10;
        }

    }
}
