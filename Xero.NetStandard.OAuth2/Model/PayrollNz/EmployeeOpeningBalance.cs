/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.6.0
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// EmployeeOpeningBalance
    /// </summary>
    [DataContract]
    public partial class EmployeeOpeningBalance :  IEquatable<EmployeeOpeningBalance>, IValidatableObject
    {
        
        /// <summary>
        /// The opening balance period end date.
        /// </summary>
        /// <value>The opening balance period end date.</value>
        [DataMember(Name="periodEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// The paid number of days.
        /// </summary>
        /// <value>The paid number of days.</value>
        [DataMember(Name="daysPaid", EmitDefaultValue=false)]
        public int? DaysPaid { get; set; }

        /// <summary>
        /// The number of unpaid weeks.
        /// </summary>
        /// <value>The number of unpaid weeks.</value>
        [DataMember(Name="unpaidWeeks", EmitDefaultValue=false)]
        public int? UnpaidWeeks { get; set; }

        /// <summary>
        /// The gross earnings during the period.
        /// </summary>
        /// <value>The gross earnings during the period.</value>
        [DataMember(Name="grossEarnings", EmitDefaultValue=false)]
        public decimal? GrossEarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeOpeningBalance {\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  DaysPaid: ").Append(DaysPaid).Append("\n");
            sb.Append("  UnpaidWeeks: ").Append(UnpaidWeeks).Append("\n");
            sb.Append("  GrossEarnings: ").Append(GrossEarnings).Append("\n");
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
            return this.Equals(input as EmployeeOpeningBalance);
        }

        /// <summary>
        /// Returns true if EmployeeOpeningBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeOpeningBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeOpeningBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.DaysPaid == input.DaysPaid ||
                    this.DaysPaid.Equals(input.DaysPaid)
                ) && 
                (
                    this.UnpaidWeeks == input.UnpaidWeeks ||
                    this.UnpaidWeeks.Equals(input.UnpaidWeeks)
                ) && 
                (
                    this.GrossEarnings == input.GrossEarnings ||
                    this.GrossEarnings.Equals(input.GrossEarnings)
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
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                hashCode = hashCode * 59 + this.DaysPaid.GetHashCode();
                hashCode = hashCode * 59 + this.UnpaidWeeks.GetHashCode();
                hashCode = hashCode * 59 + this.GrossEarnings.GetHashCode();
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
