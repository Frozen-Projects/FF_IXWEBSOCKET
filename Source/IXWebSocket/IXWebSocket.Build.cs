namespace UnrealBuildTool.Rules
{
    using System.IO;

    public class IXWebSocket : ModuleRules
    {
        public IXWebSocket(ReadOnlyTargetRules Target) : base(Target)
        {
    		Type = ModuleType.External;
            UndefinedIdentifierWarningLevel = WarningLevel.Off;
            bEnableExceptions = true;

            if (Target.Platform == UnrealTargetPlatform.Win64)
            {
                bUseRTTI = true;

                PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Win64", "include"));
                PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "Win64", "lib", "ixwebsocket.lib"));
            }
        }
    }
}
