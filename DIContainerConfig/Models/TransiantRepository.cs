using System;

namespace DIContainerConfig.Models
{
    public class TransiantRepository : ITransiantRepository
    {
        public Guid Id { get; set; }

        public TransiantRepository()
        {
            Id = Guid.NewGuid();
        }
    }

}
