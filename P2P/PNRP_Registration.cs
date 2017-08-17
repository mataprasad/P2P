using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace P2P
{
    class PNRP_Registration
    {
     public   static void Main1(string[] args)
        {

            // Creates a secure (not spoofable) PeerName

            PeerName peerName = new PeerName("MikesWebServer", PeerNameType.Secured);
            PeerNameRegistration pnReg = new PeerNameRegistration();
            pnReg.PeerName = peerName;
            pnReg.Port = 80;
            
            //OPTIONAL
            //The properties set below are optional.  You can register a PeerName without setting these properties
            pnReg.Comment = "up to 39 unicode char comment";
            pnReg.Data = System.Text.Encoding.UTF8.GetBytes("A data blob associated with the name");
            //pnReg.Cloud = Cloud.Global;

            /*

             * OPTIONAL
             *The properties below are also optional, but will not be set (ie. are commented out) for this example
             *pnReg.IPEndPointCollection = // a list of all {IPv4/v6 address, port} pairs to associate with the peername
             *pnReg.Cloud = //the scope in which the name should be registered (local subnet, internet, etc)

            */
            //Starting the registration means the name is published for others to resolve
            pnReg.Start();

         
            //pnReg.Update();

            Console.WriteLine("Registration of Peer Name: {0} complete.", peerName.ToString());
            Console.WriteLine();
            Console.WriteLine("Press any key to stop the registration and close the program");
            Console.ReadKey();
            pnReg.Stop();
        }
    }
}
