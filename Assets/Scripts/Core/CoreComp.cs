using UnityEngine;

namespace CoreSystem
{
    public class CoreComp<T> where T : CoreComponent
    {
        private global::CoreSystem.Core core;
        private T comp;

        public T Comp => comp ? comp : core.GetCoreComponent(ref comp);

        public CoreComp(global::CoreSystem.Core core)
        {
            if (core == null)
            {
                Debug.LogWarning($"Core is Null for component {typeof(T)}");
            }
            
            this.core = core;
        }
    }
}