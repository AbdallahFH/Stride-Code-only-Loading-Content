![Stride](https://media.githubusercontent.com/media/stride3d/stride/master/sources/data/images/Logo/stride-logo-readme.png)

# Stride Code-only Loading Content
this is simple example for stride code-only to Load content (Models,Textuer,etc) form code.


first you need to follow this tutrial https://github.com/VaclavElias/stride-code-only for setup Stride Code only.
after that you need to get a assets imported with stride editor (stupid but it's just for now maybe in future I will create something for importing usuing code or Vaclav Elias will do).
there is assets for sword model +(textur,material) in StrideLoadingModel>Assets you can use it.

after you placed the assets in Project Folder create new file in you project naming it same as the csproj but with .sdpkg extension than copy and paste this:


*********************************************************************
```javascript
!Package
SerializedVersion: {Assets: 3.1.0.0}
Meta:
    Name: #your Porject name#
    Version: 1.0.0
    Authors: []
    Owners: []
    Dependencies: null
AssetFolders:
    -   Path: !dir Assets
    -   Path: !dir Effects
ResourceFolders:
    - !dir Resources
OutputGroupDirectories: {}
ExplicitFolders: []
Bundles: []
TemplateFolders: []
RootAssets:
    -   361c41c9-6931-46a6-bd3e-724d781e6e5f:StrideStrike
    -   25faf428-dfd4-4bbb-b048-e4a9a58287c1:Sword
    -   9029eb89-bd4b-4b92-ab44-f1f8d2eae4f5:Textuer
```
*********************************************************************
open stride imported assets that have extensions like (sdm3d,sdmat,sdtex,and so on) copy the Id and paste it under RootAssets than type the asset name after ":" like blow:
```javascript
RootAssets:
    -   361c41c9-6931-46a6-bd3e-724d781e6e5f:StrideStrike
```
- do this for every asset in your project.
- for the asset file itself set the correct file path like this:
```javascript
!Model
Id: 361c41c9-6931-46a6-bd3e-724d781e6e5f
SerializedVersion: {Stride: 2.0.0.0}
Tags: []
Source: !file C:/Users/Abdallah/Documents/StrideLoadingModel/StrideStrike.fbx
Skeleton: null
PivotPosition: {X: 0.0, Y: 0.0, Z: 0.0}
Materials:
    d104efb40a2ffa4fc732e38b4f1254d5:
        Name: Sword
        MaterialInstance:
            Material: 25faf428-dfd4-4bbb-b048-e4a9a58287c1:Sword
Modifiers: {}
~SourceHashes:
    8bcb096ca95c876a9544a57e3a2a6faa~C:/Users/Abdallah/Desktop/The Game/StrideStrike.fbx: 0e185bba9e2d0746e534b10a351906cb
```
```c#
using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.GameDefaults.Extensions;
using Stride.Rendering;

using (var game = new Game())
{
    game.Run(start: Start);
    void Start(Scene rootScene)
    {
        game.SetupBase3DScene();
        var model = game.Content.Load<Model>("StrideStrike");
        var entity = new Entity(new Vector3(1));
        entity.Add(new ModelComponent(model));
        entity.Transform.Position = new Vector3(0, 1, 0);
        entity.Scene = rootScene;
    }
}
```
