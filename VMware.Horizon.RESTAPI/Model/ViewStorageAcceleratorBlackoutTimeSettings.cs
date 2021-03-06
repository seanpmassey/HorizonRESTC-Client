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
    /// Fields for specifying blackout time for View Storage Accelerator. Storage accelerator regeneration and VM disk space reclamation do not occur during blackout times. The same blackout policy applies to both operations.
    /// </summary>
    [DataContract]
    public partial class ViewStorageAcceleratorBlackoutTimeSettings :  IEquatable<ViewStorageAcceleratorBlackoutTimeSettings>
    {
        /// <summary>
        /// Defines Days
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DaysEnum
        {
            
            /// <summary>
            /// Enum MONDAY for value: MONDAY
            /// </summary>
            [EnumMember(Value = "MONDAY")]
            MONDAY = 1,
            
            /// <summary>
            /// Enum TUESDAY for value: TUESDAY
            /// </summary>
            [EnumMember(Value = "TUESDAY")]
            TUESDAY = 2,
            
            /// <summary>
            /// Enum WEDNESDAY for value: WEDNESDAY
            /// </summary>
            [EnumMember(Value = "WEDNESDAY")]
            WEDNESDAY = 3,
            
            /// <summary>
            /// Enum THURSDAY for value: THURSDAY
            /// </summary>
            [EnumMember(Value = "THURSDAY")]
            THURSDAY = 4,
            
            /// <summary>
            /// Enum FRIDAY for value: FRIDAY
            /// </summary>
            [EnumMember(Value = "FRIDAY")]
            FRIDAY = 5,
            
            /// <summary>
            /// Enum SATURDAY for value: SATURDAY
            /// </summary>
            [EnumMember(Value = "SATURDAY")]
            SATURDAY = 6,
            
            /// <summary>
            /// Enum SUNDAY for value: SUNDAY
            /// </summary>
            [EnumMember(Value = "SUNDAY")]
            SUNDAY = 7,
            
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 8
        }


        /// <summary>
        /// List of days for a given range of time.
        /// </summary>
        /// <value>List of days for a given range of time.</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<DaysEnum> Days { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewStorageAcceleratorBlackoutTimeSettings" /> class.
        /// </summary>
        /// <param name="days">List of days for a given range of time..</param>
        /// <param name="endTime">Ending time for the blackout in 24-hour format..</param>
        /// <param name="startTime">Starting time for the blackout in 24-hour format..</param>
        public ViewStorageAcceleratorBlackoutTimeSettings(List<DaysEnum> days = default(List<DaysEnum>), string endTime = default(string), string startTime = default(string))
        {
            this.Days = days;
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        

        /// <summary>
        /// Ending time for the blackout in 24-hour format.
        /// </summary>
        /// <value>Ending time for the blackout in 24-hour format.</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Starting time for the blackout in 24-hour format.
        /// </summary>
        /// <value>Starting time for the blackout in 24-hour format.</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewStorageAcceleratorBlackoutTimeSettings {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as ViewStorageAcceleratorBlackoutTimeSettings);
        }

        /// <summary>
        /// Returns true if ViewStorageAcceleratorBlackoutTimeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewStorageAcceleratorBlackoutTimeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewStorageAcceleratorBlackoutTimeSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(input.Days)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }

}
