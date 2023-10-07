using Godot;
using System;

public partial class SignalBusSingleton : Node
{
    public static SignalBusSingleton Instance {get; private set;}

    [Signal] public delegate void SayMessagePressedEventHandler();

    public override void _Ready()
    {
        Instance = this;
    }

    public void EmitSayMessagePressed() => EmitSignal(SignalName.SayMessagePressed);
}
