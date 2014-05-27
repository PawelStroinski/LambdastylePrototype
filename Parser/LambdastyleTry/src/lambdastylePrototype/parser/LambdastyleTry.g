grammar LambdastyleTry;

options { language = CSharp3; output = AST; }
tokens { SENTENCE; SUBJECT; START; LITERALISH_SEQUENCE; }
//@header { package lambdastylePrototype.parser; } @lexer::header { package lambdastylePrototype.parser; }
@lexer::namespace { LambdastylePrototype.Parser } @parser::namespace { LambdastylePrototype.Parser }

public style: sentence (EOL! sentence)* EOF; 

sentence
	:	(alternative1)           => alternative1 //{ System.out.println("1"); }
	|	(alternative2)           => alternative2 //{ System.out.println("2"); }
	|	(alternative3 (EOL|EOF)) => alternative3 //{ System.out.println("3"); }
	;
	
alternative1: expression1 SPACE* ARR (SPACE morespaces=SPACE*)? right_f -> ^(SENTENCE expression1 $morespaces? right_f?);

alternative2: left_f expression2 SPACE* ARR (SPACE morespaces=SPACE*)? right_f -> ^(SENTENCE left_f? expression2 $morespaces? right_f?);

alternative3: alternative3_f -> ^(SENTENCE alternative3_f?);

term1
	:	(STRING_LITERAL|REGEXP_LITERAL|STAR)
	|	literalish_sequence1_f -> ^(LITERALISH_SEQUENCE literalish_sequence1_f)
	|	term_f
	|	LP! SPACE!* logical1 SPACE!* RP!
	|	LSB^ SPACE!* logical1 SPACE!* RSB!
	;
term2
	:	(STRING_LITERAL|REGEXP_LITERAL|STAR)
	|	literalish_sequence2_f -> ^(LITERALISH_SEQUENCE literalish_sequence2_f)
	|	term_f
	|	LP! logical1 RP!
	|	LSB^ logical1 RSB!
	;
path1
	: term1 (SPACE!* DOT^ SPACE!* term1 (SPACE!* DOT! SPACE!* term1)*)?
	| DOT term1 (SPACE* DOT SPACE* term1)* -> ^(DOT START term1+)
	;
path2
	: term2 (DOT^ term2 (DOT! term2)*)?
	| DOT term2 (DOT term2)* -> ^(DOT START term2+)
	;
negation1: (E^ SPACE!*)* path1;
negation2: E^* path2;
relation1: negation1 (SPACE!* (EQ | NEQ)^ SPACE!* negation1)?;
relation2: negation2 ((EQ | NEQ)^ negation2)?;
logical1: relation1 (SPACE!* (OR | OROR | AND)^ SPACE!* relation1 (SPACE!* (OR | OROR | AND)! SPACE!* relation1)*)?;
logical2: relation2 ((OR | OROR | AND)^ relation2 ((OR | OROR | AND)! relation2)*)?;
expression1: logical1 -> ^(SUBJECT logical1);
expression2: preexpression2_f logical2 -> preexpression2_f ^(SUBJECT logical2);
fragment literalish_sequence1_f: (STRING_LITERAL|REGEXP_LITERAL|STAR) (SPACE!* (STRING_LITERAL|REGEXP_LITERAL|STAR))+;
fragment literalish_sequence2_f: (STRING_LITERAL|REGEXP_LITERAL|STAR) (STRING_LITERAL|REGEXP_LITERAL|STAR)+;
fragment term_f: NUMBER | BOOLEAN | ITEM | ITEM_INDEX | NULL;
fragment left_f: (ALL|SPACE|ITEM|NULL|Q|E|S|STRING_LITERAL|REGEXP_LITERAL|NUMBER|ITEM_INDEX|RP|RSB|STAR|DOT|EQ|NEQ|OR|OROR|AND|HASH|BOOLEAN|DUMMY)*;
fragment right_f: (~(EOL|SPACE) ~EOL*)?;
fragment alternative3_f: ~(ARR|EOL)*;
fragment preexpression2_f: ALL | SPACE;

ARR: '->';
ITEM: 'item';
NULL: 'null';
LP: '(';
RP: ')';
LSB: '[';
RSB: ']';
STAR: '*';
DOT: '.';
EQ: '=';
NEQ: '!=';
OR: '|';
OROR: '||';
AND: '&';
HASH: '#';
Q: '"';
E: '!';
S: '/';
STRING_LITERAL: (STRING_LITERAL_F) => STRING_LITERAL_F
			  |	Q;
REGEXP_LITERAL: (REGEXP_LITERAL_F) => REGEXP_LITERAL_F
			  |	S;
NUMBER: DIGIT+ (DOT DIGIT+)?;
ITEM_INDEX: (ITEM_INDEX_F) => ITEM_INDEX_F
		  | ITEM;
BOOLEAN: 'true'|'false';
SPACE: ' '|'\t';
EOL: '\r\n'|'\r'|'\n';
COMMENT: '//' ~(EOL)* { $channel=Hidden; }; //{ $channel=HIDDEN; System.out.println("comment"); };
ALL: .;
DUMMY: 'nu' | 'nul' | 'it' | 'ite' | 'tr' | 'tru' | 'fa' | 'fal' | 'fals';
fragment STRING_LITERAL_F: Q ('\\"'|~(Q|EOL))* Q;
fragment REGEXP_LITERAL_F: S ('\\/'|~(S|EOL))* S;
fragment ITEM_INDEX_F: ITEM SPACE* LSB SPACE* DIGIT+ SPACE* RSB;
fragment DIGIT: '0'..'9';