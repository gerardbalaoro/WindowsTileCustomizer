#  MetroTileCustomizer

![Compatibility](https://img.shields.io/badge/compatibility-Windows_8/8.1/10-brightgreen.svg)
![Framework](https://img.shields.io/badge/framework_version-4.5.2-lightgrey.svg)
![Release](https://img.shields.io/github/release/GerardBalaoro/MetroTileCustomizer.svg)

A tool for customizing metro tile colors in Windows 8, 8.1, and 10.

![Screenshot](https://snag.gy/WfY1NS.jpg)

## How it Works

---------------------------------------------------------------------------------------------

The tool creates a .visualelementsmanifest.xml file containing the settings and style the tile will show, and associates it with the specified program's executable file (.EXE). For more information, visit this [article](http://www.askvg.com/tip-customize-start-screen-tiles-background-color-text-color-and-logo-in-windows-8-1/) by askvg.com.

## Credits
---------------------------------------------------------------------------------------------
- [MetroFramework-Modern-UI](https://github.com/dennismagno/metroframework-modern-ui) by Dennis Magno

## Binaries and dependencies
---------------------------------------------------------------------------------------------
The software was built with [Fody.Costura](https://github.com/Fody/Costura), and all external references are already embedded within the assembly. You can still download the library and its dependencies from the releases page.

MetroTileCustomizer uses external libraries:
* MetroFramework.dll
* MetroFramework.Fonts.dll
* MetroFramework.Design.dll

**Its not necessary to download these dependencies, for all of them are already embedded in the application.*
