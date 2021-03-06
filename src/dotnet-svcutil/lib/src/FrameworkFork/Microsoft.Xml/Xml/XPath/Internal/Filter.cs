// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MS.Internal.Xml.XPath
{
    using System;
    using Microsoft.Xml;
    using Microsoft.Xml.XPath;
    using System.Diagnostics;
    using System.Globalization;

    internal class Filter : AstNode
    {
        private AstNode _input;
        private AstNode _condition;

        public Filter(AstNode input, AstNode condition)
        {
            _input = input;
            _condition = condition;
        }

        public override AstType Type { get { return AstType.Filter; } }
        public override XPathResultType ReturnType { get { return XPathResultType.NodeSet; } }

        public AstNode Input { get { return _input; } }
        public AstNode Condition { get { return _condition; } }
    }
}
