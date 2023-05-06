using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Shared.Abstractions.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
        public int Version { get; protected set; }

        private bool _versionIncremented;

        private readonly List<IDomainEvent> _events;

        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent @event)
        {
            if(!_events.Any() && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;
            }

            _events.Add(@event);
        }
        protected void IncrementVersion()
        {
            if(_versionIncremented)
                return;

            Version++;
            _versionIncremented = true;
        }
    }
}
