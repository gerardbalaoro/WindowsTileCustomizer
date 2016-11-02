##  Metro Tile Customizer ##
![License](https://img.shields.io/badge/license-MIT License-red.svg)
![Release](https://img.shields.io/badge/version-v1.0.0-blue.svg)
![Build](https://img.shields.io/badge/build-Stable-brightgreen.svg)
![Compatibility](https://img.shields.io/badge/compatibility-Windows 8/8.1/10-blue.svg)
![Framework](https://img.shields.io/badge/framework version-4.5.2-lightgrey.svg)

A tool for customizing metro tile colors in Windows 8, 8.1, and 10.

#### How it Works ####

---------------------------------------------------------------------------------------------

The tool creates a .visualelementsmanifest.xml file containing the settings and style the tile will show, and associates it with the specified program's executable file (.EXE). For more information, visit this [article](http://www.askvg.com/tip-customize-start-screen-tiles-background-color-text-color-and-logo-in-windows-8-1/) by askvg.com.

#### Credits ####
---------------------------------------------------------------------------------------------
- [MetroFramework-Modern-UI](https://github.com/dennismagno/metroframework-modern-ui) by Dennis Magno

#### Binaries and dependencies ####
---------------------------------------------------------------------------------------------
The software was built with [Fody.Costura](https://github.com/Fody/Costura), and all external references are already embedded within the assembly. You can still download the library and its dependencies from the releases page.

MetroTileCustomizer uses external libraries:
* MetroFramework.dll
* MetroFramework.Fonts.dll
* MetroFramework.Design.dll

**Its not necessary to download these dependencies, for all of them are already embedded in the application.**

#### License ####
---------------------------------------------------------------------------------------------
The MIT License (MIT)

Copyright (c) 2016 Gerard Balaoro

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.