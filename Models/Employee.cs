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
    public partial class Employee :  IEquatable<Employee>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// id of organisation (tenant)
        /// </summary>
        /// <value>id of organisation (tenant)</value>
        [Required]
        [DataMember(Name="tenantid")]
        public int? Tenantid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or Sets Thirdname
        /// </summary>
        [DataMember(Name="thirdname")]
        public string Thirdname { get; set; }

        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name="login")]
        public string Login { get; set; }

        /// <summary>
        /// Gets or Sets Passord
        /// </summary>
        [DataMember(Name="passord")]
        public string Passord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Employee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tenantid: ").Append(Tenantid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Thirdname: ").Append(Thirdname).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Passord: ").Append(Passord).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Employee)obj);
        }

        /// <summary>
        /// Returns true if Employee instances are equal
        /// </summary>
        /// <param name="other">Instance of Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employee other)
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
                    Tenantid == other.Tenantid ||
                    Tenantid != null &&
                    Tenantid.Equals(other.Tenantid)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Lastname == other.Lastname ||
                    Lastname != null &&
                    Lastname.Equals(other.Lastname)
                ) && 
                (
                    Thirdname == other.Thirdname ||
                    Thirdname != null &&
                    Thirdname.Equals(other.Thirdname)
                ) && 
                (
                    Login == other.Login ||
                    Login != null &&
                    Login.Equals(other.Login)
                ) && 
                (
                    Passord == other.Passord ||
                    Passord != null &&
                    Passord.Equals(other.Passord)
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
                    if (Tenantid != null)
                    hashCode = hashCode * 59 + Tenantid.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Lastname != null)
                    hashCode = hashCode * 59 + Lastname.GetHashCode();
                    if (Thirdname != null)
                    hashCode = hashCode * 59 + Thirdname.GetHashCode();
                    if (Login != null)
                    hashCode = hashCode * 59 + Login.GetHashCode();
                    if (Passord != null)
                    hashCode = hashCode * 59 + Passord.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Employee left, Employee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
