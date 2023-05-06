using CleanArchitectureCQRS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Policies.Gender
{
    public sealed class MaleGenderPolicy : ITravelerItemPolicy
    {
        public bool IsApplicable(PolicyData data)
           => data.Gender == Consts.Gender.Male;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
           => new List<TravelerItem>
           { 
               new TravelerItem("Laptop",1),
               new TravelerItem("Drink", 10),
               new TravelerItem("Book",(uint) Math.Ceiling(data.Days/7m))
           };


    }
}
