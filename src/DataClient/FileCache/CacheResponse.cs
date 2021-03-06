﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Data
{
    /// <summary>
    /// Simulated response from the cache.
    /// </summary>
    public sealed class CacheResponse : HttpResponseMessage
    {
        public CacheResponse(Stream stream)
            : base(HttpStatusCode.OK)
        {
            Headers.Add("X-NuGet-FileCache", "true");
            Content = new StreamContent(stream);
        }
    }
}
