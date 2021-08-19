/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself, and is **not** officially supported by VRChat. The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API, in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities.  This documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee for external applications using the API. Access to API endpoints may break **at any time, without notice**. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programatically retrive or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same, and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintain API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public UserState State { get; set; }
        /// <summary>
        /// Gets or Sets DeveloperType
        /// </summary>
        [DataMember(Name="developerType", EmitDefaultValue=true)]
        public DeveloperType DeveloperType { get; set; }
        /// <summary>
        /// Gets or Sets LastPlatform
        /// </summary>
        [DataMember(Name="last_platform", EmitDefaultValue=true)]
        public Platform LastPlatform { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="username">username (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="userIcon">userIcon (required).</param>
        /// <param name="bio">bio (required).</param>
        /// <param name="bioLinks">bioLinks (required).</param>
        /// <param name="profilePicOverride">profilePicOverride (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        /// <param name="currentAvatarImageUrl">currentAvatarImageUrl (required).</param>
        /// <param name="currentAvatarThumbnailImageUrl">currentAvatarThumbnailImageUrl (required).</param>
        /// <param name="fallbackAvatar">fallbackAvatar (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="developerType">developerType (required).</param>
        /// <param name="lastLogin">lastLogin (required).</param>
        /// <param name="lastPlatform">lastPlatform (required).</param>
        /// <param name="allowAvatarCopying">allowAvatarCopying (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="isFriend">isFriend (required).</param>
        /// <param name="friendKey">friendKey (required).</param>
        /// <param name="worldId">worldId (required).</param>
        /// <param name="instanceId">instanceId (required).</param>
        /// <param name="location">location (required).</param>
        public User(string username = default(string), string displayName = default(string), string userIcon = default(string), string bio = default(string), List<string> bioLinks = default(List<string>), string profilePicOverride = default(string), string statusDescription = default(string), string currentAvatarImageUrl = default(string), string currentAvatarThumbnailImageUrl = default(string), string fallbackAvatar = default(string), UserState state = default(UserState), List<string> tags = default(List<string>), DeveloperType developerType = default(DeveloperType), string lastLogin = default(string), Platform lastPlatform = default(Platform), bool allowAvatarCopying = default(bool), UserStatus status = default(UserStatus), bool isFriend = default(bool), string friendKey = default(string), string worldId = default(string), string instanceId = default(string), string location = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for User and cannot be null");
            }
            else
            {
                this.Username = username;
            }

            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for User and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "userIcon" is required (not null)
            if (userIcon == null)
            {
                throw new InvalidDataException("userIcon is a required property for User and cannot be null");
            }
            else
            {
                this.UserIcon = userIcon;
            }

            // to ensure "bio" is required (not null)
            if (bio == null)
            {
                throw new InvalidDataException("bio is a required property for User and cannot be null");
            }
            else
            {
                this.Bio = bio;
            }

            // to ensure "bioLinks" is required (not null)
            if (bioLinks == null)
            {
                throw new InvalidDataException("bioLinks is a required property for User and cannot be null");
            }
            else
            {
                this.BioLinks = bioLinks;
            }

            // to ensure "profilePicOverride" is required (not null)
            if (profilePicOverride == null)
            {
                throw new InvalidDataException("profilePicOverride is a required property for User and cannot be null");
            }
            else
            {
                this.ProfilePicOverride = profilePicOverride;
            }

            // to ensure "statusDescription" is required (not null)
            if (statusDescription == null)
            {
                throw new InvalidDataException("statusDescription is a required property for User and cannot be null");
            }
            else
            {
                this.StatusDescription = statusDescription;
            }

            // to ensure "currentAvatarImageUrl" is required (not null)
            if (currentAvatarImageUrl == null)
            {
                throw new InvalidDataException("currentAvatarImageUrl is a required property for User and cannot be null");
            }
            else
            {
                this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            }

            // to ensure "currentAvatarThumbnailImageUrl" is required (not null)
            if (currentAvatarThumbnailImageUrl == null)
            {
                throw new InvalidDataException("currentAvatarThumbnailImageUrl is a required property for User and cannot be null");
            }
            else
            {
                this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            }

            // to ensure "fallbackAvatar" is required (not null)
            if (fallbackAvatar == null)
            {
                throw new InvalidDataException("fallbackAvatar is a required property for User and cannot be null");
            }
            else
            {
                this.FallbackAvatar = fallbackAvatar;
            }

            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for User and cannot be null");
            }
            else
            {
                this.State = state;
            }

            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for User and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }

            // to ensure "developerType" is required (not null)
            if (developerType == null)
            {
                throw new InvalidDataException("developerType is a required property for User and cannot be null");
            }
            else
            {
                this.DeveloperType = developerType;
            }

            // to ensure "lastLogin" is required (not null)
            if (lastLogin == null)
            {
                throw new InvalidDataException("lastLogin is a required property for User and cannot be null");
            }
            else
            {
                this.LastLogin = lastLogin;
            }

            // to ensure "lastPlatform" is required (not null)
            if (lastPlatform == null)
            {
                throw new InvalidDataException("lastPlatform is a required property for User and cannot be null");
            }
            else
            {
                this.LastPlatform = lastPlatform;
            }

            // to ensure "allowAvatarCopying" is required (not null)
            if (allowAvatarCopying == null)
            {
                throw new InvalidDataException("allowAvatarCopying is a required property for User and cannot be null");
            }
            else
            {
                this.AllowAvatarCopying = allowAvatarCopying;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for User and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "isFriend" is required (not null)
            if (isFriend == null)
            {
                throw new InvalidDataException("isFriend is a required property for User and cannot be null");
            }
            else
            {
                this.IsFriend = isFriend;
            }

            // to ensure "friendKey" is required (not null)
            if (friendKey == null)
            {
                throw new InvalidDataException("friendKey is a required property for User and cannot be null");
            }
            else
            {
                this.FriendKey = friendKey;
            }

            // to ensure "worldId" is required (not null)
            if (worldId == null)
            {
                throw new InvalidDataException("worldId is a required property for User and cannot be null");
            }
            else
            {
                this.WorldId = worldId;
            }

            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new InvalidDataException("instanceId is a required property for User and cannot be null");
            }
            else
            {
                this.InstanceId = instanceId;
            }

            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for User and cannot be null");
            }
            else
            {
                this.Location = location;
            }

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name="userIcon", EmitDefaultValue=true)]
        public string UserIcon { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio", EmitDefaultValue=true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name="bioLinks", EmitDefaultValue=true)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name="profilePicOverride", EmitDefaultValue=true)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="statusDescription", EmitDefaultValue=true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarImageUrl
        /// </summary>
        [DataMember(Name="currentAvatarImageUrl", EmitDefaultValue=true)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarThumbnailImageUrl
        /// </summary>
        [DataMember(Name="currentAvatarThumbnailImageUrl", EmitDefaultValue=true)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets FallbackAvatar
        /// </summary>
        [DataMember(Name="fallbackAvatar", EmitDefaultValue=true)]
        public string FallbackAvatar { get; set; }


        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }


        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=true)]
        public string LastLogin { get; set; }


        /// <summary>
        /// Gets or Sets AllowAvatarCopying
        /// </summary>
        [DataMember(Name="allowAvatarCopying", EmitDefaultValue=true)]
        public bool AllowAvatarCopying { get; set; }


        /// <summary>
        /// Gets or Sets DateJoined
        /// </summary>
        [DataMember(Name="date_joined", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateJoined { get; private set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name="isFriend", EmitDefaultValue=true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or Sets FriendKey
        /// </summary>
        [DataMember(Name="friendKey", EmitDefaultValue=true)]
        public string FriendKey { get; set; }

        /// <summary>
        /// Gets or Sets WorldId
        /// </summary>
        [DataMember(Name="worldId", EmitDefaultValue=true)]
        public string WorldId { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  FallbackAvatar: ").Append(FallbackAvatar).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DeveloperType: ").Append(DeveloperType).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  LastPlatform: ").Append(LastPlatform).Append("\n");
            sb.Append("  AllowAvatarCopying: ").Append(AllowAvatarCopying).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  FriendKey: ").Append(FriendKey).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.FallbackAvatar == input.FallbackAvatar ||
                    (this.FallbackAvatar != null &&
                    this.FallbackAvatar.Equals(input.FallbackAvatar))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.DeveloperType == input.DeveloperType ||
                    (this.DeveloperType != null &&
                    this.DeveloperType.Equals(input.DeveloperType))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.LastPlatform == input.LastPlatform ||
                    (this.LastPlatform != null &&
                    this.LastPlatform.Equals(input.LastPlatform))
                ) && 
                (
                    this.AllowAvatarCopying == input.AllowAvatarCopying ||
                    (this.AllowAvatarCopying != null &&
                    this.AllowAvatarCopying.Equals(input.AllowAvatarCopying))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DateJoined == input.DateJoined ||
                    (this.DateJoined != null &&
                    this.DateJoined.Equals(input.DateJoined))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    (this.IsFriend != null &&
                    this.IsFriend.Equals(input.IsFriend))
                ) && 
                (
                    this.FriendKey == input.FriendKey ||
                    (this.FriendKey != null &&
                    this.FriendKey.Equals(input.FriendKey))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.UserIcon != null)
                    hashCode = hashCode * 59 + this.UserIcon.GetHashCode();
                if (this.Bio != null)
                    hashCode = hashCode * 59 + this.Bio.GetHashCode();
                if (this.BioLinks != null)
                    hashCode = hashCode * 59 + this.BioLinks.GetHashCode();
                if (this.ProfilePicOverride != null)
                    hashCode = hashCode * 59 + this.ProfilePicOverride.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.CurrentAvatarImageUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarImageUrl.GetHashCode();
                if (this.CurrentAvatarThumbnailImageUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                if (this.FallbackAvatar != null)
                    hashCode = hashCode * 59 + this.FallbackAvatar.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DeveloperType != null)
                    hashCode = hashCode * 59 + this.DeveloperType.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.LastPlatform != null)
                    hashCode = hashCode * 59 + this.LastPlatform.GetHashCode();
                if (this.AllowAvatarCopying != null)
                    hashCode = hashCode * 59 + this.AllowAvatarCopying.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DateJoined != null)
                    hashCode = hashCode * 59 + this.DateJoined.GetHashCode();
                if (this.IsFriend != null)
                    hashCode = hashCode * 59 + this.IsFriend.GetHashCode();
                if (this.FriendKey != null)
                    hashCode = hashCode * 59 + this.FriendKey.GetHashCode();
                if (this.WorldId != null)
                    hashCode = hashCode * 59 + this.WorldId.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
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

 
            // FallbackAvatar (string) pattern
            Regex regexFallbackAvatar = new Regex(@"avtr_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexFallbackAvatar.Match(this.FallbackAvatar).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FallbackAvatar, must match a pattern of " + regexFallbackAvatar, new [] { "FallbackAvatar" });
            }


 
            // WorldId (string) pattern
            Regex regexWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexWorldId.Match(this.WorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorldId, must match a pattern of " + regexWorldId, new [] { "WorldId" });
            }

            yield break;
        }
    }

}
