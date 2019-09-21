using System;

namespace DIContainerConfig.Models
{
    public class ScopeRepository : IScopeRepository
    {
        public Guid Id { get; set; }
        public ScopeRepository()
        {
            Id = Guid.NewGuid();
        }
    }

}
