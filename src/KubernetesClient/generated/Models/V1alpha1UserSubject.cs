// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// UserSubject holds detailed information for user-kind subject.
    /// </summary>
    public partial class V1alpha1UserSubject
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1UserSubject class.
        /// </summary>
        public V1alpha1UserSubject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1UserSubject class.
        /// </summary>
        /// <param name="name">`name` is the username that matches, or "*" to
        /// match all usernames. Required.</param>
        public V1alpha1UserSubject(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets `name` is the username that matches, or "*" to match
        /// all usernames. Required.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
