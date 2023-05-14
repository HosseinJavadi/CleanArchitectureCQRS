using CleanArchitectureCQRS.Application.Exceptions;
using CleanArchitectureCQRS.Domain.Repositories;
using CleanArchitectureCQRS.Domain.ValueObjects;
using CleanArchitectureCQRS.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Commands.Handler
{
    public class AddTravelerItemHandler : ICommandHandler<AddTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public AddTravelerItemHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(AddTravelerItem command)
        {
            var checkListTravelerItem = await _repository.GetAsync(command.TravelerCheckListId);
            if (checkListTravelerItem == null)
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);

            var travelerItem = new TravelerItem(command.Name, command.Quantity);
            checkListTravelerItem.AddItem(travelerItem);

            await _repository.UpdateAsync(checkListTravelerItem);
        }
    }
}
