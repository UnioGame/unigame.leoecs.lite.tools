namespace UniGame.LeoEcs.Converter.Runtime.Components
{
    using System;

    /// <summary>
    /// order of view as a child
    /// </summary>
#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif
    [Serializable]
    public struct ViewOrderComponent
    {
        public int Value;
    }
}