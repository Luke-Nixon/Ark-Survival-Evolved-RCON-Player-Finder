# Ark-Survival-Evolved-RCON-Player-Finder

RCON based player finder GUI for ark survival evolved 

This program allows location of players on an ark survival evolved cluster using a GUI.
The program converts the in-game unreal engine coordinates returned by the extended rcon command "listallplayerpos" and converts them to readable latitude and longitude coordinates using the formulas found at: https://ark.fandom.com/wiki/Coordinates

For this program to function, the ark server you connect to must have two pre-requistes installed.

- Ark server API: https://gameservershub.com/forums/resources/ark-server-api.12/
- Extended RCON: https://gameservershub.com/forums/resources/extended-rcon.13/

This project has two dependencies that must be installed to run.

- https://github.com/JamesNK/Newtonsoft.Json
- https://github.com/Challengermode/CoreRcon


To connect to the server, the config.json.template file must be renamed to config.json and configured with the desired connection information. 
For example:

```json
{
	"friendly names": 
	[
		{
			"name": "123"
		},
		{
			"name": "myusername"
		}
	],

	"servers": 
	[
		{
			"name": "aberration",
			"ip": "192.168.x.x",
			"port": "28030",
			"password": "supersecretpassword"

		},
		{
			"name": "the center",
			"ip": "192.168.x.x",
			"port": "28030",
			"password": "supersecretpassword"

		}
	]
}
```



