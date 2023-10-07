extends VBoxContainer

@export var message: String
@export_file var targetScene: String

func _ready():
    %SayMessageButton.connect('pressed', say_message)
    %ChangeSceneButton.connect('pressed', change_scene)
    SignalBusSingletonGdScript.connect('say_message', say_message)
    
    %SayMessageButton.text = 'Say ' + message

func change_scene():
    get_tree().change_scene_to_file(targetScene)

func say_message():
    print(message)
