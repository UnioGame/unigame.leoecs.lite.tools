namespace UniGame.LeoEcs.ViewSystem.Behavriour
{
    using global::UniModules.UniGame.UiSystem.Runtime;
    using System.Threading;
    using Converter.Runtime;
    using Converter.Runtime.Abstract;
    using Core.Runtime;
    using Leopotam.EcsLite;
    using Sirenix.OdinInspector;
    using Extensions;
    using UiSystem.Runtime.Settings;
    using UniGame.Runtime.Rx.Runtime.Extensions;
    using UniGame.Core.Runtime;
    using UniGame.UiSystem.Runtime;
    using UnityEngine;
    using UnityEngine.UI;

    [RequireComponent(typeof(LeoEcsMonoConverter))]
    public class OpenViewButton : MonoBehaviour, ILeoEcsComponentConverter, ILifeTimeContext
    {
        #region inspector

        public Button trigger;
        
        /// <summary>
        /// target view type
        /// </summary>
        public ViewId view;
        
        /// <summary>
        /// target layout
        /// </summary>
        public ViewType layoutType = ViewType.Window;

        #endregion

        private ILifeTime _lifeTime;

        public ILifeTime LifeTime => _lifeTime;

        public void Apply(GameObject target, EcsWorld world, 
            int entity, CancellationToken cancellationToken = default)
        {
            _lifeTime = this.GetAssetLifeTime();
            trigger ??= GetComponent<Button>();
            
            this.Bind(trigger, x => world
                .MakeViewRequest(view, layoutType));
        }
        
        [OnInspectorInit]
        private void OnInspectorInitialize()
        {
            if (trigger == null)
                trigger = GetComponent<Button>();
        }

    }
}
