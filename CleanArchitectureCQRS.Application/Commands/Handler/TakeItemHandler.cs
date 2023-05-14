using CleanArchitectureCQRS.Application.Exceptions;
using CleanArchitectureCQRS.Domain.Repositories;
using CleanArchitectureCQRS.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Commands.Handler
{
    public class TakeItemHandler : ICommandHandler<TakeItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public TakeItemHandler(ITravelerCheckListRepository repository)
            => _repository = repository;
        public async Task HandleAsync(TakeItem command)
        {
            var travelerCheckList = await _repository.GetAsync(command.TravlerCheckListId);
            if (travelerCheckList == null)
                throw new TravelerCheckListNotFound(command.TravlerCheckListId);

            travelerCheckList.TakeItem(command.Name);

            await _repository.UpdateAsync(travelerCheckList);
        }
    }
}
