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

namespace Cloudey.Nomad.Client.Test.Api
{
    /// <summary>
    ///  Class for testing StatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StatusApiTests : IDisposable
    {
        private StatusApi instance;

        public StatusApiTests()
        {
            instance = new StatusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StatusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StatusApi
            //Assert.IsType<StatusApi>(instance);
        }

        /// <summary>
        /// Test GetStatusLeader
        /// </summary>
        [Fact]
        public void GetStatusLeaderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetStatusLeader(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetStatusPeers
        /// </summary>
        [Fact]
        public void GetStatusPeersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetStatusPeers(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<string>>(response);
        }
    }
}
