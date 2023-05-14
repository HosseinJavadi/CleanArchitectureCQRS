using CleanArchitectureCQRS.Application.DTOs.External;
using CleanArchitectureCQRS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Services
{
    public interface IWeatherService
    {
        Task<WheatherDto> GetWheatherAsync(Destination destination);
    }
}
