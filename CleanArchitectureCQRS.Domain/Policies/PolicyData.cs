using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Policies
{
    public record PolicyData(ValueObjects.TravelDays Days,Consts.Gender Gender,ValueObjects.Temperature Temperature,
        ValueObjects.Destination Destination);
}
