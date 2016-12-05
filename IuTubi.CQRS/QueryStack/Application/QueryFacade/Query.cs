using IuTubi.CQRS.CommandStack.Domain.Models;
using IuTubi.CQRS.QueryStack.Application.Outputs;
using System.Collections.Generic;

namespace IuTubi.CQRS.QueryStack.Application.QueryFacade
{
    public class Query
    {
        public List<VideoItemDto> GetVideos(TenantId tenant)
        {
            //TODO: Thin Data Layer
            return null;
        }

    }
}
