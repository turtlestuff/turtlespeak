﻿using Microsoft.Scripting;

namespace TinySpeak.Compiler.Syntax
{
    public class StringToken : LiteralToken
    {
        public StringToken(string val, SourceSpan location) : base(val, location)
        {
        }
    }
}