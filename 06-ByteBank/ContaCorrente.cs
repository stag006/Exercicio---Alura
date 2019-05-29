// using _06_Bytebank;


namespace _06_Bytebank
{
    public class ContaCorrente
    {







        public Cliente titular;
        public int agencia;
        public int numero;
        private double _saldo = 100;

       

        public Cliente Titular;







        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        

       public void SetSaldo (double _saldo)
        {

            else
            {
                this._saldo = _saldo;
            }
        }



        public double GetSaldo()
        {
            return _saldo;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}







/* APRENDEMOS:
 * como definir métodos com parâmetros e retorno;
como retornar algo usando a palavra chave return antes da expressão do resultado;
o uso do return para retornar antecipadamente a execução de um método void;
como usar a referência this para acessar um atributo;
que podemos passar uma referência como parâmetro do método;
métodos são chamadas a partir da referência usando o operador ...
 */
