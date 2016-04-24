using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriven
{
    enum FSM_Type
    {
        FSM_SET,
        FSM_ADV
    }

    enum FSM_StateEnum
    {
        STATE_A,
        STATE_B,
        STATE_C,
        STATE_D,
        STATE_E 
    }

    struct FSM_Data
    {
        public FSM_Type type;
        public Byte input;
        public FSM_StateEnum state;
    }

    class FSM
    {
        public void advance(int inData)
        {

        }

        public void set(FSM_StateEnum state)
        {

        }

        public void doWork(FSM_Data data)
        {

        }
    }
}
