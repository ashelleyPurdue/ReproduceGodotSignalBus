extends Button

@export var message: String

func _ready():
    connect('pressed', Callable(SignalBusSingletonGdScript, 'emit_say_message'))
    SignalBusSingletonGdScript.connect('say_message', Callable(self, 'say_message'))
    
    text = 'Say ' + message + '(GDScript)'

func say_message():
    print(message)
