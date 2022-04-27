using System;

using R5T.T0064;


namespace R5T.Pompeii
{
    /// <summary>
    /// Encodes the conventions used to place solution and project file-system entries relative to each other, and conventions used for naming.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ISolutionAndProjectFileSystemConventions : IServiceDefinition
    {
        string GetFrameworkDirectoryPathFromPublishDirectoryPath(string publishDirectoryPath); // Standard is up one level.
        string GetPublishDirectoryPathFromFrameworkDirectoryPath(string frameworkDirectoryPath); // Standard is in the 'publish' directory.

        string GetFrameworkDirectoryPathFromExecutableDirectoryPath(string executableDirectoryPath); // Standard is the same path.
        string GetExecutableDirectoryPathFromFrameworkDirectoryPath(string frameworkDirectoryPath); // Standard is the same path.

        string GetConfigurationDirectoryPathFromFrameworkDirectoryPath(string frameworkDirectoryPath); // Standard is up one level.
        string GetFrameworkDirectoryNameFromFrameworkName(string frameworkName); // Standard is the same name.
        string GetFrameworkDirectoryPathFromConfigurationDirectoryPath(string configurationDirectoryPath, string frameworkName); // Standard is one level down, using the framework name.

        string GetBinariesDirectoryPathFromConfigurationDirectoryPath(string configurationDirectoryPath); // Standard is up on level.
        string GetConfigurationDirectoryNameFromConfigurationName(string configurationName); // Standard is the same name.
        string GetConfigurationDirectoryPathFromBinariesDirectoryPath(string binariesDirectoryPath, string configurationName); // Standard is one level down, using the configuration name.

        string GetProjectDirectoryPathFromBinariesDirectoryPath(string binariesDirectoryPath); // Standard is up one level.
        string GetBinariesDirectoryPathFromProjectDirectoryPath(string projectDirectoryPath); // Standard is just the "bin" directory.

        string GetSolutionDirectoryPathFromProjectDirectoryPath(string projectDirectoryPath); // Standard is up on level.
        string GetProjectDirectoryNameFromProjectName(string projectName); // Standard is the same.
        string GetProjectDirectoryPathFromSolutionDirectoryPath(string solutionDirectoryPath, string projectName); // Standard is one level down, using the project name.
    }
}
