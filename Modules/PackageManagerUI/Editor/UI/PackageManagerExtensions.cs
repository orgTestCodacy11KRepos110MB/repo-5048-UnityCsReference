// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.UI
{
    /// <summary>
    /// Package Manager UI Extensions
    /// </summary>
    public static class PackageManagerExtensions
    {
        internal static List<IPackageManagerExtension> Extensions { get { return extensions ?? (extensions = new List<IPackageManagerExtension>()); } }
        static List<IPackageManagerExtension> extensions;
        internal static bool extensionsGUICreated = false;

        /// <summary>
        /// Registers a new Package Manager UI extension
        /// </summary>
        /// <param name="extension">A Package Manager UI extension</param>
        public static void RegisterExtension(IPackageManagerExtension extension)
        {
            if (extension == null)
                return;

            Extensions.Add(extension);
        }

        /// <summary>
        /// Protected call to package manager extension.
        /// </summary>
        internal static void ExtensionCallback(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                Debug.LogError(string.Format(L10n.Tr("[Package Manager Window] Package manager extension failed with error: {0}"), exception));
            }
        }
    }
}
