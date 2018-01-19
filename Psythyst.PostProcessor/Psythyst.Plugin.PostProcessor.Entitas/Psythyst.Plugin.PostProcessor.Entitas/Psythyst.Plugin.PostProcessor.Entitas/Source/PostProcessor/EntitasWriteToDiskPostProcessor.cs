using System.Collections.Generic;
using System.IO;
using System;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// EntitasWriteToDiskPostProcessor Class.
    /// </summary>
    public class EntitasWriteToDiskPostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 0; } }

        public string Folder { get; private set; } = "Generated";

        public EntitasWriteToDiskPostProcessor() { }
        public EntitasWriteToDiskPostProcessor(string Folder)
        {
            this.Folder = Folder;
        }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            foreach (var File in Collection)
            {
                var TargetDirectory = Path.GetDirectoryName($"{Folder}/{File.FilePath}");
                Directory.CreateDirectory(TargetDirectory);
                System.IO.File.WriteAllText($"{Folder}/{File.FilePath}", File.FileContent);
            }
            
            return Collection;
        }
    }
}