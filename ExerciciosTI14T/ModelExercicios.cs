using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ModelExercicios
    {
        //Declaração de variáveis
        private int A;
        private int B;
        private int C;
        private double comissao;

        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 20;
            ConsultarC = 0;
        }//fim do construtor

        public int ConsultarA
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do consultarA

        public int ConsultarB
        {
            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }
        }//fim do consultarB

        public int ConsultarC
        {
            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }
        }//fim do consultarC

        //Método Exercício01
        public string Exercicio01()
        {
            ConsultarC = ConsultarA;
            ConsultarA = ConsultarB;
            ConsultarB = ConsultarC;
            return "A: " + ConsultarA + "\nB: " + ConsultarB;
        }//fim do métodoExercicio01

        public int Exercicio02(int num)
        {
            return num - 1;
        }

        public double Exercicio03(double bas, double altura)
        {
            return bas * altura;
        }

        public int Exercicio04(int ano, int mes, int dias)
        {
            return (25 * 365) + (6 * 30) + 30;
        }//fim do método exercicio04

        public string Exercicio05(double validos, double nulo, double branco, double eleitores)
        {
            branco = (branco / eleitores) * 100;
            nulo = (nulo / eleitores) * 100;
            validos = (validos / eleitores) * 100;
            string msg = "Porcentagem de votos brancos:   " + branco  + "%" +
                         "\nPorcentagem de votos nulos:   " + nulo    + "%" +
                         "\nPorcentagem de votos validos: " + validos + "%" ; 
            return msg;
        }//fim do exercício 05



        public double Exercicio06(double salario, double preajuste)
        {
            return salario * (100 + preajuste) / 100;
        
        }//fim do exercício 06

        public double Exercicio07(double imposto, double custofabrica, double pdistribuidor)
        {
            return (custofabrica * (imposto /100)) + (custofabrica * (pdistribuidor/100)) + custofabrica;
        }

        //Exercício08

        public double Exercicio08(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

 // exercicio 9

        public double Exercicio9 (double maca)
        {
            maca = maca * 1.30;
            return maca;
        }

        public double Exercicio91(double maca)
        {
            maca = maca * 1;
            return maca;
        }

        // EXERCICIO 11

        public double Exercicio11(double salario, double totalDeVendas)
        {
            if(totalDeVendas <= 1500){
                comissao = (totalDeVendas * 3) / 100;
            }
            if(totalDeVendas > 1500 ){
                comissao = (totalDeVendas * 8) / 100;
            }
            return salario + comissao;
        }

    }//fim da classe
}//fim do projeto
