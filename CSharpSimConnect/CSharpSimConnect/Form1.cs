/*
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
 */


using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;

namespace SimConnect3
{
    public partial class frmMain : Form
    {

        private SimConnect simconnect = null;
        private const int WM_USER_SIMCONNECT = 0x0402;

        enum DEFINITIONS
        {
            Struct1,
        }

        enum REQUESTS
        {
            Request1,
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string title; // Aircraft title
            public double trueAirspeed; // True airspeed in knots
            public double flaps; // Flaps position
            public double spoilers; // Airbrakes / Spoilers position
        };
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToSimConnect();
        }

        private void ConnectToSimConnect()
        {
            try
            {
                simconnect = new SimConnect("MSFS2020 SimConnect WinForms", this.Handle, WM_USER_SIMCONNECT, null, 0);

                simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(Simconnect_OnRecvOpen);
                simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(Simconnect_OnRecvQuit);
                simconnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(Simconnect_OnRecvSimobjectData);

                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Airspeed True", "knots", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Trailing Edge Flaps Left Percent", "percent", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Spoilers Handle Position", "percent", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);

                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);

                simconnect.RequestDataOnSimObject(REQUESTS.Request1, DEFINITIONS.Struct1, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND, SIMCONNECT_DATA_REQUEST_FLAG.CHANGED, 0, 0, 0);
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            catch (COMException ex)
            {
                MessageBox.Show("Unable to connect to MSFS2020: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simconnect != null)
                {
                    simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            Console.WriteLine("SimConnect connection established");
        }

        private void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            Console.WriteLine("SimConnect connection closed");
            DisconnectFromSimConnect();
        }

        private void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            if (data.dwRequestID == (uint)REQUESTS.Request1)
            {
                Struct1 s1 = (Struct1)data.dwData[0];
                UpdateUI(s1);
            }
        }

        private void UpdateUI(Struct1 data)
        {
            lblAircraftName.Text = "Aircraft: [" + data.title + "]";
            lblTrueAirspeed.Text = "True Airspeed: [" + data.trueAirspeed.ToString() + "]";
            lblFlapsStatus.Text = "Flaps: [" + data.flaps.ToString() + "] percent";
            lblAirbrakesStatus.Text = "Airbrakes: [" + data.spoilers.ToString() + "] percent";
            lblTimestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");  // Get current timestamp with milliseconds

        }

        private void DisconnectFromSimConnect()
        {
            if (simconnect != null)
            {
                simconnect.Dispose();
                simconnect = null;
            }
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectFromSimConnect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectFromSimConnect();
        }
    }
}
