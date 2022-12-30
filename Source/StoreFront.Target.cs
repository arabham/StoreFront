// Property of Do Over Games

using UnrealBuildTool;
using System.Collections.Generic;

public class StoreFrontTarget : TargetRules
{
	public StoreFrontTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "StoreFront" } );
	}
}
