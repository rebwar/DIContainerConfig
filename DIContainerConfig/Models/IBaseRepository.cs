using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIContainerConfig.Models
{
    public interface IBaseRepository
    {
         Guid Id { get; set; }
    }
}
