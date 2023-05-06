using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Repositories
{
    public interface ITravelerCheckListRepository
    {
        Task<TravelerCheckList> GetAsync(TravelerCheckListId id);

        Task AddAsync(TravelerCheckList travelerCheckList);
        Task UpdateAsync(TravelerCheckList travelerCheckList);
        Task DeleteAsync(TravelerCheckList travelerCheckList);
    }
}
