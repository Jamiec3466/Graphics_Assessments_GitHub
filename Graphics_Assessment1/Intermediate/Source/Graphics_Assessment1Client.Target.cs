using UnrealBuildTool;

public class Graphics_Assessment1ClientTarget : TargetRules
{
	public Graphics_Assessment1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Graphics_Assessment1");
	}
}
