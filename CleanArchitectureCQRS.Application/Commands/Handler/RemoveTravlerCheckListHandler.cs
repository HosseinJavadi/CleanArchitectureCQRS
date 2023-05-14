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
    public class RemoveTravlerCheckListHandler : ICommandHandler<RemoveTravlerCheckList>
    {
        private readonly ITravelerCheckListRepository _repository;

        public RemoveTravlerCheckListHandler(ITravelerCheckListRepository repository)
            => _repository = repository;
        public async Task HandleAsync(RemoveTravlerCheckList command)
        {
            var travelerCheckList = await _repository.GetAsync(command.Id);
            if(travelerCheckList == null)
              throw new TravelerCheckListNotFound(command.Id);

            await _repository.DeleteAsync(travelerCheckList);
        }
    }
}
