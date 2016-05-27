using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTextClient.UpdateService;

namespace WcfTextClient {
    class Program {
        static void Main(string[] args) {
            UpdateWcfServiceClient client = new UpdateWcfServiceClient();
            client.Open();
            Console.WriteLine(client.DoUpdate("C:\\Temp\\freshmpdb"));
            client.Close();
            Console.ReadLine();
        }
    }
}
