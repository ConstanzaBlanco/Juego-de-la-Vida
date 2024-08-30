
namespace Ucu.Poo.GameOfLife;
using System.IO;
public class Lector_Archivo
//Responsabilidades:
//-Tiene que leer el archivo dado en "board.txt" 
//-Tiene que crear un tablero que marque True o False en función del archivo leído
//Expert: Esta clase por expert tiene la información correcta para crear un "esquema" de tablero inicial que contenga
//la ubicación de en donde se encontrarán células y en donde no 
//Collab: No tiene
{
    public bool [,] ReadArchive()
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
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
        return board;
    }
}