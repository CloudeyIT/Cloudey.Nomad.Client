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
    /// Variable
    /// </summary>
    [DataContract(Name = "Variable")]
    public partial class Variable : IEquatable<Variable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        /// <param name="createIndex">createIndex.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="items">items.</param>
        /// <param name="modifyIndex">modifyIndex.</param>
        /// <param name="modifyTime">modifyTime.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="path">path.</param>
        public Variable(int createIndex = default(int), long createTime = default(long), Dictionary<string, string> items = default(Dictionary<string, string>), int modifyIndex = default(int), long modifyTime = default(long), string _namespace = default(string), string path = default(string))
        {
            this.CreateIndex = createIndex;
            this.CreateTime = createTime;
            this.Items = items;
            this.ModifyIndex = modifyIndex;
            this.ModifyTime = modifyTime;
            this.Namespace = _namespace;
            this.Path = path;
        }

        /// <summary>
        /// Gets or Sets CreateIndex
        /// </summary>
        [DataMember(Name = "CreateIndex", EmitDefaultValue = false)]
        public int CreateIndex { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "CreateTime", EmitDefaultValue = false)]
        public long CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public Dictionary<string, string> Items { get; set; }

        /// <summary>
        /// Gets or Sets ModifyIndex
        /// </summary>
        [DataMember(Name = "ModifyIndex", EmitDefaultValue = false)]
        public int ModifyIndex { get; set; }

        /// <summary>
        /// Gets or Sets ModifyTime
        /// </summary>
        [DataMember(Name = "ModifyTime", EmitDefaultValue = false)]
        public long ModifyTime { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "Namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "Path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Variable {\n");
            sb.Append("  CreateIndex: ").Append(CreateIndex).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ModifyIndex: ").Append(ModifyIndex).Append("\n");
            sb.Append("  ModifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as Variable);
        }

        /// <summary>
        /// Returns true if Variable instances are equal
        /// </summary>
        /// <param name="input">Instance of Variable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Variable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreateIndex == input.CreateIndex ||
                    this.CreateIndex.Equals(input.CreateIndex)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.ModifyIndex == input.ModifyIndex ||
                    this.ModifyIndex.Equals(input.ModifyIndex)
                ) && 
                (
                    this.ModifyTime == input.ModifyTime ||
                    this.ModifyTime.Equals(input.ModifyTime)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                hashCode = (hashCode * 59) + this.CreateIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ModifyIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.ModifyTime.GetHashCode();
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
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
            // CreateIndex (int) maximum
            if (this.CreateIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreateIndex, must be a value less than or equal to 384.", new [] { "CreateIndex" });
            }

            // CreateIndex (int) minimum
            if (this.CreateIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreateIndex, must be a value greater than or equal to 0.", new [] { "CreateIndex" });
            }

            // ModifyIndex (int) maximum
            if (this.ModifyIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModifyIndex, must be a value less than or equal to 384.", new [] { "ModifyIndex" });
            }

            // ModifyIndex (int) minimum
            if (this.ModifyIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModifyIndex, must be a value greater than or equal to 0.", new [] { "ModifyIndex" });
            }

            yield break;
        }
    }

}