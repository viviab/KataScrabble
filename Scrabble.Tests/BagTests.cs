using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrabble.Tests
{
    [TestClass]
    public class BagTests
    {
        [TestMethod]
        public void WhenGetEmpty_ThenReturnAllLetters()
        {
            var game = new Game();
            var result = game.Play(string.Empty);

            Assert.IsTrue(result.Contains("12: E"));
            Assert.IsTrue(result.Contains("9: A, I"));
            Assert.IsTrue(result.Contains("8: O"));
            Assert.IsTrue(result.Contains("6: N, R, T"));
            Assert.IsTrue(result.Contains("4: D, L, S, U"));
            Assert.IsTrue(result.Contains("3: G"));
            Assert.IsTrue(result.Contains("2: B, C, F, H, M, P, V, W, Y, _"));
            Assert.IsTrue(result.Contains("1: J, K, Q, X, Z"));


        }

        [TestMethod]
        public void WhenGetOneLetter_ThenLessOne()
        {
            var game = new Game();
            var result = game.Play("A");

            Assert.IsTrue(result.Contains("12: E"));
            Assert.IsTrue(result.Contains("9: I"));
            Assert.IsTrue(result.Contains("8: A, O"));
            Assert.IsTrue(result.Contains("6: N, R, T"));
            Assert.IsTrue(result.Contains("4: D, L, S, U"));
            Assert.IsTrue(result.Contains("3: G"));
            Assert.IsTrue(result.Contains("2: B, C, F, H, M, P, V, W, Y, _"));
            Assert.IsTrue(result.Contains("1: J, K, Q, X, Z"));


        }


        [TestMethod]
        public void WhenGetOneLetter_ThenLessTwo()
        {
            var game = new Game();
            var result = game.Play("AAB");

            Assert.IsTrue(result.Contains("12: E"));
            Assert.IsTrue(result.Contains("9: I"));
            Assert.IsTrue(result.Contains("8: O"));
            Assert.IsTrue(result.Contains("7: A"));
            Assert.IsTrue(result.Contains("6: N, R, T"));
            Assert.IsTrue(result.Contains("4: D, L, S, U"));
            Assert.IsTrue(result.Contains("3: G"));
            Assert.IsTrue(result.Contains("2: C, F, H, M, P, V, W, Y, _"));
            Assert.IsTrue(result.Contains("1: B, J, K, Q, X, Z"));

        }

        [TestMethod]
        public void WhenGetExample1_ThenResult()
        {
            var game = new Game();
            var result = game.Play("AEERTYOXMCNB_S");

            Assert.IsTrue(result.Contains("10: E"));
            Assert.IsTrue(result.Contains("9: I"));
            Assert.IsTrue(result.Contains("8: A"));
            Assert.IsTrue(result.Contains("7: O"));
            Assert.IsTrue(result.Contains("5: N, R, T"));
            Assert.IsTrue(result.Contains("4: D, L, U"));
            Assert.IsTrue(result.Contains("3: G, S"));
            Assert.IsTrue(result.Contains("2: F, H, P, V, W"));
            Assert.IsTrue(result.Contains("1: B, C, J, K, M, Q, Y, Z, _"));
            Assert.IsTrue(result.Contains("0: X"));


        }
    }
}
