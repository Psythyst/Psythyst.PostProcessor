using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas.Unity
{
    /// <summary>
    /// ProjectUnitExtension Class.
    /// </summary>
    public static class ProjectUnitExtension
    {
        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasDebugPrintFileContentPostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true)
            => Instance.AddPostProcessor(new EntitasDebugPrintFileContentPostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasDebugPrintFilePostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasDebugPrintFilePostProcessor(), Condition);
    }
}