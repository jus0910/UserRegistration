using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Interfaces
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        int CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        int UpdatedBy { get; set; }
    }
}
