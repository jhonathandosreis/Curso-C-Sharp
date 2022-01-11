using System;
using System.Globalization; // Biblioteca para imprimir valores com "."

namespace Course
{
    public class TiposDeDados
    {
        // Exemplo: 1
        public static void Main1(string[] args)
        {
            //variable declaration
            bool completo = false;
            char genero = 'M';
            char letra = '\u0041'; // Caractere Unicode -  https://unicode-table.com/en/
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "jhonathan";
            object obj1 = "Anni Karolynne";
            object obj2 = 4.5f;

            //print result
            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }

        // Exemplo: 2
        public static void Main2(string[] args)
        {
            //variable declaration
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            //print result
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }

        // Exemplo: 3
        public static void Main3(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Saidas de dados em C#
            Console.Write("Bom dia! "); // Write não inclui uma quebra de linha
            Console.WriteLine("Boa tarde"); // WriteLine inclui a quebra de linha
            Console.WriteLine("Boa noite!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // De 0 até 4 -> arredonda para baixo // de 5 até 9 arredonda para cima // CultureInfo.InvariantCulture Para imprimir valores com "."
            Console.WriteLine(nome);
        }

        // Exemplo: 4
        public static void Main4(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // PlaceHolder {dentro das chaves especifica a variavel que irá ser atribuida} //para valores {3:F5} exemplifica a quantidade de casas decimais que deseja mostrar

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // Tecnica da interpolação passando a dentro da chaves a variavel para imprimir o resultado
        }

        // Exemplo 5
        public static void Main5(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}");

            Console.WriteLine("");

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);

            Console.WriteLine("");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
        }

        // Exemplo 6
        public static void Main6(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

        }

        // Exemplo 7
        public static void Main7(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 10;
            int d = 10;

            a++; // Incrementa + 1
            b--; // decrementa - 1

            ++c; // Incrementa + 1
            --d; // Incrementa - 1

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        // Exemplo 8
        public static void Main8(string[] args)
        {
            //Conversão implicita -> double = y e está sendo atribuido x;

            float x = 4.5f; // float = 4 bytes

            double y = x; // double = 8 bytes

            Console.WriteLine(y);

            //-----------------------------------------------------------------//

            //Conversão explicita é possivel utilizando CASTING b =(float)a;

            double a; // double = 8 bytes

            float b; // float = 4 bytes

            a = 5.1;
            b = (float)a;

            Console.WriteLine(a);
        }

        // Exemplo 9
        public static void Main9(string[] args)
        {
            int a = 5;
            int b = 2;

            double resultado = (float)a / b; // Foi utilizado o CASTING para retorar o valor quebrado.

            Console.WriteLine(resultado); ;
        }

        // Exemplo 10
        public static void Main10(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3; // % Retorna sempre o resto da divisão
            double n4 = (double)10 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }

        // Exemplo 11
        public static void Main11(string[] args)
        {
            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c; //Math.Pow = Potencia

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt = Raiz quadrada
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt = Raiz quadrada

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

        // Exemplo 12
        public static void Main12(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' '); // Split analisa o string original e reconhecer cada pedaço do string e armazenará essas partes em um vetor de string
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        //Exemplo 13
        public static void Main13(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); // int.Parce para converter string para inteiro
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        // Exercício de fixação 14
        public static void Main14(string[] args)
        {
            string nomeCompleto = Console.ReadLine();
            int quantidadeDeQuartos = int.Parse(Console.ReadLine());
            double precoDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine("Quantos quartos tem sua casa? ");
            Console.WriteLine(quantidadeDeQuartos);
            Console.WriteLine("Entre com o preço de um produto: ");
            Console.WriteLine(precoDoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        // Exemplo 15
        public static void Main15(string[] args)
        {
            // Operadores comparativos
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("----------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }

        // Exemplo 16
        public static void Main16(string[] args)
        {
            // Operador && -> A codição só é verdadeira quando as duas combinações forem verdadeiras
            bool c1 = 2 > 3 && 4 != 5; // 2 é maior que 3? e 4 é diferente de 5?

            // Operador || -> A condição só é verdadeira quando uma das duas combinações forem verdadeiras
            bool c2 = 2 > 3 || 4 != 5; // 2 é maior que 3? e 4 é diferente de 5?

            // Operador ! -> A condição NÃO nega o resultado, se for verdadeiro vira falso se for falso vira verdadeiro.
            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("-------------------");

            bool c4 = 10 < 5;
            bool c5 = c2 || c3 && c4;

            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }

        // Exemplo 17
        public static void Main17(string[] args)
        {
            Console.WriteLine("Entre com o número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }


        }

        // Exemplo 18
        public static void Main18(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }

        // Exemplo 19
        public static void Main19(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }
        }

        // Exemplo 20 
        public static void Main20(string[] args)
        {
            Console.WriteLine("Digite tres números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());



            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        public static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }

        // Exemplo 21
        public static void Main21(string[] args)
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");
        }

        // Exemplo 22
        public static void Main22(string[] args)
        {
            Console.Write("Digite sua senha: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x != 2002)
            {
                Console.WriteLine("Senha Invalida!");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Acesso Permitido");
        }

        // Exemplo 23
        public static void Main23(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }

        // Exemplo 24
        public static void Main24(string[] args)
        {
            double xA, xB, xC;
            double yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        // Exemplo 25
        public static void Main25(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo X:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        }

        // Exemplo 26
        public static void Main26(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço?: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarPordutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

        // Exemplo 27
        public static void Main27(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:" + r);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.CurrentCulture));
        }

        // Exemplo 28
        public static void Main29(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        // Exemplo 29
        public static void Main30(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?: ");
            double conversorMoeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?: ");
            double conversor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + conversorMoeda * conversor);
        }
    }
}