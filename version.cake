Task("Build").Does(() => {
    var settings = new DotNetCoreMSBuildSettings();
    settings.SetVersion("20.0.0");

    DotNetCoreBuild("src/DepsParser", new DotNetCoreBuildSettings {
        MSBuildSettings = settings
    });
});

RunTarget("Build");