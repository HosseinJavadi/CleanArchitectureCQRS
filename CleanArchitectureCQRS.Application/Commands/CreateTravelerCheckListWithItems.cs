using CleanArchitectureCQRS.Domain.Consts;
using CleanArchitectureCQRS.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Commands
{
    public record CreateTravelerCheckListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
        DestinationWriteModel Destination) : ICommand;

    public record DestinationWriteModel(string City,string Country);
}
