# SwitchPresence
<p align="center">
  A Nintendo Switch custom sysmodule for Discord Rich Presence.<br><br>
  <img src="https://raw.githubusercontent.com/Random0666/Useless-stuff/master/SwitchRichPresence/images/sysmodule.png" width="365" height="151"/>
</p>
<br>
<p align="center">  
<img src="https://raw.githubusercontent.com/Random0666/Useless-stuff/master/SwitchRichPresence/images/discord.png" width="259" height="288"/>
<img src="https://raw.githubusercontent.com/Random0666/Useless-stuff/master/SwitchRichPresence/images/app.png"  width="283" height="281"/>
</p><br>

# Usage
- If using hekate, copy `switch-rich-presence.kip` to your sd card and edit the `hekate_ipl.ini` to include the sysmodule.<br>
(You can for example add a configuration like this.)
```
[Discord Rich Presence]
kip1=switch-rich-presence.kip
```
- Boot your switch into RCM mode and run your payload of choice.
	- If using hekate, launch your hekate configuration with rich presence and wait until your switch turns on completely.
- Make sure that Discord is running.
- Open the client (`SwitchRichPresence.exe`) and click the "Connect" button.
	- If you're on Linux, you'll need to run the executable using Mono. Just open a terminal in the same folder and run `mono SwitchRichPresence.exe`; eventually you can assign .exe files to Mono, but that's not suggested, you may want to use Wine instead for other programs.
- Done!

# Setup a Rich presence app
*Note : I already made a default application with some games on it but if you don't do this, most of your icons won't show on discord.*
- Go to [this link](https://discordapp.com/developers/applications/me).
- Create a new App and give it the name that will be shown on your profile (usually "Nintendo Switch").
- Enable Rich Presence for you app.
- Launch the sysmodule and connect the client to the switch (see [Usage](https://github.com/Random0666/SwitchRichPresence/blob/master/README.md#usage)).
- Once connected, click on `Utils->Export icons` and choose the path where your icons will be exported with the right name/icon size.
- Go to your rich presence app and add all the icons that you just exported with the name they were given and choose the the type "Large".
<br><img src="https://raw.githubusercontent.com/Random0666/Useless-stuff/master/SwitchRichPresence/images/upload_assets.png" with = "366" height = "215"><br>
- (optional) add a "Small" asset named "icon". This will used as the small image on your profile. (You can use [this one](https://raw.githubusercontent.com/Random0666/Useless-stuff/master/SwitchRichPresence/images/icon.png).)
- Open the `config.txt` file at the root of the client (If this file doesn't exit, running the client once closing it will create a new one.) and edit the `client_id` line  with the client ID of the rich presence app you just created.

# Known issues
- The switch might hang on when connected to the client and:
	- It goes into sleep mode.
	- Flight mode is activated or WiFi connection disconnected.
	- The PC client crashes/hangs/is forcefully closed.
	- Basically, every time something breaks the connection.
If that happens, a message should appear on the screen telling you to press the power button. If it just hangs without any message, hard shutdown your Switch by pressing the POWER button for ~15 seconds.

# Other
Again, huge thanks to everyone who contributed to the amazing documentation on [SwitchBrew](http://switchbrew.org/index.php?title=Main_Page).<br><br>