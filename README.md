# CurlDebuggerVisualizer

This repository contains a Visual Studio debugger visualizer that displays the
`HttpRequestMessage` associated with an `HttpResponseMessage` in cURL format.

## Usage

1. Download the latest `CurlDebuggerVisualizer.vsix` from the project's [releases page](../../releases)
   or build the VSIX yourself by building the solution.
2. Install the extension and restart Visual Studio. Alternatively, copy the
   generated `CurlDebuggerVisualizer.dll` into the Visual Studio visualizers
   directory (e.g., `%USERPROFILE%\Documents\Visual Studio 2022\Visualizers`).
3. While debugging, use the magnifier icon next to an `HttpResponseMessage` to
   view the request as a cURL command.

The visualizer converts the request method, URL, headers and body into a cURL
command that can be pasted into a terminal for troubleshooting.
