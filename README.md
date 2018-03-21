MiniLogger

----

A simple Logger Window that you can use as a quick and dirty test mechanism.

----

Usage:

Add this project to your solution and add the reference to this project to your projects.

There is one static "Entries" List, that every LoggerWindow uses/shows.

You can open a LoggerWindow with:

`
MiniLogger.LoggerWindow.ShowWindow();
`

There are two ways to add an entry:

`
MiniLogger.LoggerWindow.AddEntry("Line");                      // result: "hh:mm:ss: Line"
MiniLogger.LoggerWindow.AddEntry("Category", "Description");   // result: "hh:mm:ss: Category  |  Description"
`

----

Example:

![ExampleImage](https://github.com/EpsilonDeltaCode/MiniLogger/MiniLoggerExample.jpg)
