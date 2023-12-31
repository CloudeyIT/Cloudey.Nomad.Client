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
    /// TaskCSIPluginConfig
    /// </summary>
    [DataContract(Name = "TaskCSIPluginConfig")]
    public partial class TaskCSIPluginConfig : IEquatable<TaskCSIPluginConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCSIPluginConfig" /> class.
        /// </summary>
        /// <param name="healthTimeout">healthTimeout.</param>
        /// <param name="iD">iD.</param>
        /// <param name="mountDir">mountDir.</param>
        /// <param name="stagePublishBaseDir">stagePublishBaseDir.</param>
        /// <param name="type">type.</param>
        public TaskCSIPluginConfig(long healthTimeout = default(long), string iD = default(string), string mountDir = default(string), string stagePublishBaseDir = default(string), string type = default(string))
        {
            this.HealthTimeout = healthTimeout;
            this.ID = iD;
            this.MountDir = mountDir;
            this.StagePublishBaseDir = stagePublishBaseDir;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets HealthTimeout
        /// </summary>
        [DataMember(Name = "HealthTimeout", EmitDefaultValue = false)]
        public long HealthTimeout { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets MountDir
        /// </summary>
        [DataMember(Name = "MountDir", EmitDefaultValue = false)]
        public string MountDir { get; set; }

        /// <summary>
        /// Gets or Sets StagePublishBaseDir
        /// </summary>
        [DataMember(Name = "StagePublishBaseDir", EmitDefaultValue = false)]
        public string StagePublishBaseDir { get; set; }

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
            sb.Append("class TaskCSIPluginConfig {\n");
            sb.Append("  HealthTimeout: ").Append(HealthTimeout).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  MountDir: ").Append(MountDir).Append("\n");
            sb.Append("  StagePublishBaseDir: ").Append(StagePublishBaseDir).Append("\n");
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
            return this.Equals(input as TaskCSIPluginConfig);
        }

        /// <summary>
        /// Returns true if TaskCSIPluginConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskCSIPluginConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskCSIPluginConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HealthTimeout == input.HealthTimeout ||
                    this.HealthTimeout.Equals(input.HealthTimeout)
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.MountDir == input.MountDir ||
                    (this.MountDir != null &&
                    this.MountDir.Equals(input.MountDir))
                ) && 
                (
                    this.StagePublishBaseDir == input.StagePublishBaseDir ||
                    (this.StagePublishBaseDir != null &&
                    this.StagePublishBaseDir.Equals(input.StagePublishBaseDir))
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
                hashCode = (hashCode * 59) + this.HealthTimeout.GetHashCode();
                if (this.ID != null)
                {
                    hashCode = (hashCode * 59) + this.ID.GetHashCode();
                }
                if (this.MountDir != null)
                {
                    hashCode = (hashCode * 59) + this.MountDir.GetHashCode();
                }
                if (this.StagePublishBaseDir != null)
                {
                    hashCode = (hashCode * 59) + this.StagePublishBaseDir.GetHashCode();
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
