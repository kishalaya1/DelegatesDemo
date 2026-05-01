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

        #region MutipleMethodReturnType 

        public delegate Channel GetChannelInfo(string channelName,string description);

        public static Channel GetIndianChannel(string channelName, string description) { 
            return new Channel { Name = channelName, Description = description , Type = "Indian" };
        }
        public static Channel GetForeignChannel(string channelName, string description)
        {
            return new Channel { Name = channelName, Description = description, Type = "Foreign" };
        }
        public static void MutlipleMethodReturnTypeDemo()
        {
            Console.WriteLine("Delegates with return type demo start ----");
            //first assign first method to the delegate
            GetChannelInfo channelInfo = GetIndianChannel;
            var channelFirst = channelInfo("Zee TV", "A popular Indian entertainment channel");
            Console.WriteLine("The details of the channel are as follows : \n Name -" + channelFirst.Name + "\n Description -" + channelFirst.Description + "\n Type -" + channelFirst.Type);
            // adding multiple methods to the same delegate
            channelInfo = GetForeignChannel;
            /// Now when we invoke the delegate, it will call all the methods assigned to it
            var channelSecond = channelInfo("HBO", "A popular Foreign entertainment channel");
            Console.WriteLine("The details of the channel are as follows : \n Name -" + channelSecond.Name + "\n Description -" + channelSecond.Description + "\n Type -" + channelSecond.Type);
            Console.WriteLine("Delegates with return type demo end ----");
        }
        #endregion
    }
}