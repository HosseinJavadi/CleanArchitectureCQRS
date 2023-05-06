using CleanArchitectureCQRS.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.ValueObjects
{
    public record TravelDays
    {
        public ushort Value { get; }

        public TravelDays(ushort value)
        {
            if (value is 0 or > 100)
                throw new InvalidTravelDaysException(value);

            Value = value;
        }

        public static implicit operator TravelDays(ushort day)
            => new(day);
        
        public static implicit operator ushort(TravelDays day)
            => day.Value;
    }
}
