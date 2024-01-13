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
    }
}
