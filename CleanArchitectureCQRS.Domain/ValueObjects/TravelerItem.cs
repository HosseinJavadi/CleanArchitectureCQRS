using CleanArchitectureCQRS.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.ValueObjects
{
    public record TravelerItem
    {
        public string Name { get; }
        public uint Quantity { get; }
        public bool IsTaken { get; init; }

        public TravelerItem(string name, uint quantity, bool isTaken = false)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new TravelerItemException();

            Name = name;
            Quantity = quantity;
            IsTaken = isTaken;
        }
    }
}
