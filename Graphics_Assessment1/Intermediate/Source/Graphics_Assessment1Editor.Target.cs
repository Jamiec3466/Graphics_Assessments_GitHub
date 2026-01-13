using UnrealBuildTool;

public class Graphics_Assessment1EditorTarget : TargetRules
{
	public Graphics_Assessment1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Graphics_Assessment1");
	}
}
