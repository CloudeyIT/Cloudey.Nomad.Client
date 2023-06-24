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
    /// FieldDiff
    /// </summary>
    [DataContract(Name = "FieldDiff")]
    public partial class FieldDiff : IEquatable<FieldDiff>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDiff" /> class.
        /// </summary>
        /// <param name="annotations">annotations.</param>
        /// <param name="name">name.</param>
        /// <param name="_new">_new.</param>
        /// <param name="old">old.</param>
        /// <param name="type">type.</param>
        public FieldDiff(List<string> annotations = default(List<string>), string name = default(string), string _new = default(string), string old = default(string), string type = default(string))
        {
            this.Annotations = annotations;
            this.Name = name;
            this.New = _new;
            this.Old = old;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name = "Annotations", EmitDefaultValue = false)]
        public List<string> Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "New", EmitDefaultValue = false)]
        public string New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "Old", EmitDefaultValue = false)]
        public string Old { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldDiff {\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as FieldDiff);
        }

        /// <summary>
        /// Returns true if FieldDiff instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldDiff to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldDiff input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.New == input.New ||
                    (this.New != null &&
                    this.New.Equals(input.New))
                ) && 
                (
                    this.Old == input.Old ||
                    (this.Old != null &&
                    this.Old.Equals(input.Old))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Annotations != null)
                {
                    hashCode = (hashCode * 59) + this.Annotations.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.New != null)
                {
                    hashCode = (hashCode * 59) + this.New.GetHashCode();
                }
                if (this.Old != null)
                {
                    hashCode = (hashCode * 59) + this.Old.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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