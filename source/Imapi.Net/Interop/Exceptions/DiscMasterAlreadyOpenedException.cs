#region License

//
// Author: Ian Davis <ian.f.davis@gmail.com>
// Copyright (c) 2007-2008, Ian Davis.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#endregion

#region Using Directives

using System;
using System.Runtime.Serialization;
using Imapi.Net.Properties;

#endregion

namespace Imapi.Net.Interop.Exceptions
{
    /// <summary>
    /// The object is already open.
    /// </summary>
    [Serializable]
    public class DiscMasterAlreadyOpenedException : ImapiException
    {
        #region Public Methods and Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscMasterAlreadyOpenedException"/> class.
        /// </summary>
        public DiscMasterAlreadyOpenedException()
            : base( Resources.Error_Msg_IMAPI_E_ALREADYOPEN )
        {
            unchecked
            {
                HResult = (int) ErrorCodes.IMAPI_E_ALREADYOPEN;
            } // End unchecked
        } // End DiscMasterAlreadyOpenedException()


        /// <summary>
        /// Initializes a new instance of the <see cref="DiscMasterAlreadyOpenedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public DiscMasterAlreadyOpenedException( string message )
            : base( message + Environment.NewLine + Resources.Error_Msg_IMAPI_E_ALREADYOPEN )
        {
            unchecked
            {
                HResult = (int) ErrorCodes.IMAPI_E_ALREADYOPEN;
            } // End unchecked
        } // End DiscMasterAlreadyOpenedException(string message)


        /// <summary>
        /// Initializes a new instance of the <see cref="DiscMasterAlreadyOpenedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public DiscMasterAlreadyOpenedException( string message, Exception innerException )
            : base( message + Environment.NewLine + Resources.Error_Msg_IMAPI_E_ALREADYOPEN, innerException )
        {
            unchecked
            {
                HResult = (int) ErrorCodes.IMAPI_E_ALREADYOPEN;
            } // End unchecked
        } // End DiscMasterAlreadyOpenedException(string message, Exception innerException)


        /// <summary>
        /// Initializes a new instance of the <see cref="DiscMasterAlreadyOpenedException"/> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="context">The context.</param>
        protected DiscMasterAlreadyOpenedException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
            unchecked
            {
                HResult = (int) ErrorCodes.IMAPI_E_ALREADYOPEN;
            } // End unchecked
        } // End DiscMasterAlreadyOpenedException(SerializationInfo info, StreamingContext context)

        #endregion Public Methods and Constructors
    } // End class DiscMasterAlreadyOpenedException
} // End namespace Imapi.Net.Interop.Exceptions