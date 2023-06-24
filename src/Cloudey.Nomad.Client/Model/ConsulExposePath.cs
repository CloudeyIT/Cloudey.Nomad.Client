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
    /// ConsulExposePath
    /// </summary>
    [DataContract(Name = "ConsulExposePath")]
    public partial class ConsulExposePath : IEquatable<ConsulExposePath>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsulExposePath" /> class.
        /// </summary>
        /// <param name="listenerPort">listenerPort.</param>
        /// <param name="localPathPort">localPathPort.</param>
        /// <param name="path">path.</param>
        /// <param name="protocol">protocol.</param>
        public ConsulExposePath(string listenerPort = default(string), int localPathPort = default(int), string path = default(string), string protocol = default(string))
        {
            this.ListenerPort = listenerPort;
            this.LocalPathPort = localPathPort;
            this.Path = path;
            this.Protocol = protocol;
        }

        /// <summary>
        /// Gets or Sets ListenerPort
        /// </summary>
        [DataMember(Name = "ListenerPort", EmitDefaultValue = false)]
        public string ListenerPort { get; set; }

        /// <summary>
        /// Gets or Sets LocalPathPort
        /// </summary>
        [DataMember(Name = "LocalPathPort", EmitDefaultValue = false)]
        public int LocalPathPort { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "Path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "Protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsulExposePath {\n");
            sb.Append("  ListenerPort: ").Append(ListenerPort).Append("\n");
            sb.Append("  LocalPathPort: ").Append(LocalPathPort).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
            return this.Equals(input as ConsulExposePath);
        }

        /// <summary>
        /// Returns true if ConsulExposePath instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsulExposePath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsulExposePath input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ListenerPort == input.ListenerPort ||
                    (this.ListenerPort != null &&
                    this.ListenerPort.Equals(input.ListenerPort))
                ) && 
                (
                    this.LocalPathPort == input.LocalPathPort ||
                    this.LocalPathPort.Equals(input.LocalPathPort)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.ListenerPort != null)
                {
                    hashCode = (hashCode * 59) + this.ListenerPort.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LocalPathPort.GetHashCode();
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Protocol != null)
                {
                    hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
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
