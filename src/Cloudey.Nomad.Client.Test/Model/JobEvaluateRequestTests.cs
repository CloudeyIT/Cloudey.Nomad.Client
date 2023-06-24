/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Cloudey.Nomad.Client.Model;
using Cloudey.Nomad.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Cloudey.Nomad.Client.Test.Model
{
    /// <summary>
    ///  Class for testing JobEvaluateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JobEvaluateRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for JobEvaluateRequest
        //private JobEvaluateRequest instance;

        public JobEvaluateRequestTests()
        {
            // TODO uncomment below to create an instance of JobEvaluateRequest
            //instance = new JobEvaluateRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JobEvaluateRequest
        /// </summary>
        [Fact]
        public void JobEvaluateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" JobEvaluateRequest
            //Assert.IsType<JobEvaluateRequest>(instance);
        }


        /// <summary>
        /// Test the property 'EvalOptions'
        /// </summary>
        [Fact]
        public void EvalOptionsTest()
        {
            // TODO unit test for the property 'EvalOptions'
        }
        /// <summary>
        /// Test the property 'JobID'
        /// </summary>
        [Fact]
        public void JobIDTest()
        {
            // TODO unit test for the property 'JobID'
        }
        /// <summary>
        /// Test the property 'Namespace'
        /// </summary>
        [Fact]
        public void NamespaceTest()
        {
            // TODO unit test for the property 'Namespace'
        }
        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Fact]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }
        /// <summary>
        /// Test the property 'SecretID'
        /// </summary>
        [Fact]
        public void SecretIDTest()
        {
            // TODO unit test for the property 'SecretID'
        }

    }

}