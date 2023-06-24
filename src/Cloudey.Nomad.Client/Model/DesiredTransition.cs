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
    /// DesiredTransition
    /// </summary>
    [DataContract(Name = "DesiredTransition")]
    public partial class DesiredTransition : IEquatable<DesiredTransition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesiredTransition" /> class.
        /// </summary>
        /// <param name="migrate">migrate.</param>
        /// <param name="reschedule">reschedule.</param>
        public DesiredTransition(bool migrate = default(bool), bool reschedule = default(bool))
        {
            this.Migrate = migrate;
            this.Reschedule = reschedule;
        }

        /// <summary>
        /// Gets or Sets Migrate
        /// </summary>
        [DataMember(Name = "Migrate", EmitDefaultValue = true)]
        public bool Migrate { get; set; }

        /// <summary>
        /// Gets or Sets Reschedule
        /// </summary>
        [DataMember(Name = "Reschedule", EmitDefaultValue = true)]
        public bool Reschedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DesiredTransition {\n");
            sb.Append("  Migrate: ").Append(Migrate).Append("\n");
            sb.Append("  Reschedule: ").Append(Reschedule).Append("\n");
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
            return this.Equals(input as DesiredTransition);
        }

        /// <summary>
        /// Returns true if DesiredTransition instances are equal
        /// </summary>
        /// <param name="input">Instance of DesiredTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesiredTransition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Migrate == input.Migrate ||
                    this.Migrate.Equals(input.Migrate)
                ) && 
                (
                    this.Reschedule == input.Reschedule ||
                    this.Reschedule.Equals(input.Reschedule)
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
                hashCode = (hashCode * 59) + this.Migrate.GetHashCode();
                hashCode = (hashCode * 59) + this.Reschedule.GetHashCode();
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