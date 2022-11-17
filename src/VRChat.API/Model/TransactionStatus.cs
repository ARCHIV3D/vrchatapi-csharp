/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.9.1
 * Contact: me@ariesclark.com
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
    /// Defines TransactionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionStatus
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Failed for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed = 2,

        /// <summary>
        /// Enum Expired for value: expired
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired = 3,

        /// <summary>
        /// Enum Chargeback for value: chargeback
        /// </summary>
        [EnumMember(Value = "chargeback")]
        Chargeback = 4

    }

}
