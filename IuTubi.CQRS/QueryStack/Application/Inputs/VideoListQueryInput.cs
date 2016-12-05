using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.QueryStack.Application.Inputs
{
    public class VideoListQueryInput
    {
        public Guid TenantId { get; set; }
    }
}
