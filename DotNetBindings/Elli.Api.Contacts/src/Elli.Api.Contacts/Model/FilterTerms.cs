/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Contacts
 *
 * Represents borrower and business contacts
 *
 * OpenAPI spec version: 1.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Elli.Api.Contacts.Client.SwaggerDateConverter;

namespace Elli.Api.Contacts.Model
{
    /// <summary>
    /// FilterTerms
    /// </summary>
    [DataContract]
    public partial class FilterTerms :  IEquatable<FilterTerms>, IValidatableObject
    {
    
        
        /// <summary>
        /// Canonical field name for borrower contact.
        /// </summary>
        /// <value>Canonical field name for borrower contact.</value>
        [DataMember(Name="canonicalName", EmitDefaultValue=false)]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Matching value for the field provided. Values are represented as alphanumeric values such as My Pipeline. Or numeric, such as integer, date or partial date, floating point, and currency.
        /// </summary>
        /// <value>Matching value for the field provided. Values are represented as alphanumeric values such as My Pipeline. Or numeric, such as integer, date or partial date, floating point, and currency.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Type on how value should be equated to field provided. Depending on filter criteria, options can include, greaterThanOrEquals, exact, greaterThan, isNotEmpty, isEmpty, lessThan, lessThanOrEquals, equals, notEquals, startsWith and contains.
        /// </summary>
        /// <value>Type on how value should be equated to field provided. Depending on filter criteria, options can include, greaterThanOrEquals, exact, greaterThan, isNotEmpty, isEmpty, lessThan, lessThanOrEquals, equals, notEquals, startsWith and contains.</value>
        [DataMember(Name="matchType", EmitDefaultValue=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// Terms, when filter needs to be applied on more than one field. Used to create a nested/sub query.
        /// </summary>
        /// <value>Terms, when filter needs to be applied on more than one field. Used to create a nested/sub query.</value>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<FilterTerms> Terms { get; set; }

        /// <summary>
        /// Binary operator for filter criteria when filter is applied on more than one fields. Accepted values - And and Or.
        /// </summary>
        /// <value>Binary operator for filter criteria when filter is applied on more than one fields. Accepted values - And and Or.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string _Operator { get; set; }

        /// <summary>
        /// Precision applies to Dates only. Possible values are - exact, day, month, year, recurring
        /// </summary>
        /// <value>Precision applies to Dates only. Possible values are - exact, day, month, year, recurring</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public string Precision { get; set; }

        /// <summary>
        /// When include &#x3D; true (which is the default), results are included if the filter returns results. It applies to strings only. When include &#x3D; false, results are excluded if the filter returns results.
        /// </summary>
        /// <value>When include &#x3D; true (which is the default), results are included if the filter returns results. It applies to strings only. When include &#x3D; false, results are excluded if the filter returns results.</value>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public bool? Include { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterTerms {\n");
            sb.Append("  CanonicalName: ").Append(CanonicalName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilterTerms);
        }

        /// <summary>
        /// Returns true if FilterTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterTerms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanonicalName == input.CanonicalName ||
                    (this.CanonicalName != null &&
                    this.CanonicalName.Equals(input.CanonicalName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.MatchType == input.MatchType ||
                    (this.MatchType != null &&
                    this.MatchType.Equals(input.MatchType))
                ) && 
                (
                    this.Terms == input.Terms ||
                    this.Terms != null &&
                    this.Terms.SequenceEqual(input.Terms)
                ) && 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && 
                (
                    this.Precision == input.Precision ||
                    (this.Precision != null &&
                    this.Precision.Equals(input.Precision))
                ) && 
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
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
                if (this.CanonicalName != null)
                    hashCode = hashCode * 59 + this.CanonicalName.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.MatchType != null)
                    hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.Precision != null)
                    hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.Include != null)
                    hashCode = hashCode * 59 + this.Include.GetHashCode();
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
