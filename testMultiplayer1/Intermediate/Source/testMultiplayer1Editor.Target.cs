using UnrealBuildTool;

public class testMultiplayer1EditorTarget : TargetRules
{
	public testMultiplayer1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("testMultiplayer1");
	}
}
