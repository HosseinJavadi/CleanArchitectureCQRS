using CleanArchitectureCQRS.Domain.ValueObjects;

namespace CleanArchitectureCQRS.Domain.Policies.Gender
{
    public sealed class FemaleGenderPolicy : ITravelerItemPolicy
    {
        public bool IsApplicable(PolicyData data)
           => data.Gender == Consts.Gender.Female;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
           => new List<TravelerItem>
           {
               new TravelerItem("Lipstick",1),
               new TravelerItem("Powder",1),
               new TravelerItem("Eyeliner",1),
           };


    }
}
