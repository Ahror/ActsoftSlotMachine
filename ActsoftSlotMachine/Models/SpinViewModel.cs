using ActsoftSlotMachine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActsoftSlotMachine.Models
{
    public class SpinViewModel
    {
        public int RewardAmount { get; set; }
        public SlotState Slot1 { get; set; }
        public SlotState Slot2 { get; set; }
        public SlotState Slot3 { get; set; }

        public static SpinViewModel Create(SpinResult spinResult)
        {
            return new SpinViewModel
            {
                RewardAmount = spinResult.RewardAmount,
                Slot1 = spinResult.Slot1,
                Slot2 = spinResult.Slot2,
                Slot3 = spinResult.Slot3
            };
        }
    }
}
