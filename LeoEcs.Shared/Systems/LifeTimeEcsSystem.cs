using Leopotam.EcsLite;
using UniGame.Core.Runtime;
using UniGame.Runtime.DataFlow;
using UnityEngine;

namespace UniGame.LeoEcs.Shared.Systems
{
    public class LifeTimeEcsSystem : IEcsInitSystem,IEcsDestroySystem,ILifeTimeContext
    {
        private LifeTime _lifeTime = new LifeTime();

        public ILifeTime LifeTime => _lifeTime;
        
        public void Init(IEcsSystems systems)
        {
            _lifeTime.Restart();
            OnInit(systems,_lifeTime);
        }

        public void Destroy(IEcsSystems systems)
        {
            OnDestroy(systems);
            _lifeTime.Terminate();
        }

        protected virtual void OnInit(IEcsSystems systems, ILifeTime lifeTime)
        {
            
        }
        
        protected virtual void OnDestroy(IEcsSystems systems)
        {
            
        }
    }
}
