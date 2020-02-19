using System;


namespace R5T.Pompeii
{
    /// <summary>
    /// Provides a solution file name.
    /// </summary>
    public interface ISolutionFileNameProvider
    {
        string GetSolutionFileName(string solutionDirectoryPath);
    }
}
