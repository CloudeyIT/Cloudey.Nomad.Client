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
    /// CSIVolumeRegisterRequest
    /// </summary>
    [DataContract(Name = "CSIVolumeRegisterRequest")]
    public partial class CSIVolumeRegisterRequest : IEquatable<CSIVolumeRegisterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSIVolumeRegisterRequest" /> class.
        /// </summary>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="region">region.</param>
        /// <param name="secretID">secretID.</param>
        /// <param name="volumes">volumes.</param>
        public CSIVolumeRegisterRequest(string _namespace = default(string), string region = default(string), string secretID = default(string), List<CSIVolume> volumes = default(List<CSIVolume>))
        {
            this.Namespace = _namespace;
            this.Region = region;
            this.SecretID = secretID;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "Namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "Region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets SecretID
        /// </summary>
        [DataMember(Name = "SecretID", EmitDefaultValue = false)]
        public string SecretID { get; set; }

        /// <summary>
        /// Gets or Sets Volumes
        /// </summary>
        [DataMember(Name = "Volumes", EmitDefaultValue = false)]
        public List<CSIVolume> Volumes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CSIVolumeRegisterRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SecretID: ").Append(SecretID).Append("\n");
            sb.Append("  Volumes: ").Append(Volumes).Append("\n");
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
            return this.Equals(input as CSIVolumeRegisterRequest);
        }

        /// <summary>
        /// Returns true if CSIVolumeRegisterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSIVolumeRegisterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSIVolumeRegisterRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SecretID == input.SecretID ||
                    (this.SecretID != null &&
                    this.SecretID.Equals(input.SecretID))
                ) && 
                (
                    this.Volumes == input.Volumes ||
                    this.Volumes != null &&
                    input.Volumes != null &&
                    this.Volumes.SequenceEqual(input.Volumes)
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
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.SecretID != null)
                {
                    hashCode = (hashCode * 59) + this.SecretID.GetHashCode();
                }
                if (this.Volumes != null)
                {
                    hashCode = (hashCode * 59) + this.Volumes.GetHashCode();
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
