using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.CommandStack.Application.Services
{
    public interface IFileStorageService
    {
        string Send(Stream stream, string name);

    }
}
