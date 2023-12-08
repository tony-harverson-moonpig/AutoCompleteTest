# AutoCompleteTest
Minimal example to test autocomplete config in azure servicebus triggers.

# Reproduction Recipe to show the autocomplete override locally:
1. Edit [local.settings.json](https://github.com/tony-harverson-moonpig/AutoCompleteTest/blob/fb22798b58b8925ecf79fcbe9a810c48dc172292/local.settings.json#L6), replace "{your-namespace-here}" with an existing servicebus namespace name.
2. Edit [AutoCompleteTest.cs](https://github.com/tony-harverson-moonpig/AutoCompleteTest/blob/fb22798b58b8925ecf79fcbe9a810c48dc172292/AutoCompleteTest.cs#L18), replace "{your-queuename-here}" with an existing queuename in the above namespace.
3. Log into the azure subscription containing your ServiceBus namespace:
```az login```
5. In the root of the project, start the function:
```func start --verbose```

