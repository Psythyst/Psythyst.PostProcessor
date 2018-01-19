using System.Collections.Generic;
using System;

using UnityEngine;

using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// EntitasDebugPrintFilePostProcessor Class.
    /// </summary>
    public class EntitasDebugPrintFilePostProcessor : IPostProcessor<OutputModel>
    {
        public int Priority { get { return 0; } }

        public IEnumerable<OutputModel> Process(IEnumerable<OutputModel> Collection)
        {
            foreach (var x in Collection)
                Debug.Log($"<Generated-Path>/{x.FilePath}");

            Console.WriteLine();
            return Collection;
        }
    }
}