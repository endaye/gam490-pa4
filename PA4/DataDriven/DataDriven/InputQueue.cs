using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriven
{
    struct Input_Data
    {
        public int seqNum;
        public Type type;
        public Object data;
    }

    class InputQueue
    {
        private static System.Collections.Generic.Queue<Input_Data> _q = new System.Collections.Generic.Queue<Input_Data>();
        private static int seqNum = 9000;

        private static int getSeqNum()
        {
            return seqNum++;
        }

        public InputQueue()
        {
            // use singleton
        }

        ~InputQueue()
        {
            // do nothing
        }

        public void add(Object data)
        {
            Input_Data inputData;
            inputData.seqNum = getSeqNum();
            inputData.type = data.GetType();
            inputData.data = data;
            _q.Enqueue(inputData);
        }

        public void process()
        {
            Calc myCalc = new Calc();
            FSM myFSM = new FSM();

            int count = _q.Count;
            Input_Data tmpData;

            for (int i = 0; i < count; i++)
            {
                tmpData = _q.Dequeue();
                System.Console.Write("SeqNum: {0}  ", tmpData.seqNum);
                if (tmpData.type.Equals(typeof(Calc_Data)))
                {
                    myCalc.doWork((Calc_Data)tmpData.data);
                }
                else if (tmpData.type.Equals(typeof(FSM_Data)))
                {
                    myFSM.doWork((FSM_Data)tmpData.data);
                }
            }
        }
    }
}
