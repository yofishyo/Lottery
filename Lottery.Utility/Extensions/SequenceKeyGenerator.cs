using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Utility.Extensions
{
    /// <summary>
    /// 順序隨機鍵值產生器。
    /// </summary>
    public static class SequenceKeyGenerator
    {
        private static readonly SystemClock s_clock;
        static SequenceKeyGenerator()
        {
            s_clock = new SystemClock();
        }

        /// <summary>
        /// 產生全新的隨機鍵值
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public static string Generate()
        {
            return string.Concat(s_clock.UtcNow.Ticks.ToString(), Guid.NewGuid().ToString("N"));
        }
    }
}
