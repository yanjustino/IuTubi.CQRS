using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Application.Commands
{
    public class UploadVideoStreamCommand: Command
    {
        public Guid VideoId { get; set; }
        public Stream File { get; set; }
        public string FileName { get; set; }
    }
}
