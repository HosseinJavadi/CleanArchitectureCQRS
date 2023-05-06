using CleanArchitectureCQRS.Domain.Consts;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);

        TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, Destination destination,
            TravelDays days, Temperature temperature, Gender gender);
    }
}
