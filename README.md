### MiniLogger

----

A simple Logger Window that you can use as a quick and dirty test mechanism.

&nbsp;

----

#### Usage:

Add this project to your solution and add the reference to this project to your projects. <br>
There is one static "Entries" List, that every LoggerWindow uses/shows. <br>
You can add entries before and after opening LoggerWindows

&nbsp;

You can open a LoggerWindow with:

```c#
MiniLogger.LoggerWindow.ShowWindow();
```

There are two ways to add an entry:

```c#
MiniLogger.LoggerWindow.AddEntry("Line");
// result: "hh:mm:ss: Line"

MiniLogger.LoggerWindow.AddEntry("Category", "Description");
// result: "hh:mm:ss: Category  |  Description"
```

&nbsp;

----

Example:

![ExampleImage](https://github.com/EpsilonDeltaCode/MiniLogger/blob/master/MiniLoggerExample.jpg)
