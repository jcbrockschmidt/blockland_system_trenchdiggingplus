$TRT::filePath = filePath($Con::File) @ "/";

exec($TRT::filePath @ "datablocks.cs");
exec($TRT::filePath @ "ghostgroup.cs");
exec($TRT::filePath @ "placermode.cs");
exec($TRT::filePath @ "prefs.cs");
exec($TRT::filePath @ "shovelmode.cs");
exec($TRT::filePath @ "toolmode.cs");
exec($TRT::filePath @ "trenchtool.cs");
exec($TRT::filePath @ "trenchtoolimage.cs");

// TODO: do not show cube size when cube limit is 1
// TODO: remove image when item is discarded
