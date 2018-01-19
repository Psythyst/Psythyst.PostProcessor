using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasMergeFilePostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New MergeFilePostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/MergeFilePostProcessor Definition")]
    public class EntitasMergeFilePostProcessorDefinition : EntitasPostProcessorDefinition<EntitasMergeFilePostProcessor> { }
}