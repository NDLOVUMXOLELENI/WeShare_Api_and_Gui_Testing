/*
 * WeShare API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = Applications.WeShare.Swagger.Client.OpenAPIDateConverter;

namespace Applications.WeShare.Swagger.Model
{
    /// <summary>
    /// NewPaymentDTO
    /// </summary>
    [DataContract(Name = "NewPaymentDTO")]
    public partial class NewPaymentDTO : IEquatable<NewPaymentDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPaymentDTO" /> class.
        /// </summary>
        /// <param name="expenseId">expenseId.</param>
        /// <param name="paymentRequestId">paymentRequestId.</param>
        /// <param name="payingPersonId">payingPersonId.</param>
        public NewPaymentDTO(int expenseId = default(int), int paymentRequestId = default(int), int payingPersonId = default(int))
        {
            this.ExpenseId = expenseId;
            this.PaymentRequestId = paymentRequestId;
            this.PayingPersonId = payingPersonId;
        }

        /// <summary>
        /// Gets or Sets ExpenseId
        /// </summary>
        [DataMember(Name = "expenseId", EmitDefaultValue = false)]
        public int ExpenseId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentRequestId
        /// </summary>
        [DataMember(Name = "paymentRequestId", EmitDefaultValue = false)]
        public int PaymentRequestId { get; set; }

        /// <summary>
        /// Gets or Sets PayingPersonId
        /// </summary>
        [DataMember(Name = "payingPersonId", EmitDefaultValue = false)]
        public int PayingPersonId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewPaymentDTO {\n");
            sb.Append("  ExpenseId: ").Append(ExpenseId).Append("\n");
            sb.Append("  PaymentRequestId: ").Append(PaymentRequestId).Append("\n");
            sb.Append("  PayingPersonId: ").Append(PayingPersonId).Append("\n");
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
            return this.Equals(input as NewPaymentDTO);
        }

        /// <summary>
        /// Returns true if NewPaymentDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NewPaymentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewPaymentDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpenseId == input.ExpenseId ||
                    this.ExpenseId.Equals(input.ExpenseId)
                ) && 
                (
                    this.PaymentRequestId == input.PaymentRequestId ||
                    this.PaymentRequestId.Equals(input.PaymentRequestId)
                ) && 
                (
                    this.PayingPersonId == input.PayingPersonId ||
                    this.PayingPersonId.Equals(input.PayingPersonId)
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
                hashCode = (hashCode * 59) + this.ExpenseId.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentRequestId.GetHashCode();
                hashCode = (hashCode * 59) + this.PayingPersonId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
