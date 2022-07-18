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