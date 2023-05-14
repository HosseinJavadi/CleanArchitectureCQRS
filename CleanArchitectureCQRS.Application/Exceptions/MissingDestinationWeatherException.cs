using CleanArchitectureCQRS.Domain.ValueObjects;
using CleanArchitectureCQRS.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Exceptions
{
    public class MissingDestinationWeatherException : TravelerCheckListException
    {
        public Destination Destination { get; set; }
        public MissingDestinationWeatherException(Destination destination)
            : base($"Couldn't fetch weather data for Destination {destination}")
        {
            Destination = destination;
        }
    }
}
