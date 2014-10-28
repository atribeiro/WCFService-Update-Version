using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using PeopleServiceLib;


namespace WindowsServiceHost
{



    public partial class PeopleWindowsService : ServiceBase
    {


        ServiceHost host;

        public PeopleWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/PeopleServiceLib/");

            host = new ServiceHost(typeof(PeopleService), baseAddress);

            try
            {

                host.AddServiceEndpoint(typeof(IPeopleService), new WSHttpBinding(), "PeopleService");

                var smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
                host.Description.Behaviors.Add(smb);

                host.Open();

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                host.Abort();
            }

        }
        protected override void OnStop()
        {
            host.Close();
        }

    }
}
