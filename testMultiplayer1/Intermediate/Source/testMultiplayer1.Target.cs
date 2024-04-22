using UnrealBuildTool;

public class testMultiplayer1Target : TargetRules
{
	public testMultiplayer1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("testMultiplayer1");
	}
}
