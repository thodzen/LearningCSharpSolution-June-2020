using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    // Ctrl+r, then a to run tests on all
    // Ctrl+r, then t to run tests on single test that cursor is in
    public class CollectionsAndArrays
    {
        [Fact] // Note this is to show you what NOT to do
        public void UsingAnOldSchoolArrayList()
        {
            // ArrayList store object references (some comment on StackOverflow)
            var favoriteNumber = new ArrayList();
            favoriteNumber.Add(4);
            favoriteNumber.Add(20);
            favoriteNumber.Add(6);
            favoriteNumber.Add(9);

            Assert.Equal(4, favoriteNumber[0]);
            Assert.Equal(9, favoriteNumber[3]);
            favoriteNumber[0] = 10;
            Assert.Equal(10, favoriteNumber[0]);

            Assert.Throws<ArgumentOutOfRangeException>(() => favoriteNumber[99]);

            favoriteNumber.Add("Tacos");
            //favoriteNumbers[0] = "three";
            var firstTwo = (int)favoriteNumber[0] + (int)favoriteNumber[1];
            Assert.Equal(30, firstTwo);
        }

        [Fact] // Always prefer the generic types over the non-generic types
        public void UsingAGenericList()
        {
            // Generic lists will use much lower memory than the ArrayList (some comment on StackOverflow)
            // Lists have "type saftey." If you create a List<Customer> you can't accidentally add a monkey to it
            //List of int - generics provide parametric polymorphism
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(19, firstTwo);
        }

        [Fact]
        public void InitializingAndEnumeratingAList()
        {
            // Same as doing friends.Add(...) 4 times
            var friends = new List<string>
            {
                "Sean",
                "Amy",
                "Jessica",
                "Tim"
            };

            Assert.Equal("Sean", friends[0]);

            var friendString = "";
            foreach (string friend in friends)
            {
                friendString += friend;
            }
            Assert.Equal("SeanAmyJessicaTim", friendString);
        }

        [Fact]
        public void UsingDictionary()
        {
            // First argument needs to be unique
            var friends = new Dictionary<char, string>();
            friends.Add('s', "Sean");
            friends.Add('d', "David");

            Assert.Equal("David", friends['d']);
        }

        [Fact]
        public void InitilizingAndEnumeratingADictionary()
        {
            var friends = new Dictionary<char, string>
            {
                { 's', "Sean" },
                { 'd', "David" },
                { 'b', "Sean" },
            };

            Assert.Equal("David", friends['d']);
        }
        
        [Fact]
        public void ArraysAreCoolButLimited()
        {
            string[] friends = new string[] { "Joe", "Bill", "Sue", "Mary" };
            Assert.Equal("Joe", friends[0]);
        }
    }
}
