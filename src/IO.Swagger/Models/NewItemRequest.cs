/*
 * Just Order Api
 *
 * An API to create and retrieve Food items and orders.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: john.doe@somecomp.com
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
    /// A Request to Create a Food Item in the system.
    /// </summary>
    [DataContract]
    public partial class NewItemRequest : IEquatable<NewItemRequest>
    { 
        /// <summary>
        /// Name of the Food item.
        /// </summary>
        /// <value>Name of the Food item.</value>
        [Required]
        [DataMember(Name="itemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// Price of the item.
        /// </summary>
        /// <value>Price of the item.</value>
        [Required]
        [DataMember(Name="itemPrice")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewItemRequest {\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NewItemRequest)obj);
        }

        /// <summary>
        /// Returns true if NewItemRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NewItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewItemRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ItemName == other.ItemName ||
                    ItemName != null &&
                    ItemName.Equals(other.ItemName)
                ) && 
                (
                    ItemPrice == other.ItemPrice ||
                    ItemPrice != null &&
                    ItemPrice.Equals(other.ItemPrice)
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
                    if (ItemName != null)
                    hashCode = hashCode * 59 + ItemName.GetHashCode();
                    if (ItemPrice != null)
                    hashCode = hashCode * 59 + ItemPrice.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NewItemRequest left, NewItemRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NewItemRequest left, NewItemRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}