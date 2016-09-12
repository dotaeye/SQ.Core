using System;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;

namespace SQ.Core.Upload
{
    public class SQStreamProvider : MultipartFileStreamProvider
    {
        public SQStreamProvider(string uploadPath) : base(uploadPath)
        {
        }
        public override string GetLocalFileName(HttpContentHeaders headers)
        {
            string fileName = Guid.NewGuid().ToString()
                + Path.GetExtension(headers.ContentDisposition.FileName.Replace("\"", string.Empty));
            return fileName;
        }
    }
}
