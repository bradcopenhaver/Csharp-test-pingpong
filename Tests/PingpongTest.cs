using Xunit;
using System.Collections.Generic;
using System;
using Pingpong.Objects;

namespace Pingpong
{
  public class PingpongTest
  {
    [Fact]
    public void PingpongGenerator_ListCreation_true()
    {
      //Arrange
      List<string> expectedList = new List<string>{"1","2"};
      PingpongGenerator TestClass = new PingpongGenerator(2);

      //Act
      List<string> result = TestClass.CreateList();

      //Assert
      Assert.Equal(expectedList, result);
    }
    [Fact]
    public void PingpongGenerator_MakesPing_true()
    {
      //Arrange
      List<string> pingList = new List<string>{"1","2","ping","4"};
      PingpongGenerator TestPing = new PingpongGenerator(4);
      //Act
      List<string> pings = TestPing.CreateList();

      //Assert
      Assert.Equal(pingList, pings);
    }
    [Fact]
    public void PingpongGenerator_MakesPong_true()
    {
      //Arrange
      List<string> pongList = new List<string>{"1","2","ping","4","pong"};
      PingpongGenerator TestPong = new PingpongGenerator(5);
      //Act
      List<string> pongs = TestPong.CreateList();

      //Assert
      Assert.Equal(pongList, pongs);
    }
    [Fact]
    public void PingpongGenerator_MakesPingPong_true()
    {
      //Arrange
      List<string> pingpongList = new List<string>{"1","2","ping","4","pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong"};
      PingpongGenerator TestPingPong = new PingpongGenerator(15);
      //Act
      List<string> pingpongs = TestPingPong.CreateList();

      //Assert
      Assert.Equal(pingpongList, pingpongs);
    }
  }
}
