using System.Collections.Generic;
using System.Linq;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// EntitasNewLinePostProcessor Class.
    /// </summary>
    public class EntitasNewLinePostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 50; } }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            return Collection.Select(File => {
                File.FileContent =
                File.FileContent
                    .Replace("\r\n", "\n")
                    .Replace("\r", "\n");

                return File;
            });
        }
    }
}