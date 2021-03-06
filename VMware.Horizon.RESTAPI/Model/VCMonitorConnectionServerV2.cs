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
    /// Information about connection to Virtual Center from Connection Server.
    /// </summary>
    [DataContract]
    public partial class VCMonitorConnectionServerV2 :  IEquatable<VCMonitorConnectionServerV2>
    {
        /// <summary>
        /// Status of the Virtual Center Connection with respect to this Connection Server. * OK: The connection to Virtual Center server is working properly. * DOWN: The connection to Virtual Center server is down. * RECONNECTING: The connection to Virtual Center server was lost and is being reconnected to. * UNKNOWN: Connection state to Virtual Center server is unknown. * INVALID_CREDENTIALS: The supplied credentials cannot be used to authenticate to the Virtual Center server. * CANNOT_LOGIN: The connection server cannot login to the Virtual Center server. * NOT_YET_CONNECTED: Connection server has not yet connected to Virtual Center server.
        /// </summary>
        /// <value>Status of the Virtual Center Connection with respect to this Connection Server. * OK: The connection to Virtual Center server is working properly. * DOWN: The connection to Virtual Center server is down. * RECONNECTING: The connection to Virtual Center server was lost and is being reconnected to. * UNKNOWN: Connection state to Virtual Center server is unknown. * INVALID_CREDENTIALS: The supplied credentials cannot be used to authenticate to the Virtual Center server. * CANNOT_LOGIN: The connection server cannot login to the Virtual Center server. * NOT_YET_CONNECTED: Connection server has not yet connected to Virtual Center server.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,
            
            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            [EnumMember(Value = "DOWN")]
            DOWN = 2,
            
            /// <summary>
            /// Enum RECONNECTING for value: RECONNECTING
            /// </summary>
            [EnumMember(Value = "RECONNECTING")]
            RECONNECTING = 3,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 4,
            
            /// <summary>
            /// Enum INVALIDCREDENTIALS for value: INVALID_CREDENTIALS
            /// </summary>
            [EnumMember(Value = "INVALID_CREDENTIALS")]
            INVALIDCREDENTIALS = 5,
            
            /// <summary>
            /// Enum CANNOTLOGIN for value: CANNOT_LOGIN
            /// </summary>
            [EnumMember(Value = "CANNOT_LOGIN")]
            CANNOTLOGIN = 6,
            
            /// <summary>
            /// Enum NOTYETCONNECTED for value: NOT_YET_CONNECTED
            /// </summary>
            [EnumMember(Value = "NOT_YET_CONNECTED")]
            NOTYETCONNECTED = 7
        }

        /// <summary>
        /// Status of the Virtual Center Connection with respect to this Connection Server. * OK: The connection to Virtual Center server is working properly. * DOWN: The connection to Virtual Center server is down. * RECONNECTING: The connection to Virtual Center server was lost and is being reconnected to. * UNKNOWN: Connection state to Virtual Center server is unknown. * INVALID_CREDENTIALS: The supplied credentials cannot be used to authenticate to the Virtual Center server. * CANNOT_LOGIN: The connection server cannot login to the Virtual Center server. * NOT_YET_CONNECTED: Connection server has not yet connected to Virtual Center server.
        /// </summary>
        /// <value>Status of the Virtual Center Connection with respect to this Connection Server. * OK: The connection to Virtual Center server is working properly. * DOWN: The connection to Virtual Center server is down. * RECONNECTING: The connection to Virtual Center server was lost and is being reconnected to. * UNKNOWN: Connection state to Virtual Center server is unknown. * INVALID_CREDENTIALS: The supplied credentials cannot be used to authenticate to the Virtual Center server. * CANNOT_LOGIN: The connection server cannot login to the Virtual Center server. * NOT_YET_CONNECTED: Connection server has not yet connected to Virtual Center server.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorConnectionServerV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VCMonitorConnectionServerV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorConnectionServerV2" /> class.
        /// </summary>
        /// <param name="certificate">The certificate data..</param>
        /// <param name="id">Unique ID of the Connection Server. (required).</param>
        /// <param name="lastUpdatedTimestamp">The timestamp in milliseconds when the last update was obtained. Measured as epoch time..</param>
        /// <param name="name">Connection server host name or IP address. (required).</param>
        /// <param name="status">Status of the Virtual Center Connection with respect to this Connection Server. * OK: The connection to Virtual Center server is working properly. * DOWN: The connection to Virtual Center server is down. * RECONNECTING: The connection to Virtual Center server was lost and is being reconnected to. * UNKNOWN: Connection state to Virtual Center server is unknown. * INVALID_CREDENTIALS: The supplied credentials cannot be used to authenticate to the Virtual Center server. * CANNOT_LOGIN: The connection server cannot login to the Virtual Center server. * NOT_YET_CONNECTED: Connection server has not yet connected to Virtual Center server. (required).</param>
        /// <param name="thumbprintAccepted">Indicates if the thumbprints of the Virtual Center was accepted. (required).</param>
        public VCMonitorConnectionServerV2(CertificateMonitorInfo certificate = default(CertificateMonitorInfo), string id = default(string), long? lastUpdatedTimestamp = default(long?), string name = default(string), StatusEnum status = default(StatusEnum), bool? thumbprintAccepted = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for VCMonitorConnectionServerV2 and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for VCMonitorConnectionServerV2 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for VCMonitorConnectionServerV2 and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "thumbprintAccepted" is required (not null)
            if (thumbprintAccepted == null)
            {
                throw new InvalidDataException("thumbprintAccepted is a required property for VCMonitorConnectionServerV2 and cannot be null");
            }
            else
            {
                this.ThumbprintAccepted = thumbprintAccepted;
            }
            this.Certificate = certificate;
            this.LastUpdatedTimestamp = lastUpdatedTimestamp;
        }
        
        /// <summary>
        /// The certificate data.
        /// </summary>
        /// <value>The certificate data.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public CertificateMonitorInfo Certificate { get; set; }

        /// <summary>
        /// Unique ID of the Connection Server.
        /// </summary>
        /// <value>Unique ID of the Connection Server.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The timestamp in milliseconds when the last update was obtained. Measured as epoch time.
        /// </summary>
        /// <value>The timestamp in milliseconds when the last update was obtained. Measured as epoch time.</value>
        [DataMember(Name="last_updated_timestamp", EmitDefaultValue=false)]
        public long? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Connection server host name or IP address.
        /// </summary>
        /// <value>Connection server host name or IP address.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Indicates if the thumbprints of the Virtual Center was accepted.
        /// </summary>
        /// <value>Indicates if the thumbprints of the Virtual Center was accepted.</value>
        [DataMember(Name="thumbprint_accepted", EmitDefaultValue=false)]
        public bool? ThumbprintAccepted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VCMonitorConnectionServerV2 {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastUpdatedTimestamp: ").Append(LastUpdatedTimestamp).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ThumbprintAccepted: ").Append(ThumbprintAccepted).Append("\n");
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
            return this.Equals(input as VCMonitorConnectionServerV2);
        }

        /// <summary>
        /// Returns true if VCMonitorConnectionServerV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of VCMonitorConnectionServerV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VCMonitorConnectionServerV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastUpdatedTimestamp == input.LastUpdatedTimestamp ||
                    (this.LastUpdatedTimestamp != null &&
                    this.LastUpdatedTimestamp.Equals(input.LastUpdatedTimestamp))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ThumbprintAccepted == input.ThumbprintAccepted ||
                    (this.ThumbprintAccepted != null &&
                    this.ThumbprintAccepted.Equals(input.ThumbprintAccepted))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastUpdatedTimestamp != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimestamp.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ThumbprintAccepted != null)
                    hashCode = hashCode * 59 + this.ThumbprintAccepted.GetHashCode();
                return hashCode;
            }
        }
    }

}
