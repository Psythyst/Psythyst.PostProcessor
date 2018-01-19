using System.Collections.Generic;
using System;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// EntitasConsolePrintFilePostProcessor Class.
    /// </summary>
    public class EntitasConsolePrintFilePostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 0; } }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            foreach (var File in Collection) 
                Console.WriteLine($"<Generated-Path>/{File.FilePath}");

            Console.WriteLine();
            return Collection;
        }
    }
}