﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Routing.Template
{
    public interface IVirtualPathData
    {
        IRoute Route { get; }

        string VirtualPath { get; set; }
    }
}