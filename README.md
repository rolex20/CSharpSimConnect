# CSharpSimConnect
#Modern template connectivity to MSFS 2020 SimConnect in C# .NET 7

 * MSFS2020 SimConnect WinForms Example
 * 
 * This Windows Forms application demonstrates how to use SimConnect to retrieve and display
 * real-time flight data from Microsoft Flight Simulator 2020. It shows the player's aircraft name,
 * true airspeed, airbrakes status, and flaps status, updating once every second.
 * 
 * Prerequisites:
 * - Microsoft Flight Simulator 2020 installed and running.
 * - SimConnect SDK installed and configured.
 * 
 * Functionality:
 * - Connects to MSFS 2020 using SimConnect upon application start.
 * - Retrieves the following data for the user's aircraft:
 *   - Aircraft name
 *   - True airspeed (knots)
 *   - Flaps position (percent)
 *   - Airbrakes/Spoilers position (percent)
 * - Updates the displayed data once every second.
 * - Handles SimConnect events for open and quit messages.
 * 
 * Usage:
 * - Start MSFS 2020 and load into a flight.
 * - Run this application.
 * - Observe the displayed data in the application's window.
 * 
 * Note:
 * - The application overrides the WndProc method to accept/handle SimConnect messages.
 * - If you make changes, ensure that the WM_USER_SIMCONNECT message ID matches the one used in the SimConnect setup.
 * - The application must be run on the same machine as MSFS 2020.
 * - To recompile you to add to your PATH the locations of SimConnect.dll and Microsoft.FlightSimulator.SimConnect.dll, for example: C:\MSFS SDK\SimConnect SDK\lib\managed;C:\MSFS SDK\SimConnect SDK\lib;
 * - When running the program, I copy SimConnect.dll and Microsoft.FlightSimulator.SimConnect.dll to the location of the compiled CSharpSimConnect.exe to avoid changing my PATH
 * 
 * Date: 2024 -04/15
