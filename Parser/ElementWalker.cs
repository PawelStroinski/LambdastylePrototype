using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr.Runtime.Tree;

namespace LambdastylePrototype.Parser
{
    abstract class ElementWalker
    {
        public abstract void Walk(CommonTree element, ElementWalkerContext context);
    }

    class StringLiteralWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            var relation = element.Parent.Type == LambdastyleTryParser.EQ
                || element.Parent.Type == LambdastyleTryParser.NEQ;
            var rightSideOfRelation = relation && element.ChildIndex == 1;
            var insideLiteralishSequence = element.Parent.Type == LambdastyleTryParser.LITERALISH_SEQUENCE;
            if (rightSideOfRelation || insideLiteralishSequence)
                context.Builder.AddLiteralToSubject(element.Text.WithoutFirstAndLastChar());
            else
                context.Builder.AddIdToSubject(element.Text.WithoutFirstAndLastChar());
        }
    }

    class RegExpLiteralWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddRegExpToSubject(element.Text.WithoutFirstAndLastChar());
        }
    }

    class NumberWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddLiteralToSubject(long.Parse(element.Text));
        }
    }

    class StarWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddAnyToSubject();
        }
    }

    class ItemWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddItemToSubject();
        }
    }

    class ItemIndexWalker : ElementWalker
    {
        const string pattern = @"^item\s*\[\s*(\d+)\s*\]$";

        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            var result = Regex.Match(input: element.Text, pattern: pattern);
            if (result.Success)
                context.Builder.AddItemIndexToSubject(int.Parse(result.Groups[1].Value));
            else
                context.Builder.AddItemToSubject();
        }
    }

    class StartWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddStartToSubject();
        }
    }

    class NullWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddNullToSubject();
        }
    }

    class EqWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartEqualsInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndEqualsInSubject();
        }
    }

    class NeqWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartNotEqualsInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndNotEqualsInSubject();
        }
    }

    class DotWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartPathInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndPathInSubject();
        }
    }

    class LsbWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartParentInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndParentInSubject();
        }
    }

    class OrWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartOrInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndOrInSubject();
        }
    }

    class AndWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartAndInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndAndInSubject();
        }
    }

    class EWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartNotInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndNotInSubject();
        }
    }

    class OrOrWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartShortOrInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndShortOrInSubject();
        }
    }

    class LiteralishSequenceWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.StartLiteralishSequenceInSubject();
            context.WalkSubjectElements(element.GetChildren());
            context.Builder.EndLiteralishSequenceInSubject();
        }
    }

    class OtherSubjectElementWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context) { }
    }

    abstract class PredicateElementWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.PredicateRawBuffer.FlushRawToPredicate();
            if (context.PredicateRawBuffer.EscapeNextPredicateElement)
            {
                EscapedWalk(context);
                context.PredicateRawBuffer.EscapeNextPredicateElement = false;
            }
            else
                UnescapedWalk(element, context);
        }

        protected abstract void EscapedWalk(ElementWalkerContext context);

        protected abstract void UnescapedWalk(CommonTree element, ElementWalkerContext context);
    }

    class PredicateOrWalker : PredicateElementWalker
    {
        protected override void EscapedWalk(ElementWalkerContext context)
        {
            context.Builder.AddRawToPredicate(PredicateRawBuffer.Pipe.ToString());
        }

        protected override void UnescapedWalk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddInnerValueToPredicate();
        }
    }

    class PredicateOrOrWalker : PredicateElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            base.Walk(element, context);
            context.Builder.AddInnerValueToPredicate();
        }

        protected override void EscapedWalk(ElementWalkerContext context)
        {
            context.Builder.AddRawToPredicate(PredicateRawBuffer.Pipe.ToString());
        }

        protected override void UnescapedWalk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddInnerValueToPredicate();
        }
    }

    class PredicateAndWalker : PredicateElementWalker
    {
        protected override void EscapedWalk(ElementWalkerContext context)
        {
            context.Builder.AddRawToPredicate(PredicateRawBuffer.Ampersand.ToString());
        }

        protected override void UnescapedWalk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddOuterValueToPredicate();
        }
    }

    class HashWalker : PredicateElementWalker
    {
        protected override void EscapedWalk(ElementWalkerContext context)
        {
            context.Builder.AddRawToPredicate(PredicateRawBuffer.Hash.ToString());
        }

        protected override void UnescapedWalk(CommonTree element, ElementWalkerContext context)
        {
            context.Builder.AddOuterIdToPredicate();
        }
    }

    class OtherPredicateElementWalker : ElementWalker
    {
        public override void Walk(CommonTree element, ElementWalkerContext context)
        {
            context.PredicateRawBuffer.Append(element.Text);
        }
    }
}
