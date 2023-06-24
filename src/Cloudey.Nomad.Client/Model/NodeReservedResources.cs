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
    /// NodeReservedResources
    /// </summary>
    [DataContract(Name = "NodeReservedResources")]
    public partial class NodeReservedResources : IEquatable<NodeReservedResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeReservedResources" /> class.
        /// </summary>
        /// <param name="cpu">cpu.</param>
        /// <param name="disk">disk.</param>
        /// <param name="memory">memory.</param>
        /// <param name="networks">networks.</param>
        public NodeReservedResources(NodeReservedCpuResources cpu = default(NodeReservedCpuResources), NodeReservedDiskResources disk = default(NodeReservedDiskResources), NodeReservedMemoryResources memory = default(NodeReservedMemoryResources), NodeReservedNetworkResources networks = default(NodeReservedNetworkResources))
        {
            this.Cpu = cpu;
            this.Disk = disk;
            this.Memory = memory;
            this.Networks = networks;
        }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name = "Cpu", EmitDefaultValue = false)]
        public NodeReservedCpuResources Cpu { get; set; }

        /// <summary>
        /// Gets or Sets Disk
        /// </summary>
        [DataMember(Name = "Disk", EmitDefaultValue = false)]
        public NodeReservedDiskResources Disk { get; set; }

        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name = "Memory", EmitDefaultValue = false)]
        public NodeReservedMemoryResources Memory { get; set; }

        /// <summary>
        /// Gets or Sets Networks
        /// </summary>
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
        public NodeReservedNetworkResources Networks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeReservedResources {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Disk: ").Append(Disk).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
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
            return this.Equals(input as NodeReservedResources);
        }

        /// <summary>
        /// Returns true if NodeReservedResources instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeReservedResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeReservedResources input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Disk == input.Disk ||
                    (this.Disk != null &&
                    this.Disk.Equals(input.Disk))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && 
                (
                    this.Networks == input.Networks ||
                    (this.Networks != null &&
                    this.Networks.Equals(input.Networks))
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
                if (this.Cpu != null)
                {
                    hashCode = (hashCode * 59) + this.Cpu.GetHashCode();
                }
                if (this.Disk != null)
                {
                    hashCode = (hashCode * 59) + this.Disk.GetHashCode();
                }
                if (this.Memory != null)
                {
                    hashCode = (hashCode * 59) + this.Memory.GetHashCode();
                }
                if (this.Networks != null)
                {
                    hashCode = (hashCode * 59) + this.Networks.GetHashCode();
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
