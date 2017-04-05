﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;

namespace HDInsight.Tests.Helpers
{
    public class CredentialAdapter : SubscriptionCloudCredentials
    {
        ServiceClientCredentials _credentials;
        string _subscriptionId;

        public CredentialAdapter(ServiceClientCredentials wrapped, string subscriptionId)
        {
            _credentials = wrapped;
            _subscriptionId = subscriptionId;
        }

        public override string SubscriptionId
        {
            get
            {
                return _subscriptionId;
            }
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return _credentials.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}