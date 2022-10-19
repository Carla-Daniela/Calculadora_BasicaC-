using System;

namespace testec_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc=new Calculadora();
            int opcao,num1,num2;

           System.Console.WriteLine(" Calculadora:\nDigite uma das opções abaixo:");
           System.Console.WriteLine(" 1-Soma\n 2-Subtração\n 3-Multiplicação\n 4-Divisão");
           
           opcao=Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine("Digite os valores:");
           num1=Convert.ToInt32(Console.ReadLine());
           num2=Convert.ToInt32(Console.ReadLine());

           if(opcao==1){
                calc.Soma(num1,num2);
           }
           else if(opcao==2){
                calc.Subtracao(num1,num2);
           }
           else if(opcao==3){
                calc.Multiplicacao(num1,num2);
           }
           else if(opcao==4){
                if(num2!=0){
                calc.Divisao(num1,num2);
                }
                else{
                    System.Console.WriteLine("valo invalido, não existe divisão por 0");
                    num2=Convert.ToInt32(Console.ReadLine());
                    calc.Divisao(num1,num2);
                }
           }
           else{
             System.Console.WriteLine("opção não existe!");
           }
            
        }
    }
}
