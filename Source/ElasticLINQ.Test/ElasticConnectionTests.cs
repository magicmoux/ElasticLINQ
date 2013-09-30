﻿// Copyright (c) Tier 3 Inc. All rights reserved.
// This source code is made available under the terms of the Microsoft Public License (MS-PL)

using ElasticLinq;
using System;
using Xunit;

namespace ElasticLINQ.Test
{
    public class ElasticConnectionTests
    {
        [Fact]
        public void ConstructorSetsProperties()
        {
            var expectedEndpoint = new Uri("http://localhost:1234/abc");
            var expectedTimeout = TimeSpan.FromSeconds(19.2);
            const string expectedIndex = "myIndex";

            var connection = new ElasticConnection(expectedEndpoint, expectedTimeout, expectedIndex);

            Assert.Equal(expectedEndpoint, connection.Endpoint);
            Assert.Equal(expectedTimeout, connection.Timeout);
            Assert.Equal(expectedIndex, connection.Index);
        }
    }
}