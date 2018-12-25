﻿using System;

namespace BitcoinABC.Internal.Secp256K1
{
    [Flags]
    internal enum Options : uint
    {
        FlagsTypeMask = 255, // 0x000000FF
        FlagsTypeContext = 1,
        FlagsTypeCompression = 2,
        FlagsBitContextVerify = 256, // 0x00000100
        FlagsBitContextSign = 512, // 0x00000200
        FlagsBitCompression = FlagsBitContextVerify, // 0x00000100
        ContextVerify = FlagsBitCompression | FlagsTypeContext, // 0x00000101
        ContextSign = FlagsBitContextSign | FlagsTypeContext, // 0x00000201
        ContextNone = FlagsTypeContext, // 0x00000001
        EcCompressed = FlagsBitCompression | FlagsTypeCompression, // 0x00000102
        EcUncompressed = FlagsTypeCompression, // 0x00000002
    }
}
