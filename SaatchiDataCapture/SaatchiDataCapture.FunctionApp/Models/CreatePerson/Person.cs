﻿namespace SaatchiDataCapture.FunctionApp.Models.CreatePerson
{
    using System;

    /// <summary>
    /// Represents a person.
    /// </summary>
    public class Person : ModelsBase
    {
        /// <summary>
        /// Gets or sets an instance of <see cref="CreatePerson.Consent" />.
        /// </summary>
        public Consent Consent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instance of <see cref="CreatePerson.Cookie" />.
        /// </summary>
        public Cookie Cookie
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instance of <see cref="CreatePerson.Route" />.
        /// </summary>
        public Route Route
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instance of
        /// <see cref="CreatePerson.ContactDetail" />.
        /// </summary>
        public ContactDetail ContactDetail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DateTime" /> in which the person was
        /// enrolled.
        /// </summary>
        public DateTime Enrolled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName
        {
            get;
            set;
        }
    }
}