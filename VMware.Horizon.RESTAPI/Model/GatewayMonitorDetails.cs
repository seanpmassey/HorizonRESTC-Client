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
    /// Details of the Gateway.
    /// </summary>
    [DataContract]
    public partial class GatewayMonitorDetails :  IEquatable<GatewayMonitorDetails>
    {
        /// <summary>
        /// Type of the Gateway. * UAG: Unified Access Gateway type. * F5: F5 Gateway type. * UNKNOWN: Unknown type.
        /// </summary>
        /// <value>Type of the Gateway. * UAG: Unified Access Gateway type. * F5: F5 Gateway type. * UNKNOWN: Unknown type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum UAG for value: UAG
            /// </summary>
            [EnumMember(Value = "UAG")]
            UAG = 1,
            
            /// <summary>
            /// Enum F5 for value: F5
            /// </summary>
            [EnumMember(Value = "F5")]
            F5 = 2,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 3
        }

        /// <summary>
        /// Type of the Gateway. * UAG: Unified Access Gateway type. * F5: F5 Gateway type. * UNKNOWN: Unknown type.
        /// </summary>
        /// <value>Type of the Gateway. * UAG: Unified Access Gateway type. * F5: F5 Gateway type. * UNKNOWN: Unknown type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayMonitorDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayMonitorDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayMonitorDetails" /> class.
        /// </summary>
        /// <param name="address">Gateway host name or IP address. (required).</param>
        /// <param name="_internal">Indicates if the Gateway is internal. (required).</param>
        /// <param name="type">Type of the Gateway. * UAG: Unified Access Gateway type. * F5: F5 Gateway type. * UNKNOWN: Unknown type. (required).</param>
        /// <param name="version">Version of the Gateway. (required).</param>
        public GatewayMonitorDetails(string address = default(string), bool? _internal = default(bool?), TypeEnum type = default(TypeEnum), string version = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for GatewayMonitorDetails and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "_internal" is required (not null)
            if (_internal == null)
            {
                throw new InvalidDataException("_internal is a required property for GatewayMonitorDetails and cannot be null");
            }
            else
            {
                this.Internal = _internal;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GatewayMonitorDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for GatewayMonitorDetails and cannot be null");
            }
            else
            {
                this.Version = version;
            }
        }
        
        /// <summary>
        /// Gateway host name or IP address.
        /// </summary>
        /// <value>Gateway host name or IP address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Indicates if the Gateway is internal.
        /// </summary>
        /// <value>Indicates if the Gateway is internal.</value>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public bool? Internal { get; set; }


        /// <summary>
        /// Version of the Gateway.
        /// </summary>
        /// <value>Version of the Gateway.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewayMonitorDetails {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
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
            return this.Equals(input as GatewayMonitorDetails);
        }

        /// <summary>
        /// Returns true if GatewayMonitorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayMonitorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayMonitorDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && 
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
