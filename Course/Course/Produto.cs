using System;
using System.Globalization;

namespace Course
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

        public void AdicionarPordutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade +  " Unidades, Total: $ " + ValorToalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}