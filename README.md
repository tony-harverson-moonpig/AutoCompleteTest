# AutoCompleteTest
Minimal example to test autocomplete config in azure servicebus triggers.  

This repo was spun up to demonstrate an [issue](https://github.com/Azure/azure-functions-dotnet-worker/issues/2142) with the dotnet-isolated worker ServiceBusTrigger attribute.

As a mitigation for that issue, [Microsoft.Azure.Functions.Worker.Extensions.ServiceBus 5.17.0 ](https://github.com/Azure/azure-functions-dotnet-worker/releases/tag/servicebus-extension-5.17.0) has been released, which adds the AutoCompleteMessages property to the attribute, allowing each function to configure its own AutoComplete behaviour.

The [ApplyReleaseFix](https://github.com/tony-harverson-moonpig/AutoCompleteTest/tree/ApplyReleaseFix) branch demos that workaround.

# Reproduction Recipe to show the autocomplete override locally:
1. Edit [local.settings.json](local.settings.json#L6), replace "{your-namespace-here}" with an existing servicebus namespace name.
2. Edit [AutoCompleteTest.cs](AutoCompleteTest.cs#L18), replace "{your-queuename-here}" with an existing queuename in the above namespace.
3. Log into the azure subscription containing your ServiceBus namespace:
```az login```
5. In the root of the project, start the function:
```func start --verbose```

