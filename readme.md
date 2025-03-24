**Mercury App Server

MFC C++ Windows Application Server software controls data from user console devices and printing press control systemns software to operate printing press inking equipment.

**Mercury Client

.Net C# Windows client software interfaces with press operator to control ink fountains and sweep adjustments on printing press equipment.

Notes on ANSI and Unicode versions

The code base for both App Server and Client applications contain the same code for BOTH ANSI and Unicode executables to be created. ANSI version is default and Unicode version requires the UNICODE macro to be defined during builds. The VS solutions contain default debug and release for ANSI version. There is a build configuration for both Unicode Debug and Release versions.

Please note the important diferrence in creating builds for either ANSI and UNICODE version is the settings in the solution REFERENCES list. There are GMI libraries based on Boost versions 1.43 called Zethus. Use the Zethus.DLL in the ANSI REFERENCES list and use the ZethusU.DLL in the UNICODE REFERENCES list. These two DLL files can be found the SHARED/BIN folder.

**Mercury SiteGen

.Net C# Windows Application to configure the Mercury App Server and Client software.

