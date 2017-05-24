﻿//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    /// <summary>
    /// The reason for any reader failure.
    /// </summary>
    public class ReaderErrorContext : ErrorContext, IEdiItem
    {
        /// <summary>
        /// The reader error code.
        /// </summary>
        public ReaderErrorCode ReaderErrorCode { get; private set; }

        /// <summary>
        /// The reader exception.
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderErrorContext"/> class.
        /// </summary>
        /// <param name="errorCode">The reader error code.</param>
        public ReaderErrorContext(ReaderErrorCode errorCode)
            : base(null)
        {
            ReaderErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderErrorContext"/> class.
        /// </summary>
        /// <param name="errorCode">The reader error code.</param>
        /// <param name="message">The error message.</param>
        public ReaderErrorContext(ReaderErrorCode errorCode, string message)
            : base(message)
        {
            ReaderErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderErrorContext"/> class.
        /// </summary>
        /// <param name="exception">The reader exception.</param>
        /// <param name="errorCode">The reader error code.</param>
        public ReaderErrorContext(Exception exception, ReaderErrorCode errorCode) 
            : base(exception.Message)
        {
            Exception = exception;
            ReaderErrorCode = errorCode;
        }
    }
}