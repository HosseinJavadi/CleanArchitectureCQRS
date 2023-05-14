using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Exceptions
{
    public class TravelerCheckListNotFound : TravelerCheckListException
    {
        public TravelerCheckListNotFound(Guid id)
            : base($"Check list  with ID : {id} Not found")
        {
        }
    }
}
