﻿namespace Tvl.VisualStudio.Language.Java.Debugger.Collections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.Debugger.Interop;
    using System.Diagnostics.Contracts;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    public class EnumCodePaths : DebugEnumerator<IEnumCodePaths2, CODE_PATH>, IEnumCodePaths2
    {
        public EnumCodePaths(IEnumerable<CODE_PATH> codePaths)
            : base(codePaths)
        {
            Contract.Requires(codePaths != null);
        }

        protected EnumCodePaths(CODE_PATH[] elements, int currentIndex)
            : base(elements, currentIndex)
        {
        }

        protected override IEnumCodePaths2 CreateClone(CODE_PATH[] elements, int currentIndex)
        {
            return new EnumCodePaths(elements, currentIndex);
        }
    }
}
