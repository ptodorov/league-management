using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public interface IFileStorage
    {
        Task<string> Write(string key, string extension, Stream fileStream);

        Task<Stream> Read(string path);
    }
}
