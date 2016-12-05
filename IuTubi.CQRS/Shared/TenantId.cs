using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Domain.Models
{
    public class TenantId
    {
        public Guid Id { get; private set; }

        public TenantId(Guid id)
        {

        }
    }
}
