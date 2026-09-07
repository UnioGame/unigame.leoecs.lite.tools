using System;
using Leopotam.EcsLite;
using UniGame.UiSystem.Runtime;
using UniGame.ViewSystem.Runtime;
using UniGame.ViewSystem.Runtime.ViewModels;
using UnityEngine;

namespace UniGame.LeoEcs.ViewSystem.Converters
{
    [Serializable]
    public class EcsViewModel : ViewModel
    {
        public static IViewModel Model = new EcsViewModel();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        public static void OnReset()
        {
            Model = new ContextViewModel();
        }
    }
}