using CleanArchitectureCQRS.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Commands
{
    public record RemoveTravlerItem(Guid TravlerCheckListId, string Name) : ICommand;
}
