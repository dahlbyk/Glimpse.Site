﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Glimpse.Release.Support
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetAsync(string uri);
    }
}