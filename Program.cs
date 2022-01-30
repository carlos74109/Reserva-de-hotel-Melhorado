using DesafioTryCatch2.Entidade;
using DesafioTryCatch2.Entidade.Exception;
using System;

namespace DesafioTryCatch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Numero do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                Console.WriteLine("Data do check-in (DD/MM/YYYY)");
                DateTime chekin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Data do chek-out");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(numeroQuarto, chekin, checkout);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");

                Console.WriteLine("Data do check-in (DD/MM/YYYY)");
                chekin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Data do chek-out");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.updateDatas(chekin, checkout);
                Console.WriteLine(reserva);
            }
            catch (ExceptionDominio ex)
            {
                Console.WriteLine("Erro na reserva: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Digite um valor valido: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
            

            
        }
    }
}
