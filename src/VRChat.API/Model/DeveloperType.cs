/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.11.0
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
    /// \&quot;none\&quot; User is a normal user \&quot;trusted\&quot; Unknown \&quot;internal\&quot; Is a VRChat Developer \&quot;moderator\&quot; Is a VRChat Moderator  Staff can hide their developerType at will.
    /// </summary>
    /// <value>\&quot;none\&quot; User is a normal user \&quot;trusted\&quot; Unknown \&quot;internal\&quot; Is a VRChat Developer \&quot;moderator\&quot; Is a VRChat Moderator  Staff can hide their developerType at will.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeveloperType
    {
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 1,

        /// <summary>
        /// Enum Trusted for value: trusted
        /// </summary>
        [EnumMember(Value = "trusted")]
        Trusted = 2,

        /// <summary>
        /// Enum Internal for value: internal
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal = 3,

        /// <summary>
        /// Enum Moderator for value: moderator
        /// </summary>
        [EnumMember(Value = "moderator")]
        Moderator = 4

    }

}
