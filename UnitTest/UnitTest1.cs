﻿
using NavigatingTVChannels;
using System.Net.Http.Headers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var channelsCollection = new ChannelCollection();
            Channel x = new(98.3, ChannelType.News);
            channelsCollection.AddChannel(x);
            x = new Channel(99.2, ChannelType.Music);
            channelsCollection.AddChannel(x);
            x = new Channel(100.7, ChannelType.Sports);
            channelsCollection.AddChannel(x);
            IIterator iterator = channelsCollection.GetIterator();
            Dictionary<double , ChannelType> expected_list = new()
            {
                { 98.3 , ChannelType.News } ,
                { 99.2 , ChannelType.Music } ,
                { 100.7 , ChannelType.Sports }
            };

            Dictionary<double, ChannelType> observed_list = new();

            while (iterator.HasNext())
            {
                Channel c = iterator.Next();
                observed_list.Add(c.Frequency, c.Type);
            }
            Assert.IsTrue(Enumerable.SequenceEqual(observed_list, expected_list));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var channelsCollection = new ChannelCollection();
            Channel x = new(98.3, ChannelType.News);
            channelsCollection.AddChannel(x);
            x = new Channel(99.2, ChannelType.Music);
            channelsCollection.AddChannel(x);
            channelsCollection.RemoveChannel(x);
            x=new Channel(100.7, ChannelType.Sports);
            channelsCollection.AddChannel(x);
            IIterator iterator = channelsCollection.GetIterator();
            Dictionary<double , ChannelType> expected_list = new()
            {
                { 98.3 , ChannelType.News } ,
                { 100.7 , ChannelType.Sports }
            };

            Dictionary<double, ChannelType> observed_list = new();

            while (iterator.HasNext())
            {
                Channel c = iterator.Next();
                observed_list.Add(c.Frequency, c.Type);
            }
            Assert.IsTrue(Enumerable.SequenceEqual(observed_list, expected_list));
        }
    }
}
