// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Service.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Json query request
    /// </summary>
    public partial class QuerySpecification
    {
        /// <summary>
        /// Initializes a new instance of the QuerySpecification class.
        /// </summary>
        public QuerySpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuerySpecification class.
        /// </summary>
        /// <param name="query">The query.</param>
        public QuerySpecification(string query)
        {
            Query = query;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
        }
    }
}