using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTryCatch2.Entidade.Exception
{
    internal class ExceptionDominio : ApplicationException
    {
        public ExceptionDominio (string message) : base(message)
        {

        }
    }
}
