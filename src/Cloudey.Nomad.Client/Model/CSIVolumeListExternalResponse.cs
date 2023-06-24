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
    /// CSIVolumeListExternalResponse
    /// </summary>
    [DataContract(Name = "CSIVolumeListExternalResponse")]
    public partial class CSIVolumeListExternalResponse : IEquatable<CSIVolumeListExternalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSIVolumeListExternalResponse" /> class.
        /// </summary>
        /// <param name="nextToken">nextToken.</param>
        /// <param name="volumes">volumes.</param>
        public CSIVolumeListExternalResponse(string nextToken = default(string), List<CSIVolumeExternalStub> volumes = default(List<CSIVolumeExternalStub>))
        {
            this.NextToken = nextToken;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Gets or Sets NextToken
        /// </summary>
        [DataMember(Name = "NextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Gets or Sets Volumes
        /// </summary>
        [DataMember(Name = "Volumes", EmitDefaultValue = false)]
        public List<CSIVolumeExternalStub> Volumes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CSIVolumeListExternalResponse {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as CSIVolumeListExternalResponse);
        }

        /// <summary>
        /// Returns true if CSIVolumeListExternalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CSIVolumeListExternalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSIVolumeListExternalResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
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
