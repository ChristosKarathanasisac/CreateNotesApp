using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace ReminderWinService
{
    public partial class ReminderWinService : ServiceBase
    {
        clsServiceUtilities serviceUtilities = new clsServiceUtilities();
        Timer tmrExecutor = new Timer();
        public ReminderWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            serviceUtilities.WriteLog("Service Start");
            System.Diagnostics.Debugger.Launch();
            tmrExecutor.Elapsed += new ElapsedEventHandler(tmrExecutor_Elapsed);
            tmrExecutor.Interval = 60000;
            tmrExecutor.Enabled = true;
            tmrExecutor.Start();

        }
        private void tmrExecutor_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            tmrExecutor.Enabled = false;
            tmrExecutor.Stop();
           
            if (serviceUtilities.CheckConnection())
            {
                clsSendNotes startSent = new clsSendNotes();
                Boolean flag = startSent.StartSend();
                if (startSent != null)
                {
                    startSent = null;
                }
                if (!flag)
                {
                    serviceUtilities.WriteLog("StartSent did not run");

                }
            }

            tmrExecutor.Enabled = true;
            tmrExecutor.Start();
        }

        protected override void OnStop()
        {
            tmrExecutor.Enabled = false;
            serviceUtilities.WriteLog("Service Stop");

        }
    }
}
