using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasFileHeaderPostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New FileHeaderPostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/FileHeaderPostProcessor Definition")]
    public class EntitasFileHeaderPostProcessorDefinition : EntitasPostProcessorDefinition<EntitasFileHeaderPostProcessor> { }
}