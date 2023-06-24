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
    /// AllocatedDeviceResource
    /// </summary>
    [DataContract(Name = "AllocatedDeviceResource")]
    public partial class AllocatedDeviceResource : IEquatable<AllocatedDeviceResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocatedDeviceResource" /> class.
        /// </summary>
        /// <param name="deviceIDs">deviceIDs.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="vendor">vendor.</param>
        public AllocatedDeviceResource(List<string> deviceIDs = default(List<string>), string name = default(string), string type = default(string), string vendor = default(string))
        {
            this.DeviceIDs = deviceIDs;
            this.Name = name;
            this.Type = type;
            this.Vendor = vendor;
        }

        /// <summary>
        /// Gets or Sets DeviceIDs
        /// </summary>
        [DataMember(Name = "DeviceIDs", EmitDefaultValue = false)]
        public List<string> DeviceIDs { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "Vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AllocatedDeviceResource {\n");
            sb.Append("  DeviceIDs: ").Append(DeviceIDs).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
            return this.Equals(input as AllocatedDeviceResource);
        }

        /// <summary>
        /// Returns true if AllocatedDeviceResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AllocatedDeviceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocatedDeviceResource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceIDs == input.DeviceIDs ||
                    this.DeviceIDs != null &&
                    input.DeviceIDs != null &&
                    this.DeviceIDs.SequenceEqual(input.DeviceIDs)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
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
                if (this.DeviceIDs != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceIDs.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
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
