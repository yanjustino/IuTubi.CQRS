using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Domain.Models
{
    public class VideoFile
    {
        public Guid Id { get; private set; }
        public VideoId VideoId { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Thumbnail { get; private set; }

        public VideoFile(VideoId videoId, string name, string address)
        {
            Id = new Guid();
            Name = name;
            Address = address;
            Thumbnail = address + "/thumb";
        }

    }
}
