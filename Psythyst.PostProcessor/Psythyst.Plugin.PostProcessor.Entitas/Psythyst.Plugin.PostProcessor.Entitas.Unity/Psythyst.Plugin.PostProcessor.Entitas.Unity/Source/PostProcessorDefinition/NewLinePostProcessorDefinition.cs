using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasNewLinePostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New NewLinePostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/NewLinePostProcessor Definition")]
    public class EntitasNewLinePostProcessorDefinition : EntitasPostProcessorDefinition<EntitasNewLinePostProcessor> { }
}