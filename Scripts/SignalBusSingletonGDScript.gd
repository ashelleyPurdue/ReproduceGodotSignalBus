extends Node

signal say_message()

func emit_say_message(): emit_signal('say_message')
