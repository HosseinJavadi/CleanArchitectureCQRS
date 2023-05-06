using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Exceptions
{
    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; set; }
        public TravelerItemNotFoundException(string itemName)
            : base( $"Traveler Item {itemName} Not Found")
        {
            ItemName = itemName;
        }
    }
}
