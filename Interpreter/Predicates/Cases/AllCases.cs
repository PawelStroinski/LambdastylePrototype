using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class AllCases : Case
    {
        readonly List<Type> appliedCases = new List<Type>();

        public override PredicateElement[] ApplyTo(CaseContext context)
        {
            appliedCases.Clear();
            var cases = CreateCases();
            var elements = context.Elements;
            foreach (var @case in cases)
            {
                var elementsAfterCase = @case.ApplyTo(context.Copy(elements, appliedCases.ToArray()));
                if (!elementsAfterCase.SequenceEqual(elements))
                    appliedCases.Add(@case.GetType());
                elements = elementsAfterCase;
            }
            return elements;
        }

        public bool AppliedCase<T>() where T : Case
        {
            return appliedCases.Contains(typeof(T));
        }

        Case[] CreateCases()
        {
            var allTypes = Assembly.GetExecutingAssembly().GetTypes();
            var caseTypes = allTypes
                .Where(type => typeof(Case).IsAssignableFrom(type))
                .Except(new Type[] { typeof(Case), typeof(AllCases) })
                .OrderBy(type => type.GetField("Order") == null ? 0 : type.GetField("Order").GetValue(null))
                .ToArray();
            return caseTypes
                .Select(type => Activator.CreateInstance(type))
                .Cast<Case>()
                .ToArray();
        }

        public override string ToString()
        {
            return string.Join(", ", appliedCases.Select(@case => @case.Name.ToString()));
        }
    }
}
