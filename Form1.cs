using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows;

namespace SerialComm
{
    public partial class SerialComm : Form
    {
        SerialPort PORT = new SerialPort();
        bool auto_scroll = true;
        String buf = "";
        public SerialComm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SerialComm_Load(object sender, EventArgs e)
        {
            dtr_zapnuto.Checked = true;
            rts_vypnuto.Checked = true;
            par_zadna.Checked = true;
            hs_vypnuto.Checked = true;
            autoscroll.Checked = true;
            newlinePovolen.Checked = false;
            jeOtevren.Visible = false;
            jeZavren.Visible = true;
            string[] seznam_rychlosti = { "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400" };
            foreach (string jedna_rychlost in seznam_rychlosti)
            {
                try
                {
                    rychlosti.Items.Add(jedna_rychlost);
                }
                catch (ArgumentNullException) { }
            }
            rychlosti.Text = "115200";
        }

        private void vycistit_Click(object sender, EventArgs e)
        {
            vstup.Clear();
        }

        private void autoscroll_CheckedChanged(object sender, EventArgs e)
        {
            if (autoscroll.Checked) 
            {
                auto_scroll = true;
            }
            else auto_scroll = false;
        }

        public void nastavVstup (string datain)
        {
             if (vstup.InvokeRequired)
            {
                vstup.Invoke(new MethodInvoker(delegate
                {
                    if (auto_scroll)
                    {
                        if (buf != "")
                        {
                            vstup.AppendText(buf + datain);
                            buf = "";
                        }
                        else vstup.AppendText(datain);
                    }
                    else 
                    {
                        buf += datain;
                    }
                }));
            }
        }

        private void pripojit_Click(object sender, EventArgs e)
        {
            if (dtr_zapnuto.Checked) PORT.DtrEnable = true;
            else PORT.DtrEnable = false;
            if (rts_zapnuto.Checked) PORT.RtsEnable = true;
            else PORT.RtsEnable = false;
            if (par_zadna.Checked) PORT.Parity = Parity.None;
            if (par_suda.Checked) PORT.Parity = Parity.Even;
            if (par_licha.Checked) PORT.Parity = Parity.Odd;
            if (porty.Text == "") { informacniRadek.Text = "nebyl vybrán žádný port!"; return; }
            if (rychlosti.Text == "") { informacniRadek.Text = "nebyla nastavena rychlost!"; return; }
            if (PORT.IsOpen == true) { informacniRadek.Text = "port už je otevřen!"; return; }
            int nastaveni_rychlosti = 0;
            try
            {
                nastaveni_rychlosti = int.Parse(rychlosti.Text);
                //
            }
            catch (ArgumentNullException)
            {
                informacniRadek.Text = "nebyla nastavena žádná hodnota rychlosti!";
                return;
            }
            catch (FormatException)
            {
                informacniRadek.Text = "nastavená hodnota rychlosti je neplatná!";
                return;
            }
            catch (OverflowException)
            {
                informacniRadek.Text = "nastavená hodnota rychlosti je neplatná!";
                return;
            }
            try
            {
                PORT.BaudRate = nastaveni_rychlosti;
            }
            catch (ArgumentOutOfRangeException)
            {
                informacniRadek.Text = "nastavená hodnota rychlosti je mimo rozsah!";
                return;
            }
            catch (System.IO.IOException)
            {
                informacniRadek.Text = "nepodařilo se nastavit rychlost!";
                return;
            }
            try
            {
                PORT.PortName = porty.Text;
            }
            catch (ArgumentNullException)
            {
                informacniRadek.Text = "nebyl nastaven žádný port!";
                return;
            }
            catch (ArgumentException)
            {
                informacniRadek.Text = "nastavený port je neplatný!";
                return;
            }
            catch (InvalidOperationException)
            {
                informacniRadek.Text = "nepodařilo se nastavit port!";
                return;
            }
            try
            {
                PORT.Open();
            }
            catch (UnauthorizedAccessException)
            {
                informacniRadek.Text = "přístup byl odepřen!";
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                informacniRadek.Text = "nastavené hodnoty jsou mimo rozsah!";
                return;
            }
            catch (ArgumentException)
            {
                informacniRadek.Text = "nastavené hodnoty jsou neplatné!";
                return;
            }
            catch (System.IO.IOException)
            {
                informacniRadek.Text = "nepodařilo se připojit!";
                return;
            }
            catch (InvalidOperationException)
            {
                informacniRadek.Text = "nepodařilo se připojit!";
                return;
            }
            finally
            {
                if (PORT.IsOpen == true)
                {
                    informacniRadek.Text = "port byl úspěšně otevřen";
                    porty.Enabled = false;
                    rychlosti.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    jeOtevren.Visible = true;
                    jeZavren.Visible = false;
                    PORT.DataReceived += port_dataReceived;
                }
                else informacniRadek.Text = "port se nepodařilo otevřít!";
            }
            return;
        }

