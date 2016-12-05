using IuTubi.CQRS.CommandStack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Domain.Repositories
{
    public interface IVideoRepository
    {
        void Register(Video video);
        void Update(Video video);
        Video FindById(VideoId id);
        void RegisterNewView(VideoId id);
    }
}
