using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasCleanTargetDirectoryPostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New CleanTargetDirectoryPostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/CleanTargetDirectoryPostProcessor Definition")]
    public class EntitasCleanTargetDirectoryPostProcessorDefinition : EntitasPostProcessorDefinition
    {
        public StringReference Folder = "Assets/Generated";

        public override IPostProcessor<OutputModel> GetPostProcessor() 
            => new EntitasCleanTargetDirectoryPostProcessor(Folder);
    }
}