# CurlDebuggerVisualizer

CurlDebuggerVisualizer is a Visual Studio debugger visualizer that shows the `HttpRequestMessage` behind an `HttpResponseMessage` as a cURL command.

## Building

The project uses the Visual Studio SDK to create a VSIX package and therefore must be built on Windows. Run the following command to produce `CurlDebuggerVisualizer.vsix`:

```bash
msbuild src/CurlDebuggerVisualizer/CurlDebuggerVisualizer.csproj /p:Configuration=Release
```

The file will be placed under `src/CurlDebuggerVisualizer/bin/Release`.

## Installation and Usage

Install the generated VSIX in Visual Studio 2022 or newer. When debugging an `HttpResponseMessage`, use the magnifier icon to view the request as a cURL command that can be pasted into a terminal for troubleshooting.
