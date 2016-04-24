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
            this.ans = inData;
            this.dump(" set", inData);
        }

        public void add(int inData)
        {
            this.ans += inData;
            this.dump(" add", inData);
        }

        public void sub(int inData)
        {
            this.ans -= inData;
            this.dump(" sub", inData);
        }

        public void mult(int inData)
        {
            this.ans *= inData;
            this.dump("mult", inData);
        }

        public int getAnswer()
        {
            return this.ans;
        }

        private void dump(String type, int inData)
        {
            System.Console.WriteLine("calc():   {0}({1, 2}) : {2}", type, inData, this.ans);
        }

        private int ans;
    }
}
