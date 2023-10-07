using Godot;

public partial class ChangeSceneButton : Button
{
    [Export(PropertyHint.File)] public string TargetScene;

    public override void _Ready()
    {
        Pressed += ChangeScene;
    }

    private void ChangeScene()
    {
        GetTree().ChangeSceneToFile(TargetScene);
    }
}