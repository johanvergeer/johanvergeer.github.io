#tool nuget:?package=Wyam&version=2.2.4
#addin nuget:?package=Cake.Wyam&version=2.2.4

var target = Argument("target", "Build");

Task("Build")
    .Does(() =>
    {
        Wyam();        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Preview = true,
            Watch = true
        });        
    });

RunTarget(target)