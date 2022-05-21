/*
 * Bombersauce API
 *
 * API for an agent of the Bombersauce AI-hackathon.
 *
 * OpenAPI spec version: 1.0.0
 *
 * Partly generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class ActionRequest : IEquatable<ActionRequest>
    {
        /// <summary>
        /// Gets or Sets Obs
        /// </summary>
        [Required]
        [DataMember(Name = "obs")]
        public Obs Obs { get; set; }

        /// <summary>
        /// Gets or Sets ActionSpace
        /// </summary>

        [DataMember(Name = "action_space")]
        public int? ActionSpace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionRequest {\n");
            sb.Append("  Obs: ").Append(Obs).Append('\n');
            sb.Append("  ActionSpace: ").Append(ActionSpace).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ActionRequest)obj);
        }

        /// <summary>
        /// Returns true if ActionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Obs == other.Obs ||
                    Obs != null &&
                    Obs.Equals(other.Obs)
                ) &&
                (
                    ActionSpace == other.ActionSpace ||
                    ActionSpace != null &&
                    ActionSpace.Equals(other.ActionSpace)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Obs != null)
                    hashCode = hashCode * 59 + Obs.GetHashCode();
                if (ActionSpace != null)
                    hashCode = hashCode * 59 + ActionSpace.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(ActionRequest left, ActionRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActionRequest left, ActionRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}