using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasDebugPrintFileContentPostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New DebugPrintFileContentPostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/DebugPrintFileContentPostProcessor Definition")]
    public class EntitasDebugPrintFileContentPostProcessorDefinition : EntitasPostProcessorDefinition<EntitasDebugPrintFileContentPostProcessor> { }
}