# Shadow of Doubt Co-op Mod

A peer-to-peer cooperative multiplayer mod for Shadow of Doubt, allowing players to investigate crimes together in the same procedurally generated city.

## Features

- **P2P Networking**: Host-client architecture using LiteNetLib
- **Player Synchronization**: Real-time position, rotation, and animation sync
- **World Synchronization**: NPC states, time, and game events synced from host
- **Investigation Sync**: Evidence, interrogations, and case progress shared between players
- **In-game Chat**: Communicate with other players
- **Steam P2P Support**: (Planned) NAT traversal through Steam networking

## Installation

### Prerequisites

1. **Shadow of Doubt** (Steam version)
2. **BepInEx 6.0 Bleeding Edge (IL2CPP)** - [Download from Thunderstore](https://thunderstore.io/c/shadows-of-doubt/p/BepInEx/BepInExPack_IL2CPP/)

### Installing BepInEx

1. Download BepInExPack_IL2CPP for Shadows of Doubt
2. Extract to your game folder (where `Shadows of Doubt.exe` is located)
3. Run the game once to generate BepInEx folders
4. Close the game

### Installing SoD Coop

1. Download the latest release of SoDCoop
2. Copy `SoDCoop.dll` and `LiteNetLib.dll` to:
   ```
   Shadows of Doubt\BepInEx\plugins\SoDCoop\
   ```
3. Launch the game

## Usage

### Hosting a Game

1. Press **F9** to open the Co-op menu
2. Enter your player name
3. Set a port (default: 7777)
4. Click "Host Game"
5. Share your IP address with friends

### Joining a Game

1. Press **F9** to open the Co-op menu
2. Enter your player name
3. Enter the host's IP and port
4. Click "Join Game"

### In-Game

- Press **F9** to toggle the menu
- Chat is always visible when connected (bottom-left)
- Press Enter to send chat messages

## Development

### Building from Source

1. Install .NET 6.0 SDK
2. Update `Directory.Build.props` with your game path:
   ```xml
   <GamePath>C:\Program Files (x86)\Steam\steamapps\common\Shadows of Doubt</GamePath>
   ```
3. Build the project:
   ```bash
   dotnet build -c Release
   ```

### Project Structure

```
SoDCoop/
├── src/
│   ├── Plugin.cs                 # Main BepInEx entry point
│   ├── Network/
│   │   ├── NetworkManager.cs     # P2P connection management
│   │   ├── Packets.cs            # Packet type definitions
│   │   └── NetSerializer.cs      # Unity type serializers
│   ├── Sync/
│   │   ├── SyncManager.cs        # Sync orchestration
│   │   ├── PlayerSync.cs         # Player state sync
│   │   ├── WorldSync.cs          # World/NPC sync
│   │   ├── TimeSync.cs           # Game time sync
│   │   └── CaseSync.cs           # Investigation sync
│   ├── Player/
│   │   ├── RemotePlayerManager.cs # Remote player spawning
│   │   └── RemotePlayer.cs       # Remote player component
│   ├── Patches/
│   │   └── GamePatches.cs        # Harmony patches
│   └── UI/
│       └── CoopUI.cs             # IMGUI interface
├── SoDCoop.csproj
├── Directory.Build.props
└── README.md
```

### Analyzing the Game

To complete the Harmony patches, you need to analyze the game's IL2CPP assemblies:

1. Run the game once with BepInEx installed
2. Check `BepInEx\unhollowed\` for generated assemblies
3. Use dnSpy or ILSpy to inspect class structures
4. Update `GamePatches.cs` with correct class/method names

Key classes to find:
- Player controller
- Citizen/NPC manager
- Time/session controller
- Case/evidence system
- World/city generator

## Known Limitations

- **World Complexity**: Shadow of Doubt simulates hundreds of NPCs, which creates synchronization challenges
- **IL2CPP**: Some game internals may be difficult to patch
- **Desyncs**: Complex world state may drift between clients
- **Performance**: Host bears the synchronization load

## Troubleshooting

### Connection Issues

- Ensure port is forwarded if not using LAN
- Check firewall settings
- Verify both players have the same mod version

### Crashes

- Check `BepInEx\LogOutput.log` for errors
- Ensure BepInEx version matches (6.0 BE IL2CPP)
- Try running as administrator

### Desync

- Host's world state is authoritative
- Reconnecting may help resync
- Avoid actions that could cause race conditions

## License

MIT License - See LICENSE file

## Credits

- [BepInEx](https://github.com/BepInEx/BepInEx) - Mod framework
- [LiteNetLib](https://github.com/RevenantX/LiteNetLib) - Networking
- [Harmony](https://github.com/pardeike/Harmony) - Runtime patching
- ColePowered Games - Shadow of Doubt
