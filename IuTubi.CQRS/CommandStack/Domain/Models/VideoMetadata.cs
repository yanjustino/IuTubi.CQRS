using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Domain.Models
{
    public class VideoMetadata
    {
        public Guid Id { get; private set; }
        public VideoId VideoId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime RegisteredOn { get; private set; }
        public bool IsPrivate { get; private set; }

        public VideoMetadata(VideoId videoId, string title, string description, bool isPrivate)
        {
            Id = Guid.NewGuid();
            VideoId = videoId;
            IsPrivate = isPrivate;
            Title = title;
            Description = description;
            RegisteredOn = DateTime.Now;
        }
    }
}
