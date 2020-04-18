using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreParcial1.Controllers;
using PreParcial1.Models;
namespace PreParcial1.Tests
{
    [TestClass]
    public class UnitTestFriend
    {
        [TestMethod]
        public void TestMethodGetFriends()
        {
            //arrange
             FriendsController friendcontroller = new FriendsController();
            //act
            var friends = friendcontroller.GetFriends();
            //assert
            Assert.IsNotNull(friends);


    }
}
}
