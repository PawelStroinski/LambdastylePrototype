using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Parser
{
    abstract class ElementWalkerFactory
    {
        public abstract ElementWalker GetWalkerForElementType(int elementType);
    }

    class SubjectElementWalkerFactory : ElementWalkerFactory
    {
        public override ElementWalker GetWalkerForElementType(int elementType)
        {
            switch (elementType)
            {
                case LambdastyleTryParser.STRING_LITERAL:
                    return new StringLiteralWalker();
                case LambdastyleTryParser.REGEXP_LITERAL:
                    return new RegExpLiteralWalker();
                case LambdastyleTryParser.NUMBER:
                    return new NumberWalker();
                case LambdastyleTryParser.STAR:
                    return new StarWalker();
                case LambdastyleTryParser.ITEM:
                    return new ItemWalker();
                case LambdastyleTryParser.ITEM_INDEX:
                    return new ItemIndexWalker();
                case LambdastyleTryParser.START:
                    return new StartWalker();
                case LambdastyleTryParser.NULL:
                    return new NullWalker();
                case LambdastyleTryParser.EQ:
                    return new EqWalker();
                case LambdastyleTryParser.NEQ:
                    return new NeqWalker();
                case LambdastyleTryParser.DOT:
                    return new DotWalker();
                case LambdastyleTryParser.LSB:
                    return new LsbWalker();
                case LambdastyleTryParser.OR:
                    return new OrWalker();
                case LambdastyleTryParser.AND:
                    return new AndWalker();
                case LambdastyleTryParser.E:
                    return new EWalker();
                case LambdastyleTryParser.OROR:
                    return new OrOrWalker();
                case LambdastyleTryParser.LITERALISH_SEQUENCE:
                    return new LiteralishSequenceWalker();
                default:
                    return new OtherSubjectElementWalker();
            }
        }
    }

    class PredicateElementWalkerFactory : ElementWalkerFactory
    {
        public override ElementWalker GetWalkerForElementType(int elementType)
        {
            switch (elementType)
            {
                case LambdastyleTryParser.OR:
                    return new PredicateOrWalker();
                case LambdastyleTryParser.OROR:
                    return new PredicateOrOrWalker();
                case LambdastyleTryParser.AND:
                    return new PredicateAndWalker();
                case LambdastyleTryParser.HASH:
                    return new HashWalker();
                default:
                    return new OtherPredicateElementWalker();
            }
        }
    }
}
