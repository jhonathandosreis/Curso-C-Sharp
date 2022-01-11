using System;
using System.Globalization;

namespace CoursePOO
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorToalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarPordutos(int Quantidade)
        {

        }

        public void RemoverProdutos(int Quantidade)
        {

        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " Unidades, Total: $ " + ValorToalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}