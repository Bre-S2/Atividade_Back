using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
                        Console.WriteLine("Informar nome");
                        string var_nome = Console.ReadLine();
                        Console.WriteLine("Informar Endereço");
                        string var_endereco = Console.ReadLine();
                        Console.WriteLine("Pessoa Fisica(f) ou Juridica(j) ?");
                        string var_tipo = Console.ReadLine();
                        if(var_tipo == "f")
                        {
                            // --- Pessoa Fisica ----
                            Pessoa_Fisica pf = new Pessoa_Fisica();
                            pf.nome = var_nome;
                            pf.endereco = var_endereco;
                            Console.WriteLine("Informar CPF:");
                            pf.cpf = Console.ReadLine();
                            Console.WriteLine("Informe o RG:");
                            pf.rg = Console.ReadLine();
                            Console.WriteLine("Informe o valor de compra:");
                            val_pag = float.Parse(Console.ReadLine());
                            pf.Pagar_Imposto(val_pag);
                            Console.WriteLine("------ Pessoa Fisica -----");
                            Console.WriteLine("Nome ..........:" + pf.nome);
                            Console.WriteLine("Endereco ......:" + pf.endereco);
                            Console.WriteLine("CPF ...........:" + pf.cpf);
                            Console.WriteLine("Valor de Compra:" + pf.valor.ToStrin("C"));
                            Console.WriteLine("Imposto........:" + pf.valor_imposto.ToStrin("C"));
                            Conlose.WriteLine("Total a Pagar..:" + pf.total.ToStrin("C"));
                        }
                        if(var_tipo == "j")
                        {
                            // --- Pessoa Juridica ---
                            Pessoa_Juridica pj = new Pessoa_Juridica();
                            pj.nome = var_nome;
                            pj.endereco = var_endereco;
                            Console.WriteLine("Informar CNPJ:");
                            pj.cnpj = Console.ReadLine();
                            Console.WriteLine("Informar IE:");
                            pj.ie = Console.ReadLine();
                            val_pag = float.Parse(Console.ReadLine());
                            pj.Pagar_Imposto(val_pag);
                            Console.WriteLine("------- Pessoa Juridíca-------"):
                            Console.WriteLine("Nome ..........:" + pj.nome);
                            Console.WriteLine("Endereco.......:" + pj.endereco);
                            Console.WriteLine("CNPJ...........:" +pj.cnpj);
                            Console.WriteLine("IE ............:" +pj.ie);
                            Console.WriteLine("Valor de Compra:" + pj.valor.ToStrin("C"));
                            Console.WriteLine("Imposto........:" + pj.valor_imposto.ToStrin("C"));
                            Console.WriteLine("Total a Pagar..:" + pj.total.ToStrin("C"));
                        
                        }
                }

        }
}