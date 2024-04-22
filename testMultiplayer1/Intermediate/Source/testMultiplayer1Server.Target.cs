using UnrealBuildTool;

public class testMultiplayer1ServerTarget : TargetRules
{
	public testMultiplayer1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("testMultiplayer1");
	}
}
