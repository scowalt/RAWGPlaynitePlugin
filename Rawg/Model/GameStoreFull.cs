/* 
 * RAWG Video Games Database API
 *
 *  The largest open video games database.  ### Why build on RAWG - More than 350,000 games for 50 platforms including mobiles. - Rich metadata: tags, genres, developers, publishers, individual creators, official websites, release dates, Metacritic ratings. - Where to buy: links to digital distribution services - Similar games based on visual similarity. - Player activity data: Steam average playtime and RAWG player counts and ratings. - Actively developing and constantly getting better by user contribution and our algorithms.  ### Terms of Use - Free for personal use as long as you attribute RAWG as the source of the data and/or images and add an active hyperlink from every page where the data of RAWG is used. - Free for commercial use for startups and hobby projects with not more than 100,000 monthly active users or 500,000 page views per month. If your project is larger than that, email us at [api@rawg.io](mailto:api@rawg.io) for commercial terms. - No cloning. It would not be cool if you used our API to launch a clone of RAWG. We know it is not always easy to say what is a duplicate and what isn't. Drop us a line at [api@rawg.io](mailto:api@rawg.io) if you are in doubt, and we will talk it through. - Every API request should have a User-Agent header with your app name. If you don???t provide it, we may ban your requests.  __[Read more](https://rawg.io/apidocs)__. 
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Rawg.Model
{
    /// <summary>
    /// GameStoreFull
    /// </summary>
    [DataContract]
    public partial class GameStoreFull :  IEquatable<GameStoreFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameStoreFull" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameStoreFull() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameStoreFull" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        public GameStoreFull(string url = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for GameStoreFull and cannot be null");
            }
            else
            {
                this.Url = url;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="game_id", EmitDefaultValue=false)]
        public string GameId { get; private set; }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="store_id", EmitDefaultValue=false)]
        public string StoreId { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameStoreFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as GameStoreFull);
        }

        /// <summary>
        /// Returns true if GameStoreFull instances are equal
        /// </summary>
        /// <param name="input">Instance of GameStoreFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameStoreFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
            // Url (string) maxLength
            if(this.Url != null && this.Url.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 500.", new [] { "Url" });
            }

            // Url (string) minLength
            if(this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            yield break;
        }
    }

}
