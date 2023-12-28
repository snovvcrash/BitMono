﻿namespace BitMono.Utilities.Runtime;

public static class RuntimeUtilities
{
    private static EnvironmentRuntimeInformation _lastRuntimeInformation;

    public static EnvironmentRuntimeInformation GetFrameworkInformation()
    {
        if (_lastRuntimeInformation != null)
        {
            return _lastRuntimeInformation;
        }
        var dotnetFrameworkVersion = Environment.Version;
        var operatingSystem = Environment.OSVersion;
        var bits = IntPtr.Size * 8;
        var monoType = Type.GetType(KnownMonoRuntimes.MonoTypeName);
        var hasMono = monoType != null;
        string? monoDisplayName = null;
        if (hasMono)
        {
            var displayNameMethod = monoType.GetMethod(KnownMonoRuntimes.GetDisplayName, BindingFlags.NonPublic | BindingFlags.Static);
            if (displayNameMethod != null)
            {
                monoDisplayName = displayNameMethod.Invoke(null, null) as string;
            }
        }
        return _lastRuntimeInformation = new EnvironmentRuntimeInformation
        {
            OperatingSystem = operatingSystem,
            NetFrameworkVersion = dotnetFrameworkVersion,
            Bits = bits,
            HasMono = hasMono,
            MonoType = monoType,
            MonoDisplayName = monoDisplayName
        };
    }
}