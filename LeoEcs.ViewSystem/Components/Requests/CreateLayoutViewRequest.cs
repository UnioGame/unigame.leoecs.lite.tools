namespace UniGame.LeoEcs.ViewSystem.Components
{
    using global::UniModules.UniGame.UiSystem.Runtime;
    using System;
    using System.Collections.Generic;
    using Leopotam.EcsLite;
    using UniGame.Runtime.Utils;
    using UniGame.UiSystem.Runtime;
    using UnityEngine.Serialization;

    [Serializable]
    public struct CreateLayoutViewRequest : IEcsAutoReset<CreateLayoutViewRequest>
    {
        public string View;
        public string LayoutType;

        public void AutoReset(ref CreateLayoutViewRequest c)
        {
            c.View = string.Empty;
            c.LayoutType = ViewType.Window.ToStringFromCache();
        }
    }
}