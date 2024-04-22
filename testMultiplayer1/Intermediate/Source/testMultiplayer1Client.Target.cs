using UnrealBuildTool;

public class testMultiplayer1ClientTarget : TargetRules
{
	public testMultiplayer1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("testMultiplayer1");
	}
}
