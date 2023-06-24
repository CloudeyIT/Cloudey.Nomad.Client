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
    /// OperatorHealthReply
    /// </summary>
    [DataContract(Name = "OperatorHealthReply")]
    public partial class OperatorHealthReply : IEquatable<OperatorHealthReply>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorHealthReply" /> class.
        /// </summary>
        /// <param name="failureTolerance">failureTolerance.</param>
        /// <param name="healthy">healthy.</param>
        /// <param name="servers">servers.</param>
        public OperatorHealthReply(int failureTolerance = default(int), bool healthy = default(bool), List<ServerHealth> servers = default(List<ServerHealth>))
        {
            this.FailureTolerance = failureTolerance;
            this.Healthy = healthy;
            this.Servers = servers;
        }

        /// <summary>
        /// Gets or Sets FailureTolerance
        /// </summary>
        [DataMember(Name = "FailureTolerance", EmitDefaultValue = false)]
        public int FailureTolerance { get; set; }

        /// <summary>
        /// Gets or Sets Healthy
        /// </summary>
        [DataMember(Name = "Healthy", EmitDefaultValue = true)]
        public bool Healthy { get; set; }

        /// <summary>
        /// Gets or Sets Servers
        /// </summary>
        [DataMember(Name = "Servers", EmitDefaultValue = false)]
        public List<ServerHealth> Servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperatorHealthReply {\n");
            sb.Append("  FailureTolerance: ").Append(FailureTolerance).Append("\n");
            sb.Append("  Healthy: ").Append(Healthy).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
            return this.Equals(input as OperatorHealthReply);
        }

        /// <summary>
        /// Returns true if OperatorHealthReply instances are equal
        /// </summary>
        /// <param name="input">Instance of OperatorHealthReply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperatorHealthReply input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailureTolerance == input.FailureTolerance ||
                    this.FailureTolerance.Equals(input.FailureTolerance)
                ) && 
                (
                    this.Healthy == input.Healthy ||
                    this.Healthy.Equals(input.Healthy)
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
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
                hashCode = (hashCode * 59) + this.FailureTolerance.GetHashCode();
                hashCode = (hashCode * 59) + this.Healthy.GetHashCode();
                if (this.Servers != null)
                {
                    hashCode = (hashCode * 59) + this.Servers.GetHashCode();
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
            yield break;
        }
    }

}
