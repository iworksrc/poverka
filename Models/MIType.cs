/*
 * POVERKA API
 *
 * This is a Poverka  API aka ASUKMO
 *
 * OpenAPI spec version: 1.0.0
 * Contact: imail.for.iwork@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace poverka.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class MIType :  IEquatable<MIType>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Наименование СИ в госреестре РФ
        /// </summary>
        /// <value>Наименование СИ в госреестре РФ</value>
        [DataMember(Name="mi_name")]
        public string MiName { get; set; }

        /// <summary>
        /// Обозначение типа СИ в госреестре РФ
        /// </summary>
        /// <value>Обозначение типа СИ в госреестре РФ</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// номер типа СИ в госреестре РФ
        /// </summary>
        /// <value>номер типа СИ в госреестре РФ</value>
        [DataMember(Name="gosnum")]
        public string Gosnum { get; set; }

        /// <summary>
        /// межповерочный интервал (в месяцах)
        /// </summary>
        /// <value>межповерочный интервал (в месяцах)</value>
        [DataMember(Name="interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MIType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MiName: ").Append(MiName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Gosnum: ").Append(Gosnum).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((MIType)obj);
        }

        /// <summary>
        /// Returns true if MIType instances are equal
        /// </summary>
        /// <param name="other">Instance of MIType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MIType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    MiName == other.MiName ||
                    MiName != null &&
                    MiName.Equals(other.MiName)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Gosnum == other.Gosnum ||
                    Gosnum != null &&
                    Gosnum.Equals(other.Gosnum)
                ) && 
                (
                    Interval == other.Interval ||
                    Interval != null &&
                    Interval.Equals(other.Interval)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (MiName != null)
                    hashCode = hashCode * 59 + MiName.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Gosnum != null)
                    hashCode = hashCode * 59 + Gosnum.GetHashCode();
                    if (Interval != null)
                    hashCode = hashCode * 59 + Interval.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MIType left, MIType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MIType left, MIType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
