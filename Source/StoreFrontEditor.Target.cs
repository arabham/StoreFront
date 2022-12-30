// Property of Do Over Games

using UnrealBuildTool;
using System.Collections.Generic;

public class StoreFrontEditorTarget : TargetRules
{
	public StoreFrontEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "StoreFront" } );
	}
}
