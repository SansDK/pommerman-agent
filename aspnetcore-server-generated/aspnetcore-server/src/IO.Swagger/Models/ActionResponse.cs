/*
 * Bombersauce API
 *
 * API for an agent of the Bombersauce AI-hackathon.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ActionResponse : IEquatable<ActionResponse>
    {
        /// <summary>
        /// Action to take:  * `0` - Stop  * `1` - Up  * `2` - Down  * `3` - Left  * `4` - Right  * `5` - Bomb 
        /// </summary>
        /// <value>Action to take:  * `0` - Stop  * `1` - Up  * `2` - Down  * `3` - Left  * `4` - Right  * `5` - Bomb </value>

        public enum ActionEnum
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
            
            _3Enum = 3,
            
            /// <summary>
            /// Enum _4Enum for 4
            /// </summary>
            
            _4Enum = 4,
            
            /// <summary>
            /// Enum _5Enum for 5
            /// </summary>
            
            _5Enum = 5
        }

        /// <summary>
        /// Action to take:  * &#x60;0&#x60; - Stop  * &#x60;1&#x60; - Up  * &#x60;2&#x60; - Down  * &#x60;3&#x60; - Left  * &#x60;4&#x60; - Right  * &#x60;5&#x60; - Bomb 
        /// </summary>
        /// <value>Action to take:  * &#x60;0&#x60; - Stop  * &#x60;1&#x60; - Up  * &#x60;2&#x60; - Down  * &#x60;3&#x60; - Left  * &#x60;4&#x60; - Right  * &#x60;5&#x60; - Bomb </value>
        [Required]

        [DataMember(Name="action")]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ActionResponse)obj);
        }

        /// <summary>
        /// Returns true if ActionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
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
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActionResponse left, ActionResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActionResponse left, ActionResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
