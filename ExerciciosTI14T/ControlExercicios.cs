using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double bas;
        public double altura;

        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03" +
                             "\n4. Exercício 04" +
                             "\n5. Exercício 05" +
                             "\n6. Exercício 06" +
                             "\n7. Exercício 07" +
                             "\n8. Exercício 08" +
                             "\n9. Exercício 09" +
                             "\n11. Exercício 11");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;
                case 2:
                    Console.WriteLine("Informe um número");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num +
                        " é: " + model.Exercicio02(num));
                    break;
                case 3:
                    do {
                        Console.WriteLine("Informe a base: ");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if (bas <= 0)
                        {
                            Console.WriteLine("Base digitada não é valida," +
                                " digite novamente!");
                        }
                    } while (bas <= 0);

                    do
                    {
                        Console.WriteLine("Informe a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("Altura digitada não é valida," +
                                " digite novamente!");
                        }
                    } while (altura <= 0);

                    Console.WriteLine("A área do retângulo é: " +
                        model.Exercicio03(bas, altura));
                    break;
                case 4:
                    Console.WriteLine("Informe quantos anos você tem: ");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe quantos meses você tem: ");
                    int meses = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe quantos dias vocês tem: ");
                    int dias = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sua idade em dias é: " + model.Exercicio04(ano, meses, dias) + " dias");
                    break;
                case 5:
                    double totalDeEleitores;
                    double votosBrancos;
                    double votosNulos;
                    double votosValidos;

                    do
                    {
                        Console.WriteLine("Digite a quantidade total de eleitores: ");
                        totalDeEleitores = Convert.ToDouble(Console.ReadLine());
                        if (totalDeEleitores <= 0)
                        {
                            Console.WriteLine("Informe um valor maior do que zero!");
                        }
                    } while (totalDeEleitores <= 0);

                    do
                    {
                        Console.WriteLine("Digite a quantidade de votos brancos: ");
                        votosBrancos = Convert.ToDouble(Console.ReadLine());
                        if (votosBrancos <= 0)
                        {
                            Console.WriteLine("Informe um valor maior do que zero!");
                        }
                    } while (votosBrancos <= 0);

                    do
                    {
                        Console.WriteLine("Digite a quantidade de votos validos: ");
                        votosValidos = Convert.ToDouble(Console.ReadLine());
                        if (votosValidos <= 0)
                        {
                            Console.WriteLine("Informe um valor maior do que zero!");
                        }
                    } while (votosValidos <= 0);

                    do
                    {
                        Console.WriteLine("Digite a quantidade votos nulos: ");
                        votosNulos = Convert.ToDouble(Console.ReadLine());
                        if (votosNulos <= 0)
                        {
                            Console.WriteLine("Informe um valor maior do que zero!");
                        }
                    } while (votosNulos <= 0);

                    //Usar o método exercício 05
                    Console.WriteLine(model.Exercicio05(votosValidos, votosNulos, votosBrancos, totalDeEleitores));
                    break;

                case 6:
                    double salario;
                    double preajuste;

                    Console.WriteLine("Informe o seu salario: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o reajuste: ");
                    preajuste = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O novo salario é de:" + model.Exercicio06(salario, preajuste));
                    break;

                case 7:
                    Console.WriteLine("Informe o custo de fabrica do carro: ");
                    double custofabrica = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o valor do imposto: ");
                    double imposto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o percentual do distribuidor: ");
                    double pdistribuidor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O valor final do consumidor será: " + model.Exercicio07(imposto, custofabrica, pdistribuidor));
                    break;
                case 8:
                    double nota1;
                    double nota2;
                    double nota3;
                    do
                    {
                        Console.WriteLine("Informe a primeira nota:");
                        nota1 = Convert.ToDouble(Console.ReadLine());
                        if (nota1 < 0 || nota1 > 10)
                        {
                            Console.WriteLine("Informe um valor maior que zero");
                        }
                    } while (nota1 < 0 || nota1 > 10);

                    do
                    {
                        Console.WriteLine("Informe a segunda nota:");
                        nota2 = Convert.ToDouble(Console.ReadLine());
                        if (nota2 < 0 || nota2 > 10)
                        {
                            Console.WriteLine("Informe um valor maior que zero");
                        }
                    } while (nota2 < 0 || nota2 > 10);

                    do
                    {
                        Console.WriteLine("Informe a terceira nota:");
                        nota3 = Convert.ToDouble(Console.ReadLine());
                        if (nota3 < 0 || nota3 > 10)
                        {
                            Console.WriteLine("Informe um valor maior que zero");

                        }
                    } while (nota3 < 0 || nota3 > 10);
                    Console.WriteLine("Sua média final é de:" + model.Exercicio08(nota1, nota2, nota3));
                    break;

                case 9:
                    Console.WriteLine("Digite o numero de maçãs :");
                    double maca = Convert.ToDouble(Console.ReadLine());
                    if (maca < 12)
                    {
                        Console.WriteLine("O valor da sua compra é de RS " + model.Exercicio9(maca));
                    }
                    else
                    {
                        Console.WriteLine("O valor da sua compra é de RS " + model.Exercicio91(maca) + "RS");
                    }
                    break;
                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;

                case 11:
                    Console.WriteLine("Digite seu salario:");
                    salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor da venda:");
                    double totalDeVendas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Seu novo salario é de:R$" + model.Exercicio11(salario, totalDeVendas));

                    break;


            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
