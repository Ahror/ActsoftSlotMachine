using ActsoftSlotMachine.Abstractions.Services;
using ActsoftSlotMachine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActsoftSlotMachine.Services
{
    public class SpinningService : ISpinningService
    {
        private readonly IReadOnlyList<SlotState> slotStates;
        public SpinningService()
        {
            slotStates = new List<SlotState>()
            {
                 SlotState.Seven,
                 SlotState.ThreeBar,
                 SlotState.TwoBar,
                 SlotState.TwoBar,
                 SlotState.OneBar,
                 SlotState.OneBar,
                 SlotState.OneBar,
                 SlotState.Cherry,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank,
                 SlotState.Blank
            };
        }
        public SpinResult Spin(int creditAmount)
        {
            Random random = new Random();
            int slot1 = random.Next(0, slotStates.Count - 1);
            int slot2 = random.Next(0, slotStates.Count - 1);
            int slot3 = random.Next(0, slotStates.Count - 1);

            var spinResult = new SpinResult
            {
                Slot1 = slotStates[slot1],
                Slot2 = slotStates[slot2],
                Slot3 = slotStates[slot3],
            };
            spinResult.RewardAmount = CalculateReward(spinResult, creditAmount);
            return spinResult;
        }
        private int CalculateReward(SpinResult spinResult, int creditAmount)
        {
            if (spinResult.Slot1 == spinResult.Slot2 && spinResult.Slot2 == spinResult.Slot3)
            {
                switch (spinResult.Slot1)
                {
                    case SlotState.Seven:
                        return creditAmount == 3 ? 1500 : 300 * creditAmount;
                    case SlotState.ThreeBar:
                        return 100 * creditAmount;
                    case SlotState.TwoBar:
                        return 50 * creditAmount;
                    case SlotState.OneBar:
                        return 25 * creditAmount;
                    case SlotState.Cherry:
                        return 5 * creditAmount;
                    case SlotState.Blank:
                        return 2 * creditAmount;
                    default:
                        return 0;
                }
            }
            return 0;
        }
    }
}
