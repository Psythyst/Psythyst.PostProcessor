using Psythyst.Data.Entitas;

namespace Psythyst.Plugin.PostProcessor.Entitas
{
    /// <summary>
    /// ProjectUnitExtension Class.
    /// </summary>
    public static class ProjectUnitExtension
    {
        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasCleanTargetDirectoryPostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasCleanTargetDirectoryPostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasConsolePrintFileContentPostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasConsolePrintFileContentPostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasConsolePrintFilePostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasConsolePrintFilePostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasFileHeaderPostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasFileHeaderPostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasMergeFilePostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasMergeFilePostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasNewLinePostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true)
            => Instance.AddPostProcessor(new EntitasNewLinePostProcessor(), Condition);

        public static IProjectUnit<ProjectModel, OutputModel> AddEntitasWriteToDiskPostProcessor(this IProjectUnit<ProjectModel, OutputModel> Instance, bool Condition = true) 
            => Instance.AddPostProcessor(new EntitasWriteToDiskPostProcessor(), Condition); 
    }
}