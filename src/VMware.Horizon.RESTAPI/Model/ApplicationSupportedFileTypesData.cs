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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = VMware.Horizon.RESTAPI.Client.SwaggerDateConverter;

namespace VMware.Horizon.RESTAPI.Model
{
    /// <summary>
    /// Information about the file types supported by the application.
    /// </summary>
    [DataContract]
    public partial class ApplicationSupportedFileTypesData :  IEquatable<ApplicationSupportedFileTypesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSupportedFileTypesData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationSupportedFileTypesData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSupportedFileTypesData" /> class.
        /// </summary>
        /// <param name="enableAutoUpdateFileTypes">Whether or not the file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types. Default is true. (required).</param>
        /// <param name="enableAutoUpdateOtherFileTypes">Whether or not the other file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types. (required).</param>
        /// <param name="fileTypes">Set of file types reported by the application as supported (if this application is discovered) or as specified by the administrator (if this application is manually configured). If unset, this application does not present any file type support..</param>
        /// <param name="otherFileTypes">This represents the different file types reported by Application that can be passed from agent to client via broker or as specified by the administrator (if this application is manually configured). If unset, this application does not present any other file type support..</param>
        public ApplicationSupportedFileTypesData(bool? enableAutoUpdateFileTypes = default(bool?), bool? enableAutoUpdateOtherFileTypes = default(bool?), List<ApplicationFileTypeData> fileTypes = default(List<ApplicationFileTypeData>), List<ApplicationOtherFileTypeData> otherFileTypes = default(List<ApplicationOtherFileTypeData>))
        {
            // to ensure "enableAutoUpdateFileTypes" is required (not null)
            if (enableAutoUpdateFileTypes == null)
            {
                throw new InvalidDataException("enableAutoUpdateFileTypes is a required property for ApplicationSupportedFileTypesData and cannot be null");
            }
            else
            {
                this.EnableAutoUpdateFileTypes = enableAutoUpdateFileTypes;
            }
            // to ensure "enableAutoUpdateOtherFileTypes" is required (not null)
            if (enableAutoUpdateOtherFileTypes == null)
            {
                throw new InvalidDataException("enableAutoUpdateOtherFileTypes is a required property for ApplicationSupportedFileTypesData and cannot be null");
            }
            else
            {
                this.EnableAutoUpdateOtherFileTypes = enableAutoUpdateOtherFileTypes;
            }
            this.FileTypes = fileTypes;
            this.OtherFileTypes = otherFileTypes;
        }
        
        /// <summary>
        /// Whether or not the file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types. Default is true.
        /// </summary>
        /// <value>Whether or not the file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types. Default is true.</value>
        [DataMember(Name="enable_auto_update_file_types", EmitDefaultValue=false)]
        public bool? EnableAutoUpdateFileTypes { get; set; }

        /// <summary>
        /// Whether or not the other file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types.
        /// </summary>
        /// <value>Whether or not the other file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types.</value>
        [DataMember(Name="enable_auto_update_other_file_types", EmitDefaultValue=false)]
        public bool? EnableAutoUpdateOtherFileTypes { get; set; }

        /// <summary>
        /// Set of file types reported by the application as supported (if this application is discovered) or as specified by the administrator (if this application is manually configured). If unset, this application does not present any file type support.
        /// </summary>
        /// <value>Set of file types reported by the application as supported (if this application is discovered) or as specified by the administrator (if this application is manually configured). If unset, this application does not present any file type support.</value>
        [DataMember(Name="file_types", EmitDefaultValue=false)]
        public List<ApplicationFileTypeData> FileTypes { get; set; }

        /// <summary>
        /// This represents the different file types reported by Application that can be passed from agent to client via broker or as specified by the administrator (if this application is manually configured). If unset, this application does not present any other file type support.
        /// </summary>
        /// <value>This represents the different file types reported by Application that can be passed from agent to client via broker or as specified by the administrator (if this application is manually configured). If unset, this application does not present any other file type support.</value>
        [DataMember(Name="other_file_types", EmitDefaultValue=false)]
        public List<ApplicationOtherFileTypeData> OtherFileTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationSupportedFileTypesData {\n");
            sb.Append("  EnableAutoUpdateFileTypes: ").Append(EnableAutoUpdateFileTypes).Append("\n");
            sb.Append("  EnableAutoUpdateOtherFileTypes: ").Append(EnableAutoUpdateOtherFileTypes).Append("\n");
            sb.Append("  FileTypes: ").Append(FileTypes).Append("\n");
            sb.Append("  OtherFileTypes: ").Append(OtherFileTypes).Append("\n");
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
            return this.Equals(input as ApplicationSupportedFileTypesData);
        }

        /// <summary>
        /// Returns true if ApplicationSupportedFileTypesData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationSupportedFileTypesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationSupportedFileTypesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableAutoUpdateFileTypes == input.EnableAutoUpdateFileTypes ||
                    (this.EnableAutoUpdateFileTypes != null &&
                    this.EnableAutoUpdateFileTypes.Equals(input.EnableAutoUpdateFileTypes))
                ) && 
                (
                    this.EnableAutoUpdateOtherFileTypes == input.EnableAutoUpdateOtherFileTypes ||
                    (this.EnableAutoUpdateOtherFileTypes != null &&
                    this.EnableAutoUpdateOtherFileTypes.Equals(input.EnableAutoUpdateOtherFileTypes))
                ) && 
                (
                    this.FileTypes == input.FileTypes ||
                    this.FileTypes != null &&
                    this.FileTypes.SequenceEqual(input.FileTypes)
                ) && 
                (
                    this.OtherFileTypes == input.OtherFileTypes ||
                    this.OtherFileTypes != null &&
                    this.OtherFileTypes.SequenceEqual(input.OtherFileTypes)
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
                if (this.EnableAutoUpdateFileTypes != null)
                    hashCode = hashCode * 59 + this.EnableAutoUpdateFileTypes.GetHashCode();
                if (this.EnableAutoUpdateOtherFileTypes != null)
                    hashCode = hashCode * 59 + this.EnableAutoUpdateOtherFileTypes.GetHashCode();
                if (this.FileTypes != null)
                    hashCode = hashCode * 59 + this.FileTypes.GetHashCode();
                if (this.OtherFileTypes != null)
                    hashCode = hashCode * 59 + this.OtherFileTypes.GetHashCode();
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
            yield break;
        }
    }

}