﻿using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTennisGame
{
    public class Class1
    {
        [Test]
        public void LoveAll()
        {
            var tennisGame = new tennisGame();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love All", score);
        }
    }

    public class tennisGame
    {
        public string GetScore()
        {
            throw new NotImplementedException();
        }
    }
}