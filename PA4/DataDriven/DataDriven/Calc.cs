using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriven
{
    enum Calc_Type
    {
        CALC_SET,
        CALC_ADD,
        CALC_SUB,
        CALC_MULT
    }

    struct Calc_Data
    {
        public Calc_Type type;
        public int value;
    }

    class Calc
    {
        public Calc()
        {
            this.ans = 0;
        }

        ~Calc()
        {
            // do nothing
        }

        public void doWork(Calc_Data data)
        {
            switch(data.type)
            {
                case Calc_Type.CALC_SET:
                    this.set(data.value);
                    break;
                case Calc_Type.CALC_ADD:
                    this.add(data.value);
                    break;
                case Calc_Type.CALC_SUB:
                    this.sub(data.value);
                    break;
                case Calc_Type.CALC_MULT:
                    this.mult(data.value);
                    break;
                default:
                    break;
            }
        }

        public void set(int inData)
        {
            System.Console.Write("calc():    set({0, 2}) : ", inData);
            this.ans = inData;
            System.Console.WriteLine("{0}", this.ans);
        }

        public void add(int inData)
        {
            System.Console.Write("calc():    add({0, 2}) : ", inData);
            this.ans += inData;
            System.Console.WriteLine("{0}", this.ans);
        }

        public void sub(int inData)
        {
            System.Console.Write("calc():    sub({0, 2}) : ", inData);
            this.ans -= inData;
            System.Console.WriteLine("{0}", this.ans);
        }

        public void mult(int inData)
        {
            System.Console.Write("calc():   mult({0, 2}) : ", inData);
            this.ans *= inData;
            System.Console.WriteLine("{0}", this.ans);
        }

        public int ans;
    }
}
