package lambdastylePrototype.parser;

import org.antlr.runtime.ANTLRStringStream;
import org.antlr.runtime.CharStream;
import org.antlr.runtime.CommonTokenStream;
import org.antlr.runtime.RecognitionException;
import org.antlr.runtime.TokenStream;
import org.antlr.runtime.tree.CommonTree;
import lambdastylePrototype.parser.LambdastyleTryLexer;
import lambdastylePrototype.parser.LambdastyleTryParser;
import lambdastylePrototype.parser.LambdastyleTryParser.style_return;

public class TestLambdastyleTry {
	public static void main(String[] args) throws RecognitionException {
		CharStream charStream = new ANTLRStringStream(
			"*=* \"&id=\" -> \n *=*-> \n\"foo\"->");
		LambdastyleTryLexer lexer = new LambdastyleTryLexer(charStream);
		TokenStream tokenStream = new CommonTokenStream(lexer);
		LambdastyleTryParser parser = new LambdastyleTryParser(tokenStream);
		style_return style = parser.style();
		System.out.println(((CommonTree)style.tree).toStringTree());
	}
}