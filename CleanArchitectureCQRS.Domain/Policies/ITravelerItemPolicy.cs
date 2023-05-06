using CleanArchitectureCQRS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Policies
{
    public interface ITravelerItemPolicy
    {
        bool IsApplicable(PolicyData data);

        IEnumerable<TravelerItem> GenerateItems(PolicyData data);
    }
}
