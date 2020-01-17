using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActsoftSlotMachine.Data
{
    public class SpinResult
    {
        public SlotState Slot1 { get; set; }
        public SlotState Slot2 { get; set; }
        public SlotState Slot3 { get; set; }
        public int RewardAmount { get; set; }

    }
}
