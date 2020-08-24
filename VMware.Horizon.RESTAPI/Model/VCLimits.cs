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
    /// Information about the limits configured for Virtual Center
    /// </summary>
    [DataContract]
    public partial class VCLimits :  IEquatable<VCLimits>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCLimits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VCLimits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCLimits" /> class.
        /// </summary>
        /// <param name="instantCloneEngineProvisioningLimit">Maximum concurrent instant clone engine provisioning operations. This property has a default value of 20. This property has a minimum value of 1. (required).</param>
        /// <param name="powerOperationsLimit">Maximum concurrent virtual center power operations. This property has a default value of 50. This property has a minimum value of 1. (required).</param>
        /// <param name="provisioningLimit">Maximum concurrent virtual center provisioning operations. This property has a default value of 20. This property has a minimum value of 1. (required).</param>
        public VCLimits(int? instantCloneEngineProvisioningLimit = default(int?), int? powerOperationsLimit = default(int?), int? provisioningLimit = default(int?))
        {
            // to ensure "instantCloneEngineProvisioningLimit" is required (not null)
            if (instantCloneEngineProvisioningLimit == null)
            {
                throw new InvalidDataException("instantCloneEngineProvisioningLimit is a required property for VCLimits and cannot be null");
            }
            else
            {
                this.InstantCloneEngineProvisioningLimit = instantCloneEngineProvisioningLimit;
            }
            // to ensure "powerOperationsLimit" is required (not null)
            if (powerOperationsLimit == null)
            {
                throw new InvalidDataException("powerOperationsLimit is a required property for VCLimits and cannot be null");
            }
            else
            {
                this.PowerOperationsLimit = powerOperationsLimit;
            }
            // to ensure "provisioningLimit" is required (not null)
            if (provisioningLimit == null)
            {
                throw new InvalidDataException("provisioningLimit is a required property for VCLimits and cannot be null");
            }
            else
            {
                this.ProvisioningLimit = provisioningLimit;
            }
        }
        
        /// <summary>
        /// Maximum concurrent instant clone engine provisioning operations. This property has a default value of 20. This property has a minimum value of 1.
        /// </summary>
        /// <value>Maximum concurrent instant clone engine provisioning operations. This property has a default value of 20. This property has a minimum value of 1.</value>
        [DataMember(Name="instant_clone_engine_provisioning_limit", EmitDefaultValue=false)]
        public int? InstantCloneEngineProvisioningLimit { get; set; }

        /// <summary>
        /// Maximum concurrent virtual center power operations. This property has a default value of 50. This property has a minimum value of 1.
        /// </summary>
        /// <value>Maximum concurrent virtual center power operations. This property has a default value of 50. This property has a minimum value of 1.</value>
        [DataMember(Name="power_operations_limit", EmitDefaultValue=false)]
        public int? PowerOperationsLimit { get; set; }

        /// <summary>
        /// Maximum concurrent virtual center provisioning operations. This property has a default value of 20. This property has a minimum value of 1.
        /// </summary>
        /// <value>Maximum concurrent virtual center provisioning operations. This property has a default value of 20. This property has a minimum value of 1.</value>
        [DataMember(Name="provisioning_limit", EmitDefaultValue=false)]
        public int? ProvisioningLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VCLimits {\n");
            sb.Append("  InstantCloneEngineProvisioningLimit: ").Append(InstantCloneEngineProvisioningLimit).Append("\n");
            sb.Append("  PowerOperationsLimit: ").Append(PowerOperationsLimit).Append("\n");
            sb.Append("  ProvisioningLimit: ").Append(ProvisioningLimit).Append("\n");
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
            return this.Equals(input as VCLimits);
        }

        /// <summary>
        /// Returns true if VCLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of VCLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VCLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstantCloneEngineProvisioningLimit == input.InstantCloneEngineProvisioningLimit ||
                    (this.InstantCloneEngineProvisioningLimit != null &&
                    this.InstantCloneEngineProvisioningLimit.Equals(input.InstantCloneEngineProvisioningLimit))
                ) && 
                (
                    this.PowerOperationsLimit == input.PowerOperationsLimit ||
                    (this.PowerOperationsLimit != null &&
                    this.PowerOperationsLimit.Equals(input.PowerOperationsLimit))
                ) && 
                (
                    this.ProvisioningLimit == input.ProvisioningLimit ||
                    (this.ProvisioningLimit != null &&
                    this.ProvisioningLimit.Equals(input.ProvisioningLimit))
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
                if (this.InstantCloneEngineProvisioningLimit != null)
                    hashCode = hashCode * 59 + this.InstantCloneEngineProvisioningLimit.GetHashCode();
                if (this.PowerOperationsLimit != null)
                    hashCode = hashCode * 59 + this.PowerOperationsLimit.GetHashCode();
                if (this.ProvisioningLimit != null)
                    hashCode = hashCode * 59 + this.ProvisioningLimit.GetHashCode();
                return hashCode;
            }
        }
    }

}