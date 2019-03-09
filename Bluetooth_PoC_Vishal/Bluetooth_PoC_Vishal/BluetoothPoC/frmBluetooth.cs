using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using InTheHand.Net;
using System.Threading;
using InTheHand.Net.Sockets;
using System.IO;
using InTheHand.Net.Bluetooth;

namespace BluetoothPoC
{
    public partial class frmBluetooth : Form
    {
        InTheHand.Net.BluetoothAddress[] address_array = new BluetoothAddress[1000];
        private Thread thrSend;
        int Selected;

        public frmBluetooth()
        {
            InitializeComponent();
        }
        private void btnDiscover_Click(object sender, EventArgs e)
        {
            BluetoothClient thisDevice = new BluetoothClient();
            BluetoothDeviceInfo[] devices = thisDevice.DiscoverDevices();
            for (int i = 0; i < devices.Length; i++)
            {
                this.address_array[i] = devices[i].DeviceAddress;
                this.lstDevices.Items.Add(devices[i].DeviceName);
            }
            address_array.Where(x => x != null);
            Pair.Visible = true;
        }

        private void btnGetMAC_Click(object sender, EventArgs e)
        {
            if (this.lstDevices.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a device.");
                return;
            }
            int index = this.lstDevices.SelectedIndex;
            string mac = this.address_array[index].ToString();
            string nap = this.address_array[index].Nap.ToString();
            string sap = this.address_array[index].Sap.ToString();
            MessageBox.Show(mac + " " + nap + " " + sap);
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {

            if (this.lstDevices.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a device.");
                return;
            }
            Selected = this.lstDevices.SelectedIndex;
            sendfile();
            //this.thrSend = new Thread(new ThreadStart(sendfile));
            //this.thrSend.Start();
        }


        private string[] FileDialogue()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileNames;
            }
            return null;
        }

        private void sendfile()
        {
            var filepath = FileDialogue();
            foreach (var x in filepath)
            {
                string filename = Path.GetFileName(x);
                int index = Selected;
                InTheHand.Net.BluetoothAddress address = this.address_array[index];
                System.Uri uri = new Uri("obex://" + address.ToString() + "/" + filename);
                ObexWebRequest request = new ObexWebRequest(uri);
                request.ReadFile(x);
                ObexWebResponse response = (ObexWebResponse)request.GetResponse();
                response.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InTheHand.Net.Sockets.BluetoothClient bc = new InTheHand.Net.Sockets.BluetoothClient();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pair_Click(object sender, EventArgs e)
        {
            PairDevice();
        }
        public void PairDevice()
        {
            BluetoothClient client = new BluetoothClient();
            BluetoothDeviceInfo[] devices = client.DiscoverDevices();

            InTheHand.Net.BluetoothAddress address = this.address_array[this.lstDevices.SelectedIndex];
            foreach (BluetoothDeviceInfo Device in devices)
            {
                if (Device.DeviceAddress.Equals(address)) // item from ComboBox
                {
                    bool paired = BluetoothSecurity.PairRequest(Device.DeviceAddress, "123456");
                    if (paired) MessageBox.Show("Paired!");
                    else MessageBox.Show("There was a problem pairing.");
                }
            }
        }
    }
}
