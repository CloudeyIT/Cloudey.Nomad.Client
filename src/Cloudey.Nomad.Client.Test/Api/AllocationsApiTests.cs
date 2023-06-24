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
    ///  Class for testing AllocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AllocationsApiTests : IDisposable
    {
        private AllocationsApi instance;

        public AllocationsApiTests()
        {
            instance = new AllocationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AllocationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AllocationsApi
            //Assert.IsType<AllocationsApi>(instance);
        }

        /// <summary>
        /// Test GetAllocation
        /// </summary>
        [Fact]
        public void GetAllocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string allocID = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetAllocation(allocID, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<Allocation>(response);
        }

        /// <summary>
        /// Test GetAllocationServices
        /// </summary>
        [Fact]
        public void GetAllocationServicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string allocID = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetAllocationServices(allocID, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<ServiceRegistration>>(response);
        }

        /// <summary>
        /// Test GetAllocations
        /// </summary>
        [Fact]
        public void GetAllocationsTest()
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
            //bool? resources = null;
            //bool? taskStates = null;
            //var response = instance.GetAllocations(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, resources, taskStates);
            //Assert.IsType<List<AllocationListStub>>(response);
        }

        /// <summary>
        /// Test PostAllocationStop
        /// </summary>
        [Fact]
        public void PostAllocationStopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string allocID = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //bool? noShutdownDelay = null;
            //var response = instance.PostAllocationStop(allocID, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, noShutdownDelay);
            //Assert.IsType<AllocStopResponse>(response);
        }
    }
}
