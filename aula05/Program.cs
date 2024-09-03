﻿public class Program{
    public static void Main(string[] args){
        //Conversão implícita
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversão implícita de int para double:");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");

        //Conversão Convert
        double valorDouble = 7.45;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);
        Console.WriteLine("Conversão utilizando Convert");
        Console.WriteLine($"Double: {valorDouble}, Inteiro: {valorConvertidoInt}");
        Console.WriteLine($"String: {textoValor}, Inteiro: {textoConvertidoInt}");
        
        //conversão usando casting

        double x = 9.66;
        int a = (int) x;
        Console.WriteLine($"Double: (x), Inteiro: {a}");
      
        //conversão usando perse

        string textDecimal = "12.75";
        double decimalString =  double.Parse(textDecimal);
        Console.WriteLine($"String,{textDecimal}, Double: {decimalString}");

        char caractere = 'A';
        int codigoAscii = (int)caractere;
        Console.WriteLine($"Char:{caractere}, Ascii: {codigoAscii}");



    }
}