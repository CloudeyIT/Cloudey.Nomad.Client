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
    /// NodeScoreMeta
    /// </summary>
    [DataContract(Name = "NodeScoreMeta")]
    public partial class NodeScoreMeta : IEquatable<NodeScoreMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeScoreMeta" /> class.
        /// </summary>
        /// <param name="nodeID">nodeID.</param>
        /// <param name="normScore">normScore.</param>
        /// <param name="scores">scores.</param>
        public NodeScoreMeta(string nodeID = default(string), double normScore = default(double), Dictionary<string, double> scores = default(Dictionary<string, double>))
        {
            this.NodeID = nodeID;
            this.NormScore = normScore;
            this.Scores = scores;
        }

        /// <summary>
        /// Gets or Sets NodeID
        /// </summary>
        [DataMember(Name = "NodeID", EmitDefaultValue = false)]
        public string NodeID { get; set; }

        /// <summary>
        /// Gets or Sets NormScore
        /// </summary>
        [DataMember(Name = "NormScore", EmitDefaultValue = false)]
        public double NormScore { get; set; }

        /// <summary>
        /// Gets or Sets Scores
        /// </summary>
        [DataMember(Name = "Scores", EmitDefaultValue = false)]
        public Dictionary<string, double> Scores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeScoreMeta {\n");
            sb.Append("  NodeID: ").Append(NodeID).Append("\n");
            sb.Append("  NormScore: ").Append(NormScore).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
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
            return this.Equals(input as NodeScoreMeta);
        }

        /// <summary>
        /// Returns true if NodeScoreMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeScoreMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeScoreMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NodeID == input.NodeID ||
                    (this.NodeID != null &&
                    this.NodeID.Equals(input.NodeID))
                ) && 
                (
                    this.NormScore == input.NormScore ||
                    this.NormScore.Equals(input.NormScore)
                ) && 
                (
                    this.Scores == input.Scores ||
                    this.Scores != null &&
                    input.Scores != null &&
                    this.Scores.SequenceEqual(input.Scores)
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
                if (this.NodeID != null)
                {
                    hashCode = (hashCode * 59) + this.NodeID.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NormScore.GetHashCode();
                if (this.Scores != null)
                {
                    hashCode = (hashCode * 59) + this.Scores.GetHashCode();
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
