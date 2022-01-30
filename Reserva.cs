using DesafioTryCatch2.Entidade.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTryCatch2.Entidade
{
    internal class Reserva
    {
        public int numeroQuarto;
        public DateTime chekin;
        public DateTime chekout;

        public Reserva()
        {

        }

        public Reserva(int numeroQuarto, DateTime chekin, DateTime chekout)
        {

            if (chekout <= chekin)
            {
                throw new ExceptionDominio("O checkout deve ser feito em datas posteriores ao chek-in");
            }

            this.numeroQuarto = numeroQuarto;
            this.chekin = chekin;
            this.chekout = chekout;
        }

        public int Duracao()
        {
            TimeSpan duracao = chekout.Subtract(chekin);
            return (int)duracao.TotalDays;
        }

        public void updateDatas(DateTime chekin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (chekin < now || checkout < now)
            {
                throw new ExceptionDominio("As reservas devem ser feitas em datas futuras: ");
            }
            if (checkout <= chekin)
            {
                throw new ExceptionDominio("O checkout deve ser feito em datas posteriores ao chek-in");
            }

            this.chekin = chekin;
            chekout = checkout;
        }

        public override string ToString()
        {
            return "Quarto "
                + numeroQuarto
                + chekin.ToString(" dd/MM/YYYY")
                + ", chek-out: "
                + chekin.ToString(" dd/MM/YYYY")
                + ", "
                + Duracao()
                + " noites";
        }
    }
}
