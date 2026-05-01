using System.Security.Cryptography.X509Certificates;
using System;

namespace Entities
{
    public class DelegatesExample
    {
        #region SimpleDelegate 
        public delegate void StartEntertainmentContent(string channelName);
        public static void StartTvChannel(string channelName)
        {
            Console.WriteLine("Started TV Channel : " + channelName);
        }
        public static void SimpleDelegate()
        {
            Console.WriteLine("Simple Delegate Example demo start ----");
            // Define a delegate
            StartEntertainmentContent simpleDelegate = StartTvChannel;
            // Use the delegate
            simpleDelegate("TNT Movie");
            Console.WriteLine("Simple Delegate Example demo end ----");
        }
        #endregion

        #region MulticastDelegate
        public delegate void StartTVChannels();
        static void ChannelA() => Console.WriteLine("El TV channel started");
        static void ChannelB() => Console.WriteLine("MTV channel started");
        static void ChannelC() => Console.WriteLine("Channel V started");
        public static void MultiCastDelegate()
        {
            Console.WriteLine("Multicast Delegate Example demo start ----");
            //first assign first method to the delegate
            StartTVChannels multiTipleChannels = ChannelA;
            // adding multiple methods to the same delegate
            multiTipleChannels += ChannelB;
            multiTipleChannels+= ChannelC;
            /// Now when we invoke the delegate, it will call all the methods assigned to it
            multiTipleChannels();
            Console.WriteLine("Multicast Delegate Example demo end ----");
        }
        
        
        #endregion
    }
}