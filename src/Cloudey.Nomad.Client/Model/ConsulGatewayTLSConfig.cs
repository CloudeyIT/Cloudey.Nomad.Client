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
    /// ConsulGatewayTLSConfig
    /// </summary>
    [DataContract(Name = "ConsulGatewayTLSConfig")]
    public partial class ConsulGatewayTLSConfig : IEquatable<ConsulGatewayTLSConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsulGatewayTLSConfig" /> class.
        /// </summary>
        /// <param name="cipherSuites">cipherSuites.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="tLSMaxVersion">tLSMaxVersion.</param>
        /// <param name="tLSMinVersion">tLSMinVersion.</param>
        public ConsulGatewayTLSConfig(List<string> cipherSuites = default(List<string>), bool enabled = default(bool), string tLSMaxVersion = default(string), string tLSMinVersion = default(string))
        {
            this.CipherSuites = cipherSuites;
            this.Enabled = enabled;
            this.TLSMaxVersion = tLSMaxVersion;
            this.TLSMinVersion = tLSMinVersion;
        }

        /// <summary>
        /// Gets or Sets CipherSuites
        /// </summary>
        [DataMember(Name = "CipherSuites", EmitDefaultValue = false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "Enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets TLSMaxVersion
        /// </summary>
        [DataMember(Name = "TLSMaxVersion", EmitDefaultValue = false)]
        public string TLSMaxVersion { get; set; }

        /// <summary>
        /// Gets or Sets TLSMinVersion
        /// </summary>
        [DataMember(Name = "TLSMinVersion", EmitDefaultValue = false)]
        public string TLSMinVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsulGatewayTLSConfig {\n");
            sb.Append("  CipherSuites: ").Append(CipherSuites).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  TLSMaxVersion: ").Append(TLSMaxVersion).Append("\n");
            sb.Append("  TLSMinVersion: ").Append(TLSMinVersion).Append("\n");
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
            return this.Equals(input as ConsulGatewayTLSConfig);
        }

        /// <summary>
        /// Returns true if ConsulGatewayTLSConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsulGatewayTLSConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsulGatewayTLSConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CipherSuites == input.CipherSuites ||
                    this.CipherSuites != null &&
                    input.CipherSuites != null &&
                    this.CipherSuites.SequenceEqual(input.CipherSuites)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.TLSMaxVersion == input.TLSMaxVersion ||
                    (this.TLSMaxVersion != null &&
                    this.TLSMaxVersion.Equals(input.TLSMaxVersion))
                ) && 
                (
                    this.TLSMinVersion == input.TLSMinVersion ||
                    (this.TLSMinVersion != null &&
                    this.TLSMinVersion.Equals(input.TLSMinVersion))
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
                if (this.CipherSuites != null)
                {
                    hashCode = (hashCode * 59) + this.CipherSuites.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.TLSMaxVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TLSMaxVersion.GetHashCode();
                }
                if (this.TLSMinVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TLSMinVersion.GetHashCode();
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