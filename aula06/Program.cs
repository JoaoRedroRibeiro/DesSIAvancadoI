using System;

public class Program{
    public delegate void exibirNumero(int num);
    public static void imprimeNumero(int numero){
        Console.WriteLine("o numero é: " +  numero);
    } 

    public static void exibirQuadrado(int numero){
        Console.WriteLine("o quadrado do numero "+ numero +" é: "+ numero*numero);
    }

   public static void mediaNota(int nota){
    if(nota < 60){
        Console.WriteLine("aluno reprovado: " + nota)
    }
    else{
         Console.WriteLine("aluno aprovado: " + nota)
    }
   }

    public static void Main(){
        exibirNumero meuDelegate = imprimeNumero;

        meuDelegate(10);

        meuDelegate +=exibirQuadrado;
        meuDelegate(2);

        meuDelegate += delegate (int num){
            Console.WriteLine("o dobro do numero "+num+" é: "+ (num*2));
        };
         meuDelegate(3);

         Pessoa objPessoa = new Pessoa("joao", 59);
         meuDelegate += mediaNota;
         meuDelegate(objPessoa.Nota);
    }
}