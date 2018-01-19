using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasDebugPrintFilePostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New DebugPrintFilePostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/DebugPrintFilePostProcessor Definition")]
    public class EntitasDebugPrintFilePostProcessorDefinition : EntitasPostProcessorDefinition<EntitasDebugPrintFilePostProcessor> { }
}