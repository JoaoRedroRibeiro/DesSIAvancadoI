public class Program{
    /* 
    - 0 Action<t1,t2> representa um metodo que aceita 16 parametros e bao retorna valor (void)
    - Func<T,TResult>: Representa um metodo que aceita ate 16 parametros e retorna um valor do tipo TResult.  
    */
    public static void MostrarMensagem(string mensagem){
        Console.WriteLine("mensagem: " + mensagem);

    }

    public static int somar(int a, int b){
        return a + b;
    }

    public static void Main(string[] args){

        Action<string> action = MostrarMensagem;
        action("ola, joao");
        
        Func<int, int, int> operacao = somar;
        Console.WriteLine("soma: " +operacao(5,3));

        Action<int, int> exebirOperacoes = (x, y) => {
            Console.WriteLine("soma: " + (x + y));
            Console.WriteLine("multiplicação: " + (x * y));
        };

        exebirOperacoes(10,6);
        Func<int, int> calcularQuadrado = (x) => x*x;

        Func<int, int, int> executarOperacao = (x, y) =>{
            return calcularQuadrado(x) + calcularQuadrado(y);

        };

        Console.WriteLine("quadrado de 5 é: " + calcularQuadrado(5));
        Console.WriteLine("resultado da operação: " + executarOperacao(4,5));

    }
}