
using System.Collections.Generic;

namespace TicTacToe
{
    /// <summary>
    /// This has the solutions for the basic 2d Tic-Tac-Toe.
    /// There are 8 solutions.
    /// </summary>
    public static class Solutions2D
    {
        /// <summary>
        /// The left diagonal solution.
        /// Given a grid:
        /// Column   0  1  2
        ///          __ __ __
        ///     R  0|x       |
        ///     O  1|   x    |
        ///     W  2|      x |
        /// </summary>
        public static List<int[]> LeftDiagonal { get; } = new List<int[]>(3)
            {
                new int[] {0, 0},
                new int[] {1, 1},
                new int[] {2, 2},
            };

        /// <summary>
        /// The right diagonal solution.
        /// Given a grid:
        /// Column   0  1  2
        ///          __ __ __
        ///     R  0|       x|
        ///     O  1|    x   |
        ///     W  2| x      |
        /// </summary>
        public static List<int[]> RightDiagonal { get; } = new List<int[]>(3)
            {
                new int[] {0, 2},
                new int[] {1, 1},
                new int[] {2, 0},
            };

        /// <summary>
        /// The top row solution.
        /// Given a grid:
        /// Column   0  1  2
        ///          __ __ __
        ///     R  0|x---x---x|
        ///     O  1|---------|
        ///     W  2|---------|
        /// </summary>
        public static List<int[]> TopRow { get; } = new List<int[]>(3)
            {
                new int[] {0, 0},
                new int[] {0, 1},
                new int[] {0, 2},
            };

        /// <summary>
        /// The middle row solution.
        /// Given a grid:
        /// Column   0  1  2
        ///          __ __ __
        ///     R  0|---------|
        ///     O  1|x---x---x|
        ///     W  2|---------|
        /// </summary>
        public static List<int[]> MiddleRow { get; } = new List<int[]>(3)
            {
                new int[] {1, 0},
                new int[] {1, 1},
                new int[] {1, 2},
            };

        /// <summary>
        /// The bottom row solution.
        /// Given a grid:
        /// Column   0  1  2
        ///          __ __ __
        ///     R  0|---------|
        ///     O  1|---------|
        ///     W  2|x---x---x|
        /// </summary>
        public static List<int[]> BottomRow { get; } = new List<int[]>(3)
            {
                new int[] {2, 0},
                new int[] {2, 1},
                new int[] {2, 2},
            };

        /// <summary>
        /// The left column solution.
        /// Given a grid:
        /// Column   0  1  2
        ///          __ __ __
        ///     R  0|x-------|
        ///     O  1|x-------|
        ///     W  2|x-------|
        /// </summary>
        public static List<int[]> LeftColumn { get; } = new List<int[]>(3)
            {
                new int[] {0, 0},
                new int[] {1, 0},
                new int[] {2, 0},
            };

        /// <summary>
        /// The middle column solution.
        /// Given a grid:
        /// Column   0   1  2
        ///          __ __  __
        ///     R  0|----x----|
        ///     O  1|----x----|
        ///     W  2|----x----|
        /// </summary>
        public static List<int[]> MiddleColumn { get; } = new List<int[]>(3)
            {
                new int[] {0, 1},
                new int[] {1, 1},
                new int[] {2, 1},
            };

        /// <summary>
        /// The left column solution.
        /// Given a grid:
        /// Column   0   1   2
        ///          __  __  __
        ///     R  0|--------x|
        ///     O  1|--------x|
        ///     W  2|--------x|
        /// </summary>
        public static List<int[]> RightColumn { get; } = new List<int[]>(3)
            {
                new int[] {0, 2},
                new int[] {1, 2},
                new int[] {2, 2},
            };
    }
}
