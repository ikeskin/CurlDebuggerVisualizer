# CurlDebuggerVisualizer

This repository contains a Visual Studio debugger visualizer that displays the
`HttpRequestMessage` associated with an `HttpResponseMessage` in cURL format.

## Usage

1. Download the latest `CurlDebuggerVisualizer.vsix` from the project's [releases page](../../releases)
   or build the VSIX yourself by building the solution.
2. Install the extension and restart Visual Studio. Alternatively, copy the
   generated `CurlDebuggerVisualizer.dll` into the Visual Studio visualizers
   directory (e.g., `%USERPROFILE%\Documents\Visual Studio 2022\Visualizers`).

 
1. Build the `CurlDebuggerVisualizer` project to produce the VSIX package:

   ```bash
   dotnet build src/CurlDebuggerVisualizer/CurlDebuggerVisualizer.csproj -c Release
   ```

   The package `CurlDebuggerVisualizer.vsix` will be created under
   `src/CurlDebuggerVisualizer/bin/Release`. You can also download a prebuilt
   version from the project's GitHub Releases page.
2. Install the `CurlDebuggerVisualizer.vsix` by double-clicking it or using the
   `Extensions > Manage Extensions` dialog in Visual Studio 2022 or newer.
3. While debugging, use the magnifier icon next to an `HttpResponseMessage` to
   view the request as a cURL command.

The visualizer converts the request method, URL, headers and body into a cURL
command that can be pasted into a terminal for troubleshooting.
This repository contains a Visual Studio debugger visualizer that displays the `HttpRequestMessage` associated with an `HttpResponseMessage` in cURL format.

## Building

Run `dotnet build` from the repository root to generate the extension. This command produces a `CurlDebuggerVisualizer.vsix` file.

1. Build the `CurlDebuggerVisualizer` project to produce a `.vsix` package.
2. Install the generated `CurlDebuggerVisualizer.vsix` by double-clicking it or
   using the `Extensions > Manage Extensions` dialog in Visual Studio 2022 or
   newer.
3. While debugging, use the magnifier icon next to an `HttpResponseMessage` to
   view the request as a cURL command.

If you prefer not to build the project yourself, download the VSIX from the releases page of this repository.

## Installation and Usage

Install the VSIX in Visual Studio. When debugging an `HttpResponseMessage`, use the magnifier icon to view the request as a cURL command.

The visualizer converts the request method, URL, headers and body into a cURL command that can be pasted into a terminal for troubleshooting.
