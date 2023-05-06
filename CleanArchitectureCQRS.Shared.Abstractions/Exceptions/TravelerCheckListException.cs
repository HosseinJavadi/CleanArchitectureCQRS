using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Shared.Abstractions.Exceptions
{
    public class TravelerCheckListException : Exception
    {
        public TravelerCheckListException(string message)
            : base(message)
        {

        }
    }
}
