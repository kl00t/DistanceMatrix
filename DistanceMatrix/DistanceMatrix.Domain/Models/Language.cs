namespace DistanceMatrix.Domain.Models
{
    using Interfaces;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    [Serializable]
    public class Language : ILanguage
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The 2 letter alpha code.
        /// </value>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name of the language
        /// </value>
        [DataMember]
        public string Name { get; set; }
    }
}