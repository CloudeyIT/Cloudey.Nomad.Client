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
    ///  Class for testing DeploymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DeploymentsApiTests : IDisposable
    {
        private DeploymentsApi instance;

        public DeploymentsApiTests()
        {
            instance = new DeploymentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeploymentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DeploymentsApi
            //Assert.IsType<DeploymentsApi>(instance);
        }

        /// <summary>
        /// Test GetDeployment
        /// </summary>
        [Fact]
        public void GetDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetDeployment(deploymentID, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<Deployment>(response);
        }

        /// <summary>
        /// Test GetDeploymentAllocations
        /// </summary>
        [Fact]
        public void GetDeploymentAllocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetDeploymentAllocations(deploymentID, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<AllocationListStub>>(response);
        }

        /// <summary>
        /// Test GetDeployments
        /// </summary>
        [Fact]
        public void GetDeploymentsTest()
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
            //var response = instance.GetDeployments(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<Deployment>>(response);
        }

        /// <summary>
        /// Test PostDeploymentAllocationHealth
        /// </summary>
        [Fact]
        public void PostDeploymentAllocationHealthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //DeploymentAllocHealthRequest deploymentAllocHealthRequest = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //var response = instance.PostDeploymentAllocationHealth(deploymentID, deploymentAllocHealthRequest, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<DeploymentUpdateResponse>(response);
        }

        /// <summary>
        /// Test PostDeploymentFail
        /// </summary>
        [Fact]
        public void PostDeploymentFailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //var response = instance.PostDeploymentFail(deploymentID, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<DeploymentUpdateResponse>(response);
        }

        /// <summary>
        /// Test PostDeploymentPause
        /// </summary>
        [Fact]
        public void PostDeploymentPauseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //DeploymentPauseRequest deploymentPauseRequest = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //var response = instance.PostDeploymentPause(deploymentID, deploymentPauseRequest, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<DeploymentUpdateResponse>(response);
        }

        /// <summary>
        /// Test PostDeploymentPromote
        /// </summary>
        [Fact]
        public void PostDeploymentPromoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //DeploymentPromoteRequest deploymentPromoteRequest = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //var response = instance.PostDeploymentPromote(deploymentID, deploymentPromoteRequest, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<DeploymentUpdateResponse>(response);
        }

        /// <summary>
        /// Test PostDeploymentUnblock
        /// </summary>
        [Fact]
        public void PostDeploymentUnblockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentID = null;
            //DeploymentUnblockRequest deploymentUnblockRequest = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //var response = instance.PostDeploymentUnblock(deploymentID, deploymentUnblockRequest, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<DeploymentUpdateResponse>(response);
        }
    }
}
