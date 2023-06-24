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
    /// SchedulerConfiguration
    /// </summary>
    [DataContract(Name = "SchedulerConfiguration")]
    public partial class SchedulerConfiguration : IEquatable<SchedulerConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerConfiguration" /> class.
        /// </summary>
        /// <param name="createIndex">createIndex.</param>
        /// <param name="memoryOversubscriptionEnabled">memoryOversubscriptionEnabled.</param>
        /// <param name="modifyIndex">modifyIndex.</param>
        /// <param name="pauseEvalBroker">pauseEvalBroker.</param>
        /// <param name="preemptionConfig">preemptionConfig.</param>
        /// <param name="rejectJobRegistration">rejectJobRegistration.</param>
        /// <param name="schedulerAlgorithm">schedulerAlgorithm.</param>
        public SchedulerConfiguration(int createIndex = default(int), bool memoryOversubscriptionEnabled = default(bool), int modifyIndex = default(int), bool pauseEvalBroker = default(bool), PreemptionConfig preemptionConfig = default(PreemptionConfig), bool rejectJobRegistration = default(bool), string schedulerAlgorithm = default(string))
        {
            this.CreateIndex = createIndex;
            this.MemoryOversubscriptionEnabled = memoryOversubscriptionEnabled;
            this.ModifyIndex = modifyIndex;
            this.PauseEvalBroker = pauseEvalBroker;
            this.PreemptionConfig = preemptionConfig;
            this.RejectJobRegistration = rejectJobRegistration;
            this.SchedulerAlgorithm = schedulerAlgorithm;
        }

        /// <summary>
        /// Gets or Sets CreateIndex
        /// </summary>
        [DataMember(Name = "CreateIndex", EmitDefaultValue = false)]
        public int CreateIndex { get; set; }

        /// <summary>
        /// Gets or Sets MemoryOversubscriptionEnabled
        /// </summary>
        [DataMember(Name = "MemoryOversubscriptionEnabled", EmitDefaultValue = true)]
        public bool MemoryOversubscriptionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ModifyIndex
        /// </summary>
        [DataMember(Name = "ModifyIndex", EmitDefaultValue = false)]
        public int ModifyIndex { get; set; }

        /// <summary>
        /// Gets or Sets PauseEvalBroker
        /// </summary>
        [DataMember(Name = "PauseEvalBroker", EmitDefaultValue = true)]
        public bool PauseEvalBroker { get; set; }

        /// <summary>
        /// Gets or Sets PreemptionConfig
        /// </summary>
        [DataMember(Name = "PreemptionConfig", EmitDefaultValue = false)]
        public PreemptionConfig PreemptionConfig { get; set; }

        /// <summary>
        /// Gets or Sets RejectJobRegistration
        /// </summary>
        [DataMember(Name = "RejectJobRegistration", EmitDefaultValue = true)]
        public bool RejectJobRegistration { get; set; }

        /// <summary>
        /// Gets or Sets SchedulerAlgorithm
        /// </summary>
        [DataMember(Name = "SchedulerAlgorithm", EmitDefaultValue = false)]
        public string SchedulerAlgorithm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchedulerConfiguration {\n");
            sb.Append("  CreateIndex: ").Append(CreateIndex).Append("\n");
            sb.Append("  MemoryOversubscriptionEnabled: ").Append(MemoryOversubscriptionEnabled).Append("\n");
            sb.Append("  ModifyIndex: ").Append(ModifyIndex).Append("\n");
            sb.Append("  PauseEvalBroker: ").Append(PauseEvalBroker).Append("\n");
            sb.Append("  PreemptionConfig: ").Append(PreemptionConfig).Append("\n");
            sb.Append("  RejectJobRegistration: ").Append(RejectJobRegistration).Append("\n");
            sb.Append("  SchedulerAlgorithm: ").Append(SchedulerAlgorithm).Append("\n");
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
            return this.Equals(input as SchedulerConfiguration);
        }

        /// <summary>
        /// Returns true if SchedulerConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerConfiguration input)
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
                    this.MemoryOversubscriptionEnabled == input.MemoryOversubscriptionEnabled ||
                    this.MemoryOversubscriptionEnabled.Equals(input.MemoryOversubscriptionEnabled)
                ) && 
                (
                    this.ModifyIndex == input.ModifyIndex ||
                    this.ModifyIndex.Equals(input.ModifyIndex)
                ) && 
                (
                    this.PauseEvalBroker == input.PauseEvalBroker ||
                    this.PauseEvalBroker.Equals(input.PauseEvalBroker)
                ) && 
                (
                    this.PreemptionConfig == input.PreemptionConfig ||
                    (this.PreemptionConfig != null &&
                    this.PreemptionConfig.Equals(input.PreemptionConfig))
                ) && 
                (
                    this.RejectJobRegistration == input.RejectJobRegistration ||
                    this.RejectJobRegistration.Equals(input.RejectJobRegistration)
                ) && 
                (
                    this.SchedulerAlgorithm == input.SchedulerAlgorithm ||
                    (this.SchedulerAlgorithm != null &&
                    this.SchedulerAlgorithm.Equals(input.SchedulerAlgorithm))
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
                hashCode = (hashCode * 59) + this.MemoryOversubscriptionEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ModifyIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.PauseEvalBroker.GetHashCode();
                if (this.PreemptionConfig != null)
                {
                    hashCode = (hashCode * 59) + this.PreemptionConfig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RejectJobRegistration.GetHashCode();
                if (this.SchedulerAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.SchedulerAlgorithm.GetHashCode();
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