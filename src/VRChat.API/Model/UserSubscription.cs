/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.13.0
 * Contact: vrchatapi.lpv0t@aries.fyi
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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// UserSubscription
    /// </summary>
    [DataContract(Name = "UserSubscription")]
    public partial class UserSubscription : IEquatable<UserSubscription>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionPeriod Period { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TransactionStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="transactionId">transactionId (required).</param>
        /// <param name="store">Which \&quot;Store\&quot; it came from. Right now only Stores are \&quot;Steam\&quot; and \&quot;Admin\&quot;. (required).</param>
        /// <param name="steamItemId">steamItemId.</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="tier">tier (required).</param>
        /// <param name="active">active (required) (default to true).</param>
        /// <param name="status">status (required).</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="licenseGroups">licenseGroups (required).</param>
        /// <param name="isGift">isGift (required) (default to false).</param>
        public UserSubscription(string id = default(string), string transactionId = default(string), string store = default(string), string steamItemId = default(string), decimal amount = default(decimal), string description = default(string), SubscriptionPeriod period = default(SubscriptionPeriod), decimal tier = default(decimal), bool active = true, TransactionStatus status = default(TransactionStatus), DateTime expires = default(DateTime), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), List<string> licenseGroups = default(List<string>), bool isGift = false)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UserSubscription and cannot be null");
            }
            this.Id = id;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for UserSubscription and cannot be null");
            }
            this.TransactionId = transactionId;
            // to ensure "store" is required (not null)
            if (store == null)
            {
                throw new ArgumentNullException("store is a required property for UserSubscription and cannot be null");
            }
            this.Store = store;
            this.Amount = amount;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for UserSubscription and cannot be null");
            }
            this.Description = description;
            this.Period = period;
            this.Tier = tier;
            this.Active = active;
            this.Status = status;
            this.Expires = expires;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            // to ensure "licenseGroups" is required (not null)
            if (licenseGroups == null)
            {
                throw new ArgumentNullException("licenseGroups is a required property for UserSubscription and cannot be null");
            }
            this.LicenseGroups = licenseGroups;
            this.IsGift = isGift;
            this.SteamItemId = steamItemId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Which \&quot;Store\&quot; it came from. Right now only Stores are \&quot;Steam\&quot; and \&quot;Admin\&quot;.
        /// </summary>
        /// <value>Which \&quot;Store\&quot; it came from. Right now only Stores are \&quot;Steam\&quot; and \&quot;Admin\&quot;.</value>
        [DataMember(Name = "store", IsRequired = true, EmitDefaultValue = true)]
        public string Store { get; set; }

        /// <summary>
        /// Gets or Sets SteamItemId
        /// </summary>
        [DataMember(Name = "steamItemId", EmitDefaultValue = false)]
        public string SteamItemId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name = "tier", IsRequired = true, EmitDefaultValue = true)]
        public decimal Tier { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LicenseGroups
        /// </summary>
        [DataMember(Name = "licenseGroups", IsRequired = true, EmitDefaultValue = true)]
        public List<string> LicenseGroups { get; set; }

        /// <summary>
        /// Gets or Sets IsGift
        /// </summary>
        [DataMember(Name = "isGift", IsRequired = true, EmitDefaultValue = true)]
        public bool IsGift { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  SteamItemId: ").Append(SteamItemId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LicenseGroups: ").Append(LicenseGroups).Append("\n");
            sb.Append("  IsGift: ").Append(IsGift).Append("\n");
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
            return this.Equals(input as UserSubscription);
        }

        /// <summary>
        /// Returns true if UserSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSubscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.SteamItemId == input.SteamItemId ||
                    (this.SteamItemId != null &&
                    this.SteamItemId.Equals(input.SteamItemId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) && 
                (
                    this.Tier == input.Tier ||
                    this.Tier.Equals(input.Tier)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.LicenseGroups == input.LicenseGroups ||
                    this.LicenseGroups != null &&
                    input.LicenseGroups != null &&
                    this.LicenseGroups.SequenceEqual(input.LicenseGroups)
                ) && 
                (
                    this.IsGift == input.IsGift ||
                    this.IsGift.Equals(input.IsGift)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.Store != null)
                {
                    hashCode = (hashCode * 59) + this.Store.GetHashCode();
                }
                if (this.SteamItemId != null)
                {
                    hashCode = (hashCode * 59) + this.SteamItemId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                hashCode = (hashCode * 59) + this.Tier.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Expires != null)
                {
                    hashCode = (hashCode * 59) + this.Expires.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.LicenseGroups != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseGroups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsGift.GetHashCode();
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
            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // TransactionId (string) pattern
            Regex regexTransactionId = new Regex(@"txn_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexTransactionId.Match(this.TransactionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, must match a pattern of " + regexTransactionId, new [] { "TransactionId" });
            }

            // Store (string) minLength
            if (this.Store != null && this.Store.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Store, length must be greater than 1.", new [] { "Store" });
            }

            // SteamItemId (string) minLength
            if (this.SteamItemId != null && this.SteamItemId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SteamItemId, length must be greater than 1.", new [] { "SteamItemId" });
            }

            yield break;
        }
    }

}
