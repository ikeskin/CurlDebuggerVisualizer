# CurlDebuggerVisualizer

This repository contains a Visual Studio debugger visualizer that displays the
`HttpRequestMessage` associated with an `HttpResponseMessage` in cURL format.

## Usage

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
