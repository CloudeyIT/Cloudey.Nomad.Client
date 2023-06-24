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
    /// Resources
    /// </summary>
    [DataContract(Name = "Resources")]
    public partial class Resources : IEquatable<Resources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resources" /> class.
        /// </summary>
        /// <param name="cPU">cPU.</param>
        /// <param name="cores">cores.</param>
        /// <param name="devices">devices.</param>
        /// <param name="diskMB">diskMB.</param>
        /// <param name="iOPS">iOPS.</param>
        /// <param name="memoryMB">memoryMB.</param>
        /// <param name="memoryMaxMB">memoryMaxMB.</param>
        /// <param name="networks">networks.</param>
        public Resources(int cPU = default(int), int cores = default(int), List<RequestedDevice> devices = default(List<RequestedDevice>), int diskMB = default(int), int iOPS = default(int), int memoryMB = default(int), int memoryMaxMB = default(int), List<NetworkResource> networks = default(List<NetworkResource>))
        {
            this.CPU = cPU;
            this.Cores = cores;
            this.Devices = devices;
            this.DiskMB = diskMB;
            this.IOPS = iOPS;
            this.MemoryMB = memoryMB;
            this.MemoryMaxMB = memoryMaxMB;
            this.Networks = networks;
        }

        /// <summary>
        /// Gets or Sets CPU
        /// </summary>
        [DataMember(Name = "CPU", EmitDefaultValue = false)]
        public int CPU { get; set; }

        /// <summary>
        /// Gets or Sets Cores
        /// </summary>
        [DataMember(Name = "Cores", EmitDefaultValue = false)]
        public int Cores { get; set; }

        /// <summary>
        /// Gets or Sets Devices
        /// </summary>
        [DataMember(Name = "Devices", EmitDefaultValue = false)]
        public List<RequestedDevice> Devices { get; set; }

        /// <summary>
        /// Gets or Sets DiskMB
        /// </summary>
        [DataMember(Name = "DiskMB", EmitDefaultValue = false)]
        public int DiskMB { get; set; }

        /// <summary>
        /// Gets or Sets IOPS
        /// </summary>
        [DataMember(Name = "IOPS", EmitDefaultValue = false)]
        public int IOPS { get; set; }

        /// <summary>
        /// Gets or Sets MemoryMB
        /// </summary>
        [DataMember(Name = "MemoryMB", EmitDefaultValue = false)]
        public int MemoryMB { get; set; }

        /// <summary>
        /// Gets or Sets MemoryMaxMB
        /// </summary>
        [DataMember(Name = "MemoryMaxMB", EmitDefaultValue = false)]
        public int MemoryMaxMB { get; set; }

        /// <summary>
        /// Gets or Sets Networks
        /// </summary>
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
        public List<NetworkResource> Networks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Resources {\n");
            sb.Append("  CPU: ").Append(CPU).Append("\n");
            sb.Append("  Cores: ").Append(Cores).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  DiskMB: ").Append(DiskMB).Append("\n");
            sb.Append("  IOPS: ").Append(IOPS).Append("\n");
            sb.Append("  MemoryMB: ").Append(MemoryMB).Append("\n");
            sb.Append("  MemoryMaxMB: ").Append(MemoryMaxMB).Append("\n");
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
            return this.Equals(input as Resources);
        }

        /// <summary>
        /// Returns true if Resources instances are equal
        /// </summary>
        /// <param name="input">Instance of Resources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Resources input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CPU == input.CPU ||
                    this.CPU.Equals(input.CPU)
                ) && 
                (
                    this.Cores == input.Cores ||
                    this.Cores.Equals(input.Cores)
                ) && 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    input.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
                ) && 
                (
                    this.DiskMB == input.DiskMB ||
                    this.DiskMB.Equals(input.DiskMB)
                ) && 
                (
                    this.IOPS == input.IOPS ||
                    this.IOPS.Equals(input.IOPS)
                ) && 
                (
                    this.MemoryMB == input.MemoryMB ||
                    this.MemoryMB.Equals(input.MemoryMB)
                ) && 
                (
                    this.MemoryMaxMB == input.MemoryMaxMB ||
                    this.MemoryMaxMB.Equals(input.MemoryMaxMB)
                ) && 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
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
                hashCode = (hashCode * 59) + this.CPU.GetHashCode();
                hashCode = (hashCode * 59) + this.Cores.GetHashCode();
                if (this.Devices != null)
                {
                    hashCode = (hashCode * 59) + this.Devices.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DiskMB.GetHashCode();
                hashCode = (hashCode * 59) + this.IOPS.GetHashCode();
                hashCode = (hashCode * 59) + this.MemoryMB.GetHashCode();
                hashCode = (hashCode * 59) + this.MemoryMaxMB.GetHashCode();
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