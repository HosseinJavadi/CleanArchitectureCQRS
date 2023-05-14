using CleanArchitectureCQRS.Shared.Abstractions.Commands;

namespace CleanArchitectureCQRS.Application.Commands
{
    public record TakeItem(Guid TravlerCheckListId, string Name) : ICommand;
}
