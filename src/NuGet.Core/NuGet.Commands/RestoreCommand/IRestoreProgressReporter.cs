// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace NuGet.Commands
{
    /// <summary>
    /// Interface that can be used to provide updates about projects that have been restored and actually something was written on disk.
    /// </summary>
    public interface IRestoreProgressReporter
    {
        /// <summary>
        /// TODO NK - Add the files
        /// </summary>
        /// <param name="projectName"></param>
        void StartProjectUpdate(string projectName, IReadOnlyList<string> updatedFiles);

        /// <summary>
        /// TODO NK: Add the files.
        /// </summary>
        /// <param name="projectName"></param>
        void EndProjectUpdate(string projectName, IReadOnlyList<string> updatedFiles);
    }
}
