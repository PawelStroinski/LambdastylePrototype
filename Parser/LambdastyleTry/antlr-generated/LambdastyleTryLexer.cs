// $ANTLR 3.3 Nov 30, 2010 12:50:56 C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g 2014-05-26 08:32:05

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;
namespace  LambdastylePrototype.Parser 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class LambdastyleTryLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int SENTENCE=4;
	public const int SUBJECT=5;
	public const int START=6;
	public const int LITERALISH_SEQUENCE=7;
	public const int EOL=8;
	public const int SPACE=9;
	public const int ARR=10;
	public const int STRING_LITERAL=11;
	public const int REGEXP_LITERAL=12;
	public const int STAR=13;
	public const int LP=14;
	public const int RP=15;
	public const int LSB=16;
	public const int RSB=17;
	public const int DOT=18;
	public const int E=19;
	public const int EQ=20;
	public const int NEQ=21;
	public const int OR=22;
	public const int OROR=23;
	public const int AND=24;
	public const int NUMBER=25;
	public const int BOOLEAN=26;
	public const int ITEM=27;
	public const int ITEM_INDEX=28;
	public const int NULL=29;
	public const int ALL=30;
	public const int Q=31;
	public const int S=32;
	public const int HASH=33;
	public const int DUMMY=34;
	public const int STRING_LITERAL_F=35;
	public const int REGEXP_LITERAL_F=36;
	public const int DIGIT=37;
	public const int ITEM_INDEX_F=38;
	public const int COMMENT=39;

    // delegates
    // delegators

	public LambdastyleTryLexer()
	{
		OnCreated();
	}

	public LambdastyleTryLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public LambdastyleTryLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_ARR();
	partial void Leave_ARR();

	// $ANTLR start "ARR"
	[GrammarRule("ARR")]
	private void mARR()
	{
		Enter_ARR();
		EnterRule("ARR", 1);
		TraceIn("ARR", 1);
		try
		{
			int _type = ARR;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:60:4: ( '->' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:60:6: '->'
			{
			DebugLocation(60, 6);
			Match("->"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARR", 1);
			LeaveRule("ARR", 1);
			Leave_ARR();
		}
	}
	// $ANTLR end "ARR"

	partial void Enter_ITEM();
	partial void Leave_ITEM();

	// $ANTLR start "ITEM"
	[GrammarRule("ITEM")]
	private void mITEM()
	{
		Enter_ITEM();
		EnterRule("ITEM", 2);
		TraceIn("ITEM", 2);
		try
		{
			int _type = ITEM;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:61:5: ( 'item' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:61:7: 'item'
			{
			DebugLocation(61, 7);
			Match("item"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ITEM", 2);
			LeaveRule("ITEM", 2);
			Leave_ITEM();
		}
	}
	// $ANTLR end "ITEM"

	partial void Enter_NULL();
	partial void Leave_NULL();

	// $ANTLR start "NULL"
	[GrammarRule("NULL")]
	private void mNULL()
	{
		Enter_NULL();
		EnterRule("NULL", 3);
		TraceIn("NULL", 3);
		try
		{
			int _type = NULL;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:62:5: ( 'null' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:62:7: 'null'
			{
			DebugLocation(62, 7);
			Match("null"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NULL", 3);
			LeaveRule("NULL", 3);
			Leave_NULL();
		}
	}
	// $ANTLR end "NULL"

	partial void Enter_LP();
	partial void Leave_LP();

	// $ANTLR start "LP"
	[GrammarRule("LP")]
	private void mLP()
	{
		Enter_LP();
		EnterRule("LP", 4);
		TraceIn("LP", 4);
		try
		{
			int _type = LP;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:63:3: ( '(' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:63:5: '('
			{
			DebugLocation(63, 5);
			Match('('); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LP", 4);
			LeaveRule("LP", 4);
			Leave_LP();
		}
	}
	// $ANTLR end "LP"

	partial void Enter_RP();
	partial void Leave_RP();

	// $ANTLR start "RP"
	[GrammarRule("RP")]
	private void mRP()
	{
		Enter_RP();
		EnterRule("RP", 5);
		TraceIn("RP", 5);
		try
		{
			int _type = RP;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:64:3: ( ')' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:64:5: ')'
			{
			DebugLocation(64, 5);
			Match(')'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RP", 5);
			LeaveRule("RP", 5);
			Leave_RP();
		}
	}
	// $ANTLR end "RP"

	partial void Enter_LSB();
	partial void Leave_LSB();

	// $ANTLR start "LSB"
	[GrammarRule("LSB")]
	private void mLSB()
	{
		Enter_LSB();
		EnterRule("LSB", 6);
		TraceIn("LSB", 6);
		try
		{
			int _type = LSB;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:65:4: ( '[' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:65:6: '['
			{
			DebugLocation(65, 6);
			Match('['); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSB", 6);
			LeaveRule("LSB", 6);
			Leave_LSB();
		}
	}
	// $ANTLR end "LSB"

	partial void Enter_RSB();
	partial void Leave_RSB();

	// $ANTLR start "RSB"
	[GrammarRule("RSB")]
	private void mRSB()
	{
		Enter_RSB();
		EnterRule("RSB", 7);
		TraceIn("RSB", 7);
		try
		{
			int _type = RSB;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:66:4: ( ']' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:66:6: ']'
			{
			DebugLocation(66, 6);
			Match(']'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RSB", 7);
			LeaveRule("RSB", 7);
			Leave_RSB();
		}
	}
	// $ANTLR end "RSB"

	partial void Enter_STAR();
	partial void Leave_STAR();

	// $ANTLR start "STAR"
	[GrammarRule("STAR")]
	private void mSTAR()
	{
		Enter_STAR();
		EnterRule("STAR", 8);
		TraceIn("STAR", 8);
		try
		{
			int _type = STAR;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:67:5: ( '*' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:67:7: '*'
			{
			DebugLocation(67, 7);
			Match('*'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAR", 8);
			LeaveRule("STAR", 8);
			Leave_STAR();
		}
	}
	// $ANTLR end "STAR"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 9);
		TraceIn("DOT", 9);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:68:4: ( '.' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:68:6: '.'
			{
			DebugLocation(68, 6);
			Match('.'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 9);
			LeaveRule("DOT", 9);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_EQ();
	partial void Leave_EQ();

	// $ANTLR start "EQ"
	[GrammarRule("EQ")]
	private void mEQ()
	{
		Enter_EQ();
		EnterRule("EQ", 10);
		TraceIn("EQ", 10);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:69:3: ( '=' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:69:5: '='
			{
			DebugLocation(69, 5);
			Match('='); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 10);
			LeaveRule("EQ", 10);
			Leave_EQ();
		}
	}
	// $ANTLR end "EQ"

	partial void Enter_NEQ();
	partial void Leave_NEQ();

	// $ANTLR start "NEQ"
	[GrammarRule("NEQ")]
	private void mNEQ()
	{
		Enter_NEQ();
		EnterRule("NEQ", 11);
		TraceIn("NEQ", 11);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:70:4: ( '!=' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:70:6: '!='
			{
			DebugLocation(70, 6);
			Match("!="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 11);
			LeaveRule("NEQ", 11);
			Leave_NEQ();
		}
	}
	// $ANTLR end "NEQ"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 12);
		TraceIn("OR", 12);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:71:3: ( '|' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:71:5: '|'
			{
			DebugLocation(71, 5);
			Match('|'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 12);
			LeaveRule("OR", 12);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_OROR();
	partial void Leave_OROR();

	// $ANTLR start "OROR"
	[GrammarRule("OROR")]
	private void mOROR()
	{
		Enter_OROR();
		EnterRule("OROR", 13);
		TraceIn("OROR", 13);
		try
		{
			int _type = OROR;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:72:5: ( '||' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:72:7: '||'
			{
			DebugLocation(72, 7);
			Match("||"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OROR", 13);
			LeaveRule("OROR", 13);
			Leave_OROR();
		}
	}
	// $ANTLR end "OROR"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 14);
		TraceIn("AND", 14);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:73:4: ( '&' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:73:6: '&'
			{
			DebugLocation(73, 6);
			Match('&'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 14);
			LeaveRule("AND", 14);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_HASH();
	partial void Leave_HASH();

	// $ANTLR start "HASH"
	[GrammarRule("HASH")]
	private void mHASH()
	{
		Enter_HASH();
		EnterRule("HASH", 15);
		TraceIn("HASH", 15);
		try
		{
			int _type = HASH;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:74:5: ( '#' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:74:7: '#'
			{
			DebugLocation(74, 7);
			Match('#'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("HASH", 15);
			LeaveRule("HASH", 15);
			Leave_HASH();
		}
	}
	// $ANTLR end "HASH"

	partial void Enter_Q();
	partial void Leave_Q();

	// $ANTLR start "Q"
	[GrammarRule("Q")]
	private void mQ()
	{
		Enter_Q();
		EnterRule("Q", 16);
		TraceIn("Q", 16);
		try
		{
			int _type = Q;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:75:2: ( '\"' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:75:4: '\"'
			{
			DebugLocation(75, 4);
			Match('\"'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Q", 16);
			LeaveRule("Q", 16);
			Leave_Q();
		}
	}
	// $ANTLR end "Q"

	partial void Enter_E();
	partial void Leave_E();

	// $ANTLR start "E"
	[GrammarRule("E")]
	private void mE()
	{
		Enter_E();
		EnterRule("E", 17);
		TraceIn("E", 17);
		try
		{
			int _type = E;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:76:2: ( '!' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:76:4: '!'
			{
			DebugLocation(76, 4);
			Match('!'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("E", 17);
			LeaveRule("E", 17);
			Leave_E();
		}
	}
	// $ANTLR end "E"

	partial void Enter_S();
	partial void Leave_S();

	// $ANTLR start "S"
	[GrammarRule("S")]
	private void mS()
	{
		Enter_S();
		EnterRule("S", 18);
		TraceIn("S", 18);
		try
		{
			int _type = S;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:77:2: ( '/' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:77:4: '/'
			{
			DebugLocation(77, 4);
			Match('/'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("S", 18);
			LeaveRule("S", 18);
			Leave_S();
		}
	}
	// $ANTLR end "S"

	partial void Enter_STRING_LITERAL();
	partial void Leave_STRING_LITERAL();

	// $ANTLR start "STRING_LITERAL"
	[GrammarRule("STRING_LITERAL")]
	private void mSTRING_LITERAL()
	{
		Enter_STRING_LITERAL();
		EnterRule("STRING_LITERAL", 19);
		TraceIn("STRING_LITERAL", 19);
		try
		{
			int _type = STRING_LITERAL;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:78:15: ( ( STRING_LITERAL_F )=> STRING_LITERAL_F | Q )
			int alt1=2;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			int LA1_0 = input.LA(1);

			if ((LA1_0=='\"'))
			{
				int LA1_1 = input.LA(2);

				if ((LA1_1=='\\') && (EvaluatePredicate(synpred1_LambdastyleTry_fragment)))
				{
					alt1=1;
				}
				else if (((LA1_1>='\u0000' && LA1_1<='\t')||(LA1_1>='\u000B' && LA1_1<='\f')||(LA1_1>='\u000E' && LA1_1<='!')||(LA1_1>='#' && LA1_1<='[')||(LA1_1>=']' && LA1_1<='\uFFFF')) && (EvaluatePredicate(synpred1_LambdastyleTry_fragment)))
				{
					alt1=1;
				}
				else if ((LA1_1=='\"') && (EvaluatePredicate(synpred1_LambdastyleTry_fragment)))
				{
					alt1=1;
				}
				else
				{
					alt1=2;}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:78:17: ( STRING_LITERAL_F )=> STRING_LITERAL_F
				{
				DebugLocation(78, 39);
				mSTRING_LITERAL_F(); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:79:8: Q
				{
				DebugLocation(79, 8);
				mQ(); if (state.failed) return;

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING_LITERAL", 19);
			LeaveRule("STRING_LITERAL", 19);
			Leave_STRING_LITERAL();
		}
	}
	// $ANTLR end "STRING_LITERAL"

	partial void Enter_REGEXP_LITERAL();
	partial void Leave_REGEXP_LITERAL();

	// $ANTLR start "REGEXP_LITERAL"
	[GrammarRule("REGEXP_LITERAL")]
	private void mREGEXP_LITERAL()
	{
		Enter_REGEXP_LITERAL();
		EnterRule("REGEXP_LITERAL", 20);
		TraceIn("REGEXP_LITERAL", 20);
		try
		{
			int _type = REGEXP_LITERAL;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:80:15: ( ( REGEXP_LITERAL_F )=> REGEXP_LITERAL_F | S )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0=='/'))
			{
				int LA2_1 = input.LA(2);

				if ((LA2_1=='\\') && (EvaluatePredicate(synpred2_LambdastyleTry_fragment)))
				{
					alt2=1;
				}
				else if (((LA2_1>='\u0000' && LA2_1<='\t')||(LA2_1>='\u000B' && LA2_1<='\f')||(LA2_1>='\u000E' && LA2_1<='.')||(LA2_1>='0' && LA2_1<='[')||(LA2_1>=']' && LA2_1<='\uFFFF')) && (EvaluatePredicate(synpred2_LambdastyleTry_fragment)))
				{
					alt2=1;
				}
				else if ((LA2_1=='/') && (EvaluatePredicate(synpred2_LambdastyleTry_fragment)))
				{
					alt2=1;
				}
				else
				{
					alt2=2;}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:80:17: ( REGEXP_LITERAL_F )=> REGEXP_LITERAL_F
				{
				DebugLocation(80, 39);
				mREGEXP_LITERAL_F(); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:81:8: S
				{
				DebugLocation(81, 8);
				mS(); if (state.failed) return;

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REGEXP_LITERAL", 20);
			LeaveRule("REGEXP_LITERAL", 20);
			Leave_REGEXP_LITERAL();
		}
	}
	// $ANTLR end "REGEXP_LITERAL"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 21);
		TraceIn("NUMBER", 21);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:7: ( ( DIGIT )+ ( DOT ( DIGIT )+ )? )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:9: ( DIGIT )+ ( DOT ( DIGIT )+ )?
			{
			DebugLocation(82, 9);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:9: ( DIGIT )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='0' && LA3_0<='9')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:9: DIGIT
					{
					DebugLocation(82, 9);
					mDIGIT(); if (state.failed) return;

					}
					break;

				default:
					if (cnt3 >= 1)
						goto loop3;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(82, 16);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:16: ( DOT ( DIGIT )+ )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0=='.'))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:17: DOT ( DIGIT )+
				{
				DebugLocation(82, 17);
				mDOT(); if (state.failed) return;
				DebugLocation(82, 21);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:21: ( DIGIT )+
				int cnt4=0;
				try { DebugEnterSubRule(4);
				while (true)
				{
					int alt4=2;
					try { DebugEnterDecision(4, decisionCanBacktrack[4]);
					int LA4_0 = input.LA(1);

					if (((LA4_0>='0' && LA4_0<='9')))
					{
						alt4=1;
					}


					} finally { DebugExitDecision(4); }
					switch (alt4)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:82:21: DIGIT
						{
						DebugLocation(82, 21);
						mDIGIT(); if (state.failed) return;

						}
						break;

					default:
						if (cnt4 >= 1)
							goto loop4;

						if (state.backtracking>0) {state.failed=true; return;}
						EarlyExitException eee4 = new EarlyExitException( 4, input );
						DebugRecognitionException(eee4);
						throw eee4;
					}
					cnt4++;
				}
				loop4:
					;

				} finally { DebugExitSubRule(4); }


				}
				break;

			}
			} finally { DebugExitSubRule(5); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 21);
			LeaveRule("NUMBER", 21);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_ITEM_INDEX();
	partial void Leave_ITEM_INDEX();

	// $ANTLR start "ITEM_INDEX"
	[GrammarRule("ITEM_INDEX")]
	private void mITEM_INDEX()
	{
		Enter_ITEM_INDEX();
		EnterRule("ITEM_INDEX", 22);
		TraceIn("ITEM_INDEX", 22);
		try
		{
			int _type = ITEM_INDEX;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:83:11: ( ( ITEM_INDEX_F )=> ITEM_INDEX_F | ITEM )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0=='i'))
			{
				int LA6_1 = input.LA(2);

				if ((LA6_1=='t'))
				{
					int LA6_2 = input.LA(3);

					if ((LA6_2=='e'))
					{
						int LA6_3 = input.LA(4);

						if ((LA6_3=='m'))
						{
							int LA6_4 = input.LA(5);

							if ((LA6_4=='\t'||LA6_4==' ') && (EvaluatePredicate(synpred3_LambdastyleTry_fragment)))
							{
								alt6=1;
							}
							else if ((LA6_4=='[') && (EvaluatePredicate(synpred3_LambdastyleTry_fragment)))
							{
								alt6=1;
							}
							else
							{
								alt6=2;}
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return;}
							NoViableAltException nvae = new NoViableAltException("", 6, 3, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						NoViableAltException nvae = new NoViableAltException("", 6, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 6, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:83:13: ( ITEM_INDEX_F )=> ITEM_INDEX_F
				{
				DebugLocation(83, 31);
				mITEM_INDEX_F(); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:84:7: ITEM
				{
				DebugLocation(84, 7);
				mITEM(); if (state.failed) return;

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ITEM_INDEX", 22);
			LeaveRule("ITEM_INDEX", 22);
			Leave_ITEM_INDEX();
		}
	}
	// $ANTLR end "ITEM_INDEX"

	partial void Enter_BOOLEAN();
	partial void Leave_BOOLEAN();

	// $ANTLR start "BOOLEAN"
	[GrammarRule("BOOLEAN")]
	private void mBOOLEAN()
	{
		Enter_BOOLEAN();
		EnterRule("BOOLEAN", 23);
		TraceIn("BOOLEAN", 23);
		try
		{
			int _type = BOOLEAN;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:85:8: ( 'true' | 'false' )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='t'))
			{
				alt7=1;
			}
			else if ((LA7_0=='f'))
			{
				alt7=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:85:10: 'true'
				{
				DebugLocation(85, 10);
				Match("true"); if (state.failed) return;


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:85:17: 'false'
				{
				DebugLocation(85, 17);
				Match("false"); if (state.failed) return;


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOLEAN", 23);
			LeaveRule("BOOLEAN", 23);
			Leave_BOOLEAN();
		}
	}
	// $ANTLR end "BOOLEAN"

	partial void Enter_SPACE();
	partial void Leave_SPACE();

	// $ANTLR start "SPACE"
	[GrammarRule("SPACE")]
	private void mSPACE()
	{
		Enter_SPACE();
		EnterRule("SPACE", 24);
		TraceIn("SPACE", 24);
		try
		{
			int _type = SPACE;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:86:6: ( ' ' | '\\t' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:
			{
			DebugLocation(86, 6);
			if (input.LA(1)=='\t'||input.LA(1)==' ')
			{
				input.Consume();
			state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SPACE", 24);
			LeaveRule("SPACE", 24);
			Leave_SPACE();
		}
	}
	// $ANTLR end "SPACE"

	partial void Enter_EOL();
	partial void Leave_EOL();

	// $ANTLR start "EOL"
	[GrammarRule("EOL")]
	private void mEOL()
	{
		Enter_EOL();
		EnterRule("EOL", 25);
		TraceIn("EOL", 25);
		try
		{
			int _type = EOL;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:87:4: ( '\\r\\n' | '\\r' | '\\n' )
			int alt8=3;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0=='\r'))
			{
				int LA8_1 = input.LA(2);

				if ((LA8_1=='\n'))
				{
					alt8=1;
				}
				else
				{
					alt8=2;}
			}
			else if ((LA8_0=='\n'))
			{
				alt8=3;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:87:6: '\\r\\n'
				{
				DebugLocation(87, 6);
				Match("\r\n"); if (state.failed) return;


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:87:13: '\\r'
				{
				DebugLocation(87, 13);
				Match('\r'); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:87:18: '\\n'
				{
				DebugLocation(87, 18);
				Match('\n'); if (state.failed) return;

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EOL", 25);
			LeaveRule("EOL", 25);
			Leave_EOL();
		}
	}
	// $ANTLR end "EOL"

	partial void Enter_COMMENT();
	partial void Leave_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		Enter_COMMENT();
		EnterRule("COMMENT", 26);
		TraceIn("COMMENT", 26);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:88:8: ( '//' (~ ( EOL ) )* )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:88:10: '//' (~ ( EOL ) )*
			{
			DebugLocation(88, 10);
			Match("//"); if (state.failed) return;

			DebugLocation(88, 15);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:88:15: (~ ( EOL ) )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>='\u0000' && LA9_0<='\t')||(LA9_0>='\u000B' && LA9_0<='\f')||(LA9_0>='\u000E' && LA9_0<='\uFFFF')))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:88:15: ~ ( EOL )
					{
					DebugLocation(88, 15);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(88, 23);
			if ( state.backtracking == 0 )
			{
				 _channel=Hidden; 
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 26);
			LeaveRule("COMMENT", 26);
			Leave_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	partial void Enter_ALL();
	partial void Leave_ALL();

	// $ANTLR start "ALL"
	[GrammarRule("ALL")]
	private void mALL()
	{
		Enter_ALL();
		EnterRule("ALL", 27);
		TraceIn("ALL", 27);
		try
		{
			int _type = ALL;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:89:4: ( . )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:89:6: .
			{
			DebugLocation(89, 6);
			MatchAny(); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ALL", 27);
			LeaveRule("ALL", 27);
			Leave_ALL();
		}
	}
	// $ANTLR end "ALL"

	partial void Enter_DUMMY();
	partial void Leave_DUMMY();

	// $ANTLR start "DUMMY"
	[GrammarRule("DUMMY")]
	private void mDUMMY()
	{
		Enter_DUMMY();
		EnterRule("DUMMY", 28);
		TraceIn("DUMMY", 28);
		try
		{
			int _type = DUMMY;
			int _channel = DefaultTokenChannel;
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:6: ( 'nu' | 'nul' | 'it' | 'ite' | 'tr' | 'tru' | 'fa' | 'fal' | 'fals' )
			int alt10=9;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			try
			{
				alt10 = dfa10.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:8: 'nu'
				{
				DebugLocation(90, 8);
				Match("nu"); if (state.failed) return;


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:15: 'nul'
				{
				DebugLocation(90, 15);
				Match("nul"); if (state.failed) return;


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:23: 'it'
				{
				DebugLocation(90, 23);
				Match("it"); if (state.failed) return;


				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:30: 'ite'
				{
				DebugLocation(90, 30);
				Match("ite"); if (state.failed) return;


				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:38: 'tr'
				{
				DebugLocation(90, 38);
				Match("tr"); if (state.failed) return;


				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:45: 'tru'
				{
				DebugLocation(90, 45);
				Match("tru"); if (state.failed) return;


				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:53: 'fa'
				{
				DebugLocation(90, 53);
				Match("fa"); if (state.failed) return;


				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:60: 'fal'
				{
				DebugLocation(90, 60);
				Match("fal"); if (state.failed) return;


				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:90:68: 'fals'
				{
				DebugLocation(90, 68);
				Match("fals"); if (state.failed) return;


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DUMMY", 28);
			LeaveRule("DUMMY", 28);
			Leave_DUMMY();
		}
	}
	// $ANTLR end "DUMMY"

	partial void Enter_STRING_LITERAL_F();
	partial void Leave_STRING_LITERAL_F();

	// $ANTLR start "STRING_LITERAL_F"
	[GrammarRule("STRING_LITERAL_F")]
	private void mSTRING_LITERAL_F()
	{
		Enter_STRING_LITERAL_F();
		EnterRule("STRING_LITERAL_F", 29);
		TraceIn("STRING_LITERAL_F", 29);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:91:26: ( Q ( '\\\\\"' | ~ ( Q | EOL ) )* Q )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:91:28: Q ( '\\\\\"' | ~ ( Q | EOL ) )* Q
			{
			DebugLocation(91, 28);
			mQ(); if (state.failed) return;
			DebugLocation(91, 30);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:91:30: ( '\\\\\"' | ~ ( Q | EOL ) )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=3;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if ((LA11_0=='\\'))
				{
					int LA11_2 = input.LA(2);

					if ((LA11_2=='\"'))
					{
						int LA11_4 = input.LA(3);

						if (((LA11_4>='\u0000' && LA11_4<='\t')||(LA11_4>='\u000B' && LA11_4<='\f')||(LA11_4>='\u000E' && LA11_4<='\uFFFF')))
						{
							alt11=1;
						}

						else
						{
							alt11=2;
						}

					}
					else if (((LA11_2>='\u0000' && LA11_2<='\t')||(LA11_2>='\u000B' && LA11_2<='\f')||(LA11_2>='\u000E' && LA11_2<='!')||(LA11_2>='#' && LA11_2<='\uFFFF')))
					{
						alt11=2;
					}


				}
				else if (((LA11_0>='\u0000' && LA11_0<='\t')||(LA11_0>='\u000B' && LA11_0<='\f')||(LA11_0>='\u000E' && LA11_0<='!')||(LA11_0>='#' && LA11_0<='[')||(LA11_0>=']' && LA11_0<='\uFFFF')))
				{
					alt11=2;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:91:31: '\\\\\"'
					{
					DebugLocation(91, 31);
					Match("\\\""); if (state.failed) return;


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:91:37: ~ ( Q | EOL )
					{
					DebugLocation(91, 37);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop11;
				}
			}

			loop11:
				;

			} finally { DebugExitSubRule(11); }

			DebugLocation(91, 48);
			mQ(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("STRING_LITERAL_F", 29);
			LeaveRule("STRING_LITERAL_F", 29);
			Leave_STRING_LITERAL_F();
		}
	}
	// $ANTLR end "STRING_LITERAL_F"

	partial void Enter_REGEXP_LITERAL_F();
	partial void Leave_REGEXP_LITERAL_F();

	// $ANTLR start "REGEXP_LITERAL_F"
	[GrammarRule("REGEXP_LITERAL_F")]
	private void mREGEXP_LITERAL_F()
	{
		Enter_REGEXP_LITERAL_F();
		EnterRule("REGEXP_LITERAL_F", 30);
		TraceIn("REGEXP_LITERAL_F", 30);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:92:26: ( S ( '\\\\/' | ~ ( S | EOL ) )* S )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:92:28: S ( '\\\\/' | ~ ( S | EOL ) )* S
			{
			DebugLocation(92, 28);
			mS(); if (state.failed) return;
			DebugLocation(92, 30);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:92:30: ( '\\\\/' | ~ ( S | EOL ) )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=3;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0=='\\'))
				{
					int LA12_2 = input.LA(2);

					if ((LA12_2=='/'))
					{
						int LA12_4 = input.LA(3);

						if (((LA12_4>='\u0000' && LA12_4<='\t')||(LA12_4>='\u000B' && LA12_4<='\f')||(LA12_4>='\u000E' && LA12_4<='\uFFFF')))
						{
							alt12=1;
						}

						else
						{
							alt12=2;
						}

					}
					else if (((LA12_2>='\u0000' && LA12_2<='\t')||(LA12_2>='\u000B' && LA12_2<='\f')||(LA12_2>='\u000E' && LA12_2<='.')||(LA12_2>='0' && LA12_2<='\uFFFF')))
					{
						alt12=2;
					}


				}
				else if (((LA12_0>='\u0000' && LA12_0<='\t')||(LA12_0>='\u000B' && LA12_0<='\f')||(LA12_0>='\u000E' && LA12_0<='.')||(LA12_0>='0' && LA12_0<='[')||(LA12_0>=']' && LA12_0<='\uFFFF')))
				{
					alt12=2;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:92:31: '\\\\/'
					{
					DebugLocation(92, 31);
					Match("\\/"); if (state.failed) return;


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:92:37: ~ ( S | EOL )
					{
					DebugLocation(92, 37);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='.')||(input.LA(1)>='0' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }

			DebugLocation(92, 48);
			mS(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("REGEXP_LITERAL_F", 30);
			LeaveRule("REGEXP_LITERAL_F", 30);
			Leave_REGEXP_LITERAL_F();
		}
	}
	// $ANTLR end "REGEXP_LITERAL_F"

	partial void Enter_ITEM_INDEX_F();
	partial void Leave_ITEM_INDEX_F();

	// $ANTLR start "ITEM_INDEX_F"
	[GrammarRule("ITEM_INDEX_F")]
	private void mITEM_INDEX_F()
	{
		Enter_ITEM_INDEX_F();
		EnterRule("ITEM_INDEX_F", 31);
		TraceIn("ITEM_INDEX_F", 31);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:22: ( ITEM ( SPACE )* LSB ( SPACE )* ( DIGIT )+ ( SPACE )* RSB )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:24: ITEM ( SPACE )* LSB ( SPACE )* ( DIGIT )+ ( SPACE )* RSB
			{
			DebugLocation(93, 24);
			mITEM(); if (state.failed) return;
			DebugLocation(93, 29);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:29: ( SPACE )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if ((LA13_0=='\t'||LA13_0==' '))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:29: SPACE
					{
					DebugLocation(93, 29);
					mSPACE(); if (state.failed) return;

					}
					break;

				default:
					goto loop13;
				}
			}

			loop13:
				;

			} finally { DebugExitSubRule(13); }

			DebugLocation(93, 36);
			mLSB(); if (state.failed) return;
			DebugLocation(93, 40);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:40: ( SPACE )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0=='\t'||LA14_0==' '))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:40: SPACE
					{
					DebugLocation(93, 40);
					mSPACE(); if (state.failed) return;

					}
					break;

				default:
					goto loop14;
				}
			}

			loop14:
				;

			} finally { DebugExitSubRule(14); }

			DebugLocation(93, 47);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:47: ( DIGIT )+
			int cnt15=0;
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if (((LA15_0>='0' && LA15_0<='9')))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch (alt15)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:47: DIGIT
					{
					DebugLocation(93, 47);
					mDIGIT(); if (state.failed) return;

					}
					break;

				default:
					if (cnt15 >= 1)
						goto loop15;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee15 = new EarlyExitException( 15, input );
					DebugRecognitionException(eee15);
					throw eee15;
				}
				cnt15++;
			}
			loop15:
				;

			} finally { DebugExitSubRule(15); }

			DebugLocation(93, 54);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:54: ( SPACE )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0=='\t'||LA16_0==' '))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:93:54: SPACE
					{
					DebugLocation(93, 54);
					mSPACE(); if (state.failed) return;

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }

			DebugLocation(93, 61);
			mRSB(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("ITEM_INDEX_F", 31);
			LeaveRule("ITEM_INDEX_F", 31);
			Leave_ITEM_INDEX_F();
		}
	}
	// $ANTLR end "ITEM_INDEX_F"

	partial void Enter_DIGIT();
	partial void Leave_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		Enter_DIGIT();
		EnterRule("DIGIT", 32);
		TraceIn("DIGIT", 32);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:94:15: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:94:17: '0' .. '9'
			{
			DebugLocation(94, 17);
			MatchRange('0','9'); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("DIGIT", 32);
			LeaveRule("DIGIT", 32);
			Leave_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	public override void mTokens()
	{
		// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:8: ( ARR | ITEM | NULL | LP | RP | LSB | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | BOOLEAN | SPACE | EOL | COMMENT | ALL | DUMMY )
		int alt17=28;
		try { DebugEnterDecision(17, decisionCanBacktrack[17]);
		try
		{
			alt17 = dfa17.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(17); }
		switch (alt17)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:10: ARR
			{
			DebugLocation(1, 10);
			mARR(); if (state.failed) return;

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:14: ITEM
			{
			DebugLocation(1, 14);
			mITEM(); if (state.failed) return;

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:19: NULL
			{
			DebugLocation(1, 19);
			mNULL(); if (state.failed) return;

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:24: LP
			{
			DebugLocation(1, 24);
			mLP(); if (state.failed) return;

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:27: RP
			{
			DebugLocation(1, 27);
			mRP(); if (state.failed) return;

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:30: LSB
			{
			DebugLocation(1, 30);
			mLSB(); if (state.failed) return;

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:34: RSB
			{
			DebugLocation(1, 34);
			mRSB(); if (state.failed) return;

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:38: STAR
			{
			DebugLocation(1, 38);
			mSTAR(); if (state.failed) return;

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:43: DOT
			{
			DebugLocation(1, 43);
			mDOT(); if (state.failed) return;

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:47: EQ
			{
			DebugLocation(1, 47);
			mEQ(); if (state.failed) return;

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:50: NEQ
			{
			DebugLocation(1, 50);
			mNEQ(); if (state.failed) return;

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:54: OR
			{
			DebugLocation(1, 54);
			mOR(); if (state.failed) return;

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:57: OROR
			{
			DebugLocation(1, 57);
			mOROR(); if (state.failed) return;

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:62: AND
			{
			DebugLocation(1, 62);
			mAND(); if (state.failed) return;

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:66: HASH
			{
			DebugLocation(1, 66);
			mHASH(); if (state.failed) return;

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:71: Q
			{
			DebugLocation(1, 71);
			mQ(); if (state.failed) return;

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:73: E
			{
			DebugLocation(1, 73);
			mE(); if (state.failed) return;

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:75: S
			{
			DebugLocation(1, 75);
			mS(); if (state.failed) return;

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:77: STRING_LITERAL
			{
			DebugLocation(1, 77);
			mSTRING_LITERAL(); if (state.failed) return;

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:92: REGEXP_LITERAL
			{
			DebugLocation(1, 92);
			mREGEXP_LITERAL(); if (state.failed) return;

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:107: NUMBER
			{
			DebugLocation(1, 107);
			mNUMBER(); if (state.failed) return;

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:114: ITEM_INDEX
			{
			DebugLocation(1, 114);
			mITEM_INDEX(); if (state.failed) return;

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:125: BOOLEAN
			{
			DebugLocation(1, 125);
			mBOOLEAN(); if (state.failed) return;

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:133: SPACE
			{
			DebugLocation(1, 133);
			mSPACE(); if (state.failed) return;

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:139: EOL
			{
			DebugLocation(1, 139);
			mEOL(); if (state.failed) return;

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:143: COMMENT
			{
			DebugLocation(1, 143);
			mCOMMENT(); if (state.failed) return;

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:151: ALL
			{
			DebugLocation(1, 151);
			mALL(); if (state.failed) return;

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:1:155: DUMMY
			{
			DebugLocation(1, 155);
			mDUMMY(); if (state.failed) return;

			}
			break;

		}

	}

	partial void Enter_synpred1_LambdastyleTry_fragment();
	partial void Leave_synpred1_LambdastyleTry_fragment();

	// $ANTLR start synpred1_LambdastyleTry
	public void synpred1_LambdastyleTry_fragment()
	{
		Enter_synpred1_LambdastyleTry_fragment();
		EnterRule("synpred1_LambdastyleTry_fragment", 34);
		TraceIn("synpred1_LambdastyleTry_fragment", 34);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:78:17: ( STRING_LITERAL_F )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:78:18: STRING_LITERAL_F
			{
			DebugLocation(78, 18);
			mSTRING_LITERAL_F(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_LambdastyleTry_fragment", 34);
			LeaveRule("synpred1_LambdastyleTry_fragment", 34);
			Leave_synpred1_LambdastyleTry_fragment();
		}
	}
	// $ANTLR end synpred1_LambdastyleTry

	partial void Enter_synpred2_LambdastyleTry_fragment();
	partial void Leave_synpred2_LambdastyleTry_fragment();

	// $ANTLR start synpred2_LambdastyleTry
	public void synpred2_LambdastyleTry_fragment()
	{
		Enter_synpred2_LambdastyleTry_fragment();
		EnterRule("synpred2_LambdastyleTry_fragment", 35);
		TraceIn("synpred2_LambdastyleTry_fragment", 35);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:80:17: ( REGEXP_LITERAL_F )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:80:18: REGEXP_LITERAL_F
			{
			DebugLocation(80, 18);
			mREGEXP_LITERAL_F(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_LambdastyleTry_fragment", 35);
			LeaveRule("synpred2_LambdastyleTry_fragment", 35);
			Leave_synpred2_LambdastyleTry_fragment();
		}
	}
	// $ANTLR end synpred2_LambdastyleTry

	partial void Enter_synpred3_LambdastyleTry_fragment();
	partial void Leave_synpred3_LambdastyleTry_fragment();

	// $ANTLR start synpred3_LambdastyleTry
	public void synpred3_LambdastyleTry_fragment()
	{
		Enter_synpred3_LambdastyleTry_fragment();
		EnterRule("synpred3_LambdastyleTry_fragment", 36);
		TraceIn("synpred3_LambdastyleTry_fragment", 36);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:83:13: ( ITEM_INDEX_F )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:83:14: ITEM_INDEX_F
			{
			DebugLocation(83, 14);
			mITEM_INDEX_F(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred3_LambdastyleTry_fragment", 36);
			LeaveRule("synpred3_LambdastyleTry_fragment", 36);
			Leave_synpred3_LambdastyleTry_fragment();
		}
	}
	// $ANTLR end synpred3_LambdastyleTry

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA10 dfa10;
	DFA17 dfa17;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa10 = new DFA10(this);
		dfa17 = new DFA17(this, SpecialStateTransition17);
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x5\xFFFF\x1\xA\x1\xC\x1\xE\x1\x10\x6\xFFFF\x1\x12\x3\xFFFF";
		private const string DFA10_eofS =
			"\x13\xFFFF";
		private const string DFA10_minS =
			"\x1\x66\x1\x75\x1\x74\x1\x72\x1\x61\x1\x6C\x1\x65\x1\x75\x1\x6C\x6\xFFFF"+
			"\x1\x73\x3\xFFFF";
		private const string DFA10_maxS =
			"\x1\x74\x1\x75\x1\x74\x1\x72\x1\x61\x1\x6C\x1\x65\x1\x75\x1\x6C\x6\xFFFF"+
			"\x1\x73\x3\xFFFF";
		private const string DFA10_acceptS =
			"\x9\xFFFF\x1\x2\x1\x1\x1\x4\x1\x3\x1\x6\x1\x5\x1\xFFFF\x1\x7\x1\x9\x1"+
			"\x8";
		private const string DFA10_specialS =
			"\x13\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x1\x4\x2\xFFFF\x1\x2\x4\xFFFF\x1\x1\x5\xFFFF\x1\x3",
				"\x1\x5",
				"\x1\x6",
				"\x1\x7",
				"\x1\x8",
				"\x1\x9",
				"\x1\xB",
				"\x1\xD",
				"\x1\xF",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x11",
				"",
				"",
				""
			};

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "90:1: DUMMY : ( 'nu' | 'nul' | 'it' | 'ite' | 'tr' | 'tru' | 'fa' | 'fal' | 'fals' );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA17 : DFA
	{
		private const string DFA17_eotS =
			"\x1\xFFFF\x3\x17\x7\xFFFF\x1\x23\x1\x25\x2\xFFFF\x1\x28\x1\x2B\x1\xFFFF"+
			"\x2\x17\x5\xFFFF\x2\x33\xF\xFFFF\x1\x2C\x3\xFFFF\x2\x33\x2\xFFFF\x1\x33"+
			"\x1\xFFFF\x1\x33\x1\xFFFF\x2\x33\x1\x3C\x2\xFFFF\x1\x33\x2\xFFFF";
		private const string DFA17_eofS =
			"\x3E\xFFFF";
		private const string DFA17_minS =
			"\x1\x0\x1\x3E\x1\x74\x1\x75\x7\xFFFF\x1\x3D\x1\x7C\x2\xFFFF\x2\x0\x1"+
			"\xFFFF\x1\x72\x1\x61\x5\xFFFF\x1\x65\x1\x6C\xF\xFFFF\x1\x0\x3\xFFFF\x1"+
			"\x75\x1\x6C\x2\xFFFF\x1\x6D\x1\xFFFF\x1\x6C\x1\xFFFF\x1\x65\x1\x73\x1"+
			"\x9\x2\xFFFF\x1\x65\x2\xFFFF";
		private const string DFA17_maxS =
			"\x1\xFFFF\x1\x3E\x1\x74\x1\x75\x7\xFFFF\x1\x3D\x1\x7C\x2\xFFFF\x2\xFFFF"+
			"\x1\xFFFF\x1\x72\x1\x61\x5\xFFFF\x1\x65\x1\x6C\xF\xFFFF\x1\xFFFF\x3\xFFFF"+
			"\x1\x75\x1\x6C\x2\xFFFF\x1\x6D\x1\xFFFF\x1\x6C\x1\xFFFF\x1\x65\x1\x73"+
			"\x1\x5B\x2\xFFFF\x1\x65\x2\xFFFF";
		private const string DFA17_acceptS =
			"\x4\xFFFF\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1\xA\x2\xFFFF\x1\xE\x1"+
			"\xF\x2\xFFFF\x1\x15\x2\xFFFF\x1\x18\x2\x19\x1\x1B\x1\x1\x2\xFFFF\x1\x4"+
			"\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1\xA\x1\xB\x1\x11\x1\xD\x1\xC\x1\xE\x1"+
			"\xF\x1\x10\x1\x13\x1\xFFFF\x1\x12\x1\x14\x1\x15\x2\xFFFF\x1\x18\x1\x19"+
			"\x1\xFFFF\x1\x1C\x1\xFFFF\x1\x1A\x3\xFFFF\x1\x3\x1\x17\x1\xFFFF\x1\x2"+
			"\x1\x16";
		private const string DFA17_specialS =
			"\x1\x0\xE\xFFFF\x1\x2\x1\x3\x19\xFFFF\x1\x1\x13\xFFFF}>";
		private static readonly string[] DFA17_transitionS =
			{
				"\x9\x17\x1\x14\x1\x16\x2\x17\x1\x15\x12\x17\x1\x14\x1\xB\x1\xF\x1\xE"+
				"\x2\x17\x1\xD\x1\x17\x1\x4\x1\x5\x1\x8\x2\x17\x1\x1\x1\x9\x1\x10\xA"+
				"\x11\x3\x17\x1\xA\x1D\x17\x1\x6\x1\x17\x1\x7\x8\x17\x1\x13\x2\x17\x1"+
				"\x2\x4\x17\x1\x3\x5\x17\x1\x12\x7\x17\x1\xC\xFF83\x17",
				"\x1\x18",
				"\x1\x19",
				"\x1\x1A",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x22",
				"\x1\x24",
				"",
				"",
				"\xA\x29\x1\xFFFF\x2\x29\x1\xFFFF\xFFF2\x29",
				"\xA\x2C\x1\xFFFF\x2\x2C\x1\xFFFF\x21\x2C\x1\x2A\xFFD0\x2C",
				"",
				"\x1\x2E",
				"\x1\x2F",
				"",
				"",
				"",
				"",
				"",
				"\x1\x32",
				"\x1\x34",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\xA\x35\x1\xFFFF\x2\x35\x1\xFFFF\xFFF2\x35",
				"",
				"",
				"",
				"\x1\x36",
				"\x1\x37",
				"",
				"",
				"\x1\x38",
				"",
				"\x1\x39",
				"",
				"\x1\x3A",
				"\x1\x3B",
				"\x1\x3D\x16\xFFFF\x1\x3D\x3A\xFFFF\x1\x3D",
				"",
				"",
				"\x1\x3A",
				"",
				""
			};

		private static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
		private static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
		private static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
		private static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
		private static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
		private static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
		private static readonly short[][] DFA17_transition;

		static DFA17()
		{
			int numStates = DFA17_transitionS.Length;
			DFA17_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA17_transition[i] = DFA.UnpackEncodedString(DFA17_transitionS[i]);
			}
		}

		public DFA17( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 17;
			this.eot = DFA17_eot;
			this.eof = DFA17_eof;
			this.min = DFA17_min;
			this.max = DFA17_max;
			this.accept = DFA17_accept;
			this.special = DFA17_special;
			this.transition = DFA17_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( ARR | ITEM | NULL | LP | RP | LSB | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | BOOLEAN | SPACE | EOL | COMMENT | ALL | DUMMY );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition17(DFA dfa, int s, IIntStream _input)
	{
		IIntStream input = _input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA17_0 = input.LA(1);

				s = -1;
				if ( (LA17_0=='-') ) {s = 1;}

				else if ( (LA17_0=='i') ) {s = 2;}

				else if ( (LA17_0=='n') ) {s = 3;}

				else if ( (LA17_0=='(') ) {s = 4;}

				else if ( (LA17_0==')') ) {s = 5;}

				else if ( (LA17_0=='[') ) {s = 6;}

				else if ( (LA17_0==']') ) {s = 7;}

				else if ( (LA17_0=='*') ) {s = 8;}

				else if ( (LA17_0=='.') ) {s = 9;}

				else if ( (LA17_0=='=') ) {s = 10;}

				else if ( (LA17_0=='!') ) {s = 11;}

				else if ( (LA17_0=='|') ) {s = 12;}

				else if ( (LA17_0=='&') ) {s = 13;}

				else if ( (LA17_0=='#') ) {s = 14;}

				else if ( (LA17_0=='\"') ) {s = 15;}

				else if ( (LA17_0=='/') ) {s = 16;}

				else if ( ((LA17_0>='0' && LA17_0<='9')) ) {s = 17;}

				else if ( (LA17_0=='t') ) {s = 18;}

				else if ( (LA17_0=='f') ) {s = 19;}

				else if ( (LA17_0=='\t'||LA17_0==' ') ) {s = 20;}

				else if ( (LA17_0=='\r') ) {s = 21;}

				else if ( (LA17_0=='\n') ) {s = 22;}

				else if ( ((LA17_0>='\u0000' && LA17_0<='\b')||(LA17_0>='\u000B' && LA17_0<='\f')||(LA17_0>='\u000E' && LA17_0<='\u001F')||(LA17_0>='$' && LA17_0<='%')||LA17_0=='\''||(LA17_0>='+' && LA17_0<=',')||(LA17_0>=':' && LA17_0<='<')||(LA17_0>='>' && LA17_0<='Z')||LA17_0=='\\'||(LA17_0>='^' && LA17_0<='e')||(LA17_0>='g' && LA17_0<='h')||(LA17_0>='j' && LA17_0<='m')||(LA17_0>='o' && LA17_0<='s')||(LA17_0>='u' && LA17_0<='{')||(LA17_0>='}' && LA17_0<='\uFFFF')) ) {s = 23;}

				if ( s>=0 ) return s;
				break;
			case 1:
				int LA17_42 = input.LA(1);

				s = -1;
				if ( ((LA17_42>='\u0000' && LA17_42<='\t')||(LA17_42>='\u000B' && LA17_42<='\f')||(LA17_42>='\u000E' && LA17_42<='\uFFFF')) ) {s = 53;}

				else s = 44;

				if ( s>=0 ) return s;
				break;
			case 2:
				int LA17_15 = input.LA(1);

				s = -1;
				if ( ((LA17_15>='\u0000' && LA17_15<='\t')||(LA17_15>='\u000B' && LA17_15<='\f')||(LA17_15>='\u000E' && LA17_15<='\uFFFF')) ) {s = 41;}

				else s = 40;

				if ( s>=0 ) return s;
				break;
			case 3:
				int LA17_16 = input.LA(1);

				s = -1;
				if ( (LA17_16=='/') ) {s = 42;}

				else if ( ((LA17_16>='\u0000' && LA17_16<='\t')||(LA17_16>='\u000B' && LA17_16<='\f')||(LA17_16>='\u000E' && LA17_16<='.')||(LA17_16>='0' && LA17_16<='\uFFFF')) ) {s = 44;}

				else s = 43;

				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 17, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
 
	#endregion

}

} // namespace  LambdastylePrototype.Parser 
