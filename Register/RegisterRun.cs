using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Register
{
    public static class RegisterRun
    {
        private static ServiceHost _serviceHost;
        private const String ServiceName = "ServiceRegister";

        public static void Start()
        {
            // Step 1: Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8733/Register/ServiceRegister/");

            // Step 2: Create a ServiceHost instance.
            _serviceHost = new ServiceHost(typeof(ServiceRegister), baseAddress);

            try
            {
                //Step 3: Add a service endpoint.
                _serviceHost.AddServiceEndpoint(typeof(IServiceRegister), new WSHttpBinding(), baseAddress);

                // Step 4: Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };
                _serviceHost.Description.Behaviors.Add(smb);

                // Step 5: Start the service.
                _serviceHost.Open();
                Console.WriteLine("The " + ServiceName + " is ready.");
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                _serviceHost.Abort();
            }
        }

        public static void End()
        {
            try
            {
                _serviceHost.Close();
                Console.WriteLine("The " + ServiceName + " is closed.");
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                _serviceHost.Abort();
            }
        }

    }
}