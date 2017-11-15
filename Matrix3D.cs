using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_BKIT
{
    public class Matrix3D<T>
    {
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        int maxX, maxY, maxZ; //кол-во элементов по гор и верт(макс кол-во столбцов и строк)
        T nullElement;//0 эл возвр, если нет эла с коордами

        public Matrix3D(int px, int py, int pz, T nullElementParam)//конструктор
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }
        public T this[int x, int y, int z]//индексатор для доступа к данным
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
        }

        void CheckBounds(int x, int y, int z)//проверка границ
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x = " + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y = " + y + " выходит за границы");
            if (z < 0 || z >= this.maxZ) throw new Exception("z = " + z + " выходит за границы");
        }

        string DictKey(int x, int y, int z)//формирование ключа
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        public override string ToString() //приведение к строке
        {
            StringBuilder b = new StringBuilder();//b-экземпляр класса длинных строк

            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append("{");
                for (int j = 0; j < this.maxY; j++)
                {
                    if (j > 0) b.Append("");
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (this[i, j, k] != null)
                            b.Append(this[i, j, k].ToString());
                        else
                            b.Append("0");
                        if (i != (maxX - 1)) b.Append(",");
                    }
                    b.Append("]");
                }
                b.Append("}\n");
            }
            return b.ToString();
        }
    }
}
