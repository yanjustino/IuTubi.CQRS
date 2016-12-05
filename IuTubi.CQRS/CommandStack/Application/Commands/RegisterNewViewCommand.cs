using System;

namespace IuTubi.CQRS.CommandStack.Application.Commands
{
    public class RegisterNewViewCommand : Command
    {
        public Guid VideoId { get; set; }
    }
}
