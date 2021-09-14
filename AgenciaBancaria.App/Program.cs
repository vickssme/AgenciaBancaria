using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua Jaborandi 250", "Centro", "Casa 2" "09810120", "São Bernardo do Campo", "SP");
                Cliente cliente = new Cliente("Victoria", "44983378700", "545286", endereco);

                ContaCorrente contaBancaria = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + contaBancaria.Situacao+ ": " + contaBancaria.NumeroConta + "-" + contaBancaria.DigitoVerificador) ;

                string senha = "A1234567";
                contaBancaria.Abrir(senha);

                Console.WriteLine("Conta " + contaBancaria.Situacao + ": " + contaBancaria.NumeroConta + "-" + contaBancaria.DigitoVerificador);

                contaBancaria.Sacar(10, senha);

                Console.WriteLine("Saldo: " + contaBancaria.Saldo);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
