using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.ValueObjects;
using CleanArchitectureCQRS.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Events
{
    public record TravelerItemTaken(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;

}
