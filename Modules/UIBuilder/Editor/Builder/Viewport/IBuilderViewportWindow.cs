// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using UnityEngine.UIElements;

namespace Unity.UI.Builder
{
    internal interface IBuilderViewportWindow
    {
        BuilderSelection selection { get; }

        BuilderViewport viewport { get; }
        VisualElement documentRootElement { get; }
        BuilderCanvas canvas { get; }
    }
}
