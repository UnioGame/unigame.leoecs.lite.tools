namespace UniGame.LeoEcs.ViewSystem.Converters
{
    using System;
    using UniGame.UiSystem.Runtime;
    using R3;
    using System.Collections.Generic;
    using Cysharp.Threading.Tasks;
    using UniGame.Core.Runtime;
    using UniGame.LeoEcs.Converter.Runtime;
    using UniGame.LeoEcs.Shared.Extensions;
    using Components;
    using UniGame.UiSystem.Runtime;
    using UnityEngine;
    
    [RequireComponent(typeof(LeoEcsMonoConverter))]
    [RequireComponent(typeof(EcsViewConverter))]
    public class EcsView : ViewBase, IEcsView
    {
        
    }
}
