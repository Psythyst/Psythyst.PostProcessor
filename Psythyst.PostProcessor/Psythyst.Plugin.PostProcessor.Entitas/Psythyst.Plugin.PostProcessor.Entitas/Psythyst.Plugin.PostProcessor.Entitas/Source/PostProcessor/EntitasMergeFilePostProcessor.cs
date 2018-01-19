using System;
using System.Collections.Generic;
using System.IO;
using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// EntitasMergeFilePostProcessor Class.
    /// </summary>
    public class EntitasMergeFilePostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 200; } }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            var _FileCollection = new List<OutputModel>(Collection);

            var Path = new Dictionary<string, OutputModel>();

            for (int i = 0; i < _FileCollection.Count; i++) {
                var File = _FileCollection[i];

                if (!Path.ContainsKey(File.FilePath)) {
                    Path.Add(File.FilePath, File);
                } else {

                    var NewContent = new OutputModel (
                        Path[File.FilePath].FilePath, 
                        Path[File.FilePath].FileContent + "\n" + File.FileContent
                    );

                    Path[File.FilePath] = NewContent;
                }
            }

            return Path.Values; 
        }
    }
}