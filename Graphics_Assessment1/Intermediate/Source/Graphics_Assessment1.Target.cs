using UnrealBuildTool;

public class Graphics_Assessment1Target : TargetRules
{
	public Graphics_Assessment1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Graphics_Assessment1");
	}
}
