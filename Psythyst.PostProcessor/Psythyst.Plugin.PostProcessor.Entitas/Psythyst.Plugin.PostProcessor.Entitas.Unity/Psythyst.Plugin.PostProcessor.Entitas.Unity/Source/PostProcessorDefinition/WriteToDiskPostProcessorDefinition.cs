using UnityEngine;

using Psythyst.Data.Entitas;

using Psythyst.Core.Unity;
using Psythyst.Core.Unity.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasWriteToDiskPostProcessorDefinition Class.
    /// </summary>
    [CreateAssetMenu(fileName = "New WriteToDiskPostProcessor Definition", menuName = "Psythyst/Entitas/PostProcessor/Default/WriteToDiskPostProcessor Definition")]
    public class EntitasWriteToDiskPostProcessorDefinition : EntitasPostProcessorDefinition
    {
        public StringReference Folder = "Assets/Generated";

        public override IPostProcessor<OutputModel> GetPostProcessor() 
            => new EntitasWriteToDiskPostProcessor(Folder);
    }
}