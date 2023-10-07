using Godot;
using System;

public partial class SignalBusCSharp : Node
{
    public static SignalBusCSharp Instance {get; private set;}

    [Signal] public delegate void SayMessagePressedEventHandler();

    public override void _Ready()
    {
        Instance = this;
    }

    public void EmitSayMessagePressed() => EmitSignal(SignalName.SayMessagePressed);
}
