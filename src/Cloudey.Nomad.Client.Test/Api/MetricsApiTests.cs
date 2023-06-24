/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Cloudey.Nomad.Client.Client;
using Cloudey.Nomad.Client.Api;
// uncomment below to import models
//using Cloudey.Nomad.Client.Model;

namespace Cloudey.Nomad.Client.Test.Api
{
    /// <summary>
    ///  Class for testing MetricsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetricsApiTests : IDisposable
    {
        private MetricsApi instance;

        public MetricsApiTests()
        {
            instance = new MetricsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetricsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MetricsApi
            //Assert.IsType<MetricsApi>(instance);
        }

        /// <summary>
        /// Test GetMetricsSummary
        /// </summary>
        [Fact]
        public void GetMetricsSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //var response = instance.GetMetricsSummary(format);
            //Assert.IsType<MetricsSummary>(response);
        }
    }
}
