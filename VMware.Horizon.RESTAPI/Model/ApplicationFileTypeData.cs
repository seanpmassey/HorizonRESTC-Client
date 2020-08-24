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
    /// Information about the file type supported by the application.
    /// </summary>
    [DataContract]
    public partial class ApplicationFileTypeData :  IEquatable<ApplicationFileTypeData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationFileTypeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationFileTypeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationFileTypeData" /> class.
        /// </summary>
        /// <param name="description">Friendly name for the file type. If unset, no friendly name will be displayed..</param>
        /// <param name="type">File type supported by this application. This value is case insensitive. If multiple file types are specified using the same (case insensitive) name and description, all but one will be ignored. (required).</param>
        public ApplicationFileTypeData(string description = default(string), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ApplicationFileTypeData and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Description = description;
        }
        
        /// <summary>
        /// Friendly name for the file type. If unset, no friendly name will be displayed.
        /// </summary>
        /// <value>Friendly name for the file type. If unset, no friendly name will be displayed.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// File type supported by this application. This value is case insensitive. If multiple file types are specified using the same (case insensitive) name and description, all but one will be ignored.
        /// </summary>
        /// <value>File type supported by this application. This value is case insensitive. If multiple file types are specified using the same (case insensitive) name and description, all but one will be ignored.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationFileTypeData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ApplicationFileTypeData);
        }

        /// <summary>
        /// Returns true if ApplicationFileTypeData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationFileTypeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationFileTypeData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}