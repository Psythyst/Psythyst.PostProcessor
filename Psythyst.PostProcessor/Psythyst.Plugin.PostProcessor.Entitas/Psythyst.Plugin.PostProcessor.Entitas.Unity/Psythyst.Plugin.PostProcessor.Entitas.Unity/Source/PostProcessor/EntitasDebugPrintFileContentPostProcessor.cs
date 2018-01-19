using System.Collections.Generic;
using System;

using UnityEngine;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasDebugPrintFileContentPostProcessor Class.
    /// </summary>
    public class EntitasDebugPrintFileContentPostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 0; } }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            foreach (var x in Collection)
                Debug.Log($"{x.FileContent}\n");

            Console.WriteLine();
            return Collection;
        }
    }
}