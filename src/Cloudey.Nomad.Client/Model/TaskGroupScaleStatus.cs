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
    /// TaskGroupScaleStatus
    /// </summary>
    [DataContract(Name = "TaskGroupScaleStatus")]
    public partial class TaskGroupScaleStatus : IEquatable<TaskGroupScaleStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskGroupScaleStatus" /> class.
        /// </summary>
        /// <param name="desired">desired.</param>
        /// <param name="events">events.</param>
        /// <param name="healthy">healthy.</param>
        /// <param name="placed">placed.</param>
        /// <param name="running">running.</param>
        /// <param name="unhealthy">unhealthy.</param>
        public TaskGroupScaleStatus(int desired = default(int), List<ScalingEvent> events = default(List<ScalingEvent>), int healthy = default(int), int placed = default(int), int running = default(int), int unhealthy = default(int))
        {
            this.Desired = desired;
            this.Events = events;
            this.Healthy = healthy;
            this.Placed = placed;
            this.Running = running;
            this.Unhealthy = unhealthy;
        }

        /// <summary>
        /// Gets or Sets Desired
        /// </summary>
        [DataMember(Name = "Desired", EmitDefaultValue = false)]
        public int Desired { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "Events", EmitDefaultValue = false)]
        public List<ScalingEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets Healthy
        /// </summary>
        [DataMember(Name = "Healthy", EmitDefaultValue = false)]
        public int Healthy { get; set; }

        /// <summary>
        /// Gets or Sets Placed
        /// </summary>
        [DataMember(Name = "Placed", EmitDefaultValue = false)]
        public int Placed { get; set; }

        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name = "Running", EmitDefaultValue = false)]
        public int Running { get; set; }

        /// <summary>
        /// Gets or Sets Unhealthy
        /// </summary>
        [DataMember(Name = "Unhealthy", EmitDefaultValue = false)]
        public int Unhealthy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskGroupScaleStatus {\n");
            sb.Append("  Desired: ").Append(Desired).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Healthy: ").Append(Healthy).Append("\n");
            sb.Append("  Placed: ").Append(Placed).Append("\n");
            sb.Append("  Running: ").Append(Running).Append("\n");
            sb.Append("  Unhealthy: ").Append(Unhealthy).Append("\n");
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
            return this.Equals(input as TaskGroupScaleStatus);
        }

        /// <summary>
        /// Returns true if TaskGroupScaleStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskGroupScaleStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskGroupScaleStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Desired == input.Desired ||
                    this.Desired.Equals(input.Desired)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Healthy == input.Healthy ||
                    this.Healthy.Equals(input.Healthy)
                ) && 
                (
                    this.Placed == input.Placed ||
                    this.Placed.Equals(input.Placed)
                ) && 
                (
                    this.Running == input.Running ||
                    this.Running.Equals(input.Running)
                ) && 
                (
                    this.Unhealthy == input.Unhealthy ||
                    this.Unhealthy.Equals(input.Unhealthy)
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
                hashCode = (hashCode * 59) + this.Desired.GetHashCode();
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Healthy.GetHashCode();
                hashCode = (hashCode * 59) + this.Placed.GetHashCode();
                hashCode = (hashCode * 59) + this.Running.GetHashCode();
                hashCode = (hashCode * 59) + this.Unhealthy.GetHashCode();
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
