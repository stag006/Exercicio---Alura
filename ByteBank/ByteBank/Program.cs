using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "132.465.798-45";

            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia de Diretor " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionário " + robertaTeste.GetBonificacao());
                
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(); // Pula linha

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.Salario);

            Console.WriteLine(); // Pula linha

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTtotalBonificacao());

            Console.ReadLine();
        }
    }
}
/*  Podemos criar diretórios na raiz de nosso projeto para organizar melhor o código!
    O recurso de possíveis soluções do Visual Studio, acessível pelo atalho CTRL+PONTO;
    Podemos ter vários métodos com o mesmo nome, desde que possuam lista de argumentos diferentes! Estas são as sobrecargas.
 * 
 */
