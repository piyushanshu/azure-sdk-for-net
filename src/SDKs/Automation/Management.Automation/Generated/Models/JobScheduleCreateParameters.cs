// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create job schedule operation.
    /// </summary>
    public partial class JobScheduleCreateParameters
    {
        private JobScheduleCreateProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the list of job schedule properties.
        /// </summary>
        public JobScheduleCreateProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobScheduleCreateParameters class.
        /// </summary>
        public JobScheduleCreateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the JobScheduleCreateParameters class
        /// with required arguments.
        /// </summary>
        public JobScheduleCreateParameters(JobScheduleCreateProperties properties)
            : this()
        {
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Properties = properties;
        }
    }
}
