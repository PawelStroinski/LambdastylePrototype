using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace LambdastylePrototype.Parser
{
    class Builder
    {
        readonly Stack<List<Sentence>> sentences = new Stack<List<Sentence>>();
        readonly Stack<SentenceDraft> sentenceDrafts = new Stack<SentenceDraft>();
        readonly Stack<List<ExpressionElement>> expressionElements = new Stack<List<ExpressionElement>>();
        readonly List<PredicateElement> predicateElements = new List<PredicateElement>();

        public Sentence[] GetStyle()
        {
            return sentences.Peek().ToArray();
        }

        public virtual void StartStyle()
        {
            sentences.Push(new List<Sentence>());
        }

        public virtual void EndStyle()
        {
        }

        public virtual void StartSentence()
        {
            sentenceDrafts.Push(new SentenceDraft());
        }

        public virtual void EndSentence()
        {
            var draft = sentenceDrafts.Pop();
            var sentence = new Sentence(draft.Subject, draft.Predicate, draft.Children);
            sentences.Peek().Add(sentence);
        }

        public virtual void StartSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndSubject()
        {
            var draft = sentenceDrafts.Peek();
            var elements = expressionElements.Pop().ToArray();
            draft.Subject = new Subject(elements);
        }

        public virtual void StartPredicate()
        {
            predicateElements.Clear();
        }

        public virtual void EndPredicate()
        {
            var draft = sentenceDrafts.Peek();
            draft.Predicate = new Predicate(predicateElements.ToArray());
        }

        public virtual void StartChildren()
        {
            sentences.Push(new List<Sentence>());
        }

        public virtual void EndChildren()
        {
            var draft = sentenceDrafts.Peek();
            draft.Children = sentences.Pop().ToArray();
        }

        public virtual void StartEqualsInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndEqualsInSubject()
        {
            WrapPoppedExpressionElements(elements => new Equals(elements[0], elements[1]));
        }

        public virtual void StartNotEqualsInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndNotEqualsInSubject()
        {
            WrapPoppedExpressionElements(elements => new NotEquals(elements[0], elements[1]));
        }

        public virtual void StartPathInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndPathInSubject()
        {
            WrapPoppedExpressionElements(elements => new Path(elements));
        }

        public virtual void StartParentInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndParentInSubject()
        {
            WrapPoppedExpressionElements(elements => new Parent(elements));
        }

        public virtual void StartOrInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndOrInSubject()
        {
            WrapPoppedExpressionElements(elements => new Or(elements));
        }

        public virtual void StartAndInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndAndInSubject()
        {
            WrapPoppedExpressionElements(elements => new And(elements));
        }

        public virtual void StartNotInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndNotInSubject()
        {
            WrapPoppedExpressionElements(elements => new Not(elements));
        }

        public virtual void StartShortOrInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndShortOrInSubject()
        {
            WrapPoppedExpressionElements(elements => new ShortOr(elements[0], elements[1]));
        }

        public virtual void StartLiteralishSequenceInSubject()
        {
            PushToExpressionElements();
        }

        public virtual void EndLiteralishSequenceInSubject()
        {
            WrapPoppedExpressionElements(elements => new LiteralishSequence(elements.Cast<Literalish>().ToArray()));
        }

        public virtual void AddAnyToSubject()
        {
            expressionElements.Peek().Add(new Any());
        }

        public virtual void AddItemToSubject()
        {
            expressionElements.Peek().Add(new Item());
        }

        public virtual void AddItemIndexToSubject(int itemIndex)
        {
            expressionElements.Peek().Add(new ItemIndex(itemIndex));
        }

        public virtual void AddStartToSubject()
        {
            expressionElements.Peek().Add(new Start());
        }

        public virtual void AddNullToSubject()
        {
            expressionElements.Peek().Add(new Null());
        }

        public virtual void AddIdToSubject(string value)
        {
            expressionElements.Peek().Add(new Id(value));
        }

        public virtual void AddLiteralToSubject(string value)
        {
            expressionElements.Peek().Add(new Literal(value));
        }

        public virtual void AddLiteralToSubject(long value)
        {
            expressionElements.Peek().Add(new Literal(value));
        }

        public virtual void AddRegExpToSubject(string value)
        {
            expressionElements.Peek().Add(new RegExp(value));
        }

        public virtual void AddRawToPredicate(string value)
        {
            predicateElements.Add(new Raw(value));
        }

        public virtual void AddInnerValueToPredicate()
        {
            predicateElements.Add(new InnerValue());
        }

        public virtual void AddOuterValueToPredicate()
        {
            predicateElements.Add(new OuterValue());
        }

        public virtual void AddOuterIdToPredicate()
        {
            predicateElements.Add(new OuterId());
        }

        public virtual void AddRegExpGroupToPredicate(int groupNumber)
        {
            predicateElements.Add(new RegExpGroup(groupNumber));
        }

        void PushToExpressionElements()
        {
            expressionElements.Push(new List<ExpressionElement>());
        }

        void WrapPoppedExpressionElements(Func<ExpressionElement[], ExpressionElement> createWrap)
        {
            var elements = expressionElements.Pop().ToArray();
            expressionElements.Peek().Add(createWrap(elements));
        }
    }
}