        private void porty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void porty_DropDown(object sender, EventArgs e)
        {
            porty.Items.Clear();
            string[] seznam_portu = SerialPort.GetPortNames();
            try
            {
                foreach (string jmeno_portu in seznam_portu) porty.Items.Add(jmeno_portu);
            }
            catch (ArgumentNullException)
            {
                informacniRadek.Text = "došlo k chybě při aktualizaci portů!";
            }
        }

        private void odpojit_Click(object sender, EventArgs e)
        {
            if (PORT.IsOpen)
            {
                try
                {
                    PORT.Close();
                }
                catch (System.IO.IOException)
                {
                    informacniRadek.Text = "nepodařilo se odpojit port!";
                    return;
                }
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                porty.Enabled = true;
                rychlosti.Enabled = true;
                informacniRadek.Text = "port byl úspěšně odpojen";
                jeOtevren.Visible = false;
                jeZavren.Visible = true;
                PORT.DataReceived -= port_dataReceived;
            }
            else informacniRadek.Text = "port už je odpojený!";
        }

        private void odesilaciRadek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (PORT.IsOpen)
                {
                    String zprava = odesilaciRadek.Text;
                    odesilaciRadek.Text = "";
                    try
                    {
                        if (newlinePovolen.Checked) PORT.WriteLine(zprava);
                        else PORT.Write(zprava);
                    }
                    catch (ArgumentNullException)
                    {
                        informacniRadek.Text = "v odesílacím řádku není nic k odeslání!";
                    }
                    catch (ArgumentException)
                    {
                        informacniRadek.Text = "text v odesílacím řádku je neplatný!";
                    }
                    catch (InvalidOperationException)
                    {
                        informacniRadek.Text = "nepodařilo se odeslat zprávu!";
                    }
                    catch (TimeoutException)
                    {
                        informacniRadek.Text = "došlo k chybě při odesílání!";
                    }
                }
                else
                {
                    informacniRadek.Text = "port není otevřen!";
                    odesilaciRadek.Text = "";
                }
            }
        }

        private void poslat_Click(object sender, EventArgs e)
        {
            if (PORT.IsOpen)
            {
                String zprava = odesilaciRadek.Text;
                odesilaciRadek.Text = "";
                try
                {
                    if (newlinePovolen.Checked) PORT.WriteLine(zprava);
                    else PORT.Write(zprava);
                }
                catch (ArgumentNullException)
                {
                    informacniRadek.Text = "v odesílacím řádku není nic k odeslání!";
                }
                catch (ArgumentException)
                {
                    informacniRadek.Text = "text v odesílacím řádku je neplatný!";
                }
                catch (InvalidOperationException)
                {
                    informacniRadek.Text = "nepodařilo se odeslat zprávu!";
                }
                catch (TimeoutException)
                {
                    informacniRadek.Text = "došlo k chybě při odesílání!";
                }
            }
            else
            {
                informacniRadek.Text = "port není otevřen!";
                odesilaciRadek.Text = "";
            }
        }

        private void port_dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!PORT.IsOpen) return;
            String data_in = "";
            try
            {
                data_in = PORT.ReadExisting();
            }
            catch (InvalidOperationException)
            {
                informacniRadek.Text = "chyba -> nepodařilo se přečíst data z portu (InvalidOperationException)";
                return;
            }
            nastavVstup(data_in);
        }
    }
}
