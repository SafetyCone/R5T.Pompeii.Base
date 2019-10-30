using System;


namespace R5T.Pompeii
{
    public interface ISolutionFileNameProvider
    {
        string GetSolutionFileName(string solutionDirectoryPath);
    }
}
