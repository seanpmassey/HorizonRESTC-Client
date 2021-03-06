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
    /// Details of the ESX host of the Virtual Center.
    /// </summary>
    [DataContract]
    public partial class VCMonitorHostDetails :  IEquatable<VCMonitorHostDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorHostDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VCMonitorHostDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorHostDetails" /> class.
        /// </summary>
        /// <param name="apiVersion">API Version of the ESX Host. (required).</param>
        /// <param name="clusterName">Name of the cluster of the ESX Host in the Virtual Center. (required).</param>
        /// <param name="name">ESX Host name or IP address. (required).</param>
        /// <param name="version">ESX Host version. (required).</param>
        /// <param name="vgpuTypes">Types of vGPUs supported by this host..</param>
        public VCMonitorHostDetails(string apiVersion = default(string), string clusterName = default(string), string name = default(string), string version = default(string), List<string> vgpuTypes = default(List<string>))
        {
            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null)
            {
                throw new InvalidDataException("apiVersion is a required property for VCMonitorHostDetails and cannot be null");
            }
            else
            {
                this.ApiVersion = apiVersion;
            }
            // to ensure "clusterName" is required (not null)
            if (clusterName == null)
            {
                throw new InvalidDataException("clusterName is a required property for VCMonitorHostDetails and cannot be null");
            }
            else
            {
                this.ClusterName = clusterName;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for VCMonitorHostDetails and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for VCMonitorHostDetails and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            this.VgpuTypes = vgpuTypes;
        }
        
        /// <summary>
        /// API Version of the ESX Host.
        /// </summary>
        /// <value>API Version of the ESX Host.</value>
        [DataMember(Name="api_version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Name of the cluster of the ESX Host in the Virtual Center.
        /// </summary>
        /// <value>Name of the cluster of the ESX Host in the Virtual Center.</value>
        [DataMember(Name="cluster_name", EmitDefaultValue=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// ESX Host name or IP address.
        /// </summary>
        /// <value>ESX Host name or IP address.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ESX Host version.
        /// </summary>
        /// <value>ESX Host version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Types of vGPUs supported by this host.
        /// </summary>
        /// <value>Types of vGPUs supported by this host.</value>
        [DataMember(Name="vgpu_types", EmitDefaultValue=false)]
        public List<string> VgpuTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VCMonitorHostDetails {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VgpuTypes: ").Append(VgpuTypes).Append("\n");
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
            return this.Equals(input as VCMonitorHostDetails);
        }

        /// <summary>
        /// Returns true if VCMonitorHostDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of VCMonitorHostDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VCMonitorHostDetails input)
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
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VgpuTypes == input.VgpuTypes ||
                    this.VgpuTypes != null &&
                    this.VgpuTypes.SequenceEqual(input.VgpuTypes)
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
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VgpuTypes != null)
                    hashCode = hashCode * 59 + this.VgpuTypes.GetHashCode();
                return hashCode;
            }
        }
    }

}
