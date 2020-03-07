﻿using System;
using System.Collections.Generic;
using StepParser.Tokens;

namespace StepParser.Syntax
{
    internal class StepHeaderMacroSyntax : StepSyntax
    {
        public override StepSyntaxType SyntaxType => StepSyntaxType.HeaderMacro;

        public string Name { get; }
        public StepSyntaxList Values { get; }

        public StepHeaderMacroSyntax(string name, StepSyntaxList values)
            : base(values.Line, values.Column)
        {
            Name = name;
            Values = values;
        }

        public override IEnumerable<StepToken> GetTokens()
        {
            throw new NotSupportedException();
        }
    }
}
