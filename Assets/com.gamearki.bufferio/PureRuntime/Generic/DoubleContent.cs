using System.Runtime.InteropServices;

namespace GameArki {
    
    [StructLayout(LayoutKind.Explicit)]
    internal struct DoubleContent {
        [FieldOffset(0)]
        public double doubleValue;
        [FieldOffset(0)]
        public ulong ulongValue;
    }
}