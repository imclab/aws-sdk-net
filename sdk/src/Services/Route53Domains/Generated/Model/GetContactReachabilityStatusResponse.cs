/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// This is the response object from the GetContactReachabilityStatus operation.
    /// </summary>
    public partial class GetContactReachabilityStatusResponse : AmazonWebServiceResponse
    {
        private string _domainName;
        private ReachabilityStatus _status;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for which you requested the reachability status.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the registrant contact has responded. <code>PENDING</code> indicates that
        /// we sent the confirmation email and haven't received a response yet, <code>DONE</code>
        /// indicates that we sent the email and got confirmation from the registrant contact,
        /// and <code>EXPIRED</code> indicates that the time limit expired before the registrant
        /// contact responded. 
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>PENDING</code>, <code>DONE</code>, <code>EXPIRED</code>
        /// </para>
        /// </summary>
        public ReachabilityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}