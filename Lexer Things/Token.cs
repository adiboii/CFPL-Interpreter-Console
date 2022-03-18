public class Token
{
    public Lexeme lex {get;}
    public string literal {get;}
    public int line {get;}

    public Token(Lexeme lex, string literal, int line)
    {
        this.lex = lex;
        this.literal = literal;
        this.line = line;
    }
}