// Copyright 2016 UpDownLeftRight.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Net;

namespace UDLRPlugin
{
  public class HttpClient : IClient
  {
    public string ApiServer { get; private set; }

    public HttpClient(HttpClientBuilder builder)
    {
      ApiServer = builder.apiServer;
    }

    public void Execute<T>(IRequest<T> request, Action<T> callback, Action<Exception> errback) 
    {
      string uriScheme = String.Format("https://{0}", ApiServer);
      HttpWebRequest webRequest = (HttpWebRequest) WebRequest.Create(uriScheme);
    }

    public static HttpClientBuilder Builder()
    {
      return new HttpClientBuilder();
    }
  }
}
