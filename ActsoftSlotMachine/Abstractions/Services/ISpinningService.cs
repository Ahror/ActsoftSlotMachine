using ActsoftSlotMachine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActsoftSlotMachine.Abstractions.Services
{
    public interface ISpinningService
    {
        SpinResult Spin(int creditAmount);
    }
}
