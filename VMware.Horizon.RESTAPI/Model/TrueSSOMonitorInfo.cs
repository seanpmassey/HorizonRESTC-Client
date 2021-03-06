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
    /// Monitoring information related to the True SSO Connector.
    /// </summary>
    [DataContract]
    public partial class TrueSSOMonitorInfo :  IEquatable<TrueSSOMonitorInfo>
    {
        /// <summary>
        /// The state of the domain health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the domain is OK as reported by the enrollment servers. * WARN: At least one of the enrollment servers has a warning. * ERROR: At least one of the enrollment servers is in an error state.
        /// </summary>
        /// <value>The state of the domain health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the domain is OK as reported by the enrollment servers. * WARN: At least one of the enrollment servers has a warning. * ERROR: At least one of the enrollment servers is in an error state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdDomainStatusEnum
        {
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,
            
            /// <summary>
            /// Enum WARN for value: WARN
            /// </summary>
            [EnumMember(Value = "WARN")]
            WARN = 2,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3
        }

        /// <summary>
        /// The state of the domain health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the domain is OK as reported by the enrollment servers. * WARN: At least one of the enrollment servers has a warning. * ERROR: At least one of the enrollment servers is in an error state.
        /// </summary>
        /// <value>The state of the domain health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the domain is OK as reported by the enrollment servers. * WARN: At least one of the enrollment servers has a warning. * ERROR: At least one of the enrollment servers is in an error state.</value>
        [DataMember(Name="ad_domain_status", EmitDefaultValue=false)]
        public AdDomainStatusEnum AdDomainStatus { get; set; }
        /// <summary>
        /// Overall status of the True SSO connector. * OK: All the components of the True SSO connector are fine. * WARN: At least one component of the True SSO connector has a warning. * ERROR: At least one component of the True SSO connector has an error.
        /// </summary>
        /// <value>Overall status of the True SSO connector. * OK: All the components of the True SSO connector are fine. * WARN: At least one component of the True SSO connector has a warning. * ERROR: At least one component of the True SSO connector has an error.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,
            
            /// <summary>
            /// Enum WARN for value: WARN
            /// </summary>
            [EnumMember(Value = "WARN")]
            WARN = 2,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3
        }

        /// <summary>
        /// Overall status of the True SSO connector. * OK: All the components of the True SSO connector are fine. * WARN: At least one component of the True SSO connector has a warning. * ERROR: At least one component of the True SSO connector has an error.
        /// </summary>
        /// <value>Overall status of the True SSO connector. * OK: All the components of the True SSO connector are fine. * WARN: At least one component of the True SSO connector has a warning. * ERROR: At least one component of the True SSO connector has an error.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// The state of the template health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the template is OK as reported by the enrollment servers. * WARN: At least one enrollment server reports a warning on this template. * ERROR: At least one enrollment server reports an error on this template.
        /// </summary>
        /// <value>The state of the template health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the template is OK as reported by the enrollment servers. * WARN: At least one enrollment server reports a warning on this template. * ERROR: At least one enrollment server reports an error on this template.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TemplateStatusEnum
        {
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,
            
            /// <summary>
            /// Enum WARN for value: WARN
            /// </summary>
            [EnumMember(Value = "WARN")]
            WARN = 2,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3
        }

        /// <summary>
        /// The state of the template health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the template is OK as reported by the enrollment servers. * WARN: At least one enrollment server reports a warning on this template. * ERROR: At least one enrollment server reports an error on this template.
        /// </summary>
        /// <value>The state of the template health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the template is OK as reported by the enrollment servers. * WARN: At least one enrollment server reports a warning on this template. * ERROR: At least one enrollment server reports an error on this template.</value>
        [DataMember(Name="template_status", EmitDefaultValue=false)]
        public TemplateStatusEnum TemplateStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueSSOMonitorInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrueSSOMonitorInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueSSOMonitorInfo" /> class.
        /// </summary>
        /// <param name="adDomainDnsName">The DNS name of the domain. (required).</param>
        /// <param name="adDomainId">Unique ID of the AD Domain. (required).</param>
        /// <param name="adDomainStatus">The state of the domain health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the domain is OK as reported by the enrollment servers. * WARN: At least one of the enrollment servers has a warning. * ERROR: At least one of the enrollment servers is in an error state. (required).</param>
        /// <param name="certificateServerDetails">Details of each certificate server. (required).</param>
        /// <param name="enabled">Indicates if the True SSO connector is enabled. (required).</param>
        /// <param name="id">Unique ID of the True SSO Connector. (required).</param>
        /// <param name="name">True SSO connector name. (required).</param>
        /// <param name="primaryEnrollmentServer">The primary enrollment server details. (required).</param>
        /// <param name="secondaryEnrollmentServer">The secondary enrollment server details..</param>
        /// <param name="status">Overall status of the True SSO connector. * OK: All the components of the True SSO connector are fine. * WARN: At least one component of the True SSO connector has a warning. * ERROR: At least one component of the True SSO connector has an error. (required).</param>
        /// <param name="templateName">Unique name for the True SSO template. (required).</param>
        /// <param name="templateStatus">The state of the template health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the template is OK as reported by the enrollment servers. * WARN: At least one enrollment server reports a warning on this template. * ERROR: At least one enrollment server reports an error on this template. (required).</param>
        public TrueSSOMonitorInfo(string adDomainDnsName = default(string), string adDomainId = default(string), AdDomainStatusEnum adDomainStatus = default(AdDomainStatusEnum), List<CertificateServerDetails> certificateServerDetails = default(List<CertificateServerDetails>), bool? enabled = default(bool?), string id = default(string), string name = default(string), EnrollmentServerDetails primaryEnrollmentServer = default(EnrollmentServerDetails), EnrollmentServerDetails secondaryEnrollmentServer = default(EnrollmentServerDetails), StatusEnum status = default(StatusEnum), string templateName = default(string), TemplateStatusEnum templateStatus = default(TemplateStatusEnum))
        {
            // to ensure "adDomainDnsName" is required (not null)
            if (adDomainDnsName == null)
            {
                throw new InvalidDataException("adDomainDnsName is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.AdDomainDnsName = adDomainDnsName;
            }
            // to ensure "adDomainId" is required (not null)
            if (adDomainId == null)
            {
                throw new InvalidDataException("adDomainId is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.AdDomainId = adDomainId;
            }
            // to ensure "adDomainStatus" is required (not null)
            if (adDomainStatus == null)
            {
                throw new InvalidDataException("adDomainStatus is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.AdDomainStatus = adDomainStatus;
            }
            // to ensure "certificateServerDetails" is required (not null)
            if (certificateServerDetails == null)
            {
                throw new InvalidDataException("certificateServerDetails is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.CertificateServerDetails = certificateServerDetails;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "primaryEnrollmentServer" is required (not null)
            if (primaryEnrollmentServer == null)
            {
                throw new InvalidDataException("primaryEnrollmentServer is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.PrimaryEnrollmentServer = primaryEnrollmentServer;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "templateName" is required (not null)
            if (templateName == null)
            {
                throw new InvalidDataException("templateName is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.TemplateName = templateName;
            }
            // to ensure "templateStatus" is required (not null)
            if (templateStatus == null)
            {
                throw new InvalidDataException("templateStatus is a required property for TrueSSOMonitorInfo and cannot be null");
            }
            else
            {
                this.TemplateStatus = templateStatus;
            }
            this.SecondaryEnrollmentServer = secondaryEnrollmentServer;
        }
        
        /// <summary>
        /// The DNS name of the domain.
        /// </summary>
        /// <value>The DNS name of the domain.</value>
        [DataMember(Name="ad_domain_dns_name", EmitDefaultValue=false)]
        public string AdDomainDnsName { get; set; }

        /// <summary>
        /// Unique ID of the AD Domain.
        /// </summary>
        /// <value>Unique ID of the AD Domain.</value>
        [DataMember(Name="ad_domain_id", EmitDefaultValue=false)]
        public string AdDomainId { get; set; }


        /// <summary>
        /// Details of each certificate server.
        /// </summary>
        /// <value>Details of each certificate server.</value>
        [DataMember(Name="certificate_server_details", EmitDefaultValue=false)]
        public List<CertificateServerDetails> CertificateServerDetails { get; set; }

        /// <summary>
        /// Indicates if the True SSO connector is enabled.
        /// </summary>
        /// <value>Indicates if the True SSO connector is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Unique ID of the True SSO Connector.
        /// </summary>
        /// <value>Unique ID of the True SSO Connector.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// True SSO connector name.
        /// </summary>
        /// <value>True SSO connector name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The primary enrollment server details.
        /// </summary>
        /// <value>The primary enrollment server details.</value>
        [DataMember(Name="primary_enrollment_server", EmitDefaultValue=false)]
        public EnrollmentServerDetails PrimaryEnrollmentServer { get; set; }

        /// <summary>
        /// The secondary enrollment server details.
        /// </summary>
        /// <value>The secondary enrollment server details.</value>
        [DataMember(Name="secondary_enrollment_server", EmitDefaultValue=false)]
        public EnrollmentServerDetails SecondaryEnrollmentServer { get; set; }


        /// <summary>
        /// Unique name for the True SSO template.
        /// </summary>
        /// <value>Unique name for the True SSO template.</value>
        [DataMember(Name="template_name", EmitDefaultValue=false)]
        public string TemplateName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrueSSOMonitorInfo {\n");
            sb.Append("  AdDomainDnsName: ").Append(AdDomainDnsName).Append("\n");
            sb.Append("  AdDomainId: ").Append(AdDomainId).Append("\n");
            sb.Append("  AdDomainStatus: ").Append(AdDomainStatus).Append("\n");
            sb.Append("  CertificateServerDetails: ").Append(CertificateServerDetails).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryEnrollmentServer: ").Append(PrimaryEnrollmentServer).Append("\n");
            sb.Append("  SecondaryEnrollmentServer: ").Append(SecondaryEnrollmentServer).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  TemplateStatus: ").Append(TemplateStatus).Append("\n");
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
            return this.Equals(input as TrueSSOMonitorInfo);
        }

        /// <summary>
        /// Returns true if TrueSSOMonitorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TrueSSOMonitorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrueSSOMonitorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdDomainDnsName == input.AdDomainDnsName ||
                    (this.AdDomainDnsName != null &&
                    this.AdDomainDnsName.Equals(input.AdDomainDnsName))
                ) && 
                (
                    this.AdDomainId == input.AdDomainId ||
                    (this.AdDomainId != null &&
                    this.AdDomainId.Equals(input.AdDomainId))
                ) && 
                (
                    this.AdDomainStatus == input.AdDomainStatus ||
                    (this.AdDomainStatus != null &&
                    this.AdDomainStatus.Equals(input.AdDomainStatus))
                ) && 
                (
                    this.CertificateServerDetails == input.CertificateServerDetails ||
                    this.CertificateServerDetails != null &&
                    this.CertificateServerDetails.SequenceEqual(input.CertificateServerDetails)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrimaryEnrollmentServer == input.PrimaryEnrollmentServer ||
                    (this.PrimaryEnrollmentServer != null &&
                    this.PrimaryEnrollmentServer.Equals(input.PrimaryEnrollmentServer))
                ) && 
                (
                    this.SecondaryEnrollmentServer == input.SecondaryEnrollmentServer ||
                    (this.SecondaryEnrollmentServer != null &&
                    this.SecondaryEnrollmentServer.Equals(input.SecondaryEnrollmentServer))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.TemplateStatus == input.TemplateStatus ||
                    (this.TemplateStatus != null &&
                    this.TemplateStatus.Equals(input.TemplateStatus))
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
                if (this.AdDomainDnsName != null)
                    hashCode = hashCode * 59 + this.AdDomainDnsName.GetHashCode();
                if (this.AdDomainId != null)
                    hashCode = hashCode * 59 + this.AdDomainId.GetHashCode();
                if (this.AdDomainStatus != null)
                    hashCode = hashCode * 59 + this.AdDomainStatus.GetHashCode();
                if (this.CertificateServerDetails != null)
                    hashCode = hashCode * 59 + this.CertificateServerDetails.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrimaryEnrollmentServer != null)
                    hashCode = hashCode * 59 + this.PrimaryEnrollmentServer.GetHashCode();
                if (this.SecondaryEnrollmentServer != null)
                    hashCode = hashCode * 59 + this.SecondaryEnrollmentServer.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateStatus != null)
                    hashCode = hashCode * 59 + this.TemplateStatus.GetHashCode();
                return hashCode;
            }
        }
    }

}
