using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Exceptions
{
    public class TravelerCheckListIdException : TravelerCheckListException
    {
        public TravelerCheckListIdException()
            :base("value Id cannot be empty")
        {

        }
    }
}
