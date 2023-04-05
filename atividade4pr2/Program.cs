using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atv1


            //Não é possivel na linguagem em c#, porém é possivel em outras linguagens.
            //Portanto ela é falsa.
            //Ela é falsa pois float é para números "quebrados" e int para números inteiros.
            //


            //atv2

            //Console.ReadLine()  lê toda a linha de código.
            //Console.Read() lê somente um caractere


            //atv3


            //Você tem q ter certeza de q converteu oq a pessoa digitou
            //para a variavel deter minada  ex:

            //int nm;
            //Console.Writhline("digite um numero inteiro");
            //nm = int.Parce(Console.Readline());


            //atv4


            //int num, num2, num3;
            //Console.WriteLine("Entre com um numero");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10) 
            //Console.WriteLine("Mensagem 01");
            //else
            //    Console.WriteLine("Mensagem 02");
            //Console.ReadKey();

            //O objetivo desse código é saber se o número digitado é
            //divisivel por 2 e maior q 10.

            //se entrarmos com o numero 8 : "Mensagem 02"
            //se entrarmos com o numero 27 : "mensagem 02"
            //se entrarmos com o numero 28 : "Mensagem 01"


            //atv05


            //formula: v0 + a

            //int vi, a, t
            //Console.WriteLine("digite a velocida inicial");
            //vi = int.Parse(Console.ReadLine());
            //Console.WriteLine("qual foi a aceleração");
            //a = int.Parse(Console.ReadLine());  
            //Console.WriteLine("qual foi o tempo");
            //t = int.Parse(Console.ReadLine());


            //atv06


            {
                //Random rnd = new Random();
                //int num = rnd.Next(1, 100); // Gera um número aleatório entre 1 e 100

                //Console.WriteLine("Número gerado: " + num);

                //if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
                //{
                //    Console.WriteLine("O número é divisível por 3, 5 e 10");
                //}
                //else if (num % 3 == 0 && num % 5 == 0)
                //{
                //    Console.WriteLine("O número é divisível por 3 e 5");
                //}
                //else if (num % 3 == 0)
                //{
                //    Console.WriteLine("O número é divisível por 3");
                //}
                //else if (num % 5 == 0)
                //{
                //    Console.WriteLine("O número é divisível por 5");
                //}
                //else
                //{
                //    Console.WriteLine("O número não é divisível por 3, 5 nem 10");
                //}

                //Console.ReadLine();


                //atv07


                //int km;

                //Console.WriteLine("sua casa fica no km:");
                //km = int.Parse(Console.ReadLine());



                //if(km <= 12 && km >= 0)
                //     Console.WriteLine("você vai demorar 71 minutos");
                // else if (km <= 29 && km > 12)
                //{

                //    Console.WriteLine("você vai demorar 57 minutos");
                //}
                //else if (km <= 55 && km > 29)
                //{

                //    Console.WriteLine("você vai demorar 30 minutos");
                //}
                //else if (km <= 82 && km > 55)
                //{

                //    Console.WriteLine("você vai demorar 27 minutos");
                //}
                //else if (km <= 100 && km > 82)
                //{

                //    Console.WriteLine("você vai demorar 12 minutos");


                //    Console.ReadKey(); 


                //}


                //atv8

                // double marc, quant, total, custo, imp, custof, luc;

                // Console.WriteLine("=======MARCAS=======");
                // Console.WriteLine("1 ROYAL");
                // Console.WriteLine("2 WISKAS");
                // Console.WriteLine("3 GOLDEN");
                // Console.WriteLine("4 NUTRIEN");
                // Console.WriteLine("5 SPECIALCAT");
                // Console.WriteLine("6 MARBA");
                // Console.WriteLine("7 GATUS");

                // Console.WriteLine("escolha uma marca:");
                // marc = double.Parse(Console.ReadLine());
                // Console.WriteLine("escolha a quantidade");
                // quant = double.Parse(Console.ReadLine());

                // troca (marco)
                // {

                //     caso 1:
                //         total = 129,50 * quantidade;
                //         custo = total * 0,775;
                //         custof = total - custo;
                //         imp = custof * 0.33;
                //         luc = (total - custof) - imp;


                //         quebra;
                //     caso 2:
                //         total = 182,78 * quantidade;
                //         custo = total * 0,897;
                //         custof = total - custo;
                //         imp = custof * 0.275;
                //         luc = (total - custof) - imp;


                //         quebra;
                //     caso 3:
                //         total = 159,46 * quantidade;
                //         custo = total * 0,717;
                //         custof = total - custo;
                //         imp = custof * 0.225;
                //         luc = (total - custof) - imp;


                //         quebra;
                //     caso 4:
                //         total = 144,80 * quantidade;
                //         custo = total * 0,889;
                //         custof = total - custo;
                //         imp = custof * 0.25;
                //         luc = (total - custof) - imp;


                //         quebra;
                //     caso 5:
                //         total = 205,40 * quantidade;
                //         custo = total * 0,8324;
                //         custof = total - custo;
                //         imp = custof * 0.22;
                //         luc = (total - custof) - imp
                //         quebra;
                //     caso 7:
                //         total = 133,99 * quantidade;
                //         custo = total * 0,946;
                //         custof = total - custo;
                //         imp = custof * 0.20;
                //         luc = (total - custof) - imp;


                //         quebra;
                //     caso 6:
                //         total = 125,10 * quantidade;
                //         custo = total * 0,904;
                //         custof = total - custo;
                //         imp = custof * 0.179;
                //         luc = (total - custof) - imp;


                //         quebra;




            }
        }

    }
}
