using CleanArchitectureCQRS.Domain.Consts;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.Policies;
using CleanArchitectureCQRS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Factories
{
    public sealed class TravelerCheckListFactory : ITravelerCheckListFactory
    {
        private readonly IEnumerable<ITravelerItemPolicy> _policies;
        public TravelerCheckListFactory(IEnumerable<ITravelerItemPolicy> policies)
           => _policies = policies;
        public TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
            => new(id, name, destination);

        public TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, Destination destination, TravelDays days, Temperature temperature, Gender gender)
        {
            var data = new PolicyData(days, gender, temperature, destination);
            var applicablePolicies = _policies.Where(n => n.IsApplicable(data));

            var items = applicablePolicies.SelectMany(n => n.GenerateItems(data));

            var travelerCheckList = Create(id,name,destination);

            travelerCheckList.AddItems(items);

            return travelerCheckList;
        }
    }
}
