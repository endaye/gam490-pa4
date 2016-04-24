using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriven
{
   
    /*
    enum FSM_Type
    {
        FSM_SET,
        FSM_ADV
    }

    struct FSM_Data
    {
        public FSM_Type type;
        public Byte input;
        public FSM_StateEnum state;
    }
    */

    class Tests
    {
        static public void CalcTest()
        {
            Calc myCalc = new Calc();

            System.Console.WriteLine("\n------------ Calc Phase 1: Explicit Calls ---------------\n");

            myCalc.set(3);
            myCalc.add(2);
            myCalc.sub(8);
            myCalc.mult(2);
            myCalc.sub(5);
            myCalc.add(4);
            myCalc.add(22);
            myCalc.sub(4);
            myCalc.mult(2);
            myCalc.sub(5);
            myCalc.set(11);
            myCalc.add(2);
            myCalc.sub(7);
            myCalc.mult(3);
            myCalc.sub(5);

            System.Console.WriteLine("\n------------ Calc Phase 2: Data Driven ---------------\n");

            Calc_Data data;

            // myCalc.set(3);
            data.type = Calc_Type.CALC_SET;
            data.value = 3;
            myCalc.doWork(data);

            // myCalc.add(2);
            data.type = Calc_Type.CALC_ADD;
            data.value = 2;
            myCalc.doWork(data);

            // myCalc.sub(8);
            data.type = Calc_Type.CALC_SUB;
            data.value = 8;
            myCalc.doWork(data);

            // myCalc.mult(2);
            data.type = Calc_Type.CALC_MULT;
            data.value = 2;
            myCalc.doWork(data);

            // myCalc.sub(5);
            data.type = Calc_Type.CALC_SUB;
            data.value = 5;
            myCalc.doWork(data);

            // myCalc.add(4);
            data.type = Calc_Type.CALC_ADD;
            data.value = 4;
            myCalc.doWork(data);

            // myCalc.add(22);
            data.type = Calc_Type.CALC_ADD;
            data.value = 22;
            myCalc.doWork(data);

            // myCalc.sub(4);
            data.type = Calc_Type.CALC_SUB;
            data.value = 4;
            myCalc.doWork(data);

            // myCalc.mult(2);
            data.type = Calc_Type.CALC_MULT;
            data.value = 2;
            myCalc.doWork(data);

            // myCalc.sub(5);
            data.type = Calc_Type.CALC_SUB;
            data.value = 5;
            myCalc.doWork(data);

            // myCalc.set(11);
            data.type = Calc_Type.CALC_SET;
            data.value = 11;
            myCalc.doWork(data);

            // myCalc.add(2);
            data.type = Calc_Type.CALC_ADD;
            data.value = 2;
            myCalc.doWork(data);

            // myCalc.sub(7);
            data.type = Calc_Type.CALC_SUB;
            data.value = 7;
            myCalc.doWork(data);

            // myCalc.mult(3);
            data.type = Calc_Type.CALC_MULT;
            data.value = 3;
            myCalc.doWork(data);

            // myCalc.sub(5);
            data.type = Calc_Type.CALC_SUB;
            data.value = 5;
            myCalc.doWork(data);

            System.Console.WriteLine("\n------------ Calc Phase 3: Queued Data Driven ---------------\n");

            // Creates and initializes a new Queue.
            System.Collections.Generic.Queue<Calc_Data> myQ = new System.Collections.Generic.Queue<Calc_Data>();

            // myCalc.set(3);
            data.type = Calc_Type.CALC_SET;
            data.value = 3;
            myQ.Enqueue(data);

            // myCalc.add(2);
            data.type = Calc_Type.CALC_ADD;
            data.value = 2;
            myQ.Enqueue(data);

            // myCalc.sub(8);
            data.type = Calc_Type.CALC_SUB;
            data.value = 8;
            myQ.Enqueue(data);

            // myCalc.mult(2);
            data.type = Calc_Type.CALC_MULT;
            data.value = 2;
            myQ.Enqueue(data);

            // myCalc.sub(5);
            data.type = Calc_Type.CALC_SUB;
            data.value = 5;
            myQ.Enqueue(data);

            // myCalc.add(4);
            data.type = Calc_Type.CALC_ADD;
            data.value = 4;
            myQ.Enqueue(data);

            // myCalc.add(22);
            data.type = Calc_Type.CALC_ADD;
            data.value = 22;
            myQ.Enqueue(data);

            // myCalc.sub(4);
            data.type = Calc_Type.CALC_SUB;
            data.value = 4;
            myQ.Enqueue(data);

            // myCalc.mult(2);
            data.type = Calc_Type.CALC_MULT;
            data.value = 2;
            myQ.Enqueue(data);

            // myCalc.sub(5);
            data.type = Calc_Type.CALC_SUB;
            data.value = 5;
            myQ.Enqueue(data);

            // myCalc.set(11);
            data.type = Calc_Type.CALC_SET;
            data.value = 11;
            myQ.Enqueue(data);

            // myCalc.add(2);
            data.type = Calc_Type.CALC_ADD;
            data.value = 2;
            myQ.Enqueue(data);

            // myCalc.sub(7);
            data.type = Calc_Type.CALC_SUB;
            data.value = 7;
            myQ.Enqueue(data);

            // myCalc.mult(3);
            data.type = Calc_Type.CALC_MULT;
            data.value = 3;
            myQ.Enqueue(data);

            // myCalc.sub(5);
            data.type = Calc_Type.CALC_SUB;
            data.value = 5;
            myQ.Enqueue(data);


            // Now the queue is NOW filled
            // print the contents      
            int count = myQ.Count;

            for (int i = 0; i < count; i++)
            {
                Calc_Data tmpData = myQ.Dequeue();
                myCalc.doWork(tmpData);
            }

        }
        /*
        static public void FSMTest()
        {

            System.Console.WriteLine("\n------------ FSM Phase 1: Explicit Calls ---------------\n");

            FSM myFSM = new FSM();

            myFSM.advance(0);  //a
            myFSM.advance(1);  //b
            myFSM.advance(0);  //e
            myFSM.advance(1);  //a

            myFSM.advance(1);  //b
            myFSM.advance(0);  //e
            myFSM.advance(0);  //c
            myFSM.advance(1);  //e
            myFSM.advance(1);  //a

            myFSM.advance(1);  //b
            myFSM.advance(1);  //c
            myFSM.advance(0);  //d
            myFSM.advance(0);  //d
            myFSM.advance(1);  //b

            myFSM.set(FSM_StateEnum.STATE_C);
            myFSM.advance(0);
            myFSM.advance(0);
            myFSM.advance(0);

            myFSM.set(FSM_StateEnum.STATE_C);
            myFSM.advance(1);
            myFSM.advance(0);
            myFSM.advance(0);

            myFSM.set(FSM_StateEnum.STATE_B);
            myFSM.advance(1);
            myFSM.advance(1);
            myFSM.advance(0);

            myFSM.set(FSM_StateEnum.STATE_D);
            myFSM.advance(1);
            myFSM.advance(0);
            myFSM.advance(1);

            System.Console.WriteLine("\n------------ FSM Phase 2: Data Driven ---------------\n");

            FSM_Data myData;
            myData.input = 0;
            myData.state = FSM_StateEnum.STATE_A;
            myData.type = FSM_Type.FSM_ADV;

            //myFSM.advance(0);  //a
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(0);  //e
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //a
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(0);  //e
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(0);  //c
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //e
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //a
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //c
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(0);  //d
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(0);  //d
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.set(FSM_StateEnum.STATE_C);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_C;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.set(FSM_StateEnum.STATE_C);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_C;
            myFSM.doWork(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.set(FSM_StateEnum.STATE_B);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_B;
            myFSM.doWork(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.set(FSM_StateEnum.STATE_D);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_D;
            myFSM.doWork(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myFSM.doWork(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myFSM.doWork(myData);


            System.Console.WriteLine("\n------------ FSM Phase 3: Queued Data Driven ---------------\n");

            System.Collections.Generic.Queue<FSM_Data> myQ_FSM = new System.Collections.Generic.Queue<FSM_Data>();


            myData.input = 0;
            myData.state = FSM_StateEnum.STATE_A;
            myData.type = FSM_Type.FSM_ADV;

            //myFSM.advance(0);  //a
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);  //e
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //a
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);  //e
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);  //c
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //e
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //a
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //c
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);  //d
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);  //d
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);  //b
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.set(FSM_StateEnum.STATE_C);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_C;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.set(FSM_StateEnum.STATE_C);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_C;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.set(FSM_StateEnum.STATE_B);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_B;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.set(FSM_StateEnum.STATE_D);
            myData.type = FSM_Type.FSM_SET;
            myData.state = FSM_StateEnum.STATE_D;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(0);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 0;
            myQ_FSM.Enqueue(myData);

            //myFSM.advance(1);
            myData.type = FSM_Type.FSM_ADV;
            myData.input = 1;
            myQ_FSM.Enqueue(myData);


            // Now the queue is NOW filled
            // print the contents      
            int count = myQ_FSM.Count;

            for (int i = 0; i < count; i++)
            {
                FSM_Data tmpData = myQ_FSM.Dequeue();
                myFSM.doWork(tmpData);
            }

        }

        static public void InterLeaved()
        {
            System.Console.WriteLine("\n------------ Interleaved Tests(): with data driven queue ---------------\n");

            InputQueue inQueue = new InputQueue();

            // temp data to fill queue
            Calc_Data calcData;
            FSM_Data fsmData;

            // -- 0  --- 
            calcData.type = Calc_Type.CALC_SET;
            calcData.value = 3;
            inQueue.add(calcData);

            // -- 1  --- 
            calcData.type = Calc_Type.CALC_ADD;
            calcData.value = 5;
            inQueue.add(calcData);

            // -- 2  --- 
            calcData.type = Calc_Type.CALC_SUB;
            calcData.value = 9;
            inQueue.add(calcData);

            // -- 3  --- 
            fsmData.input = 0;
            fsmData.type = FSM_Type.FSM_SET;
            fsmData.state = FSM_StateEnum.STATE_C;
            inQueue.add(fsmData);

            // -- 4 ---  
            fsmData.type = FSM_Type.FSM_SET;
            fsmData.state = FSM_StateEnum.STATE_B;
            inQueue.add(fsmData);

            // -- 5  --- 
            calcData.type = Calc_Type.CALC_MULT;
            calcData.value = 3;
            inQueue.add(calcData);

            // -- 6  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 1;
            inQueue.add(fsmData);

            // -- 7  --- 
            calcData.type = Calc_Type.CALC_SUB;
            calcData.value = 5;
            inQueue.add(calcData);

            // -- 8  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 0;
            inQueue.add(fsmData);

            // -- 9  ---      
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 0;
            inQueue.add(fsmData);

            // -- 10  ---       
            fsmData.type = FSM_Type.FSM_SET;
            fsmData.state = FSM_StateEnum.STATE_B;
            inQueue.add(fsmData);

            // -- 11  --- 
            calcData.type = Calc_Type.CALC_MULT;
            calcData.value = 3;
            inQueue.add(calcData);

            // -- 12  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 1;
            inQueue.add(fsmData);

            // -- 13  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 0;
            inQueue.add(fsmData);

            // -- 14  --- 
            calcData.type = Calc_Type.CALC_ADD;
            calcData.value = 2;
            inQueue.add(calcData);

            // -- 15  --- 
            calcData.type = Calc_Type.CALC_SUB;
            calcData.value = 7;
            inQueue.add(calcData);

            // -- 16  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 1;
            inQueue.add(fsmData);

            // -- 17  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 0;
            inQueue.add(fsmData);

            // -- 18  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 0;
            inQueue.add(fsmData);

            // -- 19  --- 
            calcData.type = Calc_Type.CALC_ADD;
            calcData.value = 10;
            inQueue.add(calcData);

            // -- 20  --- 
            fsmData.type = FSM_Type.FSM_ADV;
            fsmData.input = 0;
            inQueue.add(fsmData);

            // now that they are in queue, process them
            inQueue.process();
        }
         */ 
    }


}
