using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNotesApplication
{
    class FileToUpload
    {
        private byte[] bytes;
        private string contentType;

        public FileToUpload(byte[] bytes, string contentType)
        {
            this.bytes = bytes;
            this.contentType = contentType;
        }

        public byte[] Bytes { get => bytes; set => bytes = value; }
        public string ContentType { get => contentType; set => contentType = value; }
    }
}
