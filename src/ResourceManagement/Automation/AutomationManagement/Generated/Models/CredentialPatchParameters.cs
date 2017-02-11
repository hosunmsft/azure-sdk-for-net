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
    /// The parameters supplied to the patch credential operation.
    /// </summary>
    public partial class CredentialPatchParameters
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the credential.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private CredentialPatchProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the properties of the variable.
        /// </summary>
        public CredentialPatchProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CredentialPatchParameters class.
        /// </summary>
        public CredentialPatchParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the CredentialPatchParameters class
        /// with required arguments.
        /// </summary>
        public CredentialPatchParameters(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}
