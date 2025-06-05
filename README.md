# CurlDebuggerVisualizer

This repository contains a Visual Studio debugger visualizer that displays the
`HttpRequestMessage` associated with an `HttpResponseMessage` in cURL format.

## Usage

1. Build the `CurlDebuggerVisualizer` project to produce a `.vsix` package.
2. Install the generated `CurlDebuggerVisualizer.vsix` by double-clicking it or
   using the `Extensions > Manage Extensions` dialog in Visual Studio 2022 or
   newer.
3. While debugging, use the magnifier icon next to an `HttpResponseMessage` to
   view the request as a cURL command.

The visualizer converts the request method, URL, headers and body into a cURL
command that can be pasted into a terminal for troubleshooting.
