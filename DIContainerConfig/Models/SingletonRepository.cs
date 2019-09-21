using System;

namespace DIContainerConfig.Models
{
    public class SingletonRepository : ISingletonRepository
    {
        public Guid Id { get; set; }
        public SingletonRepository()
        {
            Id = Guid.NewGuid();
        }

    }

}
