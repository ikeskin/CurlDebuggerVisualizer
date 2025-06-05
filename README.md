# CurlDebuggerVisualizer

This repository contains a Visual Studio debugger visualizer that displays the `HttpRequestMessage` associated with an `HttpResponseMessage` in cURL format.

## Building

Run `dotnet build` from the repository root to generate the extension. This command produces a `CurlDebuggerVisualizer.vsix` file.

If you prefer not to build the project yourself, download the VSIX from the releases page of this repository.

## Installation and Usage

Install the VSIX in Visual Studio. When debugging an `HttpResponseMessage`, use the magnifier icon to view the request as a cURL command.

The visualizer converts the request method, URL, headers and body into a cURL command that can be pasted into a terminal for troubleshooting.
