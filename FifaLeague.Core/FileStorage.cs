﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    class FileStorage : IFileStorage
    {
        private readonly string _baseFilePath;

        public FileStorage()
        {
            _baseFilePath = ConfigurationManager.AppSettings["BaseFilePath"];
        }

        public async Task<Stream> Read(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                await fs.ReadAsync(buffer, 0, (int)fs.Length);
                return new MemoryStream(buffer, false);
            }
        }

        public async Task<string> Write(string key, string extension, Stream fileStream)
        {
            string filePath = Path.Combine(_baseFilePath, key + '.' + extension);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                fileStream.Seek(0, SeekOrigin.Begin);
                await fileStream.CopyToAsync(fs);
            }

            return filePath;
        }
    }
}
