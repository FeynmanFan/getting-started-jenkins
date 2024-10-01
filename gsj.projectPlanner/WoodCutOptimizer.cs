using System;
using System.Collections.Generic;

public class WoodCutOptimizer
{
    private readonly double _boardLength;
    private readonly double _boardWidth;

    // Constructor to initialize board dimensions
    public WoodCutOptimizer(double boardLength, double boardWidth)
    {
        _boardLength = boardLength;
        _boardWidth = boardWidth;
    }

    // Method to calculate how many boards are needed
    public int CalculateBoardsNeeded(List<(double length, double width)> pieces)
    {
        double totalAreaNeeded = 0;

        // Calculate the total area needed for all pieces
        foreach (var piece in pieces)
        {
            double pieceArea = piece.length * piece.width;
            totalAreaNeeded += pieceArea;
        }

        // Calculate the area of a single board
        double boardArea = _boardLength * _boardWidth;

        // Determine how many boards are needed to fit all the pieces
        int boardsNeeded = (int)Math.Ceiling(totalAreaNeeded / boardArea);

        return boardsNeeded;
    }
}
