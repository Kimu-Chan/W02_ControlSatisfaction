using UnityEngine;

namespace Core
{
    public class CoreComp<T> where T : CoreComponent
    {
        private global::Core.Core core;
        private T comp;

        public T Comp => comp ? comp : core.GetCoreComponent(ref comp);

        public CoreComp(global::Core.Core core)
        {
            if (core == null)
            {
                Debug.LogWarning($"Core is Null for component {typeof(T)}");
            }
            
            this.core = core;
        }
    }
}