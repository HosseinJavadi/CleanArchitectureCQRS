using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Exceptions
{
    public class TravelerCheckListNameException : TravelerCheckListException
    {
        public TravelerCheckListNameException()
            :base("Name cannot be null")
        {

        }
    }
}
