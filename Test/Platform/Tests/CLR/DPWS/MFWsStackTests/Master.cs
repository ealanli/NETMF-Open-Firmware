/*---------------------------------------------------------------------
* Master.cs - file description
* Main class, responsible for running all of the other *Tests.cs files
* Version: 1.0
* Author: REDMOND\a-grchat
* Created: 10/22/2007 10:05:30 AM 
* ---------------------------------------------------------------------*/

using System;
using Microsoft.SPOT.Platform.Test;
using System.Net;
using System.Net.Sockets;


namespace Microsoft.SPOT.Platform.Tests
{
    public class Master_Micro_Framework_CSharp_Test2
    {
        public static void Main()
        {
            string[] args = {
                                "ServicesTests", 
                                "FaultsTests", 
                                "MtomTests", 
                                "SoapTests", 
                                "TransportTests", 
                                "UtilitiesTests", 
                                "WsaAddressingTests", 
                                "XmlTests" };
            MFTestRunner runner = new MFTestRunner(args);
        }
    }
}