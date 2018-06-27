using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;

namespace AppStopper17_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Update();
        }

        private ServiceController[] services = ServiceController.GetServices();
        private Process[] procs = Process.GetProcesses();


        private void button1_Click(object sender, EventArgs e)
        {
            string enteredApp = this.servCB.GetItemText(this.servCB.SelectedItem);
            foreach (ServiceController service in services)
            {
                if (service.ServiceName == enteredApp)
                {
                    DialogResult result = MessageBox.Show("Do you really want to stop " + enteredApp + "? It could have a negative impact on your system.", "Abfrage", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        switch (service.Status.ToString())
                        {
                            case "Running":
                                try
                                {
                                    service.Stop();
                                    errorTB.Text = service.ServiceName + " was stopped";
                                }
                                catch (Exception ex)
                                {
                                    errorTB.Text = "Error: " + service.ServiceName + " cant be stopped || Reason: not enough rights";
                                }
                                break;
                            case "Stopped":
                                errorTB.Text = "Error: " + service.ServiceName + " can't be stopped || Reason: was already stopped";
                                break;
                        }
                    }
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopProcB_Click(object sender, EventArgs e)
        {
            string enteredProc = this.procCB.GetItemText(this.procCB.SelectedItem);
            foreach (Process proc in procs)
            {
                if (proc.ProcessName == enteredProc)
                {
                    DialogResult result = MessageBox.Show("Do you really want to stop " + enteredProc + "? It could have a negative impact on your system.", "Abfrage", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        proc.Kill();
                        errorTB.Text = proc.ProcessName + " was killed";
                    }
                    break;
                }
            }
        }

        private void Update()
        {
            foreach (ServiceController service in services)
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    servCB.Items.Add(service.ServiceName);
                }
            }
            foreach (Process proc in procs)
            {
                procCB.Items.Add(proc.ProcessName);
            }
        }
    }
}
