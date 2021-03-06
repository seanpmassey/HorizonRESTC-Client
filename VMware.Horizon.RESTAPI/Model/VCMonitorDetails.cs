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
    /// Details about the Virtual Center.
    /// </summary>
    [DataContract]
    public partial class VCMonitorDetails :  IEquatable<VCMonitorDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VCMonitorDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorDetails" /> class.
        /// </summary>
        /// <param name="apiVersion">API Version of the Virtual Center. (required).</param>
        /// <param name="build">Build number of the Virtual Center. (required).</param>
        /// <param name="version">Version of the Virtual Center. (required).</param>
        public VCMonitorDetails(string apiVersion = default(string), string build = default(string), string version = default(string))
        {
            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null)
            {
                throw new InvalidDataException("apiVersion is a required property for VCMonitorDetails and cannot be null");
            }
            else
            {
                this.ApiVersion = apiVersion;
            }
            // to ensure "build" is required (not null)
            if (build == null)
            {
                throw new InvalidDataException("build is a required property for VCMonitorDetails and cannot be null");
            }
            else
            {
                this.Build = build;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for VCMonitorDetails and cannot be null");
            }
            else
            {
                this.Version = version;
            }
        }
        
        /// <summary>
        /// API Version of the Virtual Center.
        /// </summary>
        /// <value>API Version of the Virtual Center.</value>
        [DataMember(Name="api_version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Build number of the Virtual Center.
        /// </summary>
        /// <value>Build number of the Virtual Center.</value>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public string Build { get; set; }

        /// <summary>
        /// Version of the Virtual Center.
        /// </summary>
        /// <value>Version of the Virtual Center.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VCMonitorDetails {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
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
            return this.Equals(input as VCMonitorDetails);
        }

        /// <summary>
        /// Returns true if VCMonitorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of VCMonitorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VCMonitorDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
