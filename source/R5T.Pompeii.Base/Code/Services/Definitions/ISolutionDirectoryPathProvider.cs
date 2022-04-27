﻿using System;

using R5T.T0064;


namespace R5T.Pompeii
{
    [ServiceDefinitionMarker]
    public interface ISolutionDirectoryPathProvider : IServiceDefinition
    {
        string GetSolutionDirectoryPath();
    }
}
