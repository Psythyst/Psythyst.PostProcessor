using System.Collections.Generic;
using System;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// EntitasConsolePrintFileContentPostProcessor Class.
    /// </summary>
    public class EntitasConsolePrintFileContentPostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 0; } }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            foreach (var File in Collection) 
                Console.WriteLine($"{File.FileContent}\n"); 

            Console.WriteLine();
            return Collection;
        }
    }
}