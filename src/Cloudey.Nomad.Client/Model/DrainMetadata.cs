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
    /// DrainMetadata
    /// </summary>
    [DataContract(Name = "DrainMetadata")]
    public partial class DrainMetadata : IEquatable<DrainMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrainMetadata" /> class.
        /// </summary>
        /// <param name="accessorID">accessorID.</param>
        /// <param name="meta">meta.</param>
        /// <param name="startedAt">startedAt.</param>
        /// <param name="status">status.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public DrainMetadata(string accessorID = default(string), Dictionary<string, string> meta = default(Dictionary<string, string>), DateTime startedAt = default(DateTime), string status = default(string), DateTime updatedAt = default(DateTime))
        {
            this.AccessorID = accessorID;
            this.Meta = meta;
            this.StartedAt = startedAt;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets AccessorID
        /// </summary>
        [DataMember(Name = "AccessorID", EmitDefaultValue = false)]
        public string AccessorID { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "Meta", EmitDefaultValue = false)]
        public Dictionary<string, string> Meta { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
        public DateTime StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DrainMetadata {\n");
            sb.Append("  AccessorID: ").Append(AccessorID).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as DrainMetadata);
        }

        /// <summary>
        /// Returns true if DrainMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of DrainMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrainMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessorID == input.AccessorID ||
                    (this.AccessorID != null &&
                    this.AccessorID.Equals(input.AccessorID))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AccessorID != null)
                {
                    hashCode = (hashCode * 59) + this.AccessorID.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.StartedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartedAt.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
