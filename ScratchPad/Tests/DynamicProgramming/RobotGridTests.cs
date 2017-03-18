using System;
using NUnit.Framework;
using ScratchPad.DynamicProgramming;

namespace ScratchPad.Tests.DynamicProgramming
{
    public class RobotGridTests
    {
        [Test]
        public void GetPathTest()
        {
            var maze = new [,]
            {
                {1,1,0,0},
                {0,1,1,0},
                {0,0,1,1},
                {1,0,0,1},
                {0,0,0,1}
            };
            var path = RobotGrid.GetPath(maze);

            foreach (var item in path)
            {
                Console.WriteLine("(" + item.GetX() + "," + item.GetY() + ")" + ",");
            }

            Console.Read();
        } 
    }
}