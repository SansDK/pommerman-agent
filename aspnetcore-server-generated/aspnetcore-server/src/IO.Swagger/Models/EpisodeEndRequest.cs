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
    public partial class EpisodeEndRequest : IEquatable<EpisodeEndRequest>
    {
        /// <summary>
        /// Result of the game:  * `0` - Win  * `1` - Loss  * `2` - Tie  * `3` - Incomplete
        /// </summary>
        /// <value>Result of the game:  * `0` - Win  * `1` - Loss  * `2` - Tie  * `3` - Incomplete </value>

        public enum RewardEnum
        {
            /// <summary>
            /// Enum _0Enum for 0
            /// </summary>

            _0Enum = 0,

            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>

            _1Enum = 1,

            /// <summary>
            /// Enum _2Enum for 2
            /// </summary>

            _2Enum = 2,

            /// <summary>
            /// Enum _3Enum for 3
            /// </summary>

            _3Enum = 3
        }

        /// <summary>
        /// Result of the game:  * &#x60;0&#x60; - Win  * &#x60;1&#x60; - Loss  * &#x60;2&#x60; - Tie  * &#x60;3&#x60; - Incomplete
        /// </summary>
        /// <value>Result of the game:  * &#x60;0&#x60; - Win  * &#x60;1&#x60; - Loss  * &#x60;2&#x60; - Tie  * &#x60;3&#x60; - Incomplete </value>
        [Required]
        [DataMember(Name = "reward")]
        public RewardEnum? Reward { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpisodeEndRequest {\n");
            sb.Append("  Reward: ").Append(Reward).Append('\n');
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
            return obj.GetType() == GetType() && Equals((EpisodeEndRequest)obj);
        }

        /// <summary>
        /// Returns true if EpisodeEndRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EpisodeEndRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EpisodeEndRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Reward == other.Reward ||
                    Reward != null &&
                    Reward.Equals(other.Reward)
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
                if (Reward != null)
                    hashCode = hashCode * 59 + Reward.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(EpisodeEndRequest left, EpisodeEndRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EpisodeEndRequest left, EpisodeEndRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}