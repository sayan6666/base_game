using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_game
{
    internal class Map
    {
        private Random rand;
        private int size;
        private int closeBorder;
        private int farBorder;
        private Tile[,] map;
        private Tile tile1;
        private Tile tile2;
        private Tile tile3;

        private bool farZone(int x, int y) => (x < farBorder || x > (size-farBorder) || y < farBorder || y > (size-farBorder));
        private bool closeZone(int x, int y) => (!farZone(x,y)) && (!zeroZone(x,y));
        private bool zeroZone(int x, int y) => !(x > closeBorder || x < (size-closeBorder) || y > closeBorder || y < (size-closeBorder));

        public Map(int size, int closeBorder, int farBorder) 
        {
            this.size = size;
            this.closeBorder = closeBorder;
            this.farBorder = farBorder;
            rand = new Random();
            map = new Tile[size, size];
            tile1 = new Tile(50, "tile1", 1);
            tile2 = new Tile(50, "tile2", 1);
            tile3 = new Tile(50, "tile3", 1);
        }

        public void Generate()
        {
            int tileType=0;
            for (int i=0;i<size;i++)
                for (int j=0;j<size;j++)
                {
                    tileType = rand.Next(0, 101);
                    if (farZone(i,j))
                    {
                        if (tileType < 61)
                            map[i, j] = tile1;
                        else if (tileType < 91)
                            map[i, j] = tile2;
                        else if (tileType < 101)
                            map[i, j] = tile3;
                    }
                    if (closeZone(i,j))
                    {
                        if (tileType < 71)
                            map[i, j] = tile1;
                        else if (tileType < 101)
                            map[i, j] = tile2;
                    }
                    if (zeroZone(i,j))
                    {
                        map[i, j] = tile1;
                    }
                }
        }

        public void Draw()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    map[i, j].Draw(i,j);
        }
    }
}
