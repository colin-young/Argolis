using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;
using NullGuard;

namespace Hydra.Core
{
    /// <summary>
    /// A Hydra property
    /// </summary>
    [NullGuard(ValidationFlags.AllPublic ^ ValidationFlags.Properties)]
    public class SupportedProperty : Resource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedProperty"/> class.
        /// </summary>
        public SupportedProperty()
        {
            SupportedOperations = new System.Collections.ObjectModel.Collection<Operation>();
            Property = new Property();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SupportedProperty"/> is required.
        /// </summary>
        [JsonProperty(Hydra.required)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether property can be read.
        /// </summary>
        [JsonProperty(Hydra.readable)]
        public bool Readable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether property can be written.
        /// </summary>
        [JsonProperty(Hydra.writeable)]
        public bool Writeable { get; set; }

        /// <summary>
        /// Gets the supported operations.
        /// </summary>
        [JsonProperty(Hydra.supportedOperation)]
        public ICollection<Operation> SupportedOperations { get; private set; }

        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        [JsonProperty(Hydra.property)]
        public Property Property { get; set; }

        [JsonProperty, UsedImplicitly]
        private string Type
        {
            get { return Hydra.SupportedProperty; }
        }
    }
}
