using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Exceptions
{
    public class TravelerItemException : TravelerCheckListException
    {
        public TravelerItemException()
            : base("Traveler Item cannot be null")
        {

        }
    }
}
