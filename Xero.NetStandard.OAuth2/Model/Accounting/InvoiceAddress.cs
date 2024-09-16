/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// InvoiceAddress
    /// </summary>
    [DataContract]
    public partial class InvoiceAddress :  IEquatable<InvoiceAddress>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether the address is defined as origin (FROM) or destination (TO)
        /// </summary>
        /// <value>Indicates whether the address is defined as origin (FROM) or destination (TO)</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum InvoiceAddressTypeEnum
        {
            /// <summary>
            /// Enum FROM for value: FROM
            /// </summary>
            [EnumMember(Value = "FROM")]
            FROM = 1,

            /// <summary>
            /// Enum TO for value: TO
            /// </summary>
            [EnumMember(Value = "TO")]
            TO = 2

        }

        /// <summary>
        /// Indicates whether the address is defined as origin (FROM) or destination (TO)
        /// </summary>
        /// <value>Indicates whether the address is defined as origin (FROM) or destination (TO)</value>
        [DataMember(Name="InvoiceAddressType", EmitDefaultValue=false)]
        public InvoiceAddressTypeEnum InvoiceAddressType { get; set; }
        
        /// <summary>
        /// First line of a physical address
        /// </summary>
        /// <value>First line of a physical address</value>
        [DataMember(Name="AddressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of a physical address
        /// </summary>
        /// <value>Second line of a physical address</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of a physical address
        /// </summary>
        /// <value>Third line of a physical address</value>
        [DataMember(Name="AddressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Fourth line of a physical address
        /// </summary>
        /// <value>Fourth line of a physical address</value>
        [DataMember(Name="AddressLine4", EmitDefaultValue=false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// City of a physical address
        /// </summary>
        /// <value>City of a physical address</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Region or state of a physical address
        /// </summary>
        /// <value>Region or state of a physical address</value>
        [DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Postal code of a physical address
        /// </summary>
        /// <value>Postal code of a physical address</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of a physical address
        /// </summary>
        /// <value>Country of a physical address</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceAddress {\n");
            sb.Append("  InvoiceAddressType: ").Append(InvoiceAddressType).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvoiceAddress);
        }

        /// <summary>
        /// Returns true if InvoiceAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvoiceAddressType == input.InvoiceAddressType ||
                    this.InvoiceAddressType.Equals(input.InvoiceAddressType)
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.AddressLine4 == input.AddressLine4 ||
                    (this.AddressLine4 != null &&
                    this.AddressLine4.Equals(input.AddressLine4))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                hashCode = hashCode * 59 + this.InvoiceAddressType.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.AddressLine4 != null)
                    hashCode = hashCode * 59 + this.AddressLine4.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
