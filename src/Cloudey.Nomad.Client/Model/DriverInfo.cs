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
    /// DriverInfo
    /// </summary>
    [DataContract(Name = "DriverInfo")]
    public partial class DriverInfo : IEquatable<DriverInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriverInfo" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="detected">detected.</param>
        /// <param name="healthDescription">healthDescription.</param>
        /// <param name="healthy">healthy.</param>
        /// <param name="updateTime">updateTime.</param>
        public DriverInfo(Dictionary<string, string> attributes = default(Dictionary<string, string>), bool detected = default(bool), string healthDescription = default(string), bool healthy = default(bool), DateTime updateTime = default(DateTime))
        {
            this.Attributes = attributes;
            this.Detected = detected;
            this.HealthDescription = healthDescription;
            this.Healthy = healthy;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "Attributes", EmitDefaultValue = false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Detected
        /// </summary>
        [DataMember(Name = "Detected", EmitDefaultValue = true)]
        public bool Detected { get; set; }

        /// <summary>
        /// Gets or Sets HealthDescription
        /// </summary>
        [DataMember(Name = "HealthDescription", EmitDefaultValue = false)]
        public string HealthDescription { get; set; }

        /// <summary>
        /// Gets or Sets Healthy
        /// </summary>
        [DataMember(Name = "Healthy", EmitDefaultValue = true)]
        public bool Healthy { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "UpdateTime", EmitDefaultValue = false)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DriverInfo {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Detected: ").Append(Detected).Append("\n");
            sb.Append("  HealthDescription: ").Append(HealthDescription).Append("\n");
            sb.Append("  Healthy: ").Append(Healthy).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
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
            return this.Equals(input as DriverInfo);
        }

        /// <summary>
        /// Returns true if DriverInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DriverInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DriverInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Detected == input.Detected ||
                    this.Detected.Equals(input.Detected)
                ) && 
                (
                    this.HealthDescription == input.HealthDescription ||
                    (this.HealthDescription != null &&
                    this.HealthDescription.Equals(input.HealthDescription))
                ) && 
                (
                    this.Healthy == input.Healthy ||
                    this.Healthy.Equals(input.Healthy)
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Detected.GetHashCode();
                if (this.HealthDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HealthDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Healthy.GetHashCode();
                if (this.UpdateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateTime.GetHashCode();
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