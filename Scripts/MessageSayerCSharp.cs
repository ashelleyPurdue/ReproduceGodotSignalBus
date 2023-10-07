using Godot;

public partial class MessageSayerCSharp : Button
{
    [Export] public string Message;

    public override void _Ready()
    {
        Pressed += SignalBusSingleton.Instance.EmitSayMessagePressed;
        SignalBusSingleton.Instance.SayMessagePressed += SayMessage;

        Text = $"Say {Message}(C#)";
    }

    private void SayMessage()
    {
        GD.Print(Message);
    }
}