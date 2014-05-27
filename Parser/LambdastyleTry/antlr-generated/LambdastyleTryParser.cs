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

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  LambdastylePrototype.Parser 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class LambdastyleTryParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "SENTENCE", "SUBJECT", "START", "LITERALISH_SEQUENCE", "EOL", "SPACE", "ARR", "STRING_LITERAL", "REGEXP_LITERAL", "STAR", "LP", "RP", "LSB", "RSB", "DOT", "E", "EQ", "NEQ", "OR", "OROR", "AND", "NUMBER", "BOOLEAN", "ITEM", "ITEM_INDEX", "NULL", "ALL", "Q", "S", "HASH", "DUMMY", "STRING_LITERAL_F", "REGEXP_LITERAL_F", "DIGIT", "ITEM_INDEX_F", "COMMENT"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, true, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public LambdastyleTryParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public LambdastyleTryParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return LambdastyleTryParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class style_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_style();
	partial void Leave_style();

	// $ANTLR start "style"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:8:8: public style : sentence ( EOL sentence )* EOF ;
	[GrammarRule("style")]
	public LambdastyleTryParser.style_return style()
	{
		Enter_style();
		EnterRule("style", 1);
		TraceIn("style", 1);
		LambdastyleTryParser.style_return retval = new LambdastyleTryParser.style_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOL2=null;
		IToken EOF4=null;
		LambdastyleTryParser.sentence_return sentence1 = default(LambdastyleTryParser.sentence_return);
		LambdastyleTryParser.sentence_return sentence3 = default(LambdastyleTryParser.sentence_return);

		object EOL2_tree=null;
		object EOF4_tree=null;

		try { DebugEnterRule(GrammarFileName, "style");
		DebugLocation(8, 43);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:8:13: ( sentence ( EOL sentence )* EOF )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:8:15: sentence ( EOL sentence )* EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(8, 15);
			PushFollow(Follow._sentence_in_style63);
			sentence1=sentence();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sentence1.Tree);
			DebugLocation(8, 24);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:8:24: ( EOL sentence )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==EOL))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:8:25: EOL sentence
					{
					DebugLocation(8, 28);
					EOL2=(IToken)Match(input,EOL,Follow._EOL_in_style66); if (state.failed) return retval;
					DebugLocation(8, 30);
					PushFollow(Follow._sentence_in_style69);
					sentence3=sentence();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sentence3.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(8, 41);
			EOF4=(IToken)Match(input,EOF,Follow._EOF_in_style73); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			EOF4_tree = (object)adaptor.Create(EOF4);
			adaptor.AddChild(root_0, EOF4_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("style", 1);
			LeaveRule("style", 1);
			Leave_style();
		}
		DebugLocation(8, 43);
		} finally { DebugExitRule(GrammarFileName, "style"); }
		return retval;

	}
	// $ANTLR end "style"

	public class sentence_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_sentence();
	partial void Leave_sentence();

	// $ANTLR start "sentence"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:10:1: sentence : ( ( alternative1 )=> alternative1 | ( alternative2 )=> alternative2 | ( alternative3 ( EOL | EOF ) )=> alternative3 );
	[GrammarRule("sentence")]
	private LambdastyleTryParser.sentence_return sentence()
	{
		Enter_sentence();
		EnterRule("sentence", 2);
		TraceIn("sentence", 2);
		LambdastyleTryParser.sentence_return retval = new LambdastyleTryParser.sentence_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		LambdastyleTryParser.alternative1_return alternative15 = default(LambdastyleTryParser.alternative1_return);
		LambdastyleTryParser.alternative2_return alternative26 = default(LambdastyleTryParser.alternative2_return);
		LambdastyleTryParser.alternative3_return alternative37 = default(LambdastyleTryParser.alternative3_return);


		try { DebugEnterRule(GrammarFileName, "sentence");
		DebugLocation(10, 1);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:11:2: ( ( alternative1 )=> alternative1 | ( alternative2 )=> alternative2 | ( alternative3 ( EOL | EOF ) )=> alternative3 )
			int alt2=3;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			try
			{
				alt2 = dfa2.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:11:4: ( alternative1 )=> alternative1
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(11, 32);
				PushFollow(Follow._alternative1_in_sentence99);
				alternative15=alternative1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, alternative15.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:12:4: ( alternative2 )=> alternative2
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(12, 32);
				PushFollow(Follow._alternative2_in_sentence121);
				alternative26=alternative2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, alternative26.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:13:4: ( alternative3 ( EOL | EOF ) )=> alternative3
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(13, 32);
				PushFollow(Follow._alternative3_in_sentence139);
				alternative37=alternative3();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, alternative37.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("sentence", 2);
			LeaveRule("sentence", 2);
			Leave_sentence();
		}
		DebugLocation(14, 1);
		} finally { DebugExitRule(GrammarFileName, "sentence"); }
		return retval;

	}
	// $ANTLR end "sentence"

	public class alternative1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_alternative1();
	partial void Leave_alternative1();

	// $ANTLR start "alternative1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:1: alternative1 : expression1 ( SPACE )* ARR ( SPACE (morespaces= SPACE )* )? right_f -> ^( SENTENCE expression1 ( $morespaces)? ( right_f )? ) ;
	[GrammarRule("alternative1")]
	private LambdastyleTryParser.alternative1_return alternative1()
	{
		Enter_alternative1();
		EnterRule("alternative1", 3);
		TraceIn("alternative1", 3);
		LambdastyleTryParser.alternative1_return retval = new LambdastyleTryParser.alternative1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken morespaces=null;
		IToken SPACE9=null;
		IToken ARR10=null;
		IToken SPACE11=null;
		LambdastyleTryParser.expression1_return expression18 = default(LambdastyleTryParser.expression1_return);
		LambdastyleTryParser.right_f_return right_f12 = default(LambdastyleTryParser.right_f_return);

		object morespaces_tree=null;
		object SPACE9_tree=null;
		object ARR10_tree=null;
		object SPACE11_tree=null;
		RewriteRuleITokenStream stream_SPACE=new RewriteRuleITokenStream(adaptor,"token SPACE");
		RewriteRuleITokenStream stream_ARR=new RewriteRuleITokenStream(adaptor,"token ARR");
		RewriteRuleSubtreeStream stream_right_f=new RewriteRuleSubtreeStream(adaptor,"rule right_f");
		RewriteRuleSubtreeStream stream_expression1=new RewriteRuleSubtreeStream(adaptor,"rule expression1");
		try { DebugEnterRule(GrammarFileName, "alternative1");
		DebugLocation(16, 120);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:13: ( expression1 ( SPACE )* ARR ( SPACE (morespaces= SPACE )* )? right_f -> ^( SENTENCE expression1 ( $morespaces)? ( right_f )? ) )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:15: expression1 ( SPACE )* ARR ( SPACE (morespaces= SPACE )* )? right_f
			{
			DebugLocation(16, 15);
			PushFollow(Follow._expression1_in_alternative1150);
			expression18=expression1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression1.Add(expression18.Tree);
			DebugLocation(16, 27);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:27: ( SPACE )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0==SPACE))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:27: SPACE
					{
					DebugLocation(16, 27);
					SPACE9=(IToken)Match(input,SPACE,Follow._SPACE_in_alternative1152); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_SPACE.Add(SPACE9);


					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(16, 34);
			ARR10=(IToken)Match(input,ARR,Follow._ARR_in_alternative1155); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ARR.Add(ARR10);

			DebugLocation(16, 38);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:38: ( SPACE (morespaces= SPACE )* )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==SPACE))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:39: SPACE (morespaces= SPACE )*
				{
				DebugLocation(16, 39);
				SPACE11=(IToken)Match(input,SPACE,Follow._SPACE_in_alternative1158); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SPACE.Add(SPACE11);

				DebugLocation(16, 55);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:55: (morespaces= SPACE )*
				try { DebugEnterSubRule(4);
				while (true)
				{
					int alt4=2;
					try { DebugEnterDecision(4, decisionCanBacktrack[4]);
					int LA4_0 = input.LA(1);

					if ((LA4_0==SPACE))
					{
						alt4=1;
					}


					} finally { DebugExitDecision(4); }
					switch ( alt4 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:55: morespaces= SPACE
						{
						DebugLocation(16, 55);
						morespaces=(IToken)Match(input,SPACE,Follow._SPACE_in_alternative1162); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_SPACE.Add(morespaces);


						}
						break;

					default:
						goto loop4;
					}
				}

				loop4:
					;

				} finally { DebugExitSubRule(4); }


				}
				break;

			}
			} finally { DebugExitSubRule(5); }

			DebugLocation(16, 65);
			PushFollow(Follow._right_f_in_alternative1167);
			right_f12=right_f();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_right_f.Add(right_f12.Tree);


			{
			// AST REWRITE
			// elements: right_f, expression1, morespaces
			// token labels: morespaces
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_morespaces=new RewriteRuleITokenStream(adaptor,"token morespaces",morespaces);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 16:73: -> ^( SENTENCE expression1 ( $morespaces)? ( right_f )? )
			{
				DebugLocation(16, 76);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:76: ^( SENTENCE expression1 ( $morespaces)? ( right_f )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(16, 78);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SENTENCE, "SENTENCE"), root_1);

				DebugLocation(16, 87);
				adaptor.AddChild(root_1, stream_expression1.NextTree());
				DebugLocation(16, 99);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:99: ( $morespaces)?
				if ( stream_morespaces.HasNext )
				{
					DebugLocation(16, 99);
					adaptor.AddChild(root_1, stream_morespaces.NextNode());

				}
				stream_morespaces.Reset();
				DebugLocation(16, 112);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:16:112: ( right_f )?
				if ( stream_right_f.HasNext )
				{
					DebugLocation(16, 112);
					adaptor.AddChild(root_1, stream_right_f.NextTree());

				}
				stream_right_f.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("alternative1", 3);
			LeaveRule("alternative1", 3);
			Leave_alternative1();
		}
		DebugLocation(16, 120);
		} finally { DebugExitRule(GrammarFileName, "alternative1"); }
		return retval;

	}
	// $ANTLR end "alternative1"

	public class alternative2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_alternative2();
	partial void Leave_alternative2();

	// $ANTLR start "alternative2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:1: alternative2 : left_f expression2 ( SPACE )* ARR ( SPACE (morespaces= SPACE )* )? right_f -> ^( SENTENCE ( left_f )? expression2 ( $morespaces)? ( right_f )? ) ;
	[GrammarRule("alternative2")]
	private LambdastyleTryParser.alternative2_return alternative2()
	{
		Enter_alternative2();
		EnterRule("alternative2", 4);
		TraceIn("alternative2", 4);
		LambdastyleTryParser.alternative2_return retval = new LambdastyleTryParser.alternative2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken morespaces=null;
		IToken SPACE15=null;
		IToken ARR16=null;
		IToken SPACE17=null;
		LambdastyleTryParser.left_f_return left_f13 = default(LambdastyleTryParser.left_f_return);
		LambdastyleTryParser.expression2_return expression214 = default(LambdastyleTryParser.expression2_return);
		LambdastyleTryParser.right_f_return right_f18 = default(LambdastyleTryParser.right_f_return);

		object morespaces_tree=null;
		object SPACE15_tree=null;
		object ARR16_tree=null;
		object SPACE17_tree=null;
		RewriteRuleITokenStream stream_SPACE=new RewriteRuleITokenStream(adaptor,"token SPACE");
		RewriteRuleITokenStream stream_ARR=new RewriteRuleITokenStream(adaptor,"token ARR");
		RewriteRuleSubtreeStream stream_right_f=new RewriteRuleSubtreeStream(adaptor,"rule right_f");
		RewriteRuleSubtreeStream stream_left_f=new RewriteRuleSubtreeStream(adaptor,"rule left_f");
		RewriteRuleSubtreeStream stream_expression2=new RewriteRuleSubtreeStream(adaptor,"rule expression2");
		try { DebugEnterRule(GrammarFileName, "alternative2");
		DebugLocation(18, 135);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:13: ( left_f expression2 ( SPACE )* ARR ( SPACE (morespaces= SPACE )* )? right_f -> ^( SENTENCE ( left_f )? expression2 ( $morespaces)? ( right_f )? ) )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:15: left_f expression2 ( SPACE )* ARR ( SPACE (morespaces= SPACE )* )? right_f
			{
			DebugLocation(18, 15);
			PushFollow(Follow._left_f_in_alternative2189);
			left_f13=left_f();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_left_f.Add(left_f13.Tree);
			DebugLocation(18, 22);
			PushFollow(Follow._expression2_in_alternative2191);
			expression214=expression2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression2.Add(expression214.Tree);
			DebugLocation(18, 34);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:34: ( SPACE )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==SPACE))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:34: SPACE
					{
					DebugLocation(18, 34);
					SPACE15=(IToken)Match(input,SPACE,Follow._SPACE_in_alternative2193); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_SPACE.Add(SPACE15);


					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(18, 41);
			ARR16=(IToken)Match(input,ARR,Follow._ARR_in_alternative2196); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ARR.Add(ARR16);

			DebugLocation(18, 45);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:45: ( SPACE (morespaces= SPACE )* )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==SPACE))
			{
				alt8=1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:46: SPACE (morespaces= SPACE )*
				{
				DebugLocation(18, 46);
				SPACE17=(IToken)Match(input,SPACE,Follow._SPACE_in_alternative2199); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SPACE.Add(SPACE17);

				DebugLocation(18, 62);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:62: (morespaces= SPACE )*
				try { DebugEnterSubRule(7);
				while (true)
				{
					int alt7=2;
					try { DebugEnterDecision(7, decisionCanBacktrack[7]);
					int LA7_0 = input.LA(1);

					if ((LA7_0==SPACE))
					{
						alt7=1;
					}


					} finally { DebugExitDecision(7); }
					switch ( alt7 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:62: morespaces= SPACE
						{
						DebugLocation(18, 62);
						morespaces=(IToken)Match(input,SPACE,Follow._SPACE_in_alternative2203); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_SPACE.Add(morespaces);


						}
						break;

					default:
						goto loop7;
					}
				}

				loop7:
					;

				} finally { DebugExitSubRule(7); }


				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(18, 72);
			PushFollow(Follow._right_f_in_alternative2208);
			right_f18=right_f();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_right_f.Add(right_f18.Tree);


			{
			// AST REWRITE
			// elements: expression2, left_f, right_f, morespaces
			// token labels: morespaces
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_morespaces=new RewriteRuleITokenStream(adaptor,"token morespaces",morespaces);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 18:80: -> ^( SENTENCE ( left_f )? expression2 ( $morespaces)? ( right_f )? )
			{
				DebugLocation(18, 83);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:83: ^( SENTENCE ( left_f )? expression2 ( $morespaces)? ( right_f )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(18, 85);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SENTENCE, "SENTENCE"), root_1);

				DebugLocation(18, 94);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:94: ( left_f )?
				if ( stream_left_f.HasNext )
				{
					DebugLocation(18, 94);
					adaptor.AddChild(root_1, stream_left_f.NextTree());

				}
				stream_left_f.Reset();
				DebugLocation(18, 102);
				adaptor.AddChild(root_1, stream_expression2.NextTree());
				DebugLocation(18, 114);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:114: ( $morespaces)?
				if ( stream_morespaces.HasNext )
				{
					DebugLocation(18, 114);
					adaptor.AddChild(root_1, stream_morespaces.NextNode());

				}
				stream_morespaces.Reset();
				DebugLocation(18, 127);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:18:127: ( right_f )?
				if ( stream_right_f.HasNext )
				{
					DebugLocation(18, 127);
					adaptor.AddChild(root_1, stream_right_f.NextTree());

				}
				stream_right_f.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("alternative2", 4);
			LeaveRule("alternative2", 4);
			Leave_alternative2();
		}
		DebugLocation(18, 135);
		} finally { DebugExitRule(GrammarFileName, "alternative2"); }
		return retval;

	}
	// $ANTLR end "alternative2"

	public class alternative3_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_alternative3();
	partial void Leave_alternative3();

	// $ANTLR start "alternative3"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:20:1: alternative3 : alternative3_f -> ^( SENTENCE ( alternative3_f )? ) ;
	[GrammarRule("alternative3")]
	private LambdastyleTryParser.alternative3_return alternative3()
	{
		Enter_alternative3();
		EnterRule("alternative3", 5);
		TraceIn("alternative3", 5);
		LambdastyleTryParser.alternative3_return retval = new LambdastyleTryParser.alternative3_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		LambdastyleTryParser.alternative3_f_return alternative3_f19 = default(LambdastyleTryParser.alternative3_f_return);

		RewriteRuleSubtreeStream stream_alternative3_f=new RewriteRuleSubtreeStream(adaptor,"rule alternative3_f");
		try { DebugEnterRule(GrammarFileName, "alternative3");
		DebugLocation(20, 59);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:20:13: ( alternative3_f -> ^( SENTENCE ( alternative3_f )? ) )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:20:15: alternative3_f
			{
			DebugLocation(20, 15);
			PushFollow(Follow._alternative3_f_in_alternative3233);
			alternative3_f19=alternative3_f();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_alternative3_f.Add(alternative3_f19.Tree);


			{
			// AST REWRITE
			// elements: alternative3_f
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 20:30: -> ^( SENTENCE ( alternative3_f )? )
			{
				DebugLocation(20, 33);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:20:33: ^( SENTENCE ( alternative3_f )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(20, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SENTENCE, "SENTENCE"), root_1);

				DebugLocation(20, 44);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:20:44: ( alternative3_f )?
				if ( stream_alternative3_f.HasNext )
				{
					DebugLocation(20, 44);
					adaptor.AddChild(root_1, stream_alternative3_f.NextTree());

				}
				stream_alternative3_f.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("alternative3", 5);
			LeaveRule("alternative3", 5);
			Leave_alternative3();
		}
		DebugLocation(20, 59);
		} finally { DebugExitRule(GrammarFileName, "alternative3"); }
		return retval;

	}
	// $ANTLR end "alternative3"

	public class term1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term1();
	partial void Leave_term1();

	// $ANTLR start "term1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:22:1: term1 : ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) | literalish_sequence1_f -> ^( LITERALISH_SEQUENCE literalish_sequence1_f ) | term_f | LP ( SPACE )* logical1 ( SPACE )* RP | LSB ( SPACE )* logical1 ( SPACE )* RSB );
	[GrammarRule("term1")]
	private LambdastyleTryParser.term1_return term1()
	{
		Enter_term1();
		EnterRule("term1", 6);
		TraceIn("term1", 6);
		LambdastyleTryParser.term1_return retval = new LambdastyleTryParser.term1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set20=null;
		IToken LP23=null;
		IToken SPACE24=null;
		IToken SPACE26=null;
		IToken RP27=null;
		IToken LSB28=null;
		IToken SPACE29=null;
		IToken SPACE31=null;
		IToken RSB32=null;
		LambdastyleTryParser.literalish_sequence1_f_return literalish_sequence1_f21 = default(LambdastyleTryParser.literalish_sequence1_f_return);
		LambdastyleTryParser.term_f_return term_f22 = default(LambdastyleTryParser.term_f_return);
		LambdastyleTryParser.logical1_return logical125 = default(LambdastyleTryParser.logical1_return);
		LambdastyleTryParser.logical1_return logical130 = default(LambdastyleTryParser.logical1_return);

		object set20_tree=null;
		object LP23_tree=null;
		object SPACE24_tree=null;
		object SPACE26_tree=null;
		object RP27_tree=null;
		object LSB28_tree=null;
		object SPACE29_tree=null;
		object SPACE31_tree=null;
		object RSB32_tree=null;
		RewriteRuleSubtreeStream stream_literalish_sequence1_f=new RewriteRuleSubtreeStream(adaptor,"rule literalish_sequence1_f");
		try { DebugEnterRule(GrammarFileName, "term1");
		DebugLocation(22, 1);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:23:2: ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) | literalish_sequence1_f -> ^( LITERALISH_SEQUENCE literalish_sequence1_f ) | term_f | LP ( SPACE )* logical1 ( SPACE )* RP | LSB ( SPACE )* logical1 ( SPACE )* RSB )
			int alt13=5;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			try
			{
				alt13 = dfa13.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:23:4: ( STRING_LITERAL | REGEXP_LITERAL | STAR )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(23, 4);
				set20=(IToken)input.LT(1);
				if ((input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set20));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:24:4: literalish_sequence1_f
				{
				DebugLocation(24, 4);
				PushFollow(Follow._literalish_sequence1_f_in_term1262);
				literalish_sequence1_f21=literalish_sequence1_f();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_literalish_sequence1_f.Add(literalish_sequence1_f21.Tree);


				{
				// AST REWRITE
				// elements: literalish_sequence1_f
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 24:27: -> ^( LITERALISH_SEQUENCE literalish_sequence1_f )
				{
					DebugLocation(24, 30);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:24:30: ^( LITERALISH_SEQUENCE literalish_sequence1_f )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(24, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LITERALISH_SEQUENCE, "LITERALISH_SEQUENCE"), root_1);

					DebugLocation(24, 52);
					adaptor.AddChild(root_1, stream_literalish_sequence1_f.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:25:4: term_f
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(25, 4);
				PushFollow(Follow._term_f_in_term1275);
				term_f22=term_f();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term_f22.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:26:4: LP ( SPACE )* logical1 ( SPACE )* RP
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(26, 6);
				LP23=(IToken)Match(input,LP,Follow._LP_in_term1280); if (state.failed) return retval;
				DebugLocation(26, 13);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:26:13: ( SPACE )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==SPACE))
					{
						alt9=1;
					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:26:13: SPACE
						{
						DebugLocation(26, 13);
						SPACE24=(IToken)Match(input,SPACE,Follow._SPACE_in_term1283); if (state.failed) return retval;

						}
						break;

					default:
						goto loop9;
					}
				}

				loop9:
					;

				} finally { DebugExitSubRule(9); }

				DebugLocation(26, 16);
				PushFollow(Follow._logical1_in_term1287);
				logical125=logical1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logical125.Tree);
				DebugLocation(26, 30);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:26:30: ( SPACE )*
				try { DebugEnterSubRule(10);
				while (true)
				{
					int alt10=2;
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0==SPACE))
					{
						alt10=1;
					}


					} finally { DebugExitDecision(10); }
					switch ( alt10 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:26:30: SPACE
						{
						DebugLocation(26, 30);
						SPACE26=(IToken)Match(input,SPACE,Follow._SPACE_in_term1289); if (state.failed) return retval;

						}
						break;

					default:
						goto loop10;
					}
				}

				loop10:
					;

				} finally { DebugExitSubRule(10); }

				DebugLocation(26, 35);
				RP27=(IToken)Match(input,RP,Follow._RP_in_term1293); if (state.failed) return retval;

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:27:4: LSB ( SPACE )* logical1 ( SPACE )* RSB
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(27, 7);
				LSB28=(IToken)Match(input,LSB,Follow._LSB_in_term1299); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				LSB28_tree = (object)adaptor.Create(LSB28);
				root_0 = (object)adaptor.BecomeRoot(LSB28_tree, root_0);
				}
				DebugLocation(27, 14);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:27:14: ( SPACE )*
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==SPACE))
					{
						alt11=1;
					}


					} finally { DebugExitDecision(11); }
					switch ( alt11 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:27:14: SPACE
						{
						DebugLocation(27, 14);
						SPACE29=(IToken)Match(input,SPACE,Follow._SPACE_in_term1302); if (state.failed) return retval;

						}
						break;

					default:
						goto loop11;
					}
				}

				loop11:
					;

				} finally { DebugExitSubRule(11); }

				DebugLocation(27, 17);
				PushFollow(Follow._logical1_in_term1306);
				logical130=logical1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logical130.Tree);
				DebugLocation(27, 31);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:27:31: ( SPACE )*
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=2;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==SPACE))
					{
						alt12=1;
					}


					} finally { DebugExitDecision(12); }
					switch ( alt12 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:27:31: SPACE
						{
						DebugLocation(27, 31);
						SPACE31=(IToken)Match(input,SPACE,Follow._SPACE_in_term1308); if (state.failed) return retval;

						}
						break;

					default:
						goto loop12;
					}
				}

				loop12:
					;

				} finally { DebugExitSubRule(12); }

				DebugLocation(27, 37);
				RSB32=(IToken)Match(input,RSB,Follow._RSB_in_term1312); if (state.failed) return retval;

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term1", 6);
			LeaveRule("term1", 6);
			Leave_term1();
		}
		DebugLocation(28, 1);
		} finally { DebugExitRule(GrammarFileName, "term1"); }
		return retval;

	}
	// $ANTLR end "term1"

	public class term2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term2();
	partial void Leave_term2();

	// $ANTLR start "term2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:29:1: term2 : ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) | literalish_sequence2_f -> ^( LITERALISH_SEQUENCE literalish_sequence2_f ) | term_f | LP logical1 RP | LSB logical1 RSB );
	[GrammarRule("term2")]
	private LambdastyleTryParser.term2_return term2()
	{
		Enter_term2();
		EnterRule("term2", 7);
		TraceIn("term2", 7);
		LambdastyleTryParser.term2_return retval = new LambdastyleTryParser.term2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set33=null;
		IToken LP36=null;
		IToken RP38=null;
		IToken LSB39=null;
		IToken RSB41=null;
		LambdastyleTryParser.literalish_sequence2_f_return literalish_sequence2_f34 = default(LambdastyleTryParser.literalish_sequence2_f_return);
		LambdastyleTryParser.term_f_return term_f35 = default(LambdastyleTryParser.term_f_return);
		LambdastyleTryParser.logical1_return logical137 = default(LambdastyleTryParser.logical1_return);
		LambdastyleTryParser.logical1_return logical140 = default(LambdastyleTryParser.logical1_return);

		object set33_tree=null;
		object LP36_tree=null;
		object RP38_tree=null;
		object LSB39_tree=null;
		object RSB41_tree=null;
		RewriteRuleSubtreeStream stream_literalish_sequence2_f=new RewriteRuleSubtreeStream(adaptor,"rule literalish_sequence2_f");
		try { DebugEnterRule(GrammarFileName, "term2");
		DebugLocation(29, 1);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:30:2: ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) | literalish_sequence2_f -> ^( LITERALISH_SEQUENCE literalish_sequence2_f ) | term_f | LP logical1 RP | LSB logical1 RSB )
			int alt14=5;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			switch (input.LA(1))
			{
			case STRING_LITERAL:
			case REGEXP_LITERAL:
			case STAR:
				{
				int LA14_1 = input.LA(2);

				if (((LA14_1>=SPACE && LA14_1<=ARR)||LA14_1==DOT||(LA14_1>=EQ && LA14_1<=AND)))
				{
					alt14=1;
				}
				else if (((LA14_1>=STRING_LITERAL && LA14_1<=STAR)))
				{
					alt14=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case NUMBER:
			case BOOLEAN:
			case ITEM:
			case ITEM_INDEX:
			case NULL:
				{
				alt14=3;
				}
				break;
			case LP:
				{
				alt14=4;
				}
				break;
			case LSB:
				{
				alt14=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:30:4: ( STRING_LITERAL | REGEXP_LITERAL | STAR )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(30, 4);
				set33=(IToken)input.LT(1);
				if ((input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set33));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:31:4: literalish_sequence2_f
				{
				DebugLocation(31, 4);
				PushFollow(Follow._literalish_sequence2_f_in_term2334);
				literalish_sequence2_f34=literalish_sequence2_f();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_literalish_sequence2_f.Add(literalish_sequence2_f34.Tree);


				{
				// AST REWRITE
				// elements: literalish_sequence2_f
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 31:27: -> ^( LITERALISH_SEQUENCE literalish_sequence2_f )
				{
					DebugLocation(31, 30);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:31:30: ^( LITERALISH_SEQUENCE literalish_sequence2_f )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(31, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LITERALISH_SEQUENCE, "LITERALISH_SEQUENCE"), root_1);

					DebugLocation(31, 52);
					adaptor.AddChild(root_1, stream_literalish_sequence2_f.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:32:4: term_f
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(32, 4);
				PushFollow(Follow._term_f_in_term2347);
				term_f35=term_f();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term_f35.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:33:4: LP logical1 RP
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(33, 6);
				LP36=(IToken)Match(input,LP,Follow._LP_in_term2352); if (state.failed) return retval;
				DebugLocation(33, 8);
				PushFollow(Follow._logical1_in_term2355);
				logical137=logical1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logical137.Tree);
				DebugLocation(33, 19);
				RP38=(IToken)Match(input,RP,Follow._RP_in_term2357); if (state.failed) return retval;

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:34:4: LSB logical1 RSB
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(34, 7);
				LSB39=(IToken)Match(input,LSB,Follow._LSB_in_term2363); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				LSB39_tree = (object)adaptor.Create(LSB39);
				root_0 = (object)adaptor.BecomeRoot(LSB39_tree, root_0);
				}
				DebugLocation(34, 9);
				PushFollow(Follow._logical1_in_term2366);
				logical140=logical1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logical140.Tree);
				DebugLocation(34, 21);
				RSB41=(IToken)Match(input,RSB,Follow._RSB_in_term2368); if (state.failed) return retval;

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term2", 7);
			LeaveRule("term2", 7);
			Leave_term2();
		}
		DebugLocation(35, 1);
		} finally { DebugExitRule(GrammarFileName, "term2"); }
		return retval;

	}
	// $ANTLR end "term2"

	public class path1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_path1();
	partial void Leave_path1();

	// $ANTLR start "path1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:36:1: path1 : ( term1 ( ( SPACE )* DOT ( SPACE )* term1 ( ( SPACE )* DOT ( SPACE )* term1 )* )? | DOT term1 ( ( SPACE )* DOT ( SPACE )* term1 )* -> ^( DOT START ( term1 )+ ) );
	[GrammarRule("path1")]
	private LambdastyleTryParser.path1_return path1()
	{
		Enter_path1();
		EnterRule("path1", 8);
		TraceIn("path1", 8);
		LambdastyleTryParser.path1_return retval = new LambdastyleTryParser.path1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken SPACE43=null;
		IToken DOT44=null;
		IToken SPACE45=null;
		IToken SPACE47=null;
		IToken DOT48=null;
		IToken SPACE49=null;
		IToken DOT51=null;
		IToken SPACE53=null;
		IToken DOT54=null;
		IToken SPACE55=null;
		LambdastyleTryParser.term1_return term142 = default(LambdastyleTryParser.term1_return);
		LambdastyleTryParser.term1_return term146 = default(LambdastyleTryParser.term1_return);
		LambdastyleTryParser.term1_return term150 = default(LambdastyleTryParser.term1_return);
		LambdastyleTryParser.term1_return term152 = default(LambdastyleTryParser.term1_return);
		LambdastyleTryParser.term1_return term156 = default(LambdastyleTryParser.term1_return);

		object SPACE43_tree=null;
		object DOT44_tree=null;
		object SPACE45_tree=null;
		object SPACE47_tree=null;
		object DOT48_tree=null;
		object SPACE49_tree=null;
		object DOT51_tree=null;
		object SPACE53_tree=null;
		object DOT54_tree=null;
		object SPACE55_tree=null;
		RewriteRuleITokenStream stream_SPACE=new RewriteRuleITokenStream(adaptor,"token SPACE");
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");
		RewriteRuleSubtreeStream stream_term1=new RewriteRuleSubtreeStream(adaptor,"rule term1");
		try { DebugEnterRule(GrammarFileName, "path1");
		DebugLocation(36, 1);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:2: ( term1 ( ( SPACE )* DOT ( SPACE )* term1 ( ( SPACE )* DOT ( SPACE )* term1 )* )? | DOT term1 ( ( SPACE )* DOT ( SPACE )* term1 )* -> ^( DOT START ( term1 )+ ) )
			int alt24=2;
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if (((LA24_0>=STRING_LITERAL && LA24_0<=LP)||LA24_0==LSB||(LA24_0>=NUMBER && LA24_0<=NULL)))
			{
				alt24=1;
			}
			else if ((LA24_0==DOT))
			{
				alt24=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:4: term1 ( ( SPACE )* DOT ( SPACE )* term1 ( ( SPACE )* DOT ( SPACE )* term1 )* )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(37, 4);
				PushFollow(Follow._term1_in_path1379);
				term142=term1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term142.Tree);
				DebugLocation(37, 10);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:10: ( ( SPACE )* DOT ( SPACE )* term1 ( ( SPACE )* DOT ( SPACE )* term1 )* )?
				int alt20=2;
				try { DebugEnterSubRule(20);
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				try
				{
					alt20 = dfa20.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:11: ( SPACE )* DOT ( SPACE )* term1 ( ( SPACE )* DOT ( SPACE )* term1 )*
					{
					DebugLocation(37, 16);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:16: ( SPACE )*
					try { DebugEnterSubRule(15);
					while (true)
					{
						int alt15=2;
						try { DebugEnterDecision(15, decisionCanBacktrack[15]);
						int LA15_0 = input.LA(1);

						if ((LA15_0==SPACE))
						{
							alt15=1;
						}


						} finally { DebugExitDecision(15); }
						switch ( alt15 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:16: SPACE
							{
							DebugLocation(37, 16);
							SPACE43=(IToken)Match(input,SPACE,Follow._SPACE_in_path1382); if (state.failed) return retval;

							}
							break;

						default:
							goto loop15;
						}
					}

					loop15:
						;

					} finally { DebugExitSubRule(15); }

					DebugLocation(37, 22);
					DOT44=(IToken)Match(input,DOT,Follow._DOT_in_path1386); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					DOT44_tree = (object)adaptor.Create(DOT44);
					root_0 = (object)adaptor.BecomeRoot(DOT44_tree, root_0);
					}
					DebugLocation(37, 29);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:29: ( SPACE )*
					try { DebugEnterSubRule(16);
					while (true)
					{
						int alt16=2;
						try { DebugEnterDecision(16, decisionCanBacktrack[16]);
						int LA16_0 = input.LA(1);

						if ((LA16_0==SPACE))
						{
							alt16=1;
						}


						} finally { DebugExitDecision(16); }
						switch ( alt16 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:29: SPACE
							{
							DebugLocation(37, 29);
							SPACE45=(IToken)Match(input,SPACE,Follow._SPACE_in_path1389); if (state.failed) return retval;

							}
							break;

						default:
							goto loop16;
						}
					}

					loop16:
						;

					} finally { DebugExitSubRule(16); }

					DebugLocation(37, 32);
					PushFollow(Follow._term1_in_path1393);
					term146=term1();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term146.Tree);
					DebugLocation(37, 38);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:38: ( ( SPACE )* DOT ( SPACE )* term1 )*
					try { DebugEnterSubRule(19);
					while (true)
					{
						int alt19=2;
						try { DebugEnterDecision(19, decisionCanBacktrack[19]);
						try
						{
							alt19 = dfa19.Predict(input);
						}
						catch (NoViableAltException nvae)
						{
							DebugRecognitionException(nvae);
							throw;
						}
						} finally { DebugExitDecision(19); }
						switch ( alt19 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:39: ( SPACE )* DOT ( SPACE )* term1
							{
							DebugLocation(37, 44);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:44: ( SPACE )*
							try { DebugEnterSubRule(17);
							while (true)
							{
								int alt17=2;
								try { DebugEnterDecision(17, decisionCanBacktrack[17]);
								int LA17_0 = input.LA(1);

								if ((LA17_0==SPACE))
								{
									alt17=1;
								}


								} finally { DebugExitDecision(17); }
								switch ( alt17 )
								{
								case 1:
									DebugEnterAlt(1);
									// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:44: SPACE
									{
									DebugLocation(37, 44);
									SPACE47=(IToken)Match(input,SPACE,Follow._SPACE_in_path1396); if (state.failed) return retval;

									}
									break;

								default:
									goto loop17;
								}
							}

							loop17:
								;

							} finally { DebugExitSubRule(17); }

							DebugLocation(37, 50);
							DOT48=(IToken)Match(input,DOT,Follow._DOT_in_path1400); if (state.failed) return retval;
							DebugLocation(37, 57);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:57: ( SPACE )*
							try { DebugEnterSubRule(18);
							while (true)
							{
								int alt18=2;
								try { DebugEnterDecision(18, decisionCanBacktrack[18]);
								int LA18_0 = input.LA(1);

								if ((LA18_0==SPACE))
								{
									alt18=1;
								}


								} finally { DebugExitDecision(18); }
								switch ( alt18 )
								{
								case 1:
									DebugEnterAlt(1);
									// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:37:57: SPACE
									{
									DebugLocation(37, 57);
									SPACE49=(IToken)Match(input,SPACE,Follow._SPACE_in_path1403); if (state.failed) return retval;

									}
									break;

								default:
									goto loop18;
								}
							}

							loop18:
								;

							} finally { DebugExitSubRule(18); }

							DebugLocation(37, 60);
							PushFollow(Follow._term1_in_path1407);
							term150=term1();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term150.Tree);

							}
							break;

						default:
							goto loop19;
						}
					}

					loop19:
						;

					} finally { DebugExitSubRule(19); }


					}
					break;

				}
				} finally { DebugExitSubRule(20); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:4: DOT term1 ( ( SPACE )* DOT ( SPACE )* term1 )*
				{
				DebugLocation(38, 4);
				DOT51=(IToken)Match(input,DOT,Follow._DOT_in_path1416); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DOT.Add(DOT51);

				DebugLocation(38, 8);
				PushFollow(Follow._term1_in_path1418);
				term152=term1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term1.Add(term152.Tree);
				DebugLocation(38, 14);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:14: ( ( SPACE )* DOT ( SPACE )* term1 )*
				try { DebugEnterSubRule(23);
				while (true)
				{
					int alt23=2;
					try { DebugEnterDecision(23, decisionCanBacktrack[23]);
					try
					{
						alt23 = dfa23.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(23); }
					switch ( alt23 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:15: ( SPACE )* DOT ( SPACE )* term1
						{
						DebugLocation(38, 15);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:15: ( SPACE )*
						try { DebugEnterSubRule(21);
						while (true)
						{
							int alt21=2;
							try { DebugEnterDecision(21, decisionCanBacktrack[21]);
							int LA21_0 = input.LA(1);

							if ((LA21_0==SPACE))
							{
								alt21=1;
							}


							} finally { DebugExitDecision(21); }
							switch ( alt21 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:15: SPACE
								{
								DebugLocation(38, 15);
								SPACE53=(IToken)Match(input,SPACE,Follow._SPACE_in_path1421); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_SPACE.Add(SPACE53);


								}
								break;

							default:
								goto loop21;
							}
						}

						loop21:
							;

						} finally { DebugExitSubRule(21); }

						DebugLocation(38, 22);
						DOT54=(IToken)Match(input,DOT,Follow._DOT_in_path1424); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_DOT.Add(DOT54);

						DebugLocation(38, 26);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:26: ( SPACE )*
						try { DebugEnterSubRule(22);
						while (true)
						{
							int alt22=2;
							try { DebugEnterDecision(22, decisionCanBacktrack[22]);
							int LA22_0 = input.LA(1);

							if ((LA22_0==SPACE))
							{
								alt22=1;
							}


							} finally { DebugExitDecision(22); }
							switch ( alt22 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:26: SPACE
								{
								DebugLocation(38, 26);
								SPACE55=(IToken)Match(input,SPACE,Follow._SPACE_in_path1426); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_SPACE.Add(SPACE55);


								}
								break;

							default:
								goto loop22;
							}
						}

						loop22:
							;

						} finally { DebugExitSubRule(22); }

						DebugLocation(38, 33);
						PushFollow(Follow._term1_in_path1429);
						term156=term1();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_term1.Add(term156.Tree);

						}
						break;

					default:
						goto loop23;
					}
				}

				loop23:
					;

				} finally { DebugExitSubRule(23); }



				{
				// AST REWRITE
				// elements: term1, DOT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 38:41: -> ^( DOT START ( term1 )+ )
				{
					DebugLocation(38, 44);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:38:44: ^( DOT START ( term1 )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(38, 46);
					root_1 = (object)adaptor.BecomeRoot(stream_DOT.NextNode(), root_1);

					DebugLocation(38, 50);
					adaptor.AddChild(root_1, (object)adaptor.Create(START, "START"));
					DebugLocation(38, 56);
					if ( !(stream_term1.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_term1.HasNext )
					{
						DebugLocation(38, 56);
						adaptor.AddChild(root_1, stream_term1.NextTree());

					}
					stream_term1.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("path1", 8);
			LeaveRule("path1", 8);
			Leave_path1();
		}
		DebugLocation(39, 1);
		} finally { DebugExitRule(GrammarFileName, "path1"); }
		return retval;

	}
	// $ANTLR end "path1"

	public class path2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_path2();
	partial void Leave_path2();

	// $ANTLR start "path2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:40:1: path2 : ( term2 ( DOT term2 ( DOT term2 )* )? | DOT term2 ( DOT term2 )* -> ^( DOT START ( term2 )+ ) );
	[GrammarRule("path2")]
	private LambdastyleTryParser.path2_return path2()
	{
		Enter_path2();
		EnterRule("path2", 9);
		TraceIn("path2", 9);
		LambdastyleTryParser.path2_return retval = new LambdastyleTryParser.path2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DOT58=null;
		IToken DOT60=null;
		IToken DOT62=null;
		IToken DOT64=null;
		LambdastyleTryParser.term2_return term257 = default(LambdastyleTryParser.term2_return);
		LambdastyleTryParser.term2_return term259 = default(LambdastyleTryParser.term2_return);
		LambdastyleTryParser.term2_return term261 = default(LambdastyleTryParser.term2_return);
		LambdastyleTryParser.term2_return term263 = default(LambdastyleTryParser.term2_return);
		LambdastyleTryParser.term2_return term265 = default(LambdastyleTryParser.term2_return);

		object DOT58_tree=null;
		object DOT60_tree=null;
		object DOT62_tree=null;
		object DOT64_tree=null;
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");
		RewriteRuleSubtreeStream stream_term2=new RewriteRuleSubtreeStream(adaptor,"rule term2");
		try { DebugEnterRule(GrammarFileName, "path2");
		DebugLocation(40, 1);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:41:2: ( term2 ( DOT term2 ( DOT term2 )* )? | DOT term2 ( DOT term2 )* -> ^( DOT START ( term2 )+ ) )
			int alt28=2;
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if (((LA28_0>=STRING_LITERAL && LA28_0<=LP)||LA28_0==LSB||(LA28_0>=NUMBER && LA28_0<=NULL)))
			{
				alt28=1;
			}
			else if ((LA28_0==DOT))
			{
				alt28=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:41:4: term2 ( DOT term2 ( DOT term2 )* )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(41, 4);
				PushFollow(Follow._term2_in_path2452);
				term257=term2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term257.Tree);
				DebugLocation(41, 10);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:41:10: ( DOT term2 ( DOT term2 )* )?
				int alt26=2;
				try { DebugEnterSubRule(26);
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==DOT))
				{
					alt26=1;
				}
				} finally { DebugExitDecision(26); }
				switch (alt26)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:41:11: DOT term2 ( DOT term2 )*
					{
					DebugLocation(41, 14);
					DOT58=(IToken)Match(input,DOT,Follow._DOT_in_path2455); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					DOT58_tree = (object)adaptor.Create(DOT58);
					root_0 = (object)adaptor.BecomeRoot(DOT58_tree, root_0);
					}
					DebugLocation(41, 16);
					PushFollow(Follow._term2_in_path2458);
					term259=term2();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term259.Tree);
					DebugLocation(41, 22);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:41:22: ( DOT term2 )*
					try { DebugEnterSubRule(25);
					while (true)
					{
						int alt25=2;
						try { DebugEnterDecision(25, decisionCanBacktrack[25]);
						int LA25_0 = input.LA(1);

						if ((LA25_0==DOT))
						{
							alt25=1;
						}


						} finally { DebugExitDecision(25); }
						switch ( alt25 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:41:23: DOT term2
							{
							DebugLocation(41, 26);
							DOT60=(IToken)Match(input,DOT,Follow._DOT_in_path2461); if (state.failed) return retval;
							DebugLocation(41, 28);
							PushFollow(Follow._term2_in_path2464);
							term261=term2();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term261.Tree);

							}
							break;

						default:
							goto loop25;
						}
					}

					loop25:
						;

					} finally { DebugExitSubRule(25); }


					}
					break;

				}
				} finally { DebugExitSubRule(26); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:42:4: DOT term2 ( DOT term2 )*
				{
				DebugLocation(42, 4);
				DOT62=(IToken)Match(input,DOT,Follow._DOT_in_path2473); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DOT.Add(DOT62);

				DebugLocation(42, 8);
				PushFollow(Follow._term2_in_path2475);
				term263=term2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term2.Add(term263.Tree);
				DebugLocation(42, 14);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:42:14: ( DOT term2 )*
				try { DebugEnterSubRule(27);
				while (true)
				{
					int alt27=2;
					try { DebugEnterDecision(27, decisionCanBacktrack[27]);
					int LA27_0 = input.LA(1);

					if ((LA27_0==DOT))
					{
						alt27=1;
					}


					} finally { DebugExitDecision(27); }
					switch ( alt27 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:42:15: DOT term2
						{
						DebugLocation(42, 15);
						DOT64=(IToken)Match(input,DOT,Follow._DOT_in_path2478); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_DOT.Add(DOT64);

						DebugLocation(42, 19);
						PushFollow(Follow._term2_in_path2480);
						term265=term2();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_term2.Add(term265.Tree);

						}
						break;

					default:
						goto loop27;
					}
				}

				loop27:
					;

				} finally { DebugExitSubRule(27); }



				{
				// AST REWRITE
				// elements: term2, DOT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 42:27: -> ^( DOT START ( term2 )+ )
				{
					DebugLocation(42, 30);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:42:30: ^( DOT START ( term2 )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(42, 32);
					root_1 = (object)adaptor.BecomeRoot(stream_DOT.NextNode(), root_1);

					DebugLocation(42, 36);
					adaptor.AddChild(root_1, (object)adaptor.Create(START, "START"));
					DebugLocation(42, 42);
					if ( !(stream_term2.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_term2.HasNext )
					{
						DebugLocation(42, 42);
						adaptor.AddChild(root_1, stream_term2.NextTree());

					}
					stream_term2.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("path2", 9);
			LeaveRule("path2", 9);
			Leave_path2();
		}
		DebugLocation(43, 1);
		} finally { DebugExitRule(GrammarFileName, "path2"); }
		return retval;

	}
	// $ANTLR end "path2"

	public class negation1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_negation1();
	partial void Leave_negation1();

	// $ANTLR start "negation1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:1: negation1 : ( E ( SPACE )* )* path1 ;
	[GrammarRule("negation1")]
	private LambdastyleTryParser.negation1_return negation1()
	{
		Enter_negation1();
		EnterRule("negation1", 10);
		TraceIn("negation1", 10);
		LambdastyleTryParser.negation1_return retval = new LambdastyleTryParser.negation1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken E66=null;
		IToken SPACE67=null;
		LambdastyleTryParser.path1_return path168 = default(LambdastyleTryParser.path1_return);

		object E66_tree=null;
		object SPACE67_tree=null;

		try { DebugEnterRule(GrammarFileName, "negation1");
		DebugLocation(44, 30);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:10: ( ( E ( SPACE )* )* path1 )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:12: ( E ( SPACE )* )* path1
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(44, 12);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:12: ( E ( SPACE )* )*
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==E))
				{
					alt30=1;
				}


				} finally { DebugExitDecision(30); }
				switch ( alt30 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:13: E ( SPACE )*
					{
					DebugLocation(44, 14);
					E66=(IToken)Match(input,E,Follow._E_in_negation1502); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					E66_tree = (object)adaptor.Create(E66);
					root_0 = (object)adaptor.BecomeRoot(E66_tree, root_0);
					}
					DebugLocation(44, 21);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:21: ( SPACE )*
					try { DebugEnterSubRule(29);
					while (true)
					{
						int alt29=2;
						try { DebugEnterDecision(29, decisionCanBacktrack[29]);
						int LA29_0 = input.LA(1);

						if ((LA29_0==SPACE))
						{
							alt29=1;
						}


						} finally { DebugExitDecision(29); }
						switch ( alt29 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:44:21: SPACE
							{
							DebugLocation(44, 21);
							SPACE67=(IToken)Match(input,SPACE,Follow._SPACE_in_negation1505); if (state.failed) return retval;

							}
							break;

						default:
							goto loop29;
						}
					}

					loop29:
						;

					} finally { DebugExitSubRule(29); }


					}
					break;

				default:
					goto loop30;
				}
			}

			loop30:
				;

			} finally { DebugExitSubRule(30); }

			DebugLocation(44, 26);
			PushFollow(Follow._path1_in_negation1511);
			path168=path1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, path168.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("negation1", 10);
			LeaveRule("negation1", 10);
			Leave_negation1();
		}
		DebugLocation(44, 30);
		} finally { DebugExitRule(GrammarFileName, "negation1"); }
		return retval;

	}
	// $ANTLR end "negation1"

	public class negation2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_negation2();
	partial void Leave_negation2();

	// $ANTLR start "negation2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:45:1: negation2 : ( E )* path2 ;
	[GrammarRule("negation2")]
	private LambdastyleTryParser.negation2_return negation2()
	{
		Enter_negation2();
		EnterRule("negation2", 11);
		TraceIn("negation2", 11);
		LambdastyleTryParser.negation2_return retval = new LambdastyleTryParser.negation2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken E69=null;
		LambdastyleTryParser.path2_return path270 = default(LambdastyleTryParser.path2_return);

		object E69_tree=null;

		try { DebugEnterRule(GrammarFileName, "negation2");
		DebugLocation(45, 20);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:45:10: ( ( E )* path2 )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:45:12: ( E )* path2
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(45, 13);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:45:13: ( E )*
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==E))
				{
					alt31=1;
				}


				} finally { DebugExitDecision(31); }
				switch ( alt31 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:45:13: E
					{
					DebugLocation(45, 13);
					E69=(IToken)Match(input,E,Follow._E_in_negation2517); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					E69_tree = (object)adaptor.Create(E69);
					root_0 = (object)adaptor.BecomeRoot(E69_tree, root_0);
					}

					}
					break;

				default:
					goto loop31;
				}
			}

			loop31:
				;

			} finally { DebugExitSubRule(31); }

			DebugLocation(45, 16);
			PushFollow(Follow._path2_in_negation2521);
			path270=path2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, path270.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("negation2", 11);
			LeaveRule("negation2", 11);
			Leave_negation2();
		}
		DebugLocation(45, 20);
		} finally { DebugExitRule(GrammarFileName, "negation2"); }
		return retval;

	}
	// $ANTLR end "negation2"

	public class relation1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relation1();
	partial void Leave_relation1();

	// $ANTLR start "relation1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:1: relation1 : negation1 ( ( SPACE )* ( EQ | NEQ ) ( SPACE )* negation1 )? ;
	[GrammarRule("relation1")]
	private LambdastyleTryParser.relation1_return relation1()
	{
		Enter_relation1();
		EnterRule("relation1", 12);
		TraceIn("relation1", 12);
		LambdastyleTryParser.relation1_return retval = new LambdastyleTryParser.relation1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken SPACE72=null;
		IToken set73=null;
		IToken SPACE74=null;
		LambdastyleTryParser.negation1_return negation171 = default(LambdastyleTryParser.negation1_return);
		LambdastyleTryParser.negation1_return negation175 = default(LambdastyleTryParser.negation1_return);

		object SPACE72_tree=null;
		object set73_tree=null;
		object SPACE74_tree=null;

		try { DebugEnterRule(GrammarFileName, "relation1");
		DebugLocation(46, 61);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:10: ( negation1 ( ( SPACE )* ( EQ | NEQ ) ( SPACE )* negation1 )? )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:12: negation1 ( ( SPACE )* ( EQ | NEQ ) ( SPACE )* negation1 )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(46, 12);
			PushFollow(Follow._negation1_in_relation1527);
			negation171=negation1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negation171.Tree);
			DebugLocation(46, 22);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:22: ( ( SPACE )* ( EQ | NEQ ) ( SPACE )* negation1 )?
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			try
			{
				alt34 = dfa34.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:23: ( SPACE )* ( EQ | NEQ ) ( SPACE )* negation1
				{
				DebugLocation(46, 28);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:28: ( SPACE )*
				try { DebugEnterSubRule(32);
				while (true)
				{
					int alt32=2;
					try { DebugEnterDecision(32, decisionCanBacktrack[32]);
					int LA32_0 = input.LA(1);

					if ((LA32_0==SPACE))
					{
						alt32=1;
					}


					} finally { DebugExitDecision(32); }
					switch ( alt32 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:28: SPACE
						{
						DebugLocation(46, 28);
						SPACE72=(IToken)Match(input,SPACE,Follow._SPACE_in_relation1530); if (state.failed) return retval;

						}
						break;

					default:
						goto loop32;
					}
				}

				loop32:
					;

				} finally { DebugExitSubRule(32); }

				DebugLocation(46, 31);
				set73=(IToken)input.LT(1);
				set73=(IToken)input.LT(1);
				if ((input.LA(1)>=EQ && input.LA(1)<=NEQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set73), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(46, 48);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:48: ( SPACE )*
				try { DebugEnterSubRule(33);
				while (true)
				{
					int alt33=2;
					try { DebugEnterDecision(33, decisionCanBacktrack[33]);
					int LA33_0 = input.LA(1);

					if ((LA33_0==SPACE))
					{
						alt33=1;
					}


					} finally { DebugExitDecision(33); }
					switch ( alt33 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:46:48: SPACE
						{
						DebugLocation(46, 48);
						SPACE74=(IToken)Match(input,SPACE,Follow._SPACE_in_relation1543); if (state.failed) return retval;

						}
						break;

					default:
						goto loop33;
					}
				}

				loop33:
					;

				} finally { DebugExitSubRule(33); }

				DebugLocation(46, 51);
				PushFollow(Follow._negation1_in_relation1547);
				negation175=negation1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negation175.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(34); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relation1", 12);
			LeaveRule("relation1", 12);
			Leave_relation1();
		}
		DebugLocation(46, 61);
		} finally { DebugExitRule(GrammarFileName, "relation1"); }
		return retval;

	}
	// $ANTLR end "relation1"

	public class relation2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relation2();
	partial void Leave_relation2();

	// $ANTLR start "relation2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:47:1: relation2 : negation2 ( ( EQ | NEQ ) negation2 )? ;
	[GrammarRule("relation2")]
	private LambdastyleTryParser.relation2_return relation2()
	{
		Enter_relation2();
		EnterRule("relation2", 13);
		TraceIn("relation2", 13);
		LambdastyleTryParser.relation2_return retval = new LambdastyleTryParser.relation2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set77=null;
		LambdastyleTryParser.negation2_return negation276 = default(LambdastyleTryParser.negation2_return);
		LambdastyleTryParser.negation2_return negation278 = default(LambdastyleTryParser.negation2_return);

		object set77_tree=null;

		try { DebugEnterRule(GrammarFileName, "relation2");
		DebugLocation(47, 45);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:47:10: ( negation2 ( ( EQ | NEQ ) negation2 )? )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:47:12: negation2 ( ( EQ | NEQ ) negation2 )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(47, 12);
			PushFollow(Follow._negation2_in_relation2555);
			negation276=negation2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negation276.Tree);
			DebugLocation(47, 22);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:47:22: ( ( EQ | NEQ ) negation2 )?
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if (((LA35_0>=EQ && LA35_0<=NEQ)))
			{
				alt35=1;
			}
			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:47:23: ( EQ | NEQ ) negation2
				{
				DebugLocation(47, 23);
				set77=(IToken)input.LT(1);
				set77=(IToken)input.LT(1);
				if ((input.LA(1)>=EQ && input.LA(1)<=NEQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set77), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(47, 35);
				PushFollow(Follow._negation2_in_relation2567);
				negation278=negation2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negation278.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(35); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relation2", 13);
			LeaveRule("relation2", 13);
			Leave_relation2();
		}
		DebugLocation(47, 45);
		} finally { DebugExitRule(GrammarFileName, "relation2"); }
		return retval;

	}
	// $ANTLR end "relation2"

	public class logical1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logical1();
	partial void Leave_logical1();

	// $ANTLR start "logical1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:1: logical1 : relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )* )? ;
	[GrammarRule("logical1")]
	private LambdastyleTryParser.logical1_return logical1()
	{
		Enter_logical1();
		EnterRule("logical1", 14);
		TraceIn("logical1", 14);
		LambdastyleTryParser.logical1_return retval = new LambdastyleTryParser.logical1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken SPACE80=null;
		IToken set81=null;
		IToken SPACE82=null;
		IToken SPACE84=null;
		IToken set85=null;
		IToken SPACE86=null;
		LambdastyleTryParser.relation1_return relation179 = default(LambdastyleTryParser.relation1_return);
		LambdastyleTryParser.relation1_return relation183 = default(LambdastyleTryParser.relation1_return);
		LambdastyleTryParser.relation1_return relation187 = default(LambdastyleTryParser.relation1_return);

		object SPACE80_tree=null;
		object set81_tree=null;
		object SPACE82_tree=null;
		object SPACE84_tree=null;
		object set85_tree=null;
		object SPACE86_tree=null;

		try { DebugEnterRule(GrammarFileName, "logical1");
		DebugLocation(48, 115);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:9: ( relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )* )? )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:11: relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )* )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(48, 11);
			PushFollow(Follow._relation1_in_logical1575);
			relation179=relation1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relation179.Tree);
			DebugLocation(48, 21);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:21: ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )* )?
			int alt41=2;
			try { DebugEnterSubRule(41);
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			try
			{
				alt41 = dfa41.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(41); }
			switch (alt41)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:22: ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )*
				{
				DebugLocation(48, 27);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:27: ( SPACE )*
				try { DebugEnterSubRule(36);
				while (true)
				{
					int alt36=2;
					try { DebugEnterDecision(36, decisionCanBacktrack[36]);
					int LA36_0 = input.LA(1);

					if ((LA36_0==SPACE))
					{
						alt36=1;
					}


					} finally { DebugExitDecision(36); }
					switch ( alt36 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:27: SPACE
						{
						DebugLocation(48, 27);
						SPACE80=(IToken)Match(input,SPACE,Follow._SPACE_in_logical1578); if (state.failed) return retval;

						}
						break;

					default:
						goto loop36;
					}
				}

				loop36:
					;

				} finally { DebugExitSubRule(36); }

				DebugLocation(48, 30);
				set81=(IToken)input.LT(1);
				set81=(IToken)input.LT(1);
				if ((input.LA(1)>=OR && input.LA(1)<=AND))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set81), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(48, 54);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:54: ( SPACE )*
				try { DebugEnterSubRule(37);
				while (true)
				{
					int alt37=2;
					try { DebugEnterDecision(37, decisionCanBacktrack[37]);
					int LA37_0 = input.LA(1);

					if ((LA37_0==SPACE))
					{
						alt37=1;
					}


					} finally { DebugExitDecision(37); }
					switch ( alt37 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:54: SPACE
						{
						DebugLocation(48, 54);
						SPACE82=(IToken)Match(input,SPACE,Follow._SPACE_in_logical1595); if (state.failed) return retval;

						}
						break;

					default:
						goto loop37;
					}
				}

				loop37:
					;

				} finally { DebugExitSubRule(37); }

				DebugLocation(48, 57);
				PushFollow(Follow._relation1_in_logical1599);
				relation183=relation1();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relation183.Tree);
				DebugLocation(48, 67);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:67: ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )*
				try { DebugEnterSubRule(40);
				while (true)
				{
					int alt40=2;
					try { DebugEnterDecision(40, decisionCanBacktrack[40]);
					try
					{
						alt40 = dfa40.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(40); }
					switch ( alt40 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:68: ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1
						{
						DebugLocation(48, 73);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:73: ( SPACE )*
						try { DebugEnterSubRule(38);
						while (true)
						{
							int alt38=2;
							try { DebugEnterDecision(38, decisionCanBacktrack[38]);
							int LA38_0 = input.LA(1);

							if ((LA38_0==SPACE))
							{
								alt38=1;
							}


							} finally { DebugExitDecision(38); }
							switch ( alt38 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:73: SPACE
								{
								DebugLocation(48, 73);
								SPACE84=(IToken)Match(input,SPACE,Follow._SPACE_in_logical1602); if (state.failed) return retval;

								}
								break;

							default:
								goto loop38;
							}
						}

						loop38:
							;

						} finally { DebugExitSubRule(38); }

						DebugLocation(48, 76);
						set85=(IToken)input.LT(1);
						if ((input.LA(1)>=OR && input.LA(1)<=AND))
						{
							input.Consume();
							state.errorRecovery=false;state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}

						DebugLocation(48, 100);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:100: ( SPACE )*
						try { DebugEnterSubRule(39);
						while (true)
						{
							int alt39=2;
							try { DebugEnterDecision(39, decisionCanBacktrack[39]);
							int LA39_0 = input.LA(1);

							if ((LA39_0==SPACE))
							{
								alt39=1;
							}


							} finally { DebugExitDecision(39); }
							switch ( alt39 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:48:100: SPACE
								{
								DebugLocation(48, 100);
								SPACE86=(IToken)Match(input,SPACE,Follow._SPACE_in_logical1619); if (state.failed) return retval;

								}
								break;

							default:
								goto loop39;
							}
						}

						loop39:
							;

						} finally { DebugExitSubRule(39); }

						DebugLocation(48, 103);
						PushFollow(Follow._relation1_in_logical1623);
						relation187=relation1();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relation187.Tree);

						}
						break;

					default:
						goto loop40;
					}
				}

				loop40:
					;

				} finally { DebugExitSubRule(40); }


				}
				break;

			}
			} finally { DebugExitSubRule(41); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logical1", 14);
			LeaveRule("logical1", 14);
			Leave_logical1();
		}
		DebugLocation(48, 115);
		} finally { DebugExitRule(GrammarFileName, "logical1"); }
		return retval;

	}
	// $ANTLR end "logical1"

	public class logical2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logical2();
	partial void Leave_logical2();

	// $ANTLR start "logical2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:1: logical2 : relation2 ( ( OR | OROR | AND ) relation2 ( ( OR | OROR | AND ) relation2 )* )? ;
	[GrammarRule("logical2")]
	private LambdastyleTryParser.logical2_return logical2()
	{
		Enter_logical2();
		EnterRule("logical2", 15);
		TraceIn("logical2", 15);
		LambdastyleTryParser.logical2_return retval = new LambdastyleTryParser.logical2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set89=null;
		IToken set91=null;
		LambdastyleTryParser.relation2_return relation288 = default(LambdastyleTryParser.relation2_return);
		LambdastyleTryParser.relation2_return relation290 = default(LambdastyleTryParser.relation2_return);
		LambdastyleTryParser.relation2_return relation292 = default(LambdastyleTryParser.relation2_return);

		object set89_tree=null;
		object set91_tree=null;

		try { DebugEnterRule(GrammarFileName, "logical2");
		DebugLocation(49, 83);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:9: ( relation2 ( ( OR | OROR | AND ) relation2 ( ( OR | OROR | AND ) relation2 )* )? )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:11: relation2 ( ( OR | OROR | AND ) relation2 ( ( OR | OROR | AND ) relation2 )* )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(49, 11);
			PushFollow(Follow._relation2_in_logical2633);
			relation288=relation2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relation288.Tree);
			DebugLocation(49, 21);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:21: ( ( OR | OROR | AND ) relation2 ( ( OR | OROR | AND ) relation2 )* )?
			int alt43=2;
			try { DebugEnterSubRule(43);
			try { DebugEnterDecision(43, decisionCanBacktrack[43]);
			int LA43_0 = input.LA(1);

			if (((LA43_0>=OR && LA43_0<=AND)))
			{
				alt43=1;
			}
			} finally { DebugExitDecision(43); }
			switch (alt43)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:22: ( OR | OROR | AND ) relation2 ( ( OR | OROR | AND ) relation2 )*
				{
				DebugLocation(49, 22);
				set89=(IToken)input.LT(1);
				set89=(IToken)input.LT(1);
				if ((input.LA(1)>=OR && input.LA(1)<=AND))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set89), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(49, 41);
				PushFollow(Follow._relation2_in_logical2649);
				relation290=relation2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relation290.Tree);
				DebugLocation(49, 51);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:51: ( ( OR | OROR | AND ) relation2 )*
				try { DebugEnterSubRule(42);
				while (true)
				{
					int alt42=2;
					try { DebugEnterDecision(42, decisionCanBacktrack[42]);
					int LA42_0 = input.LA(1);

					if (((LA42_0>=OR && LA42_0<=AND)))
					{
						alt42=1;
					}


					} finally { DebugExitDecision(42); }
					switch ( alt42 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:49:52: ( OR | OROR | AND ) relation2
						{
						DebugLocation(49, 52);
						set91=(IToken)input.LT(1);
						if ((input.LA(1)>=OR && input.LA(1)<=AND))
						{
							input.Consume();
							state.errorRecovery=false;state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}

						DebugLocation(49, 71);
						PushFollow(Follow._relation2_in_logical2665);
						relation292=relation2();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relation292.Tree);

						}
						break;

					default:
						goto loop42;
					}
				}

				loop42:
					;

				} finally { DebugExitSubRule(42); }


				}
				break;

			}
			} finally { DebugExitSubRule(43); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logical2", 15);
			LeaveRule("logical2", 15);
			Leave_logical2();
		}
		DebugLocation(49, 83);
		} finally { DebugExitRule(GrammarFileName, "logical2"); }
		return retval;

	}
	// $ANTLR end "logical2"

	public class expression1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression1();
	partial void Leave_expression1();

	// $ANTLR start "expression1"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:50:1: expression1 : logical1 -> ^( SUBJECT logical1 ) ;
	[GrammarRule("expression1")]
	private LambdastyleTryParser.expression1_return expression1()
	{
		Enter_expression1();
		EnterRule("expression1", 16);
		TraceIn("expression1", 16);
		LambdastyleTryParser.expression1_return retval = new LambdastyleTryParser.expression1_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		LambdastyleTryParser.logical1_return logical193 = default(LambdastyleTryParser.logical1_return);

		RewriteRuleSubtreeStream stream_logical1=new RewriteRuleSubtreeStream(adaptor,"rule logical1");
		try { DebugEnterRule(GrammarFileName, "expression1");
		DebugLocation(50, 44);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:50:12: ( logical1 -> ^( SUBJECT logical1 ) )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:50:14: logical1
			{
			DebugLocation(50, 14);
			PushFollow(Follow._logical1_in_expression1675);
			logical193=logical1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_logical1.Add(logical193.Tree);


			{
			// AST REWRITE
			// elements: logical1
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 50:23: -> ^( SUBJECT logical1 )
			{
				DebugLocation(50, 26);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:50:26: ^( SUBJECT logical1 )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(50, 28);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SUBJECT, "SUBJECT"), root_1);

				DebugLocation(50, 36);
				adaptor.AddChild(root_1, stream_logical1.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression1", 16);
			LeaveRule("expression1", 16);
			Leave_expression1();
		}
		DebugLocation(50, 44);
		} finally { DebugExitRule(GrammarFileName, "expression1"); }
		return retval;

	}
	// $ANTLR end "expression1"

	public class expression2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression2();
	partial void Leave_expression2();

	// $ANTLR start "expression2"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:51:1: expression2 : preexpression2_f logical2 -> preexpression2_f ^( SUBJECT logical2 ) ;
	[GrammarRule("expression2")]
	private LambdastyleTryParser.expression2_return expression2()
	{
		Enter_expression2();
		EnterRule("expression2", 17);
		TraceIn("expression2", 17);
		LambdastyleTryParser.expression2_return retval = new LambdastyleTryParser.expression2_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		LambdastyleTryParser.preexpression2_f_return preexpression2_f94 = default(LambdastyleTryParser.preexpression2_f_return);
		LambdastyleTryParser.logical2_return logical295 = default(LambdastyleTryParser.logical2_return);

		RewriteRuleSubtreeStream stream_logical2=new RewriteRuleSubtreeStream(adaptor,"rule logical2");
		RewriteRuleSubtreeStream stream_preexpression2_f=new RewriteRuleSubtreeStream(adaptor,"rule preexpression2_f");
		try { DebugEnterRule(GrammarFileName, "expression2");
		DebugLocation(51, 78);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:51:12: ( preexpression2_f logical2 -> preexpression2_f ^( SUBJECT logical2 ) )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:51:14: preexpression2_f logical2
			{
			DebugLocation(51, 14);
			PushFollow(Follow._preexpression2_f_in_expression2689);
			preexpression2_f94=preexpression2_f();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_preexpression2_f.Add(preexpression2_f94.Tree);
			DebugLocation(51, 31);
			PushFollow(Follow._logical2_in_expression2691);
			logical295=logical2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_logical2.Add(logical295.Tree);


			{
			// AST REWRITE
			// elements: preexpression2_f, logical2
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 51:40: -> preexpression2_f ^( SUBJECT logical2 )
			{
				DebugLocation(51, 43);
				adaptor.AddChild(root_0, stream_preexpression2_f.NextTree());
				DebugLocation(51, 60);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:51:60: ^( SUBJECT logical2 )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(51, 62);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SUBJECT, "SUBJECT"), root_1);

				DebugLocation(51, 70);
				adaptor.AddChild(root_1, stream_logical2.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression2", 17);
			LeaveRule("expression2", 17);
			Leave_expression2();
		}
		DebugLocation(51, 78);
		} finally { DebugExitRule(GrammarFileName, "expression2"); }
		return retval;

	}
	// $ANTLR end "expression2"

	public class literalish_sequence1_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_literalish_sequence1_f();
	partial void Leave_literalish_sequence1_f();

	// $ANTLR start "literalish_sequence1_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:10: fragment literalish_sequence1_f : ( STRING_LITERAL | REGEXP_LITERAL | STAR ) ( ( SPACE )* ( STRING_LITERAL | REGEXP_LITERAL | STAR ) )+ ;
	[GrammarRule("literalish_sequence1_f")]
	private LambdastyleTryParser.literalish_sequence1_f_return literalish_sequence1_f()
	{
		Enter_literalish_sequence1_f();
		EnterRule("literalish_sequence1_f", 18);
		TraceIn("literalish_sequence1_f", 18);
		LambdastyleTryParser.literalish_sequence1_f_return retval = new LambdastyleTryParser.literalish_sequence1_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set96=null;
		IToken SPACE97=null;
		IToken set98=null;

		object set96_tree=null;
		object SPACE97_tree=null;
		object set98_tree=null;

		try { DebugEnterRule(GrammarFileName, "literalish_sequence1_f");
		DebugLocation(52, 117);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:32: ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) ( ( SPACE )* ( STRING_LITERAL | REGEXP_LITERAL | STAR ) )+ )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:34: ( STRING_LITERAL | REGEXP_LITERAL | STAR ) ( ( SPACE )* ( STRING_LITERAL | REGEXP_LITERAL | STAR ) )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(52, 34);
			set96=(IToken)input.LT(1);
			if ((input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set96));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(52, 71);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:71: ( ( SPACE )* ( STRING_LITERAL | REGEXP_LITERAL | STAR ) )+
			int cnt45=0;
			try { DebugEnterSubRule(45);
			while (true)
			{
				int alt45=2;
				try { DebugEnterDecision(45, decisionCanBacktrack[45]);
				try
				{
					alt45 = dfa45.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(45); }
				switch (alt45)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:72: ( SPACE )* ( STRING_LITERAL | REGEXP_LITERAL | STAR )
					{
					DebugLocation(52, 77);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:77: ( SPACE )*
					try { DebugEnterSubRule(44);
					while (true)
					{
						int alt44=2;
						try { DebugEnterDecision(44, decisionCanBacktrack[44]);
						int LA44_0 = input.LA(1);

						if ((LA44_0==SPACE))
						{
							alt44=1;
						}


						} finally { DebugExitDecision(44); }
						switch ( alt44 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:52:77: SPACE
							{
							DebugLocation(52, 77);
							SPACE97=(IToken)Match(input,SPACE,Follow._SPACE_in_literalish_sequence1_f718); if (state.failed) return retval;

							}
							break;

						default:
							goto loop44;
						}
					}

					loop44:
						;

					} finally { DebugExitSubRule(44); }

					DebugLocation(52, 80);
					set98=(IToken)input.LT(1);
					if ((input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set98));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}


					}
					break;

				default:
					if (cnt45 >= 1)
						goto loop45;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee45 = new EarlyExitException( 45, input );
					DebugRecognitionException(eee45);
					throw eee45;
				}
				cnt45++;
			}
			loop45:
				;

			} finally { DebugExitSubRule(45); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("literalish_sequence1_f", 18);
			LeaveRule("literalish_sequence1_f", 18);
			Leave_literalish_sequence1_f();
		}
		DebugLocation(52, 117);
		} finally { DebugExitRule(GrammarFileName, "literalish_sequence1_f"); }
		return retval;

	}
	// $ANTLR end "literalish_sequence1_f"

	public class literalish_sequence2_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_literalish_sequence2_f();
	partial void Leave_literalish_sequence2_f();

	// $ANTLR start "literalish_sequence2_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:53:10: fragment literalish_sequence2_f : ( STRING_LITERAL | REGEXP_LITERAL | STAR ) ( STRING_LITERAL | REGEXP_LITERAL | STAR )+ ;
	[GrammarRule("literalish_sequence2_f")]
	private LambdastyleTryParser.literalish_sequence2_f_return literalish_sequence2_f()
	{
		Enter_literalish_sequence2_f();
		EnterRule("literalish_sequence2_f", 19);
		TraceIn("literalish_sequence2_f", 19);
		LambdastyleTryParser.literalish_sequence2_f_return retval = new LambdastyleTryParser.literalish_sequence2_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set99=null;
		IToken set100=null;

		object set99_tree=null;
		object set100_tree=null;

		try { DebugEnterRule(GrammarFileName, "literalish_sequence2_f");
		DebugLocation(53, 107);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:53:32: ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) ( STRING_LITERAL | REGEXP_LITERAL | STAR )+ )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:53:34: ( STRING_LITERAL | REGEXP_LITERAL | STAR ) ( STRING_LITERAL | REGEXP_LITERAL | STAR )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(53, 34);
			set99=(IToken)input.LT(1);
			if ((input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set99));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(53, 71);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:53:71: ( STRING_LITERAL | REGEXP_LITERAL | STAR )+
			int cnt46=0;
			try { DebugEnterSubRule(46);
			while (true)
			{
				int alt46=2;
				try { DebugEnterDecision(46, decisionCanBacktrack[46]);
				int LA46_0 = input.LA(1);

				if (((LA46_0>=STRING_LITERAL && LA46_0<=STAR)))
				{
					alt46=1;
				}


				} finally { DebugExitDecision(46); }
				switch (alt46)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:
					{
					DebugLocation(53, 71);
					set100=(IToken)input.LT(1);
					if ((input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set100));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}


					}
					break;

				default:
					if (cnt46 >= 1)
						goto loop46;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee46 = new EarlyExitException( 46, input );
					DebugRecognitionException(eee46);
					throw eee46;
				}
				cnt46++;
			}
			loop46:
				;

			} finally { DebugExitSubRule(46); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("literalish_sequence2_f", 19);
			LeaveRule("literalish_sequence2_f", 19);
			Leave_literalish_sequence2_f();
		}
		DebugLocation(53, 107);
		} finally { DebugExitRule(GrammarFileName, "literalish_sequence2_f"); }
		return retval;

	}
	// $ANTLR end "literalish_sequence2_f"

	public class term_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term_f();
	partial void Leave_term_f();

	// $ANTLR start "term_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:54:10: fragment term_f : ( NUMBER | BOOLEAN | ITEM | ITEM_INDEX | NULL );
	[GrammarRule("term_f")]
	private LambdastyleTryParser.term_f_return term_f()
	{
		Enter_term_f();
		EnterRule("term_f", 20);
		TraceIn("term_f", 20);
		LambdastyleTryParser.term_f_return retval = new LambdastyleTryParser.term_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set101=null;

		object set101_tree=null;

		try { DebugEnterRule(GrammarFileName, "term_f");
		DebugLocation(54, 60);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:54:16: ( NUMBER | BOOLEAN | ITEM | ITEM_INDEX | NULL )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(54, 16);
			set101=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=NULL))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set101));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term_f", 20);
			LeaveRule("term_f", 20);
			Leave_term_f();
		}
		DebugLocation(54, 60);
		} finally { DebugExitRule(GrammarFileName, "term_f"); }
		return retval;

	}
	// $ANTLR end "term_f"

	public class left_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_left_f();
	partial void Leave_left_f();

	// $ANTLR start "left_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:55:10: fragment left_f : ( ALL | SPACE | ITEM | NULL | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | RP | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | BOOLEAN | DUMMY )* ;
	[GrammarRule("left_f")]
	private LambdastyleTryParser.left_f_return left_f()
	{
		Enter_left_f();
		EnterRule("left_f", 21);
		TraceIn("left_f", 21);
		LambdastyleTryParser.left_f_return retval = new LambdastyleTryParser.left_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set102=null;

		object set102_tree=null;

		try { DebugEnterRule(GrammarFileName, "left_f");
		DebugLocation(55, 147);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:55:16: ( ( ALL | SPACE | ITEM | NULL | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | RP | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | BOOLEAN | DUMMY )* )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:55:18: ( ALL | SPACE | ITEM | NULL | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | RP | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | BOOLEAN | DUMMY )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(55, 18);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:55:18: ( ALL | SPACE | ITEM | NULL | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | RP | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | BOOLEAN | DUMMY )*
			try { DebugEnterSubRule(47);
			while (true)
			{
				int alt47=2;
				try { DebugEnterDecision(47, decisionCanBacktrack[47]);
				try
				{
					alt47 = dfa47.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(47); }
				switch ( alt47 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:
					{
					DebugLocation(55, 18);
					set102=(IToken)input.LT(1);
					if (input.LA(1)==SPACE||(input.LA(1)>=STRING_LITERAL && input.LA(1)<=STAR)||input.LA(1)==RP||(input.LA(1)>=RSB && input.LA(1)<=DUMMY))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set102));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}


					}
					break;

				default:
					goto loop47;
				}
			}

			loop47:
				;

			} finally { DebugExitSubRule(47); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("left_f", 21);
			LeaveRule("left_f", 21);
			Leave_left_f();
		}
		DebugLocation(55, 147);
		} finally { DebugExitRule(GrammarFileName, "left_f"); }
		return retval;

	}
	// $ANTLR end "left_f"

	public class right_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_right_f();
	partial void Leave_right_f();

	// $ANTLR start "right_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:10: fragment right_f : (~ ( EOL | SPACE ) (~ EOL )* )? ;
	[GrammarRule("right_f")]
	private LambdastyleTryParser.right_f_return right_f()
	{
		Enter_right_f();
		EnterRule("right_f", 22);
		TraceIn("right_f", 22);
		LambdastyleTryParser.right_f_return retval = new LambdastyleTryParser.right_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set103=null;
		IToken set104=null;

		object set103_tree=null;
		object set104_tree=null;

		try { DebugEnterRule(GrammarFileName, "right_f");
		DebugLocation(56, 39);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:17: ( (~ ( EOL | SPACE ) (~ EOL )* )? )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:19: (~ ( EOL | SPACE ) (~ EOL )* )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(56, 19);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:19: (~ ( EOL | SPACE ) (~ EOL )* )?
			int alt49=2;
			try { DebugEnterSubRule(49);
			try { DebugEnterDecision(49, decisionCanBacktrack[49]);
			int LA49_0 = input.LA(1);

			if (((LA49_0>=SENTENCE && LA49_0<=LITERALISH_SEQUENCE)||(LA49_0>=ARR && LA49_0<=COMMENT)))
			{
				alt49=1;
			}
			} finally { DebugExitDecision(49); }
			switch (alt49)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:20: ~ ( EOL | SPACE ) (~ EOL )*
				{
				DebugLocation(56, 20);
				set103=(IToken)input.LT(1);
				if ((input.LA(1)>=SENTENCE && input.LA(1)<=LITERALISH_SEQUENCE)||(input.LA(1)>=ARR && input.LA(1)<=COMMENT))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set103));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(56, 33);
				// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:33: (~ EOL )*
				try { DebugEnterSubRule(48);
				while (true)
				{
					int alt48=2;
					try { DebugEnterDecision(48, decisionCanBacktrack[48]);
					int LA48_0 = input.LA(1);

					if (((LA48_0>=SENTENCE && LA48_0<=LITERALISH_SEQUENCE)||(LA48_0>=SPACE && LA48_0<=COMMENT)))
					{
						alt48=1;
					}


					} finally { DebugExitDecision(48); }
					switch ( alt48 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:56:33: ~ EOL
						{
						DebugLocation(56, 33);
						set104=(IToken)input.LT(1);
						if ((input.LA(1)>=SENTENCE && input.LA(1)<=LITERALISH_SEQUENCE)||(input.LA(1)>=SPACE && input.LA(1)<=COMMENT))
						{
							input.Consume();
							if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set104));
							state.errorRecovery=false;state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}


						}
						break;

					default:
						goto loop48;
					}
				}

				loop48:
					;

				} finally { DebugExitSubRule(48); }


				}
				break;

			}
			} finally { DebugExitSubRule(49); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("right_f", 22);
			LeaveRule("right_f", 22);
			Leave_right_f();
		}
		DebugLocation(56, 39);
		} finally { DebugExitRule(GrammarFileName, "right_f"); }
		return retval;

	}
	// $ANTLR end "right_f"

	public class alternative3_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_alternative3_f();
	partial void Leave_alternative3_f();

	// $ANTLR start "alternative3_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:57:10: fragment alternative3_f : (~ ( ARR | EOL ) )* ;
	[GrammarRule("alternative3_f")]
	private LambdastyleTryParser.alternative3_f_return alternative3_f()
	{
		Enter_alternative3_f();
		EnterRule("alternative3_f", 23);
		TraceIn("alternative3_f", 23);
		LambdastyleTryParser.alternative3_f_return retval = new LambdastyleTryParser.alternative3_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set105=null;

		object set105_tree=null;

		try { DebugEnterRule(GrammarFileName, "alternative3_f");
		DebugLocation(57, 36);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:57:24: ( (~ ( ARR | EOL ) )* )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:57:26: (~ ( ARR | EOL ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(57, 26);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:57:26: (~ ( ARR | EOL ) )*
			try { DebugEnterSubRule(50);
			while (true)
			{
				int alt50=2;
				try { DebugEnterDecision(50, decisionCanBacktrack[50]);
				int LA50_0 = input.LA(1);

				if (((LA50_0>=SENTENCE && LA50_0<=LITERALISH_SEQUENCE)||LA50_0==SPACE||(LA50_0>=STRING_LITERAL && LA50_0<=COMMENT)))
				{
					alt50=1;
				}


				} finally { DebugExitDecision(50); }
				switch ( alt50 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:57:26: ~ ( ARR | EOL )
					{
					DebugLocation(57, 26);
					set105=(IToken)input.LT(1);
					if ((input.LA(1)>=SENTENCE && input.LA(1)<=LITERALISH_SEQUENCE)||input.LA(1)==SPACE||(input.LA(1)>=STRING_LITERAL && input.LA(1)<=COMMENT))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set105));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}


					}
					break;

				default:
					goto loop50;
				}
			}

			loop50:
				;

			} finally { DebugExitSubRule(50); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("alternative3_f", 23);
			LeaveRule("alternative3_f", 23);
			Leave_alternative3_f();
		}
		DebugLocation(57, 36);
		} finally { DebugExitRule(GrammarFileName, "alternative3_f"); }
		return retval;

	}
	// $ANTLR end "alternative3_f"

	public class preexpression2_f_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_preexpression2_f();
	partial void Leave_preexpression2_f();

	// $ANTLR start "preexpression2_f"
	// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:58:10: fragment preexpression2_f : ( ALL | SPACE );
	[GrammarRule("preexpression2_f")]
	private LambdastyleTryParser.preexpression2_f_return preexpression2_f()
	{
		Enter_preexpression2_f();
		EnterRule("preexpression2_f", 24);
		TraceIn("preexpression2_f", 24);
		LambdastyleTryParser.preexpression2_f_return retval = new LambdastyleTryParser.preexpression2_f_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set106=null;

		object set106_tree=null;

		try { DebugEnterRule(GrammarFileName, "preexpression2_f");
		DebugLocation(58, 38);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:58:26: ( ALL | SPACE )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(58, 26);
			set106=(IToken)input.LT(1);
			if (input.LA(1)==SPACE||input.LA(1)==ALL)
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set106));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("preexpression2_f", 24);
			LeaveRule("preexpression2_f", 24);
			Leave_preexpression2_f();
		}
		DebugLocation(58, 38);
		} finally { DebugExitRule(GrammarFileName, "preexpression2_f"); }
		return retval;

	}
	// $ANTLR end "preexpression2_f"

	partial void Enter_synpred1_LambdastyleTry_fragment();
	partial void Leave_synpred1_LambdastyleTry_fragment();

	// $ANTLR start synpred1_LambdastyleTry
	public void synpred1_LambdastyleTry_fragment()
	{
		Enter_synpred1_LambdastyleTry_fragment();
		EnterRule("synpred1_LambdastyleTry_fragment", 25);
		TraceIn("synpred1_LambdastyleTry_fragment", 25);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:11:4: ( alternative1 )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:11:5: alternative1
			{
			DebugLocation(11, 5);
			PushFollow(Follow._alternative1_in_synpred1_LambdastyleTry84);
			alternative1();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_LambdastyleTry_fragment", 25);
			LeaveRule("synpred1_LambdastyleTry_fragment", 25);
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
		EnterRule("synpred2_LambdastyleTry_fragment", 26);
		TraceIn("synpred2_LambdastyleTry_fragment", 26);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:12:4: ( alternative2 )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:12:5: alternative2
			{
			DebugLocation(12, 5);
			PushFollow(Follow._alternative2_in_synpred2_LambdastyleTry106);
			alternative2();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_LambdastyleTry_fragment", 26);
			LeaveRule("synpred2_LambdastyleTry_fragment", 26);
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
		EnterRule("synpred3_LambdastyleTry_fragment", 27);
		TraceIn("synpred3_LambdastyleTry_fragment", 27);
		try
		{
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:13:4: ( alternative3 ( EOL | EOF ) )
			DebugEnterAlt(1);
			// C:\\Documents and Settings\\ANTLRUser\\workspace\\LambdastyleTry\\src\\lambdastylePrototype\\parser\\LambdastyleTry.g:13:5: alternative3 ( EOL | EOF )
			{
			DebugLocation(13, 5);
			PushFollow(Follow._alternative3_in_synpred3_LambdastyleTry128);
			alternative3();
			PopFollow();
			if (state.failed) return;
			DebugLocation(13, 18);
			if (input.LA(1)==EOF||input.LA(1)==EOL)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("synpred3_LambdastyleTry_fragment", 27);
			LeaveRule("synpred3_LambdastyleTry_fragment", 27);
			Leave_synpred3_LambdastyleTry_fragment();
		}
	}
	// $ANTLR end synpred3_LambdastyleTry
	#endregion Rules

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
	DFA2 dfa2;
	DFA13 dfa13;
	DFA20 dfa20;
	DFA19 dfa19;
	DFA23 dfa23;
	DFA34 dfa34;
	DFA41 dfa41;
	DFA40 dfa40;
	DFA45 dfa45;
	DFA47 dfa47;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa2 = new DFA2( this, SpecialStateTransition2 );
		dfa13 = new DFA13( this );
		dfa20 = new DFA20( this );
		dfa19 = new DFA19( this );
		dfa23 = new DFA23( this );
		dfa34 = new DFA34( this );
		dfa41 = new DFA41( this );
		dfa40 = new DFA40( this );
		dfa45 = new DFA45( this );
		dfa47 = new DFA47( this );
	}

	private class DFA2 : DFA
	{
		private const string DFA2_eotS =
			"\xE\xFFFF";
		private const string DFA2_eofS =
			"\x1\xB\xD\xFFFF";
		private const string DFA2_minS =
			"\x1\x4\x8\x0\x5\xFFFF";
		private const string DFA2_maxS =
			"\x1\x27\x8\x0\x5\xFFFF";
		private const string DFA2_acceptS =
			"\x9\xFFFF\x3\x3\x1\x1\x1\x2";
		private const string DFA2_specialS =
			"\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x5\xFFFF}>";
		private static readonly string[] DFA2_transitionS =
			{
				"\x4\x9\x1\xA\x1\x7\x1\xFFFF\x3\x2\x1\x4\x1\x8\x1\x5\x1\x8\x1\x6\x1"+
				"\x1\x5\x8\x5\x3\x1\x7\x4\x8\x5\x9",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
		private static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
		private static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
		private static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
		private static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
		private static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
		private static readonly short[][] DFA2_transition;

		static DFA2()
		{
			int numStates = DFA2_transitionS.Length;
			DFA2_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA2_transition[i] = DFA.UnpackEncodedString(DFA2_transitionS[i]);
			}
		}

		public DFA2( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 2;
			this.eot = DFA2_eot;
			this.eof = DFA2_eof;
			this.min = DFA2_min;
			this.max = DFA2_max;
			this.accept = DFA2_accept;
			this.special = DFA2_special;
			this.transition = DFA2_transition;
		}

		public override string Description { get { return "10:1: sentence : ( ( alternative1 )=> alternative1 | ( alternative2 )=> alternative2 | ( alternative3 ( EOL | EOF ) )=> alternative3 );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition2(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA2_0 = input.LA(1);


				int index2_0 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA2_0==E) ) {s = 1;}

				else if ( ((LA2_0>=STRING_LITERAL && LA2_0<=STAR)) ) {s = 2;}

				else if ( ((LA2_0>=NUMBER && LA2_0<=NULL)) ) {s = 3;}

				else if ( (LA2_0==LP) ) {s = 4;}

				else if ( (LA2_0==LSB) ) {s = 5;}

				else if ( (LA2_0==DOT) ) {s = 6;}

				else if ( (LA2_0==SPACE||LA2_0==ALL) ) {s = 7;}

				else if ( (LA2_0==RP||LA2_0==RSB||(LA2_0>=EQ && LA2_0<=AND)||(LA2_0>=Q && LA2_0<=DUMMY)) ) {s = 8;}

				else if ( ((LA2_0>=SENTENCE && LA2_0<=LITERALISH_SEQUENCE)||(LA2_0>=STRING_LITERAL_F && LA2_0<=COMMENT)) && (EvaluatePredicate(synpred3_LambdastyleTry_fragment))) {s = 9;}

				else if ( (LA2_0==EOL) && (EvaluatePredicate(synpred3_LambdastyleTry_fragment))) {s = 10;}

				else if ( (LA2_0==EOF) && (EvaluatePredicate(synpred3_LambdastyleTry_fragment))) {s = 11;}


				input.Seek(index2_0);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA2_1 = input.LA(1);


				int index2_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_LambdastyleTry_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred2_LambdastyleTry_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_1);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA2_2 = input.LA(1);


				int index2_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_LambdastyleTry_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred2_LambdastyleTry_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_2);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA2_3 = input.LA(1);


				int index2_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_LambdastyleTry_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred2_LambdastyleTry_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_3);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA2_4 = input.LA(1);


				int index2_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_LambdastyleTry_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_4);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA2_5 = input.LA(1);


				int index2_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_LambdastyleTry_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_5);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA2_6 = input.LA(1);


				int index2_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_LambdastyleTry_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred2_LambdastyleTry_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_6);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA2_7 = input.LA(1);


				int index2_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred2_LambdastyleTry_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_7);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA2_8 = input.LA(1);


				int index2_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred2_LambdastyleTry_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_LambdastyleTry_fragment)) ) {s = 11;}


				input.Seek(index2_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 2, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA13 : DFA
	{
		private const string DFA13_eotS =
			"\x8\xFFFF";
		private const string DFA13_eofS =
			"\x8\xFFFF";
		private const string DFA13_minS =
			"\x1\xB\x1\x9\x3\xFFFF\x1\x9\x2\xFFFF";
		private const string DFA13_maxS =
			"\x1\x1D\x1\x18\x3\xFFFF\x1\x18\x2\xFFFF";
		private const string DFA13_acceptS =
			"\x2\xFFFF\x1\x3\x1\x4\x1\x5\x1\xFFFF\x1\x1\x1\x2";
		private const string DFA13_specialS =
			"\x8\xFFFF}>";
		private static readonly string[] DFA13_transitionS =
			{
				"\x3\x1\x1\x3\x1\xFFFF\x1\x4\x8\xFFFF\x5\x2",
				"\x1\x5\x1\x6\x3\x7\x1\xFFFF\x1\x6\x1\xFFFF\x2\x6\x1\xFFFF\x5\x6",
				"",
				"",
				"",
				"\x1\x5\x1\x6\x3\x7\x1\xFFFF\x1\x6\x1\xFFFF\x2\x6\x1\xFFFF\x5\x6",
				"",
				""
			};

		private static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
		private static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
		private static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
		private static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
		private static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
		private static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
		private static readonly short[][] DFA13_transition;

		static DFA13()
		{
			int numStates = DFA13_transitionS.Length;
			DFA13_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA13_transition[i] = DFA.UnpackEncodedString(DFA13_transitionS[i]);
			}
		}

		public DFA13( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 13;
			this.eot = DFA13_eot;
			this.eof = DFA13_eof;
			this.min = DFA13_min;
			this.max = DFA13_max;
			this.accept = DFA13_accept;
			this.special = DFA13_special;
			this.transition = DFA13_transition;
		}

		public override string Description { get { return "22:1: term1 : ( ( STRING_LITERAL | REGEXP_LITERAL | STAR ) | literalish_sequence1_f -> ^( LITERALISH_SEQUENCE literalish_sequence1_f ) | term_f | LP ( SPACE )* logical1 ( SPACE )* RP | LSB ( SPACE )* logical1 ( SPACE )* RSB );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA20 : DFA
	{
		private const string DFA20_eotS =
			"\x4\xFFFF";
		private const string DFA20_eofS =
			"\x4\xFFFF";
		private const string DFA20_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA20_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA20_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA20_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA20_transitionS =
			{
				"\x1\x1\x1\x3\x4\xFFFF\x1\x3\x1\xFFFF\x1\x3\x1\x2\x1\xFFFF\x5\x3",
				"\x1\x1\x1\x3\x4\xFFFF\x1\x3\x1\xFFFF\x1\x3\x1\x2\x1\xFFFF\x5\x3",
				"",
				""
			};

		private static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
		private static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
		private static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
		private static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
		private static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
		private static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
		private static readonly short[][] DFA20_transition;

		static DFA20()
		{
			int numStates = DFA20_transitionS.Length;
			DFA20_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA20_transition[i] = DFA.UnpackEncodedString(DFA20_transitionS[i]);
			}
		}

		public DFA20( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 20;
			this.eot = DFA20_eot;
			this.eof = DFA20_eof;
			this.min = DFA20_min;
			this.max = DFA20_max;
			this.accept = DFA20_accept;
			this.special = DFA20_special;
			this.transition = DFA20_transition;
		}

		public override string Description { get { return "37:10: ( ( SPACE )* DOT ( SPACE )* term1 ( ( SPACE )* DOT ( SPACE )* term1 )* )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA19 : DFA
	{
		private const string DFA19_eotS =
			"\x4\xFFFF";
		private const string DFA19_eofS =
			"\x4\xFFFF";
		private const string DFA19_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA19_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA19_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA19_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA19_transitionS =
			{
				"\x1\x1\x1\x2\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3\x1\xFFFF\x5\x2",
				"\x1\x1\x1\x2\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3\x1\xFFFF\x5\x2",
				"",
				""
			};

		private static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
		private static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
		private static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
		private static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
		private static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
		private static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
		private static readonly short[][] DFA19_transition;

		static DFA19()
		{
			int numStates = DFA19_transitionS.Length;
			DFA19_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA19_transition[i] = DFA.UnpackEncodedString(DFA19_transitionS[i]);
			}
		}

		public DFA19( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 19;
			this.eot = DFA19_eot;
			this.eof = DFA19_eof;
			this.min = DFA19_min;
			this.max = DFA19_max;
			this.accept = DFA19_accept;
			this.special = DFA19_special;
			this.transition = DFA19_transition;
		}

		public override string Description { get { return "()* loopback of 37:38: ( ( SPACE )* DOT ( SPACE )* term1 )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA23 : DFA
	{
		private const string DFA23_eotS =
			"\x4\xFFFF";
		private const string DFA23_eofS =
			"\x4\xFFFF";
		private const string DFA23_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA23_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA23_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA23_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA23_transitionS =
			{
				"\x1\x1\x1\x2\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3\x1\xFFFF\x5\x2",
				"\x1\x1\x1\x2\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3\x1\xFFFF\x5\x2",
				"",
				""
			};

		private static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
		private static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
		private static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
		private static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
		private static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
		private static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
		private static readonly short[][] DFA23_transition;

		static DFA23()
		{
			int numStates = DFA23_transitionS.Length;
			DFA23_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA23_transition[i] = DFA.UnpackEncodedString(DFA23_transitionS[i]);
			}
		}

		public DFA23( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 23;
			this.eot = DFA23_eot;
			this.eof = DFA23_eof;
			this.min = DFA23_min;
			this.max = DFA23_max;
			this.accept = DFA23_accept;
			this.special = DFA23_special;
			this.transition = DFA23_transition;
		}

		public override string Description { get { return "()* loopback of 38:14: ( ( SPACE )* DOT ( SPACE )* term1 )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA34 : DFA
	{
		private const string DFA34_eotS =
			"\x4\xFFFF";
		private const string DFA34_eofS =
			"\x4\xFFFF";
		private const string DFA34_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA34_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA34_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA34_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA34_transitionS =
			{
				"\x1\x1\x1\x3\x4\xFFFF\x1\x3\x1\xFFFF\x1\x3\x2\xFFFF\x2\x2\x3\x3",
				"\x1\x1\x1\x3\x4\xFFFF\x1\x3\x1\xFFFF\x1\x3\x2\xFFFF\x2\x2\x3\x3",
				"",
				""
			};

		private static readonly short[] DFA34_eot = DFA.UnpackEncodedString(DFA34_eotS);
		private static readonly short[] DFA34_eof = DFA.UnpackEncodedString(DFA34_eofS);
		private static readonly char[] DFA34_min = DFA.UnpackEncodedStringToUnsignedChars(DFA34_minS);
		private static readonly char[] DFA34_max = DFA.UnpackEncodedStringToUnsignedChars(DFA34_maxS);
		private static readonly short[] DFA34_accept = DFA.UnpackEncodedString(DFA34_acceptS);
		private static readonly short[] DFA34_special = DFA.UnpackEncodedString(DFA34_specialS);
		private static readonly short[][] DFA34_transition;

		static DFA34()
		{
			int numStates = DFA34_transitionS.Length;
			DFA34_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA34_transition[i] = DFA.UnpackEncodedString(DFA34_transitionS[i]);
			}
		}

		public DFA34( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 34;
			this.eot = DFA34_eot;
			this.eof = DFA34_eof;
			this.min = DFA34_min;
			this.max = DFA34_max;
			this.accept = DFA34_accept;
			this.special = DFA34_special;
			this.transition = DFA34_transition;
		}

		public override string Description { get { return "46:22: ( ( SPACE )* ( EQ | NEQ ) ( SPACE )* negation1 )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA41 : DFA
	{
		private const string DFA41_eotS =
			"\x4\xFFFF";
		private const string DFA41_eofS =
			"\x4\xFFFF";
		private const string DFA41_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA41_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA41_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA41_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA41_transitionS =
			{
				"\x1\x1\x1\x3\x4\xFFFF\x1\x3\x1\xFFFF\x1\x3\x4\xFFFF\x3\x2",
				"\x1\x1\x1\x3\x4\xFFFF\x1\x3\x1\xFFFF\x1\x3\x4\xFFFF\x3\x2",
				"",
				""
			};

		private static readonly short[] DFA41_eot = DFA.UnpackEncodedString(DFA41_eotS);
		private static readonly short[] DFA41_eof = DFA.UnpackEncodedString(DFA41_eofS);
		private static readonly char[] DFA41_min = DFA.UnpackEncodedStringToUnsignedChars(DFA41_minS);
		private static readonly char[] DFA41_max = DFA.UnpackEncodedStringToUnsignedChars(DFA41_maxS);
		private static readonly short[] DFA41_accept = DFA.UnpackEncodedString(DFA41_acceptS);
		private static readonly short[] DFA41_special = DFA.UnpackEncodedString(DFA41_specialS);
		private static readonly short[][] DFA41_transition;

		static DFA41()
		{
			int numStates = DFA41_transitionS.Length;
			DFA41_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA41_transition[i] = DFA.UnpackEncodedString(DFA41_transitionS[i]);
			}
		}

		public DFA41( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 41;
			this.eot = DFA41_eot;
			this.eof = DFA41_eof;
			this.min = DFA41_min;
			this.max = DFA41_max;
			this.accept = DFA41_accept;
			this.special = DFA41_special;
			this.transition = DFA41_transition;
		}

		public override string Description { get { return "48:21: ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )* )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA40 : DFA
	{
		private const string DFA40_eotS =
			"\x4\xFFFF";
		private const string DFA40_eofS =
			"\x4\xFFFF";
		private const string DFA40_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA40_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA40_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA40_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA40_transitionS =
			{
				"\x1\x1\x1\x2\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x4\xFFFF\x3\x3",
				"\x1\x1\x1\x2\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x4\xFFFF\x3\x3",
				"",
				""
			};

		private static readonly short[] DFA40_eot = DFA.UnpackEncodedString(DFA40_eotS);
		private static readonly short[] DFA40_eof = DFA.UnpackEncodedString(DFA40_eofS);
		private static readonly char[] DFA40_min = DFA.UnpackEncodedStringToUnsignedChars(DFA40_minS);
		private static readonly char[] DFA40_max = DFA.UnpackEncodedStringToUnsignedChars(DFA40_maxS);
		private static readonly short[] DFA40_accept = DFA.UnpackEncodedString(DFA40_acceptS);
		private static readonly short[] DFA40_special = DFA.UnpackEncodedString(DFA40_specialS);
		private static readonly short[][] DFA40_transition;

		static DFA40()
		{
			int numStates = DFA40_transitionS.Length;
			DFA40_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA40_transition[i] = DFA.UnpackEncodedString(DFA40_transitionS[i]);
			}
		}

		public DFA40( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 40;
			this.eot = DFA40_eot;
			this.eof = DFA40_eof;
			this.min = DFA40_min;
			this.max = DFA40_max;
			this.accept = DFA40_accept;
			this.special = DFA40_special;
			this.transition = DFA40_transition;
		}

		public override string Description { get { return "()* loopback of 48:67: ( ( SPACE )* ( OR | OROR | AND ) ( SPACE )* relation1 )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA45 : DFA
	{
		private const string DFA45_eotS =
			"\x4\xFFFF";
		private const string DFA45_eofS =
			"\x4\xFFFF";
		private const string DFA45_minS =
			"\x2\x9\x2\xFFFF";
		private const string DFA45_maxS =
			"\x2\x18\x2\xFFFF";
		private const string DFA45_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA45_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA45_transitionS =
			{
				"\x1\x1\x1\x2\x3\x3\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x1\xFFFF\x5\x2",
				"\x1\x1\x1\x2\x3\x3\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x1\xFFFF\x5\x2",
				"",
				""
			};

		private static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
		private static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
		private static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
		private static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
		private static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
		private static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
		private static readonly short[][] DFA45_transition;

		static DFA45()
		{
			int numStates = DFA45_transitionS.Length;
			DFA45_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA45_transition[i] = DFA.UnpackEncodedString(DFA45_transitionS[i]);
			}
		}

		public DFA45( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 45;
			this.eot = DFA45_eot;
			this.eof = DFA45_eof;
			this.min = DFA45_min;
			this.max = DFA45_max;
			this.accept = DFA45_accept;
			this.special = DFA45_special;
			this.transition = DFA45_transition;
		}

		public override string Description { get { return "()+ loopback of 52:71: ( ( SPACE )* ( STRING_LITERAL | REGEXP_LITERAL | STAR ) )+"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA47 : DFA
	{
		private const string DFA47_eotS =
			"\x82\xFFFF";
		private const string DFA47_eofS =
			"\x82\xFFFF";
		private const string DFA47_minS =
			"\x2\x9\x1\xFFFF\x3\x9\x1\xFFFF\x7B\x9";
		private const string DFA47_maxS =
			"\x2\x22\x1\xFFFF\x3\x22\x1\xFFFF\x7B\x22";
		private const string DFA47_acceptS =
			"\x2\xFFFF\x1\x1\x3\xFFFF\x1\x2\x7B\xFFFF";
		private const string DFA47_specialS =
			"\x82\xFFFF}>";
		private static readonly string[] DFA47_transitionS =
			{
				"\x1\x1\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\xD\x2\x1\x1\x4\x2",
				"\x1\x2\x1\xFFFF\x3\x4\x1\x6\x1\x2\x1\x6\x1\x2\x1\x7\x1\x3\x5\x2\x5"+
				"\x5\x5\x2",
				"",
				"\x1\x2\x1\xFFFF\x3\x4\x1\x6\x1\x2\x1\x6\x1\x2\x1\x7\x1\x3\x5\x2\x5"+
				"\x5\x5\x2",
				"\x1\xB\x1\x6\x3\xC\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x8\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x8\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"",
				"\x1\x2\x1\xFFFF\x3\xD\x1\x6\x1\x2\x1\x6\x8\x2\x5\xE\x5\x2",
				"\x1\x2\x1\xFFFF\x3\xF\x1\x6\x1\x2\x1\x6\x8\x2\x5\x10\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x12\x1\x6\x1\x2\x1\x6\x1\x2\x1\x14\x1\x11\x5\x2"+
				"\x5\x13\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x16\x1\x6\x1\x2\x1\x6\x1\x2\x1\x18\x1\x15\x5\x2"+
				"\x5\x17\x5\x2",
				"\x1\xB\x1\x6\x18\x2",
				"\x1\xB\x1\x6\x3\xC\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x8\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x1A\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x19\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x19\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x1C\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1B\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1B\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x12\x1\x6\x1\x2\x1\x6\x1\x2\x1\x14\x1\x11\x5\x2"+
				"\x5\x13\x5\x2",
				"\x1\xB\x1\x6\x3\x1E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1D\x3\x2\x3\xA"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x1F\x1\x6\x1\x2\x1\x6\x8\x2\x5\x20\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x16\x1\x6\x1\x2\x1\x6\x1\x2\x1\x18\x1\x15\x5\x2"+
				"\x5\x17\x5\x2",
				"\x1\xB\x1\x6\x3\x24\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x21\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x21\x1\x2\x2\x22"+
				"\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x25\x1\x6\x1\x2\x1\x6\x8\x2\x5\x26\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x27\x1\x6\x1\x2\x1\x6\x8\x2\x5\x28\x5\x2",
				"\x1\xB\x1\x6\x3\x1A\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x19\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x29\x1\x6\x1\x2\x1\x6\x8\x2\x5\x2A\x5\x2",
				"\x1\xB\x1\x6\x3\x1C\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1B\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x2B\x1\x6\x1\x2\x1\x6\x8\x2\x5\x2C\x5\x2",
				"\x1\xB\x1\x6\x3\x1E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x2D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x2D\x3\x2\x3\xA"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x2F\x1\x6\x1\x2\x1\x6\x8\x2\x5\x30\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x32\x1\x6\x1\x2\x1\x6\x1\x2\x1\x34\x1\x31\x5\x2"+
				"\x5\x33\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x36\x1\x6\x1\x2\x1\x6\x1\x2\x1\x38\x1\x35\x5\x2"+
				"\x5\x37\x5\x2",
				"\x1\xB\x1\x6\x3\x24\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x21\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x3A\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x39\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x39\x1\x2\x2\x22"+
				"\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x3B\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x19\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x19\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x3C\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1B\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1B\x1\x2\x2\x9"+
				"\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x3E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3D\x3\x2\x3\xA"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x3F\x1\x6\x1\x2\x1\x6\x8\x2\x5\x40\x5\x2",
				"\x1\xB\x1\x6\x3\x2E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x2D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x42\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x41\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x41\x1\x2\x2\x22"+
				"\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x32\x1\x6\x1\x2\x1\x6\x1\x2\x1\x34\x1\x31\x5\x2"+
				"\x5\x33\x5\x2",
				"\x1\xB\x1\x6\x3\x44\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x43\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x43\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x45\x1\x6\x1\x2\x1\x6\x8\x2\x5\x46\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x36\x1\x6\x1\x2\x1\x6\x1\x2\x1\x38\x1\x35\x5\x2"+
				"\x5\x37\x5\x2",
				"\x1\xB\x1\x6\x3\x49\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x47\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x47\x1\x2\x2\x48"+
				"\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x4A\x1\x6\x1\x2\x1\x6\x8\x2\x5\x4B\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x4C\x1\x6\x1\x2\x1\x6\x8\x2\x5\x4D\x5\x2",
				"\x1\xB\x1\x6\x3\x3A\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x39\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x3B\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x19\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x3C\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x1B\x1\x2\x2"+
				"\x9\x3\xA\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x4E\x1\x6\x1\x2\x1\x6\x8\x2\x5\x4F\x5\x2",
				"\x1\xB\x1\x6\x3\x3E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x50\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x2D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x2D\x3\x2\x3\xA"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x51\x1\x6\x1\x2\x1\x6\x8\x2\x5\x52\x5\x2",
				"\x1\xB\x1\x6\x3\x42\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x41\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x53\x1\x6\x1\x2\x1\x6\x8\x2\x5\x54\x5\x2",
				"\x1\xB\x1\x6\x3\x44\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x43\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x56\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x55\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x55\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x57\x1\x6\x1\x2\x1\x6\x8\x2\x5\x58\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x5A\x1\x6\x1\x2\x1\x6\x1\x2\x1\x5C\x1\x59\x5\x2"+
				"\x5\x5B\x5\x2",
				"\x1\xB\x1\x6\x3\x49\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x47\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x5E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x5D\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x5D\x1\x2\x2\x48"+
				"\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x5F\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x39\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x39\x1\x2\x2\x22"+
				"\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x60\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3D\x3\x2\x3\xA"+
				"\xA\x2",
				"\x1\xB\x1\x6\x3\x50\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x2D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x61\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x41\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x41\x1\x2\x2\x22"+
				"\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x63\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x62\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x62\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x64\x1\x6\x1\x2\x1\x6\x8\x2\x5\x65\x5\x2",
				"\x1\xB\x1\x6\x3\x56\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x55\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x67\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x66\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x66\x1\x2\x2\x48"+
				"\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x5A\x1\x6\x1\x2\x1\x6\x1\x2\x1\x5C\x1\x59\x5\x2"+
				"\x5\x5B\x5\x2",
				"\x1\xB\x1\x6\x3\x69\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x68\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x68\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x6A\x1\x6\x1\x2\x1\x6\x8\x2\x5\x6B\x5\x2",
				"\x1\x2\x1\xFFFF\x3\x6C\x1\x6\x1\x2\x1\x6\x8\x2\x5\x6D\x5\x2",
				"\x1\xB\x1\x6\x3\x5E\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x5D\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x5F\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x39\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x60\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3D\x3\x2\x3"+
				"\xA\xA\x2",
				"\x1\xB\x1\x6\x3\x61\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x41\x1\x2\x2"+
				"\x22\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x6E\x1\x6\x1\x2\x1\x6\x8\x2\x5\x6F\x5\x2",
				"\x1\xB\x1\x6\x3\x63\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x62\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x70\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x55\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x55\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x71\x1\x6\x1\x2\x1\x6\x8\x2\x5\x72\x5\x2",
				"\x1\xB\x1\x6\x3\x67\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x66\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x73\x1\x6\x1\x2\x1\x6\x8\x2\x5\x74\x5\x2",
				"\x1\xB\x1\x6\x3\x69\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x68\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x76\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x75\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x75\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\xB\x1\x6\x3\x77\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x5D\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x5D\x1\x2\x2\x48"+
				"\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x78\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x62\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x62\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\xB\x1\x6\x3\x70\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x55\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x79\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x66\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x66\x1\x2\x2\x48"+
				"\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x7B\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x7A\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x7A\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x7C\x1\x6\x1\x2\x1\x6\x8\x2\x5\x7D\x5\x2",
				"\x1\xB\x1\x6\x3\x76\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x75\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x77\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x5D\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x78\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x62\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x79\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x66\x1\x2\x2"+
				"\x48\x3\x23\xA\x2",
				"\x1\x2\x1\xFFFF\x3\x7E\x1\x6\x1\x2\x1\x6\x8\x2\x5\x7F\x5\x2",
				"\x1\xB\x1\x6\x3\x7B\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x7A\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x80\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x75\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x75\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\xB\x1\x6\x3\x81\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x7A\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x7A\x3\x2\x3\x23"+
				"\xA\x2",
				"\x1\xB\x1\x6\x3\x80\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x75\x3\x2\x3"+
				"\x23\xA\x2",
				"\x1\xB\x1\x6\x3\x81\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x7A\x3\x2\x3"+
				"\x23\xA\x2"
			};

		private static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
		private static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
		private static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
		private static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
		private static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
		private static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
		private static readonly short[][] DFA47_transition;

		static DFA47()
		{
			int numStates = DFA47_transitionS.Length;
			DFA47_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA47_transition[i] = DFA.UnpackEncodedString(DFA47_transitionS[i]);
			}
		}

		public DFA47( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 47;
			this.eot = DFA47_eot;
			this.eof = DFA47_eof;
			this.min = DFA47_min;
			this.max = DFA47_max;
			this.accept = DFA47_accept;
			this.special = DFA47_special;
			this.transition = DFA47_transition;
		}

		public override string Description { get { return "()* loopback of 55:18: ( ALL | SPACE | ITEM | NULL | Q | E | S | STRING_LITERAL | REGEXP_LITERAL | NUMBER | ITEM_INDEX | RP | RSB | STAR | DOT | EQ | NEQ | OR | OROR | AND | HASH | BOOLEAN | DUMMY )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _sentence_in_style63 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _EOL_in_style66 = new BitSet(new ulong[]{0xFFFFFFFAF0UL});
		public static readonly BitSet _sentence_in_style69 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _EOF_in_style73 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative1_in_sentence99 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative2_in_sentence121 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative3_in_sentence139 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression1_in_alternative1150 = new BitSet(new ulong[]{0x600UL});
		public static readonly BitSet _SPACE_in_alternative1152 = new BitSet(new ulong[]{0x600UL});
		public static readonly BitSet _ARR_in_alternative1155 = new BitSet(new ulong[]{0xFFFFFFFEF0UL});
		public static readonly BitSet _SPACE_in_alternative1158 = new BitSet(new ulong[]{0xFFFFFFFEF0UL});
		public static readonly BitSet _SPACE_in_alternative1162 = new BitSet(new ulong[]{0xFFFFFFFEF0UL});
		public static readonly BitSet _right_f_in_alternative1167 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _left_f_in_alternative2189 = new BitSet(new ulong[]{0x7FFFEBA00UL});
		public static readonly BitSet _expression2_in_alternative2191 = new BitSet(new ulong[]{0x600UL});
		public static readonly BitSet _SPACE_in_alternative2193 = new BitSet(new ulong[]{0x600UL});
		public static readonly BitSet _ARR_in_alternative2196 = new BitSet(new ulong[]{0xFFFFFFFEF0UL});
		public static readonly BitSet _SPACE_in_alternative2199 = new BitSet(new ulong[]{0xFFFFFFFEF0UL});
		public static readonly BitSet _SPACE_in_alternative2203 = new BitSet(new ulong[]{0xFFFFFFFEF0UL});
		public static readonly BitSet _right_f_in_alternative2208 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative3_f_in_alternative3233 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_term1251 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literalish_sequence1_f_in_term1262 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_f_in_term1275 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LP_in_term1280 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _SPACE_in_term1283 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _logical1_in_term1287 = new BitSet(new ulong[]{0x8200UL});
		public static readonly BitSet _SPACE_in_term1289 = new BitSet(new ulong[]{0x8200UL});
		public static readonly BitSet _RP_in_term1293 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LSB_in_term1299 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _SPACE_in_term1302 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _logical1_in_term1306 = new BitSet(new ulong[]{0x20200UL});
		public static readonly BitSet _SPACE_in_term1308 = new BitSet(new ulong[]{0x20200UL});
		public static readonly BitSet _RSB_in_term1312 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_term2323 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literalish_sequence2_f_in_term2334 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_f_in_term2347 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LP_in_term2352 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _logical1_in_term2355 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RP_in_term2357 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LSB_in_term2363 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _logical1_in_term2366 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _RSB_in_term2368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term1_in_path1379 = new BitSet(new ulong[]{0x40202UL});
		public static readonly BitSet _SPACE_in_path1382 = new BitSet(new ulong[]{0x40200UL});
		public static readonly BitSet _DOT_in_path1386 = new BitSet(new ulong[]{0x3E017A00UL});
		public static readonly BitSet _SPACE_in_path1389 = new BitSet(new ulong[]{0x3E017A00UL});
		public static readonly BitSet _term1_in_path1393 = new BitSet(new ulong[]{0x40202UL});
		public static readonly BitSet _SPACE_in_path1396 = new BitSet(new ulong[]{0x40200UL});
		public static readonly BitSet _DOT_in_path1400 = new BitSet(new ulong[]{0x3E017A00UL});
		public static readonly BitSet _SPACE_in_path1403 = new BitSet(new ulong[]{0x3E017A00UL});
		public static readonly BitSet _term1_in_path1407 = new BitSet(new ulong[]{0x40202UL});
		public static readonly BitSet _DOT_in_path1416 = new BitSet(new ulong[]{0x3E017800UL});
		public static readonly BitSet _term1_in_path1418 = new BitSet(new ulong[]{0x40202UL});
		public static readonly BitSet _SPACE_in_path1421 = new BitSet(new ulong[]{0x40200UL});
		public static readonly BitSet _DOT_in_path1424 = new BitSet(new ulong[]{0x3E017A00UL});
		public static readonly BitSet _SPACE_in_path1426 = new BitSet(new ulong[]{0x3E017A00UL});
		public static readonly BitSet _term1_in_path1429 = new BitSet(new ulong[]{0x40202UL});
		public static readonly BitSet _term2_in_path2452 = new BitSet(new ulong[]{0x40002UL});
		public static readonly BitSet _DOT_in_path2455 = new BitSet(new ulong[]{0x3E017800UL});
		public static readonly BitSet _term2_in_path2458 = new BitSet(new ulong[]{0x40002UL});
		public static readonly BitSet _DOT_in_path2461 = new BitSet(new ulong[]{0x3E017800UL});
		public static readonly BitSet _term2_in_path2464 = new BitSet(new ulong[]{0x40002UL});
		public static readonly BitSet _DOT_in_path2473 = new BitSet(new ulong[]{0x3E017800UL});
		public static readonly BitSet _term2_in_path2475 = new BitSet(new ulong[]{0x40002UL});
		public static readonly BitSet _DOT_in_path2478 = new BitSet(new ulong[]{0x3E017800UL});
		public static readonly BitSet _term2_in_path2480 = new BitSet(new ulong[]{0x40002UL});
		public static readonly BitSet _E_in_negation1502 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _SPACE_in_negation1505 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _path1_in_negation1511 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _E_in_negation2517 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _path2_in_negation2521 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _negation1_in_relation1527 = new BitSet(new ulong[]{0x300202UL});
		public static readonly BitSet _SPACE_in_relation1530 = new BitSet(new ulong[]{0x300200UL});
		public static readonly BitSet _set_in_relation1534 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _SPACE_in_relation1543 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _negation1_in_relation1547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _negation2_in_relation2555 = new BitSet(new ulong[]{0x300002UL});
		public static readonly BitSet _set_in_relation2558 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _negation2_in_relation2567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _relation1_in_logical1575 = new BitSet(new ulong[]{0x1C00202UL});
		public static readonly BitSet _SPACE_in_logical1578 = new BitSet(new ulong[]{0x1C00200UL});
		public static readonly BitSet _set_in_logical1582 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _SPACE_in_logical1595 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _relation1_in_logical1599 = new BitSet(new ulong[]{0x1C00202UL});
		public static readonly BitSet _SPACE_in_logical1602 = new BitSet(new ulong[]{0x1C00200UL});
		public static readonly BitSet _set_in_logical1606 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _SPACE_in_logical1619 = new BitSet(new ulong[]{0x3E0D7A00UL});
		public static readonly BitSet _relation1_in_logical1623 = new BitSet(new ulong[]{0x1C00202UL});
		public static readonly BitSet _relation2_in_logical2633 = new BitSet(new ulong[]{0x1C00002UL});
		public static readonly BitSet _set_in_logical2636 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _relation2_in_logical2649 = new BitSet(new ulong[]{0x1C00002UL});
		public static readonly BitSet _set_in_logical2652 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _relation2_in_logical2665 = new BitSet(new ulong[]{0x1C00002UL});
		public static readonly BitSet _logical1_in_expression1675 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _preexpression2_f_in_expression2689 = new BitSet(new ulong[]{0x3E0D7800UL});
		public static readonly BitSet _logical2_in_expression2691 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_literalish_sequence1_f709 = new BitSet(new ulong[]{0x3A00UL});
		public static readonly BitSet _SPACE_in_literalish_sequence1_f718 = new BitSet(new ulong[]{0x3A00UL});
		public static readonly BitSet _set_in_literalish_sequence1_f722 = new BitSet(new ulong[]{0x3A02UL});
		public static readonly BitSet _set_in_literalish_sequence2_f738 = new BitSet(new ulong[]{0x3800UL});
		public static readonly BitSet _set_in_literalish_sequence2_f746 = new BitSet(new ulong[]{0x3802UL});
		public static readonly BitSet _set_in_term_f0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_left_f785 = new BitSet(new ulong[]{0x7FFFEBA02UL});
		public static readonly BitSet _set_in_right_f841 = new BitSet(new ulong[]{0xFFFFFFFEF2UL});
		public static readonly BitSet _set_in_right_f848 = new BitSet(new ulong[]{0xFFFFFFFEF2UL});
		public static readonly BitSet _set_in_alternative3_f860 = new BitSet(new ulong[]{0xFFFFFFFAF2UL});
		public static readonly BitSet _set_in_preexpression2_f0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative1_in_synpred1_LambdastyleTry84 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative2_in_synpred2_LambdastyleTry106 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative3_in_synpred3_LambdastyleTry128 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _set_in_synpred3_LambdastyleTry130 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  LambdastylePrototype.Parser 
