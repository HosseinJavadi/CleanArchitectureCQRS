using CleanArchitectureCQRS.Application.DTOs;
using CleanArchitectureCQRS.Domain.Repositories;
using CleanArchitectureCQRS.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Queries.Handler
{
    public class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly ITravelerCheckListRepository _repository;
        public GetTravelerCheckListHandler(ITravelerCheckListRepository repository)
           => _repository = repository;
       
        public async Task<TravelerCheckListDto> HandlerAsync(GetTravelerCheckList query)
        {
            var travelerCheckList = await _repository.GetAsync(query.Id);
            return null;
        }
    }
}
