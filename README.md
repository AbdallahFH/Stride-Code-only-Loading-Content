### Stride-Code-only-Loading-Content
this is simple example for stride code-only to Load content (Models,Textuer,etc) form code.


- first you need to follow this tutrial https://github.com/VaclavElias/stride-code-only for setup Stride Code only.
- after that you need to get a assets imported with stride editor (stupid but it's just for now maybe in future I will create something for importing usuing code or Vaclav Elias will do).
- there is assets for sword model +(textur,material) in StrideLoadingModel>Assets you can use it.

- after you placed the assets in right place create new file in you project naming it same as the csproj but with .sdpkg extension than copy and paste this 


*********************************************************************
<?cs
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
?>
*********************************************************************
    

<?cs
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
?>
