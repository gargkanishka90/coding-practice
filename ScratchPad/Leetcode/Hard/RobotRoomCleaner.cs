using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode.Hard
{
    public interface Robot
    {
        // Returns true if the cell in front is open and robot moves into the cell.
        // Returns false if the cell in front is blocked and robot stays in the current cell.
        bool Move();

        // Robot will stay in the same cell after calling turnLeft/turnRight.
        // Each turn will be 90 degrees.
        void TurnLeft();

        void TurnRight();

        // Clean the current cell.
        void Clean();
    }

    public class RobotRoomCleaner
    {
        private int[,] _room;
        private IDictionary<char, int[]> _dirMap;
        public RobotRoomCleaner()
        {
            _room = new int[,]
            {
                {1, 1, 1, 1, 1, 0, 1, 1},
                {1, 1, 1, 1, 1, 0, 1, 1},
                {1, 0, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 1, 0, 0, 0, 0},
                {1, 1, 1, 1, 1, 1, 1, 1}
            };
            _dirMap = new Dictionary<char, int[]>()
            {
                ['U'] = new []{-1,0},
                ['D'] = new []{1,0},
                ['L'] = new []{0,-1},
                ['R'] = new []{0,1}
            };
        }
        public void CleanRoom(Robot robot)
        {
            // denote each cell by "x#y" where is x,y is relative to 0,0
            var visited = new HashSet<string>();
            Helper(0, 0, 'U', visited, robot);
        }

        private void Helper(int x, int y, char direction, ISet<string> visited, Robot robot)
        {
            visited.Add($"{x}#{y}");
            robot.Clean();

            foreach (var nextDir in new[] {'U', 'R', 'D', 'L'})
            {
                var nextDistance = _dirMap[nextDir];
                var nextX = x + nextDistance[0];
                var nextY = y + nextDistance[1];

                if (!visited.Contains($"{nextX}#{nextY}") && robot.Move())
                {
                    Helper(nextX, nextY, nextDir, visited, robot);
                    robot.TurnLeft();
                    robot.TurnLeft();
                    robot.Move();
                    switch (nextDir)
                    {
                        case 'U':
                            robot.TurnLeft();
                            break;
                        case 'R':
                            robot.TurnRight();
                            break;
                        case 'D':
                            robot.TurnLeft();
                            break;
                        case 'L':
                            robot.TurnRight();
                            break;
                    }
                }
                else
                {
                    robot.TurnRight();
                } 
            }
        }
    }
}
