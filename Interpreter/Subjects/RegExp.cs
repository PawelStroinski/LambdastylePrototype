using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class RegExp : Literal
    {
        readonly string value;

        public RegExp(string value)
        {
            this.value = value;
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var position = context.Position;
            foreach (var step in position.Where(step => step.Value != null))
            {
                var result = Regex.Match(input: step.Value.ToString(), pattern: value);
                if (result.Success)
                {
                    var groups = result.Groups.Cast<Group>().Skip(1).Select(group => group.Value).ToArray();
                    return new AppliesAtResult(true, new LogEntry(GetType(), tail: false, position: null,
                        regExpGroups: groups));
                }
            }
            return Result(false);
        }

        public override string ToRegExp()
        {
            return value;
        }
    }
}
