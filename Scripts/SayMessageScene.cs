using Godot;

public partial class SayMessageScene : Control
{
    [Export] public string Message;
    [Export(PropertyHint.File)] public string TargetScene;

    private Button _sayMessageButton => GetNode<Button>("%SayMessageButton");
    private Button _changeSceneButton => GetNode<Button>("%ChangeSceneButton");

    public override void _Ready()
    {
        _sayMessageButton.Pressed += SignalBusSingleton.Instance.EmitSayMessagePressed;
        _changeSceneButton.Pressed += ChangeScene;

        SignalBusSingleton.Instance.SayMessagePressed += SayMessage;
    }

    public void ChangeScene()
    {
        GD.Print($"Changing scene to {TargetScene}");
        GetTree().ChangeSceneToFile(TargetScene);
    }

    public void SayMessage()
    {
        GD.Print(Message);
    }
}