// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

namespace UnityEditor.PackageManager.UI.Internal
{
    internal enum PackageState
    {
        None = 0,
        Installed,
        InstalledAsDependency,
        DownloadAvailable,
        ImportAvailable,
        Imported,
        InDevelopment,
        UpdateAvailable,
        InProgress,
        Error,
        Warning
    }
}
