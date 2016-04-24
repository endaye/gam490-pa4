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
        public FSM()
        {
            this.state = FSM_StateEnum.STATE_A;
        }

        ~FSM()
        {
            // do nothing
        }

        public void set(FSM_StateEnum inState)
        {
            this.state = inState;
            this.dump(FSM_Type.FSM_SET, inState);
        }

        public void advance(Byte input)
        {
            switch(this.state)
            {
                case FSM_StateEnum.STATE_A:
                    if      (input == 0) this.state = FSM_StateEnum.STATE_A;
                    else if (input == 1) this.state = FSM_StateEnum.STATE_B;
                    this.dump(FSM_Type.FSM_ADV, input);
                    break;
                case FSM_StateEnum.STATE_B:
                    if      (input == 0) this.state = FSM_StateEnum.STATE_E;
                    else if (input == 1) this.state = FSM_StateEnum.STATE_C;
                    this.dump(FSM_Type.FSM_ADV, input);
                    break;
                case FSM_StateEnum.STATE_C:
                    if      (input == 0) this.state = FSM_StateEnum.STATE_D;
                    else if (input == 1) this.state = FSM_StateEnum.STATE_E;
                    this.dump(FSM_Type.FSM_ADV, input);
                    break;
                case FSM_StateEnum.STATE_D:
                    if      (input == 0) this.state = FSM_StateEnum.STATE_D;
                    else if (input == 1) this.state = FSM_StateEnum.STATE_B;
                    this.dump(FSM_Type.FSM_ADV, input);
                    break;
                case FSM_StateEnum.STATE_E:
                    if      (input == 0) this.state = FSM_StateEnum.STATE_C;
                    else if (input == 1) this.state = FSM_StateEnum.STATE_A;
                    this.dump(FSM_Type.FSM_ADV, input);
                    break;
                default:
                    break;
            }
        }

        public void doWork(FSM_Data data)
        {
            switch (data.type)
            {
                case FSM_Type.FSM_SET:
                    this.set(data.state);
                    break;
                case FSM_Type.FSM_ADV:
                    this.advance(data.input);
                    break;
                default:
                    break;
            }
        }

        public FSM_StateEnum getState()
        {
            return this.state;
        }

        private FSM_StateEnum state;

        private void dump(FSM_Type inputType, Object input)
        {
            if (inputType == FSM_Type.FSM_SET)
            {
                System.Console.WriteLine("FSM(): set({0}): {1} ", (FSM_StateEnum)input, this.state);
            }
            else if (inputType == FSM_Type.FSM_ADV)
            {
                System.Console.WriteLine("FSM():   advance({0}): {1} ", (Byte)input, this.state);
            }
            else
            {
                // do nothing
            }
            
        }
    }
}
