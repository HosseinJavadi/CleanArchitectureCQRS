using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Exceptions
{
    public class InvalidTravelDaysException : TravelerCheckListException
    {
        public ushort Day { get; set; }
        public InvalidTravelDaysException(ushort day)
            : base($"Value {day} is invalid travel check list")
            => Day = day;
    }
}
