using System.IO;

namespace Ucu.Poo.GameOfLife;

public class Lector_Archivo
{
    public bool[,] ReadArchive()
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        return board;
    }
}