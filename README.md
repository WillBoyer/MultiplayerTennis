# About This Project

This is a tennis-inspired multiplayer game, written in C#/.NET and powered by the Godot game development engine.

This project is intended to demonstrate a low-latency network-based application. It uses the ENet framework to synchronise the player and ball positions for both players. The current release demonstrates functionality over the local machine, connecting using the a machine's loopback IP address.

## How to Use:

1. Download either the Windows or Linux version in 'Releases' on the right-hand side.
2. Extract the .zip file.
3. Run the game by opening two instances:
   - If using Linux, double-click on `Multiplayer Tennis.x86_64`.
   - If using Windows, double-click on `Multiplayer Lan Tutorial CSharp.exe`.
4. Enter a name in each instance.
5. Click on `Host` in one instance.
6. Click on `Join` in the other instance.
7. Click on `Start Game` in either instance.
8. Each instance controls one paddle. Use `W` or `Up` to move the paddle up, and `S` or `Down` to move down.