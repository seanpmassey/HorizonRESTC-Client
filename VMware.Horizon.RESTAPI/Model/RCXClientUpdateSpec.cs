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
    /// Update specification for the RCX client.
    /// </summary>
    [DataContract]
    public partial class RCXClientUpdateSpec :  IEquatable<RCXClientUpdateSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RCXClientUpdateSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RCXClientUpdateSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RCXClientUpdateSpec" /> class.
        /// </summary>
        /// <param name="ipAddress">IP address of the RCX client..</param>
        /// <param name="thumbprints">Thumbprints of the RCX client certificate. (required).</param>
        public RCXClientUpdateSpec(string ipAddress = default(string), List<CertificateThumbprint> thumbprints = default(List<CertificateThumbprint>))
        {
            // to ensure "thumbprints" is required (not null)
            if (thumbprints == null)
            {
                throw new InvalidDataException("thumbprints is a required property for RCXClientUpdateSpec and cannot be null");
            }
            else
            {
                this.Thumbprints = thumbprints;
            }
            this.IpAddress = ipAddress;
        }
        
        /// <summary>
        /// IP address of the RCX client.
        /// </summary>
        /// <value>IP address of the RCX client.</value>
        [DataMember(Name="ip_address", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Thumbprints of the RCX client certificate.
        /// </summary>
        /// <value>Thumbprints of the RCX client certificate.</value>
        [DataMember(Name="thumbprints", EmitDefaultValue=false)]
        public List<CertificateThumbprint> Thumbprints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RCXClientUpdateSpec {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Thumbprints: ").Append(Thumbprints).Append("\n");
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
            return this.Equals(input as RCXClientUpdateSpec);
        }

        /// <summary>
        /// Returns true if RCXClientUpdateSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of RCXClientUpdateSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RCXClientUpdateSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Thumbprints == input.Thumbprints ||
                    this.Thumbprints != null &&
                    this.Thumbprints.SequenceEqual(input.Thumbprints)
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Thumbprints != null)
                    hashCode = hashCode * 59 + this.Thumbprints.GetHashCode();
                return hashCode;
            }
        }
    }

}
