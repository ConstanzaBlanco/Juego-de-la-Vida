namespace Ucu.Poo.GameOfLife;

public class Leer_archivo
{
    string url = "board.txt";
    bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
    {
        for (int x=0; x<contentLines[y].Length; x++)
        {
            if(contentLines[y][x]=='1')
            {
                board[x,y]=true;
            }
        }
    }
}