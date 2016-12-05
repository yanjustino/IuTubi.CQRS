using System;

namespace IuTubi.CQRS.CommandStack.Application.Commands
{
    public class RegisterVideoMetadataCommand : Command
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPrivate { get; set; }
        public Guid Tenant { get; set; }
    }
}
