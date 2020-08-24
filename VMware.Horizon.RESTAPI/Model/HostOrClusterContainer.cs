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
    /// Details of the host or cluster container node.
    /// </summary>
    [DataContract]
    public partial class HostOrClusterContainer :  IEquatable<HostOrClusterContainer>
    {
        /// <summary>
        /// Type of container. * FOLDER: A folder container. * OTHER: Other container type.
        /// </summary>
        /// <value>Type of container. * FOLDER: A folder container. * OTHER: Other container type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum FOLDER for value: FOLDER
            /// </summary>
            [EnumMember(Value = "FOLDER")]
            FOLDER = 1,
            
            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 2
        }

        /// <summary>
        /// Type of container. * FOLDER: A folder container. * OTHER: Other container type.
        /// </summary>
        /// <value>Type of container. * FOLDER: A folder container. * OTHER: Other container type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostOrClusterContainer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HostOrClusterContainer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostOrClusterContainer" /> class.
        /// </summary>
        /// <param name="children">Contents of the container. These may be hosts or clusters or further nested containers..</param>
        /// <param name="name">Host or cluster container node display name. (required).</param>
        /// <param name="path">Host or cluster container node path. (required).</param>
        /// <param name="type">Type of container. * FOLDER: A folder container. * OTHER: Other container type. (required).</param>
        public HostOrClusterContainer(List<HostOrClusterInfo> children = default(List<HostOrClusterInfo>), string name = default(string), string path = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for HostOrClusterContainer and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for HostOrClusterContainer and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for HostOrClusterContainer and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Children = children;
        }
        
        /// <summary>
        /// Contents of the container. These may be hosts or clusters or further nested containers.
        /// </summary>
        /// <value>Contents of the container. These may be hosts or clusters or further nested containers.</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<HostOrClusterInfo> Children { get; set; }

        /// <summary>
        /// Host or cluster container node display name.
        /// </summary>
        /// <value>Host or cluster container node display name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Host or cluster container node path.
        /// </summary>
        /// <value>Host or cluster container node path.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostOrClusterContainer {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as HostOrClusterContainer);
        }

        /// <summary>
        /// Returns true if HostOrClusterContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of HostOrClusterContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostOrClusterContainer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}