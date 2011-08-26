﻿namespace Tvl.Java.DebugInterface.Request
{
    public enum StepSize
    {
        /// <summary>
        /// Step by the minimum possible amount (often a bytecode instruction).
        /// </summary>
        Minimum = 0,

        /// <summary>
        /// Step to the next source line unless there is no line number information in which case a <see cref="Minimum"/> step is done instead.
        /// </summary>
        Line = 1,
    }
}
