using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Exceptions
{
    internal class InvalidTemperatureException : TravelerCheckListException
    {
        public double Temperature { get; set; }
        public InvalidTemperatureException(double temperature)
            : base($"Value {temperature} is invalid temperature")
        {
            Temperature = temperature;
        }
    }
}
