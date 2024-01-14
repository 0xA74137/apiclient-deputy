using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Av.ApiClients.Deputy.ResourceGenerator
{
    internal class IndentableStringBuilder
    {
        private readonly StringBuilder _sb;
        private readonly string _indent;
        private int _indentLevel;

        public IndentableStringBuilder(string indent)
        {
            _sb = new StringBuilder();
            _indent = indent;
        }

        public IndentableStringBuilder Append(string value)
        {
            _sb.Append(value);
            return this;
        }

        public IndentableStringBuilder AppendLine()
        {
            _sb.AppendLine();
            return this;
        }

        public IndentableStringBuilder AppendLine(string line)
        {
            for (int i = 0; i < _indentLevel; i++)
                _sb.Append(_indent);

            _sb.AppendLine(line);
            return this;
        }

        public IDisposable Block() => Block("{", "}");
        public IDisposable Block(string openBlock, string closeBlock)
            => new IndentContext(this, openBlock, closeBlock);

        public IndentableStringBuilder Indent()
        {
            _indentLevel++;
            return this;
        }

        public IndentableStringBuilder Dedent()
        {
            _indentLevel--;
            return this;
        }

        public override string ToString()
        {
            return _sb.ToString();
        }

        class IndentContext : IDisposable
        {
            private readonly IndentableStringBuilder _sb;
            private readonly string _closeBlock;

            public IndentContext(IndentableStringBuilder sb, string openBlock, string closeBlock)
            {
                _sb = sb;
                _closeBlock = closeBlock;
                _sb.AppendLine(openBlock);
                _sb.Indent();
            }

            public void Dispose()
            {
                _sb.Dedent();
                _sb.AppendLine(_closeBlock);
            }
        }
    }
}
