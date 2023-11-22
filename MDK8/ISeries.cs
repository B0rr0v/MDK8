using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK8
{
    public interface ISeries
    {
        double Next { get; }
        double GetNext(); //Возвратить след по порядку число
        void Reset(); //Перезапустить
        void SetStart(double x); //Задать начальное значение
    }
    public interface IComparable 
    {
        int CompareTo(GeomProg obj);//метод CompareTo(), возвращающий результат сравнения двух объектов – текущего и переданного ему в качестве параметра
    }
}
