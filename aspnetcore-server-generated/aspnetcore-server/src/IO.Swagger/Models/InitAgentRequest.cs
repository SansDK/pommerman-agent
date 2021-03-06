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
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class InitAgentRequest : IEquatable<InitAgentRequest>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>

        [DataMember(Name = "game_type")]
        public GameType GameType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitAgentRequest {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  GameType: ").Append(GameType).Append('\n');
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
            return obj.GetType() == GetType() && Equals((InitAgentRequest)obj);
        }

        /// <summary>
        /// Returns true if InitAgentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InitAgentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitAgentRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    GameType == other.GameType ||
                    GameType.Equals(other.GameType)
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                hashCode = hashCode * 59 + GameType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(InitAgentRequest left, InitAgentRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InitAgentRequest left, InitAgentRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}