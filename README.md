# BTagged Extensions
==========================


# Installing

To import the addon, use one of the following methods:


> **Important**: if updating from a pre-3.0 version, please *DELETE* any Bolt.Addons.Community dll files.  By default these were placed in your *Plugins* folder.

### Via Package Manager:

Open the Unity Package Manager, and click the "+" button in the top-left corner :

![](https://imgur.com/v92tiFD.png)

and add the following url:

> https://github.com/RealityStop/Bolt.Addons.Community.git

> **Important**: looking for Unity Visual Scripting (UnityVS) support?  Use https://github.com/RealityStop/Bolt.Addons.Community.git#UVSsupport instead!


(for more information, or if errors are encountered, see https://docs.unity3d.com/Manual/upm-ui-giturl.html)

Then, use the Tools menu to Build Unit Options, and they're ready to go!  Once you've rebuilt your unit options, the new nodes will be available for use.



### Manual install:
Alternatively, open Packages/manifest.json and add this line under dependencies:

	"dev.bolt.addons": "https://github.com/RealityStop/Bolt.Addons.Community.git"
	
(for more information, or if errors are encountered, see https://docs.unity3d.com/Manual/upm-ui-giturl.html)
	
Then, use the Tools menu to Build Unit Options, and they're ready to go!  Once you've rebuilt your unit options, the new nodes will be available for use.


# Updating
To update, open Packages/manifest.json and remove the dev.bolt.addons entry under lock at the end of the file.
