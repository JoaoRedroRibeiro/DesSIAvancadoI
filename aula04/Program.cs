class Program{
    public static void Main(string[]args){
        Pessoa objPessoa = new Pessoa("joaojoao");
        Console.WriteLine("ates do metodo (class);" + objPessoa.ToString());
        AlteraNomeClasse(objPessoa);
        Console.WriteLine("depois do metodo (class);" + objPessoa.ToString());

        PessoaStruct objPessoaStruct = new PessoaStruct("miguel");
        Console.WriteLine("antes do metodo (struct):" + objPessoaStruct.ToString());
        AlteraNomeStruct(objPessoaStruct);
        Console.WriteLine("depois do metodo (struct):" + objPessoaStruct.ToString());


    }
    public static void AlteraNomeClasse(Pessoa objaux){
        objaux.Nome = "dani";

    }
    public static void AlteraNomeStruct(PessoaStruct objaux){
        objaux.NomeStruct = "mingau";
    }
}