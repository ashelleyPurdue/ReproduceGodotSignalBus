extends Button

@export var message: String

func _ready():
    connect('pressed', Callable(SignalBusGDScript, 'emit_say_message'))
    SignalBusGDScript.connect('say_message', Callable(self, 'say_message'))
    
    text = 'Say ' + message + '(GDScript)'

func say_message():
    print(message)
