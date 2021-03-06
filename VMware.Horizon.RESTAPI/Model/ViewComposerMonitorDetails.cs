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
    /// Details of the View Composer.
    /// </summary>
    [DataContract]
    public partial class ViewComposerMonitorDetails :  IEquatable<ViewComposerMonitorDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewComposerMonitorDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ViewComposerMonitorDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewComposerMonitorDetails" /> class.
        /// </summary>
        /// <param name="apiVerion">The version of the View Composer API used to communicate with the View Composer server. (required).</param>
        /// <param name="build">The build of the View Composer server. (required).</param>
        /// <param name="minEsxVersion">The minimum ESX version required for compatibility with this View Composer server. (required).</param>
        /// <param name="minVcVersion">The minimum Virtual Center version required for compatibility with this View Composer server. (required).</param>
        /// <param name="referencedVcs">The Virtual Center servers referencing to this View Composer. (required).</param>
        /// <param name="version">The version of the View Composer server. (required).</param>
        public ViewComposerMonitorDetails(string apiVerion = default(string), string build = default(string), string minEsxVersion = default(string), string minVcVersion = default(string), List<string> referencedVcs = default(List<string>), string version = default(string))
        {
            // to ensure "apiVerion" is required (not null)
            if (apiVerion == null)
            {
                throw new InvalidDataException("apiVerion is a required property for ViewComposerMonitorDetails and cannot be null");
            }
            else
            {
                this.ApiVerion = apiVerion;
            }
            // to ensure "build" is required (not null)
            if (build == null)
            {
                throw new InvalidDataException("build is a required property for ViewComposerMonitorDetails and cannot be null");
            }
            else
            {
                this.Build = build;
            }
            // to ensure "minEsxVersion" is required (not null)
            if (minEsxVersion == null)
            {
                throw new InvalidDataException("minEsxVersion is a required property for ViewComposerMonitorDetails and cannot be null");
            }
            else
            {
                this.MinEsxVersion = minEsxVersion;
            }
            // to ensure "minVcVersion" is required (not null)
            if (minVcVersion == null)
            {
                throw new InvalidDataException("minVcVersion is a required property for ViewComposerMonitorDetails and cannot be null");
            }
            else
            {
                this.MinVcVersion = minVcVersion;
            }
            // to ensure "referencedVcs" is required (not null)
            if (referencedVcs == null)
            {
                throw new InvalidDataException("referencedVcs is a required property for ViewComposerMonitorDetails and cannot be null");
            }
            else
            {
                this.ReferencedVcs = referencedVcs;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for ViewComposerMonitorDetails and cannot be null");
            }
            else
            {
                this.Version = version;
            }
        }
        
        /// <summary>
        /// The version of the View Composer API used to communicate with the View Composer server.
        /// </summary>
        /// <value>The version of the View Composer API used to communicate with the View Composer server.</value>
        [DataMember(Name="api_verion", EmitDefaultValue=false)]
        public string ApiVerion { get; set; }

        /// <summary>
        /// The build of the View Composer server.
        /// </summary>
        /// <value>The build of the View Composer server.</value>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public string Build { get; set; }

        /// <summary>
        /// The minimum ESX version required for compatibility with this View Composer server.
        /// </summary>
        /// <value>The minimum ESX version required for compatibility with this View Composer server.</value>
        [DataMember(Name="min_esx_version", EmitDefaultValue=false)]
        public string MinEsxVersion { get; set; }

        /// <summary>
        /// The minimum Virtual Center version required for compatibility with this View Composer server.
        /// </summary>
        /// <value>The minimum Virtual Center version required for compatibility with this View Composer server.</value>
        [DataMember(Name="min_vc_version", EmitDefaultValue=false)]
        public string MinVcVersion { get; set; }

        /// <summary>
        /// The Virtual Center servers referencing to this View Composer.
        /// </summary>
        /// <value>The Virtual Center servers referencing to this View Composer.</value>
        [DataMember(Name="referenced_vcs", EmitDefaultValue=false)]
        public List<string> ReferencedVcs { get; set; }

        /// <summary>
        /// The version of the View Composer server.
        /// </summary>
        /// <value>The version of the View Composer server.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewComposerMonitorDetails {\n");
            sb.Append("  ApiVerion: ").Append(ApiVerion).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  MinEsxVersion: ").Append(MinEsxVersion).Append("\n");
            sb.Append("  MinVcVersion: ").Append(MinVcVersion).Append("\n");
            sb.Append("  ReferencedVcs: ").Append(ReferencedVcs).Append("\n");
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
            return this.Equals(input as ViewComposerMonitorDetails);
        }

        /// <summary>
        /// Returns true if ViewComposerMonitorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewComposerMonitorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewComposerMonitorDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVerion == input.ApiVerion ||
                    (this.ApiVerion != null &&
                    this.ApiVerion.Equals(input.ApiVerion))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.MinEsxVersion == input.MinEsxVersion ||
                    (this.MinEsxVersion != null &&
                    this.MinEsxVersion.Equals(input.MinEsxVersion))
                ) && 
                (
                    this.MinVcVersion == input.MinVcVersion ||
                    (this.MinVcVersion != null &&
                    this.MinVcVersion.Equals(input.MinVcVersion))
                ) && 
                (
                    this.ReferencedVcs == input.ReferencedVcs ||
                    this.ReferencedVcs != null &&
                    this.ReferencedVcs.SequenceEqual(input.ReferencedVcs)
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
                if (this.ApiVerion != null)
                    hashCode = hashCode * 59 + this.ApiVerion.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.MinEsxVersion != null)
                    hashCode = hashCode * 59 + this.MinEsxVersion.GetHashCode();
                if (this.MinVcVersion != null)
                    hashCode = hashCode * 59 + this.MinVcVersion.GetHashCode();
                if (this.ReferencedVcs != null)
                    hashCode = hashCode * 59 + this.ReferencedVcs.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
