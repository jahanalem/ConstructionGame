using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionGame
{
    public class ConstructionGame
    {
        private int[,] _table;
        private int _length;
        private int _width;

        public ConstructionGame(int length, int width)
        {
            this._length = length;
            this._width = width;
            this._table = new int[length, width];
        }

        public void AddCubes(bool[,] cubes)
        {
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (cubes[i, j])
                    {
                        _table[i, j]++; // add height
                    }
                }
            }
        }

        public int GetHeight()
        {
            var isFullLevel = true; // Check if the entire table area is filled with cubes or not.
            while (isFullLevel)
            {
                for (int i = 0; i < _length; i++)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        if (_table[i, j] == 0)
                        {
                            isFullLevel = false;
                            break;
                        }
                    }
                }
                if (isFullLevel)
                {
                    for (int i = 0; i < _length; i++)
                    {
                        for (int j = 0; j < _width; j++)
                        {
                            _table[i, j] -= 1; // if the whole cell of the table is fulled with cubes then we reduce the hieght.
                        }
                    }
                }
            }

            int maxHeight = 0;
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (_table[i, j] > maxHeight)
                    {
                        maxHeight = _table[i, j];
                    }
                }
            }

            return maxHeight;
        }
    }
}
