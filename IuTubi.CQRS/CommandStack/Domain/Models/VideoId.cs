using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Domain.Models
{
    public class VideoId
    {
        public Guid Id { get; private set; }

        public VideoId(Guid id)
        {
            Id = id;
        }

        public VideoId() : this(Guid.NewGuid())
        {

        }
    }
}
