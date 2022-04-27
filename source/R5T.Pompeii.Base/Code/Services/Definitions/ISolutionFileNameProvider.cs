using System;

using R5T.T0064;


namespace R5T.Pompeii
{
    /// <summary>
    /// Provides a solution file name.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ISolutionFileNameProvider : IServiceDefinition
    {
        string GetSolutionFileName(string solutionDirectoryPath);
    }
}
