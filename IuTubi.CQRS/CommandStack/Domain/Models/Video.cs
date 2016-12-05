using IuTubi.CQRS.CommandStack.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Domain.Models
{
    public class Video
    {
        public VideoId Id { get; private set; }
        public VideoMetadata Metadata { get; private set; }
        public VideoFile File { get; private set; }
        public TenantId Tenant { get; private set; }

        public void AttachFile(VideoFile videoFile)
        {
            File = videoFile;
        }


        public static class Factory
        {
            public static Video New(RegisterVideoMetadataCommand command)
            {
                var id = new VideoId();

                return new Video
                {
                    Id = id,
                    Metadata = new VideoMetadata(id, command.Title, command.Description, command.IsPrivate),
                    Tenant = new TenantId(command.Tenant)
                };
            }
        }

    }
}
