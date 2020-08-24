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
    /// Information related to Restricted Horizon Clients.
    /// </summary>
    [DataContract]
    public partial class RestrictedClientData :  IEquatable<RestrictedClientData>
    {
        /// <summary>
        /// The type of Horizon Client. * WINDOWS: The client is the Horizon Client for Windows. * MAC: The client is the Horizon Client for MacOS. * HTMLACCESS: The client is a Web client. * LINUX: The client is the Horizon Client for Linux. * IOS: The client is the Horizon Client for IOS devices. * ANDROID: The client is the Horizon Client for Android. * WINSTORE: The client is the Horizon Client for Windows 10 UWP. * CHROME: The client is the Horizon Client for Chrome Native OS.
        /// </summary>
        /// <value>The type of Horizon Client. * WINDOWS: The client is the Horizon Client for Windows. * MAC: The client is the Horizon Client for MacOS. * HTMLACCESS: The client is a Web client. * LINUX: The client is the Horizon Client for Linux. * IOS: The client is the Horizon Client for IOS devices. * ANDROID: The client is the Horizon Client for Android. * WINSTORE: The client is the Horizon Client for Windows 10 UWP. * CHROME: The client is the Horizon Client for Chrome Native OS.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum WINDOWS for value: WINDOWS
            /// </summary>
            [EnumMember(Value = "WINDOWS")]
            WINDOWS = 1,
            
            /// <summary>
            /// Enum MAC for value: MAC
            /// </summary>
            [EnumMember(Value = "MAC")]
            MAC = 2,
            
            /// <summary>
            /// Enum HTMLACCESS for value: HTMLACCESS
            /// </summary>
            [EnumMember(Value = "HTMLACCESS")]
            HTMLACCESS = 3,
            
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            [EnumMember(Value = "LINUX")]
            LINUX = 4,
            
            /// <summary>
            /// Enum IOS for value: IOS
            /// </summary>
            [EnumMember(Value = "IOS")]
            IOS = 5,
            
            /// <summary>
            /// Enum ANDROID for value: ANDROID
            /// </summary>
            [EnumMember(Value = "ANDROID")]
            ANDROID = 6,
            
            /// <summary>
            /// Enum WINSTORE for value: WINSTORE
            /// </summary>
            [EnumMember(Value = "WINSTORE")]
            WINSTORE = 7,
            
            /// <summary>
            /// Enum CHROME for value: CHROME
            /// </summary>
            [EnumMember(Value = "CHROME")]
            CHROME = 8
        }

        /// <summary>
        /// The type of Horizon Client. * WINDOWS: The client is the Horizon Client for Windows. * MAC: The client is the Horizon Client for MacOS. * HTMLACCESS: The client is a Web client. * LINUX: The client is the Horizon Client for Linux. * IOS: The client is the Horizon Client for IOS devices. * ANDROID: The client is the Horizon Client for Android. * WINSTORE: The client is the Horizon Client for Windows 10 UWP. * CHROME: The client is the Horizon Client for Chrome Native OS.
        /// </summary>
        /// <value>The type of Horizon Client. * WINDOWS: The client is the Horizon Client for Windows. * MAC: The client is the Horizon Client for MacOS. * HTMLACCESS: The client is a Web client. * LINUX: The client is the Horizon Client for Linux. * IOS: The client is the Horizon Client for IOS devices. * ANDROID: The client is the Horizon Client for Android. * WINSTORE: The client is the Horizon Client for Windows 10 UWP. * CHROME: The client is the Horizon Client for Chrome Native OS.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedClientData" /> class.
        /// </summary>
        /// <param name="type">The type of Horizon Client. * WINDOWS: The client is the Horizon Client for Windows. * MAC: The client is the Horizon Client for MacOS. * HTMLACCESS: The client is a Web client. * LINUX: The client is the Horizon Client for Linux. * IOS: The client is the Horizon Client for IOS devices. * ANDROID: The client is the Horizon Client for Android. * WINSTORE: The client is the Horizon Client for Windows 10 UWP. * CHROME: The client is the Horizon Client for Chrome Native OS..</param>
        /// <param name="version">The version of Horizon Client..</param>
        public RestrictedClientData(TypeEnum? type = default(TypeEnum?), string version = default(string))
        {
            this.Type = type;
            this.Version = version;
        }
        

        /// <summary>
        /// The version of Horizon Client.
        /// </summary>
        /// <value>The version of Horizon Client.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestrictedClientData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as RestrictedClientData);
        }

        /// <summary>
        /// Returns true if RestrictedClientData instances are equal
        /// </summary>
        /// <param name="input">Instance of RestrictedClientData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestrictedClientData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}