/* 
 * Horizon Server API
 *
 * Welcome to the Horizon Server API Reference documentation. This API reference provides comprehensive information about status of all Horizon Server components and resources.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = VMware.Horizon.RESTAPI.Client.SwaggerDateConverter;

namespace VMware.Horizon.RESTAPI.Model
{
    /// <summary>
    /// Authentication Tokens
    /// </summary>
    [DataContract]
    public partial class AuthTokens :  IEquatable<AuthTokens>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokens" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthTokens() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokens" /> class.
        /// </summary>
        /// <param name="accessToken">Access Token to be used in API calls. (required).</param>
        /// <param name="refreshToken">Refresh Token to be used to get a new Access token. (required).</param>
        public AuthTokens(string accessToken = default(string), string refreshToken = default(string))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new InvalidDataException("accessToken is a required property for AuthTokens and cannot be null");
            }
            else
            {
                this.AccessToken = accessToken;
            }
            // to ensure "refreshToken" is required (not null)
            if (refreshToken == null)
            {
                throw new InvalidDataException("refreshToken is a required property for AuthTokens and cannot be null");
            }
            else
            {
                this.RefreshToken = refreshToken;
            }
        }
        
        /// <summary>
        /// Access Token to be used in API calls.
        /// </summary>
        /// <value>Access Token to be used in API calls.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Refresh Token to be used to get a new Access token.
        /// </summary>
        /// <value>Refresh Token to be used to get a new Access token.</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthTokens {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as AuthTokens);
        }

        /// <summary>
        /// Returns true if AuthTokens instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthTokens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthTokens input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                return hashCode;
            }
        }
    }

}
