using System.Collections.Generic;
using System.IO;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// EntitasCleanTargetDirectoryPostProcessor Class.
    /// </summary>
    public class EntitasCleanTargetDirectoryPostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 500; } }

        public string Folder { get; private set; } = "Generated";

        public EntitasCleanTargetDirectoryPostProcessor() { }
        public EntitasCleanTargetDirectoryPostProcessor(string Folder)
        {
            this.Folder = Folder;
        }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            if (Directory.Exists(Folder)) Directory.Delete(Folder, true); return Collection;
        }
    }
}