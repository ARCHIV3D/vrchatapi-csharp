/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.4.2
 * Contact: me@ruby.js.org
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
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// InlineResponse200
    /// </summary>
    [DataContract]
    public partial class InlineResponse200 :  IEquatable<InlineResponse200>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse200() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="ok">ok (required).</param>
        /// <param name="token">token (required).</param>
        public InlineResponse200(bool ok = default(bool), string token = default(string))
        {
            // to ensure "ok" is required (not null)
            if (ok == null)
            {
                throw new InvalidDataException("ok is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Ok = ok;
            }

            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Token = token;
            }

        }

        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name="ok", EmitDefaultValue=true)]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ok == input.Ok ||
                    (this.Ok != null &&
                    this.Ok.Equals(input.Ok))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Ok != null)
                    hashCode = hashCode * 59 + this.Ok.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
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

            // Token (string) minLength
            if(this.Token != null && this.Token.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be greater than 1.", new [] { "Token" });
            }

            yield break;
        }
    }

}
