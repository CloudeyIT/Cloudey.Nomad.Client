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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloudey.Nomad.Client.Client.OpenAPIDateConverter;

namespace Cloudey.Nomad.Client.Model
{
    /// <summary>
    /// JobRegisterResponse
    /// </summary>
    [DataContract(Name = "JobRegisterResponse")]
    public partial class JobRegisterResponse : IEquatable<JobRegisterResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRegisterResponse" /> class.
        /// </summary>
        /// <param name="evalCreateIndex">evalCreateIndex.</param>
        /// <param name="evalID">evalID.</param>
        /// <param name="jobModifyIndex">jobModifyIndex.</param>
        /// <param name="knownLeader">knownLeader.</param>
        /// <param name="lastContact">lastContact.</param>
        /// <param name="lastIndex">lastIndex.</param>
        /// <param name="nextToken">nextToken.</param>
        /// <param name="requestTime">requestTime.</param>
        /// <param name="warnings">warnings.</param>
        public JobRegisterResponse(int evalCreateIndex = default(int), string evalID = default(string), int jobModifyIndex = default(int), bool knownLeader = default(bool), long lastContact = default(long), int lastIndex = default(int), string nextToken = default(string), long requestTime = default(long), string warnings = default(string))
        {
            this.EvalCreateIndex = evalCreateIndex;
            this.EvalID = evalID;
            this.JobModifyIndex = jobModifyIndex;
            this.KnownLeader = knownLeader;
            this.LastContact = lastContact;
            this.LastIndex = lastIndex;
            this.NextToken = nextToken;
            this.RequestTime = requestTime;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets EvalCreateIndex
        /// </summary>
        [DataMember(Name = "EvalCreateIndex", EmitDefaultValue = false)]
        public int EvalCreateIndex { get; set; }

        /// <summary>
        /// Gets or Sets EvalID
        /// </summary>
        [DataMember(Name = "EvalID", EmitDefaultValue = false)]
        public string EvalID { get; set; }

        /// <summary>
        /// Gets or Sets JobModifyIndex
        /// </summary>
        [DataMember(Name = "JobModifyIndex", EmitDefaultValue = false)]
        public int JobModifyIndex { get; set; }

        /// <summary>
        /// Gets or Sets KnownLeader
        /// </summary>
        [DataMember(Name = "KnownLeader", EmitDefaultValue = true)]
        public bool KnownLeader { get; set; }

        /// <summary>
        /// Gets or Sets LastContact
        /// </summary>
        [DataMember(Name = "LastContact", EmitDefaultValue = false)]
        public long LastContact { get; set; }

        /// <summary>
        /// Gets or Sets LastIndex
        /// </summary>
        [DataMember(Name = "LastIndex", EmitDefaultValue = false)]
        public int LastIndex { get; set; }

        /// <summary>
        /// Gets or Sets NextToken
        /// </summary>
        [DataMember(Name = "NextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Gets or Sets RequestTime
        /// </summary>
        [DataMember(Name = "RequestTime", EmitDefaultValue = false)]
        public long RequestTime { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "Warnings", EmitDefaultValue = false)]
        public string Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobRegisterResponse {\n");
            sb.Append("  EvalCreateIndex: ").Append(EvalCreateIndex).Append("\n");
            sb.Append("  EvalID: ").Append(EvalID).Append("\n");
            sb.Append("  JobModifyIndex: ").Append(JobModifyIndex).Append("\n");
            sb.Append("  KnownLeader: ").Append(KnownLeader).Append("\n");
            sb.Append("  LastContact: ").Append(LastContact).Append("\n");
            sb.Append("  LastIndex: ").Append(LastIndex).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobRegisterResponse);
        }

        /// <summary>
        /// Returns true if JobRegisterResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JobRegisterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobRegisterResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EvalCreateIndex == input.EvalCreateIndex ||
                    this.EvalCreateIndex.Equals(input.EvalCreateIndex)
                ) && 
                (
                    this.EvalID == input.EvalID ||
                    (this.EvalID != null &&
                    this.EvalID.Equals(input.EvalID))
                ) && 
                (
                    this.JobModifyIndex == input.JobModifyIndex ||
                    this.JobModifyIndex.Equals(input.JobModifyIndex)
                ) && 
                (
                    this.KnownLeader == input.KnownLeader ||
                    this.KnownLeader.Equals(input.KnownLeader)
                ) && 
                (
                    this.LastContact == input.LastContact ||
                    this.LastContact.Equals(input.LastContact)
                ) && 
                (
                    this.LastIndex == input.LastIndex ||
                    this.LastIndex.Equals(input.LastIndex)
                ) && 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    this.RequestTime.Equals(input.RequestTime)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    (this.Warnings != null &&
                    this.Warnings.Equals(input.Warnings))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.EvalCreateIndex.GetHashCode();
                if (this.EvalID != null)
                {
                    hashCode = (hashCode * 59) + this.EvalID.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JobModifyIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.KnownLeader.GetHashCode();
                hashCode = (hashCode * 59) + this.LastContact.GetHashCode();
                hashCode = (hashCode * 59) + this.LastIndex.GetHashCode();
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestTime.GetHashCode();
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // EvalCreateIndex (int) maximum
            if (this.EvalCreateIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvalCreateIndex, must be a value less than or equal to 384.", new [] { "EvalCreateIndex" });
            }

            // EvalCreateIndex (int) minimum
            if (this.EvalCreateIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvalCreateIndex, must be a value greater than or equal to 0.", new [] { "EvalCreateIndex" });
            }

            // JobModifyIndex (int) maximum
            if (this.JobModifyIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JobModifyIndex, must be a value less than or equal to 384.", new [] { "JobModifyIndex" });
            }

            // JobModifyIndex (int) minimum
            if (this.JobModifyIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JobModifyIndex, must be a value greater than or equal to 0.", new [] { "JobModifyIndex" });
            }

            // LastIndex (int) maximum
            if (this.LastIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastIndex, must be a value less than or equal to 384.", new [] { "LastIndex" });
            }

            // LastIndex (int) minimum
            if (this.LastIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastIndex, must be a value greater than or equal to 0.", new [] { "LastIndex" });
            }

            yield break;
        }
    }

}
