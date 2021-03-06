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
    /// The parameters supplied to the create or update connection operation.
    /// </summary>
    public partial class ConnectionCreateOrUpdateParameters
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the connection.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private ConnectionCreateOrUpdateProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the properties of the connection.
        /// </summary>
        public ConnectionCreateOrUpdateProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionCreateOrUpdateParameters class.
        /// </summary>
        public ConnectionCreateOrUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionCreateOrUpdateParameters class with required arguments.
        /// </summary>
        public ConnectionCreateOrUpdateParameters(string name, ConnectionCreateOrUpdateProperties properties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Name = name;
            this.Properties = properties;
        }
    }
}
