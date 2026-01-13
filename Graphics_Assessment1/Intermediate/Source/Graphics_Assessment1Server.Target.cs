using UnrealBuildTool;

public class Graphics_Assessment1ServerTarget : TargetRules
{
	public Graphics_Assessment1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Graphics_Assessment1");
	}
}
