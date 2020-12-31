using System;
using System.Collections;
using System.IO;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000173 RID: 371
	internal class TSql80LexerInternal : TSqlLexerBaseInternal, TokenStream
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x0001A724 File Offset: 0x00018924
		public override int testLiteralsTable(int ttype)
		{
			string text = this.text.ToString();
			if (text == null || text == string.Empty)
			{
				return ttype;
			}
			if (text.Substring(text.Length - 1, 1) == ":")
			{
				text = text.Substring(0, text.Length - 1);
			}
			return this.testLiteralsTable(text, ttype);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0001A782 File Offset: 0x00018982
		public TSql80LexerInternal() : this(new StringReader(string.Empty))
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0001A794 File Offset: 0x00018994
		public TSql80LexerInternal(Stream ins) : this(new ByteBuffer(ins))
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0001A7A2 File Offset: 0x000189A2
		public TSql80LexerInternal(TextReader r) : this(new CharBuffer(r))
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001A7B0 File Offset: 0x000189B0
		public TSql80LexerInternal(InputBuffer ib) : this(new LexerSharedInputState(ib))
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001A7BE File Offset: 0x000189BE
		public TSql80LexerInternal(LexerSharedInputState state) : base(state)
		{
			this.initialize();
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001A7D0 File Offset: 0x000189D0
		private void initialize()
		{
			this.caseSensitiveLiterals = false;
			this.setCaseSensitive(false);
			this.literals = new Hashtable(100, 0.4f, StringComparer.OrdinalIgnoreCase);
			this.literals.Add("index", 84);
			this.literals.Add("full", 72);
			this.literals.Add("cross", 36);
			this.literals.Add("close", 23);
			this.literals.Add("union", 158);
			this.literals.Add("coalesce", 25);
			this.literals.Add("use", 162);
			this.literals.Add("escape", 58);
			this.literals.Add("right", 133);
			this.literals.Add("with", 171);
			this.literals.Add("replication", 128);
			this.literals.Add("over", 115);
			this.literals.Add("collate", 26);
			this.literals.Add("values", 164);
			this.literals.Add("freetexttable", 70);
			this.literals.Add("contains", 31);
			this.literals.Add("percent", 116);
			this.literals.Add("errlvl", 57);
			this.literals.Add("holdlock", 78);
			this.literals.Add("varying", 165);
			this.literals.Add("cursor", 42);
			this.literals.Add("references", 127);
			this.literals.Add("continue", 33);
			this.literals.Add("for", 67);
			this.literals.Add("else", 55);
			this.literals.Add("is", 89);
			this.literals.Add("insert", 86);
			this.literals.Add("of", 102);
			this.literals.Add("and", 7);
			this.literals.Add("inner", 85);
			this.literals.Add("user", 163);
			this.literals.Add("lineno", 95);
			this.literals.Add("as", 9);
			this.literals.Add("some", 145);
			this.literals.Add("database", 43);
			this.literals.Add("nullif", 101);
			this.literals.Add("distinct", 51);
			this.literals.Add("key", 91);
			this.literals.Add("truncate", 156);
			this.literals.Add("desc", 50);
			this.literals.Add("current_timestamp", 40);
			this.literals.Add("public", 122);
			this.literals.Add("exists", 62);
			this.literals.Add("like", 94);
			this.literals.Add("clustered", 24);
			this.literals.Add("left", 93);
			this.literals.Add("shutdown", 144);
			this.literals.Add("openrowset", 109);
			this.literals.Add("fetch", 64);
			this.literals.Add("tran", 153);
			this.literals.Add("open", 106);
			this.literals.Add("between", 14);
			this.literals.Add("function", 73);
			this.literals.Add("system_user", 147);
			this.literals.Add("identity_insert", 80);
			this.literals.Add("backup", 12);
			this.literals.Add("national", 96);
			this.literals.Add("compute", 29);
			this.literals.Add("intersect", 87);
			this.literals.Add("view", 166);
			this.literals.Add("bulk", 17);
			this.literals.Add("any", 8);
			this.literals.Add("fillfactor", 66);
			this.literals.Add("not", 99);
			this.literals.Add("off", 103);
			this.literals.Add("updatetext", 161);
			this.literals.Add("all", 5);
			this.literals.Add("in", 83);
			this.literals.Add("except", 59);
			this.literals.Add("file", 65);
			this.literals.Add("declare", 46);
			this.literals.Add("column", 27);
			this.literals.Add("opendatasource", 107);
			this.literals.Add("execute", 61);
			this.literals.Add("reconfigure", 126);
			this.literals.Add("transaction", 154);
			this.literals.Add("proc", 120);
			this.literals.Add("unique", 159);
			this.literals.Add("identitycol", 81);
			this.literals.Add("offsets", 104);
			this.literals.Add("restrict", 130);
			this.literals.Add("delete", 48);
			this.literals.Add("when", 168);
			this.literals.Add("null", 100);
			this.literals.Add("join", 90);
			this.literals.Add("top", 152);
			this.literals.Add("foreign", 68);
			this.literals.Add("rule", 137);
			this.literals.Add("deallocate", 45);
			this.literals.Add("procedure", 121);
			this.literals.Add("freetext", 69);
			this.literals.Add("disk", 173);
			this.literals.Add("convert", 34);
			this.literals.Add("restore", 129);
			this.literals.Add("readtext", 125);
			this.literals.Add("begin", 13);
			this.literals.Add("cascade", 19);
			this.literals.Add("to", 151);
			this.literals.Add("into", 88);
			this.literals.Add("current_date", 38);
			this.literals.Add("case", 20);
			this.literals.Add("check", 21);
			this.literals.Add("outer", 114);
			this.literals.Add("deny", 49);
			this.literals.Add("primary", 118);
			this.literals.Add("plan", 117);
			this.literals.Add("current_user", 41);
			this.literals.Add("textsize", 149);
			this.literals.Add("grant", 75);
			this.literals.Add("break", 15);
			this.literals.Add("containstable", 32);
			this.literals.Add("print", 119);
			this.literals.Add("openquery", 108);
			this.literals.Add("current_time", 39);
			this.literals.Add("checkpoint", 22);
			this.literals.Add("nonclustered", 98);
			this.literals.Add("current", 37);
			this.literals.Add("having", 77);
			this.literals.Add("statistics", 146);
			this.literals.Add("precision", 174);
			this.literals.Add("then", 150);
			this.literals.Add("set", 142);
			this.literals.Add("update", 160);
			this.literals.Add("schema", 139);
			this.literals.Add("save", 138);
			this.literals.Add("browse", 16);
			this.literals.Add("or", 112);
			this.literals.Add("if", 82);
			this.literals.Add("exec", 60);
			this.literals.Add("by", 18);
			this.literals.Add("add", 4);
			this.literals.Add("distributed", 52);
			this.literals.Add("return", 131);
			this.literals.Add("dump", 180);
			this.literals.Add("from", 71);
			this.literals.Add("openxml", 110);
			this.literals.Add("read", 124);
			this.literals.Add("setuser", 143);
			this.literals.Add("load", 181);
			this.literals.Add("nocheck", 97);
			this.literals.Add("drop", 54);
			this.literals.Add("rowguidcol", 136);
			this.literals.Add("kill", 92);
			this.literals.Add("waitfor", 167);
			this.literals.Add("dbcc", 44);
			this.literals.Add("revoke", 132);
			this.literals.Add("identity", 79);
			this.literals.Add("option", 111);
			this.literals.Add("while", 170);
			this.literals.Add("rowcount", 135);
			this.literals.Add("end", 56);
			this.literals.Add("commit", 28);
			this.literals.Add("goto", 74);
			this.literals.Add("on", 105);
			this.literals.Add("create", 35);
			this.literals.Add("select", 140);
			this.literals.Add("authorization", 11);
			this.literals.Add("raiserror", 123);
			this.literals.Add("session_user", 141);
			this.literals.Add("order", 113);
			this.literals.Add("constraint", 30);
			this.literals.Add("tsequal", 157);
			this.literals.Add("where", 169);
			this.literals.Add("alter", 6);
			this.literals.Add("writetext", 172);
			this.literals.Add("asc", 10);
			this.literals.Add("double", 53);
			this.literals.Add("default", 47);
			this.literals.Add("trigger", 155);
			this.literals.Add("rollback", 134);
			this.literals.Add("group", 76);
			this.literals.Add("exit", 63);
			this.literals.Add("table", 148);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0001B81C File Offset: 0x00019A1C
		public override IToken nextToken()
		{
			IToken returnToken_34;
			for (;;)
			{
				this.resetText();
				try
				{
					char cached_LA = this.cached_LA1;
					switch (cached_LA)
					{
					case '\u0001':
					case '\u0002':
					case '\u0003':
					case '\u0004':
					case '\u0005':
					case '\u0006':
					case '\a':
					case '\b':
					case '\t':
					case '\n':
					case '\v':
					case '\f':
					case '\r':
					case '\u000e':
					case '\u000f':
					case '\u0010':
					case '\u0011':
					case '\u0012':
					case '\u0013':
					case '\u0014':
					case '\u0015':
					case '\u0016':
					case '\u0017':
					case '\u0018':
					case '\u0019':
					case '\u001a':
					case '\u001b':
					case '\u001c':
					case '\u001d':
					case '\u001e':
					case '\u001f':
					case ' ':
					{
						this.mWhiteSpace(true);
						IToken returnToken_ = this.returnToken_;
						goto IL_535;
					}
					case '!':
					{
						this.mBang(true);
						IToken returnToken_2 = this.returnToken_;
						goto IL_535;
					}
					case '"':
					case '[':
					{
						this.mQuotedIdentifier(true);
						IToken returnToken_3 = this.returnToken_;
						goto IL_535;
					}
					case '#':
					case '$':
					case '*':
					case '-':
					case '/':
					case ':':
					case '=':
					case '?':
					case 'A':
					case 'B':
					case 'C':
					case 'D':
					case 'E':
					case 'F':
					case 'G':
					case 'H':
					case 'I':
					case 'J':
					case 'K':
					case 'L':
					case 'M':
					case 'N':
					case 'O':
					case 'P':
					case 'Q':
					case 'R':
					case 'S':
					case 'T':
					case 'U':
					case 'V':
					case 'W':
					case 'X':
					case 'Y':
					case 'Z':
					case '\\':
					case ']':
						break;
					case '%':
					{
						this.mPercentSign(true);
						IToken returnToken_4 = this.returnToken_;
						goto IL_535;
					}
					case '&':
					{
						this.mAmpersand(true);
						IToken returnToken_5 = this.returnToken_;
						goto IL_535;
					}
					case '\'':
					{
						this.mAsciiStringLiteral(true);
						IToken returnToken_6 = this.returnToken_;
						goto IL_535;
					}
					case '(':
					{
						this.mLeftParenthesis(true);
						IToken returnToken_7 = this.returnToken_;
						goto IL_535;
					}
					case ')':
					{
						this.mRightParenthesis(true);
						IToken returnToken_8 = this.returnToken_;
						goto IL_535;
					}
					case '+':
					{
						this.mPlus(true);
						IToken returnToken_9 = this.returnToken_;
						goto IL_535;
					}
					case ',':
					{
						this.mComma(true);
						IToken returnToken_10 = this.returnToken_;
						goto IL_535;
					}
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					{
						this.mNumber(true);
						IToken returnToken_11 = this.returnToken_;
						goto IL_535;
					}
					case ';':
					{
						this.mProcNameSemicolon(true);
						IToken returnToken_12 = this.returnToken_;
						goto IL_535;
					}
					case '<':
					{
						this.mLessThan(true);
						IToken returnToken_13 = this.returnToken_;
						goto IL_535;
					}
					case '>':
					{
						this.mGreaterThan(true);
						IToken returnToken_14 = this.returnToken_;
						goto IL_535;
					}
					case '@':
					{
						this.mVariable(true);
						IToken returnToken_15 = this.returnToken_;
						goto IL_535;
					}
					case '^':
					{
						this.mCircumflex(true);
						IToken returnToken_16 = this.returnToken_;
						goto IL_535;
					}
					default:
						switch (cached_LA)
						{
						case '{':
						{
							this.mLeftCurly(true);
							IToken returnToken_17 = this.returnToken_;
							goto IL_535;
						}
						case '|':
						{
							this.mVerticalLine(true);
							IToken returnToken_18 = this.returnToken_;
							goto IL_535;
						}
						case '}':
						{
							this.mRightCurly(true);
							IToken returnToken_19 = this.returnToken_;
							goto IL_535;
						}
						case '~':
						{
							this.mTilde(true);
							IToken returnToken_20 = this.returnToken_;
							goto IL_535;
						}
						}
						break;
					}
					if (this.cached_LA1 == '*' && this.cached_LA2 == '=')
					{
						this.mMultiplyEquals(true);
						IToken returnToken_21 = this.returnToken_;
					}
					else if (this.cached_LA1 == ':' && this.cached_LA2 == ':')
					{
						this.mDoubleColon(true);
						IToken returnToken_22 = this.returnToken_;
					}
					else if (this.cached_LA1 == '=' && this.cached_LA2 == '*')
					{
						this.mRightOuterJoin(true);
						IToken returnToken_23 = this.returnToken_;
					}
					else if (this.cached_LA1 == 'g' && this.cached_LA2 == 'o' && base.CurrentOffset == this._acceptableGoOffset)
					{
						this.mGo(true);
						IToken returnToken_24 = this.returnToken_;
					}
					else if (this.cached_LA1 == 'n' && this.cached_LA2 == '\'')
					{
						this.mUnicodeStringLiteral(true);
						IToken returnToken_25 = this.returnToken_;
					}
					else if (this.cached_LA1 == '-' && this.cached_LA2 == '-')
					{
						this.mSingleLineComment(true);
						IToken returnToken_26 = this.returnToken_;
					}
					else if (this.cached_LA1 == '/' && this.cached_LA2 == '*')
					{
						this.mMultilineComment(true);
						IToken returnToken_27 = this.returnToken_;
					}
					else if (this.cached_LA1 == '*')
					{
						this.mStar(true);
						IToken returnToken_28 = this.returnToken_;
					}
					else if (this.cached_LA1 == '-')
					{
						this.mMinus(true);
						IToken returnToken_29 = this.returnToken_;
					}
					else if (this.cached_LA1 == '/')
					{
						this.mDivide(true);
						IToken returnToken_30 = this.returnToken_;
					}
					else if (this.cached_LA1 == ':')
					{
						this.mColon(true);
						IToken returnToken_31 = this.returnToken_;
					}
					else if (this.cached_LA1 == '=')
					{
						this.mEqualsSign(true);
						IToken returnToken_32 = this.returnToken_;
					}
					else if (TSql80LexerInternal.tokenSet_0_.member((int)this.cached_LA1))
					{
						this.mIdentifier(true);
						IToken returnToken_33 = this.returnToken_;
					}
					else
					{
						if (this.cached_LA1 != CharScanner.EOF_CHAR)
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.uponEOF();
						this.returnToken_ = this.makeToken(1);
					}
					IL_535:
					if (this.returnToken_ == null)
					{
						continue;
					}
					int type = this.returnToken_.Type;
					this.returnToken_.Type = type;
					returnToken_34 = this.returnToken_;
				}
				catch (RecognitionException re)
				{
					throw new TokenStreamRecognitionException(re);
				}
				break;
			}
			return returnToken_34;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		public void mBang(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 188;
			this.match('!');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001BE1C File Offset: 0x0001A01C
		public void mPercentSign(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 189;
			this.match('%');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001BE84 File Offset: 0x0001A084
		public void mAmpersand(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 190;
			this.match('&');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001BEEC File Offset: 0x0001A0EC
		public void mLeftParenthesis(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 191;
			this.match('(');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001BF54 File Offset: 0x0001A154
		public void mRightParenthesis(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 192;
			this.match(')');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0001BFBC File Offset: 0x0001A1BC
		public void mLeftCurly(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 193;
			this.match('{');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0001C024 File Offset: 0x0001A224
		public void mRightCurly(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 194;
			this.match('}');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001C08C File Offset: 0x0001A28C
		public void mStar(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 195;
			this.match('*');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
		public void mMultiplyEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 196;
			this.match("*=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001C15C File Offset: 0x0001A35C
		public void mPlus(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 197;
			this.match('+');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		public void mComma(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 198;
			this.match(',');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001C22C File Offset: 0x0001A42C
		public void mMinus(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 199;
			this.match('-');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001C294 File Offset: 0x0001A494
		protected void mDot(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 200;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001C2F4 File Offset: 0x0001A4F4
		public void mDivide(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 201;
			this.match('/');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001C35C File Offset: 0x0001A55C
		public void mColon(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 202;
			this.match(':');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
		public void mDoubleColon(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 203;
			this.match("::");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001C42C File Offset: 0x0001A62C
		public void mLessThan(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 205;
			this.match('<');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001C494 File Offset: 0x0001A694
		public void mEqualsSign(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 206;
			this.match('=');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0001C4FC File Offset: 0x0001A6FC
		public void mRightOuterJoin(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 207;
			this.match("=*");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001C564 File Offset: 0x0001A764
		public void mGreaterThan(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 208;
			this.match('>');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		public void mCircumflex(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 209;
			this.match('^');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0001C634 File Offset: 0x0001A834
		public void mVerticalLine(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 210;
			this.match('|');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001C69C File Offset: 0x0001A89C
		public void mTilde(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 211;
			this.match('~');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0001C704 File Offset: 0x0001A904
		protected void mSemicolon(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 204;
			this.match(';');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0001C76C File Offset: 0x0001A96C
		protected void mDigit(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 240;
			this.matchRange('0', '9');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
		protected void mFirstLetter(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 241;
			char cached_LA = this.cached_LA1;
			if (cached_LA != '#')
			{
				switch (cached_LA)
				{
				case '_':
					this.match('_');
					goto IL_108;
				case 'a':
				case 'b':
				case 'c':
				case 'd':
				case 'e':
				case 'f':
				case 'g':
				case 'h':
				case 'i':
				case 'j':
				case 'k':
				case 'l':
				case 'm':
				case 'n':
				case 'o':
				case 'p':
				case 'q':
				case 'r':
				case 's':
				case 't':
				case 'u':
				case 'v':
				case 'w':
				case 'x':
				case 'y':
				case 'z':
					this.matchRange('a', 'z');
					goto IL_108;
				}
				if (this.cached_LA1 < '\u0080' || this.cached_LA1 > '￾')
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.matchRange('\u0080', '￾');
			}
			else
			{
				this.match('#');
			}
			IL_108:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001C928 File Offset: 0x0001AB28
		protected void mLetter(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 242;
			char cached_LA = this.cached_LA1;
			switch (cached_LA)
			{
			case '#':
				this.match('#');
				break;
			case '$':
				this.match('$');
				break;
			default:
				if (cached_LA != '@')
				{
					switch (cached_LA)
					{
					case '_':
						this.match('_');
						goto IL_12D;
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
					case 'g':
					case 'h':
					case 'i':
					case 'j':
					case 'k':
					case 'l':
					case 'm':
					case 'n':
					case 'o':
					case 'p':
					case 'q':
					case 'r':
					case 's':
					case 't':
					case 'u':
					case 'v':
					case 'w':
					case 'x':
					case 'y':
					case 'z':
						this.matchRange('a', 'z');
						goto IL_12D;
					}
					if (this.cached_LA1 < '\u0080' || this.cached_LA1 > '￾')
					{
						throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
					}
					this.matchRange('\u0080', '￾');
				}
				else
				{
					this.match('@');
				}
				break;
			}
			IL_12D:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		protected void mMoneySign(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 243;
			char cached_LA = this.cached_LA1;
			if (cached_LA <= '¥')
			{
				if (cached_LA == '$')
				{
					this.match('$');
					goto IL_1C8;
				}
				switch (cached_LA)
				{
				case '£':
					this.match('£');
					goto IL_1C8;
				case '¤':
					this.match('¤');
					goto IL_1C8;
				case '¥':
					this.match('¥');
					goto IL_1C8;
				}
			}
			else
			{
				switch (cached_LA)
				{
				case '৲':
					this.match('৲');
					goto IL_1C8;
				case '৳':
					this.match('৳');
					goto IL_1C8;
				default:
					if (cached_LA == '฿')
					{
						this.match('฿');
						goto IL_1C8;
					}
					switch (cached_LA)
					{
					case '₡':
						this.match('₡');
						goto IL_1C8;
					case '₢':
						this.match('₢');
						goto IL_1C8;
					case '₣':
						this.match('₣');
						goto IL_1C8;
					case '₤':
						this.match('₤');
						goto IL_1C8;
					case '₦':
						this.match('₦');
						goto IL_1C8;
					case '₧':
						this.match('₧');
						goto IL_1C8;
					case '₨':
						this.match('₨');
						goto IL_1C8;
					case '₩':
						this.match('₩');
						goto IL_1C8;
					case '₪':
						this.match('₪');
						goto IL_1C8;
					case '₫':
						this.match('₫');
						goto IL_1C8;
					case '€':
						this.match('€');
						goto IL_1C8;
					}
					break;
				}
			}
			throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
			IL_1C8:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		public void mProcNameSemicolon(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 236;
			bool flag = false;
			if (this.cached_LA1 == ';')
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.mSemicolon(false);
					while (TSql80LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
					{
						this.mWS_CHAR_WO_NEWLINE(false);
					}
					this.mNumber(false);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.mSemicolon(false);
			}
			else
			{
				if (this.cached_LA1 != ';')
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.mSemicolon(false);
				if (this.inputState.guessing == 0)
				{
					num = 204;
				}
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		protected void mWS_CHAR_WO_NEWLINE(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 244;
			switch (this.cached_LA1)
			{
			case '\u0001':
				this.match('\u0001');
				goto IL_226;
			case '\u0002':
				this.match('\u0002');
				goto IL_226;
			case '\u0003':
				this.match('\u0003');
				goto IL_226;
			case '\u0004':
				this.match('\u0004');
				goto IL_226;
			case '\u0005':
				this.match('\u0005');
				goto IL_226;
			case '\u0006':
				this.match('\u0006');
				goto IL_226;
			case '\a':
				this.match('\a');
				goto IL_226;
			case '\b':
				this.match('\b');
				goto IL_226;
			case '\t':
				this.match('\t');
				goto IL_226;
			case '\v':
				this.match('\v');
				goto IL_226;
			case '\f':
				this.match('\f');
				goto IL_226;
			case '\u000e':
				this.match('\u000e');
				goto IL_226;
			case '\u000f':
				this.match('\u000f');
				goto IL_226;
			case '\u0010':
				this.match('\u0010');
				goto IL_226;
			case '\u0011':
				this.match('\u0011');
				goto IL_226;
			case '\u0012':
				this.match('\u0012');
				goto IL_226;
			case '\u0013':
				this.match('\u0013');
				goto IL_226;
			case '\u0014':
				this.match('\u0014');
				goto IL_226;
			case '\u0015':
				this.match('\u0015');
				goto IL_226;
			case '\u0016':
				this.match('\u0016');
				goto IL_226;
			case '\u0017':
				this.match('\u0017');
				goto IL_226;
			case '\u0018':
				this.match('\u0018');
				goto IL_226;
			case '\u0019':
				this.match('\u0019');
				goto IL_226;
			case '\u001a':
				this.match('\u001a');
				goto IL_226;
			case '\u001b':
				this.match('\u001b');
				goto IL_226;
			case '\u001c':
				this.match('\u001c');
				goto IL_226;
			case '\u001d':
				this.match('\u001d');
				goto IL_226;
			case '\u001e':
				this.match('\u001e');
				goto IL_226;
			case '\u001f':
				this.match('\u001f');
				goto IL_226;
			case ' ':
				this.match(' ');
				goto IL_226;
			}
			throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
			IL_226:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001D058 File Offset: 0x0001B258
		public void mNumber(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 245;
			if (this.cached_LA1 == '0' && this.cached_LA2 == 'x')
			{
				this.match("0x");
				for (;;)
				{
					char cached_LA = this.cached_LA1;
					switch (cached_LA)
					{
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						this.mDigit(false);
						break;
					default:
						switch (cached_LA)
						{
						case '\\':
							this.match('\\');
							this.mEndOfLine(false);
							continue;
						case 'a':
						case 'b':
						case 'c':
						case 'd':
						case 'e':
						case 'f':
							this.matchRange('a', 'f');
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				if (this.inputState.guessing == 0)
				{
					num = 224;
				}
			}
			else if (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
			{
				int num2 = 0;
				while (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
				{
					this.mDigit(false);
					num2++;
				}
				if (num2 < 1)
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				if (this.inputState.guessing == 0)
				{
					if (TSqlLexerBaseInternal.IsValueTooLargeForTokenInteger(this.text.ToString()))
					{
						num = 222;
					}
					else
					{
						num = 221;
					}
				}
				if (this.cached_LA1 == '.')
				{
					this.match('.');
					while (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
					{
						this.mDigit(false);
					}
					if (this.inputState.guessing == 0)
					{
						num = 222;
					}
				}
				if (this.cached_LA1 == 'e')
				{
					this.mExponent(false);
					if (this.inputState.guessing == 0)
					{
						num = 223;
					}
				}
			}
			else
			{
				if (this.cached_LA1 != '.')
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.match('.');
				if (this.inputState.guessing == 0)
				{
					num = 200;
				}
				if (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
				{
					int num3 = 0;
					while (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
					{
						this.mDigit(false);
						num3++;
					}
					if (num3 < 1)
					{
						throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
					}
					if (this.inputState.guessing == 0)
					{
						num = 222;
					}
					if (this.cached_LA1 == 'e')
					{
						this.mExponent(false);
						if (this.inputState.guessing == 0)
						{
							num = 223;
						}
					}
				}
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001D378 File Offset: 0x0001B578
		public void mWhiteSpace(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 239;
			bool flag = base.CurrentOffset == this._acceptableGoOffset;
			switch (this.cached_LA1)
			{
			case '\u0001':
			case '\u0002':
			case '\u0003':
			case '\u0004':
			case '\u0005':
			case '\u0006':
			case '\a':
			case '\b':
			case '\t':
			case '\v':
			case '\f':
			case '\u000e':
			case '\u000f':
			case '\u0010':
			case '\u0011':
			case '\u0012':
			case '\u0013':
			case '\u0014':
			case '\u0015':
			case '\u0016':
			case '\u0017':
			case '\u0018':
			case '\u0019':
			case '\u001a':
			case '\u001b':
			case '\u001c':
			case '\u001d':
			case '\u001e':
			case '\u001f':
			case ' ':
			{
				int num2 = 0;
				while (TSql80LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
				{
					this.mWS_CHAR_WO_NEWLINE(false);
					if (this.inputState.guessing == 0 && flag)
					{
						this._acceptableGoOffset = base.CurrentOffset;
					}
					num2++;
				}
				if (num2 < 1)
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				break;
			}
			case '\n':
			case '\r':
				this.mEndOfLine(false);
				if (this.inputState.guessing == 0)
				{
					this._acceptableGoOffset = base.CurrentOffset;
				}
				break;
			default:
				throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001D520 File Offset: 0x0001B720
		protected void mEndOfLine(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 247;
			if (this.cached_LA1 == '\r' && this.cached_LA2 == '\n')
			{
				this.match("\r\n");
			}
			else if (this.cached_LA1 == '\r')
			{
				this.match('\r');
			}
			else
			{
				if (this.cached_LA1 != '\n')
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.match('\n');
			}
			if (this.inputState.guessing == 0)
			{
				this.newline();
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		public void mGo(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 219;
			if (base.CurrentOffset != this._acceptableGoOffset)
			{
				throw new SemanticException(" CurrentOffset==_acceptableGoOffset ");
			}
			this.match("go");
			for (;;)
			{
				if (TSql80LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
				{
					this.mLetter(false);
					if (this.inputState.guessing == 0)
					{
						num = 232;
					}
				}
				else
				{
					if (this.cached_LA1 < '0' || this.cached_LA1 > '9')
					{
						break;
					}
					this.mDigit(false);
					if (this.inputState.guessing == 0)
					{
						num = 232;
					}
				}
			}
			bool flag = false;
			if (this.cached_LA1 == ':')
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.mColon(false);
					this.matchNot(':');
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.mColon(false);
				if (this.inputState.guessing == 0)
				{
					num = 220;
				}
			}
			num = this.testLiteralsTable(num);
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001D768 File Offset: 0x0001B968
		protected void mLabel(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 220;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		protected void mInteger(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 221;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001D828 File Offset: 0x0001BA28
		protected void mNumeric(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 222;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001D888 File Offset: 0x0001BA88
		protected void mReal(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 223;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
		protected void mHexLiteral(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 224;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001D948 File Offset: 0x0001BB48
		protected void mExponent(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 246;
			this.match('e');
			switch (this.cached_LA1)
			{
			case '+':
				this.match('+');
				break;
			case '-':
				this.match('-');
				break;
			}
			while (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
			{
				this.mDigit(false);
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		protected void mMoney(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 225;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		protected void mSqlCommandIdentifier(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 226;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0001DABC File Offset: 0x0001BCBC
		protected void mPseudoColumn(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 227;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001DB1C File Offset: 0x0001BD1C
		protected void mDollarPartition(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 228;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0001DB7C File Offset: 0x0001BD7C
		protected void mAsciiStringOrQuotedIdentifier(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 229;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0001DBDC File Offset: 0x0001BDDC
		public void mAsciiStringLiteral(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 230;
			if (this.inputState.guessing == 0)
			{
				base.beginComplexToken();
			}
			this.match('\'');
			for (;;)
			{
				if (this.cached_LA1 == '\'' && this.cached_LA2 == '\'')
				{
					this.match('\'');
					this.match('\'');
				}
				else if (TSql80LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql80LexerInternal.tokenSet_3_);
				}
				else
				{
					if (this.cached_LA1 != '\n' && this.cached_LA1 != '\r')
					{
						break;
					}
					this.mEndOfLine(false);
				}
			}
			this.match('\'');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001DCD4 File Offset: 0x0001BED4
		public void mUnicodeStringLiteral(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 231;
			if (this.inputState.guessing == 0)
			{
				base.beginComplexToken();
			}
			this.match('n');
			this.match('\'');
			for (;;)
			{
				if (this.cached_LA1 == '\'' && this.cached_LA2 == '\'')
				{
					this.match('\'');
					this.match('\'');
				}
				else if (TSql80LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql80LexerInternal.tokenSet_3_);
				}
				else
				{
					if (this.cached_LA1 != '\n' && this.cached_LA1 != '\r')
					{
						break;
					}
					this.mEndOfLine(false);
				}
			}
			this.match('\'');
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		public void mIdentifier(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 232;
			bool flag = false;
			if (this.cached_LA1 == '$' && this.cached_LA2 == '(')
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match('$');
					this.mLeftParenthesis(false);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				if (this.inputState.guessing == 0)
				{
					base.beginComplexToken();
				}
				this.match('$');
				this.mLeftParenthesis(false);
				int num2 = 0;
				for (;;)
				{
					if (TSql80LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.SqlCommandIdentifier);
						}
						this.match(TSql80LexerInternal.tokenSet_4_);
					}
					else
					{
						if (this.cached_LA1 != '\n' && this.cached_LA1 != '\r')
						{
							break;
						}
						this.mEndOfLine(false);
					}
					num2++;
				}
				if (num2 < 1)
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.mRightParenthesis(false);
				if (this.inputState.guessing == 0)
				{
					num = 226;
				}
			}
			else
			{
				bool flag2 = false;
				if (this.cached_LA1 == '$' && TSql80LexerInternal.tokenSet_5_.member((int)this.cached_LA2))
				{
					int pos2 = this.mark();
					flag2 = true;
					this.inputState.guessing++;
					try
					{
						this.match('$');
						if (this.cached_LA1 == '@')
						{
							this.match('@');
						}
						else
						{
							if (!TSql80LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
							{
								throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
							}
							this.mFirstLetter(false);
						}
					}
					catch (RecognitionException)
					{
						flag2 = false;
					}
					this.rewind(pos2);
					this.inputState.guessing--;
				}
				if (flag2)
				{
					this.match('$');
					if (this.cached_LA1 == '@')
					{
						this.match('@');
					}
					else
					{
						if (!TSql80LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
					}
					for (;;)
					{
						if (TSql80LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
						{
							this.mLetter(false);
						}
						else
						{
							if (this.cached_LA1 < '0' || this.cached_LA1 > '9')
							{
								break;
							}
							this.mDigit(false);
						}
					}
					if (this.inputState.guessing == 0)
					{
						if (string.Equals(this.text.ToString(), "$PARTITION", StringComparison.OrdinalIgnoreCase))
						{
							num = 228;
						}
						else
						{
							num = 227;
						}
					}
				}
				else
				{
					bool flag3 = false;
					if (TSql80LexerInternal.tokenSet_7_.member((int)this.cached_LA1) && TSql80LexerInternal.tokenSet_8_.member((int)this.cached_LA2))
					{
						int pos3 = this.mark();
						flag3 = true;
						this.inputState.guessing++;
						try
						{
							this.mMoneySign(false);
						}
						catch (RecognitionException)
						{
							flag3 = false;
						}
						this.rewind(pos3);
						this.inputState.guessing--;
					}
					if (flag3)
					{
						this.mMoneySign(false);
						while (this.cached_LA1 == ' ')
						{
							this.match(' ');
						}
						switch (this.cached_LA1)
						{
						case '+':
							this.mPlus(false);
							goto IL_3DE;
						case '-':
							this.mMinus(false);
							goto IL_3DE;
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							goto IL_3DE;
						}
						throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						IL_3DE:
						int num3 = 0;
						while (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
						{
							this.mDigit(false);
							num3++;
						}
						if (num3 < 1)
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						char cached_LA = this.cached_LA1;
						if (cached_LA != '.')
						{
							if (cached_LA == 'e')
							{
								this.mExponent(false);
							}
						}
						else
						{
							this.match('.');
							while (this.cached_LA1 >= '0' && this.cached_LA1 <= '9')
							{
								this.mDigit(false);
							}
							if (this.cached_LA1 == 'e')
							{
								this.mExponent(false);
							}
						}
						if (this.inputState.guessing == 0)
						{
							num = 225;
						}
					}
					else
					{
						if (!TSql80LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
						for (;;)
						{
							if (TSql80LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
							{
								this.mLetter(false);
							}
							else
							{
								if (this.cached_LA1 < '0' || this.cached_LA1 > '9')
								{
									break;
								}
								this.mDigit(false);
							}
						}
						bool flag4 = false;
						if (this.cached_LA1 == ':')
						{
							int pos4 = this.mark();
							flag4 = true;
							this.inputState.guessing++;
							try
							{
								this.mColon(false);
								this.matchNot(':');
							}
							catch (RecognitionException)
							{
								flag4 = false;
							}
							this.rewind(pos4);
							this.inputState.guessing--;
						}
						if (flag4)
						{
							this.mColon(false);
							if (this.inputState.guessing == 0)
							{
								num = 220;
							}
						}
					}
				}
			}
			num = this.testLiteralsTable(num);
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0001E3E4 File Offset: 0x0001C5E4
		public void mQuotedIdentifier(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 233;
			char cached_LA = this.cached_LA1;
			if (cached_LA != '"')
			{
				if (cached_LA != '[')
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				if (this.inputState.guessing == 0)
				{
					base.beginComplexToken();
				}
				this.match('[');
				int num2 = 0;
				for (;;)
				{
					if (this.cached_LA1 == ']' && this.cached_LA2 == ']')
					{
						this.match(']');
						this.match(']');
					}
					else if (TSql80LexerInternal.tokenSet_9_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql80LexerInternal.tokenSet_9_);
					}
					else
					{
						if (this.cached_LA1 != '\n' && this.cached_LA1 != '\r')
						{
							break;
						}
						this.mEndOfLine(false);
					}
					num2++;
				}
				if (num2 < 1)
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.match(']');
			}
			else
			{
				if (this.inputState.guessing == 0)
				{
					base.beginComplexToken();
				}
				this.match('"');
				for (;;)
				{
					if (this.cached_LA1 == '"' && this.cached_LA2 == '"')
					{
						this.match('"');
						this.match('"');
					}
					else if (TSql80LexerInternal.tokenSet_10_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql80LexerInternal.tokenSet_10_);
					}
					else
					{
						if (this.cached_LA1 != '\n' && this.cached_LA1 != '\r')
						{
							break;
						}
						this.mEndOfLine(false);
					}
				}
				if (this.inputState.guessing == 0)
				{
					if (this.text.Length > 1)
					{
						num = 229;
					}
					else
					{
						num = 230;
					}
				}
				this.match('"');
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001E608 File Offset: 0x0001C808
		public void mVariable(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 234;
			this.match('@');
			for (;;)
			{
				if (TSql80LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
				{
					this.mLetter(false);
				}
				else
				{
					if (this.cached_LA1 < '0' || this.cached_LA1 > '9')
					{
						break;
					}
					this.mDigit(false);
				}
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		protected void mOdbcInitiator(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 235;
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0001E708 File Offset: 0x0001C908
		public void mSingleLineComment(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 237;
			this.match("--");
			bool flag = false;
			if (this.cached_LA1 == '(' && this.cached_LA2 == '*')
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match('(');
					this.match('*');
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.match('(');
				this.match('*');
				if (this.inputState.guessing == 0)
				{
					num = 235;
				}
			}
			else
			{
				while (TSql80LexerInternal.tokenSet_11_.member((int)this.cached_LA1) && this.LA(1) != CharScanner.EOF_CHAR)
				{
					this.match(TSql80LexerInternal.tokenSet_11_);
				}
				if (this.inputState.guessing == 0)
				{
					this._acceptableGoOffset = base.CurrentOffset;
				}
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001E854 File Offset: 0x0001CA54
		public void mMultilineComment(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 238;
			bool flag = base.CurrentOffset == this._acceptableGoOffset;
			if (this.inputState.guessing == 0)
			{
				base.beginComplexToken();
			}
			this.match("/*");
			for (;;)
			{
				if (this.cached_LA1 == '*' && this.cached_LA2 >= '\0' && this.cached_LA2 <= '￿' && this.LA(2) != '/')
				{
					this.match('*');
				}
				else if (this.cached_LA1 == '/' && this.cached_LA2 >= '\0' && this.cached_LA2 <= '￿' && this.LA(2) != '*')
				{
					this.match('/');
				}
				else if (this.cached_LA1 == '/' && this.cached_LA2 == '*')
				{
					this.mMultilineComment(false);
				}
				else if (this.cached_LA1 == '\n' || this.cached_LA1 == '\r')
				{
					this.mEndOfLine(false);
				}
				else
				{
					if (!TSql80LexerInternal.tokenSet_12_.member((int)this.cached_LA1))
					{
						break;
					}
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.MultiLineComment);
					}
					this.match(TSql80LexerInternal.tokenSet_12_);
				}
			}
			this.match("*/");
			if (this.inputState.guessing == 0 && flag)
			{
				this._acceptableGoOffset = base.CurrentOffset;
			}
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
		private static long[] mk_tokenSet_0_()
		{
			long[] array = new long[3072];
			array[0] = 103079215104L;
			array[1] = 576460745860972544L;
			for (int i = 2; i <= 1022; i++)
			{
				array[i] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int j = 1024; j <= 3071; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0001EA58 File Offset: 0x0001CC58
		private static long[] mk_tokenSet_1_()
		{
			long[] array = new long[1025];
			array[0] = 8589925374L;
			for (int i = 1; i <= 1024; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001EA94 File Offset: 0x0001CC94
		private static long[] mk_tokenSet_2_()
		{
			long[] array = new long[3072];
			array[0] = 103079215104L;
			array[1] = 576460745860972545L;
			for (int i = 2; i <= 1022; i++)
			{
				array[i] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int j = 1024; j <= 3071; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0001EB04 File Offset: 0x0001CD04
		private static long[] mk_tokenSet_3_()
		{
			long[] array = new long[2048];
			array[0] = -549755823105L;
			for (int i = 1; i <= 1023; i++)
			{
				array[i] = -1L;
			}
			for (int j = 1024; j <= 2047; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0001EB58 File Offset: 0x0001CD58
		private static long[] mk_tokenSet_4_()
		{
			long[] array = new long[2048];
			array[0] = -2199023264769L;
			for (int i = 1; i <= 1023; i++)
			{
				array[i] = -1L;
			}
			for (int j = 1024; j <= 2047; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0001EBAC File Offset: 0x0001CDAC
		private static long[] mk_tokenSet_5_()
		{
			long[] array = new long[3072];
			array[0] = 34359738368L;
			array[1] = 576460745860972545L;
			for (int i = 2; i <= 1022; i++)
			{
				array[i] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int j = 1024; j <= 3071; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0001EC1C File Offset: 0x0001CE1C
		private static long[] mk_tokenSet_6_()
		{
			long[] array = new long[3072];
			array[0] = 34359738368L;
			array[1] = 576460745860972544L;
			for (int i = 2; i <= 1022; i++)
			{
				array[i] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int j = 1024; j <= 3071; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001EC8C File Offset: 0x0001CE8C
		private static long[] mk_tokenSet_7_()
		{
			long[] array = new long[1025];
			array[0] = 68719476736L;
			array[1] = 0L;
			array[2] = 240518168576L;
			for (int i = 3; i <= 38; i++)
			{
				array[i] = 0L;
			}
			array[39] = 3377699720527872L;
			for (int j = 40; j <= 55; j++)
			{
				array[j] = 0L;
			}
			array[56] = long.MinValue;
			for (int k = 57; k <= 129; k++)
			{
				array[k] = 0L;
			}
			array[130] = 35038343200768L;
			for (int l = 131; l <= 1024; l++)
			{
				array[l] = 0L;
			}
			return array;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0001ED48 File Offset: 0x0001CF48
		private static long[] mk_tokenSet_8_()
		{
			long[] array = new long[1025];
			array[0] = 287992885935079424L;
			for (int i = 1; i <= 1024; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001ED84 File Offset: 0x0001CF84
		private static long[] mk_tokenSet_9_()
		{
			long[] array = new long[2048];
			array[0] = -9217L;
			array[1] = -536870913L;
			for (int i = 2; i <= 1023; i++)
			{
				array[i] = -1L;
			}
			for (int j = 1024; j <= 2047; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		private static long[] mk_tokenSet_10_()
		{
			long[] array = new long[2048];
			array[0] = -17179878401L;
			for (int i = 1; i <= 1023; i++)
			{
				array[i] = -1L;
			}
			for (int j = 1024; j <= 2047; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0001EE34 File Offset: 0x0001D034
		private static long[] mk_tokenSet_11_()
		{
			long[] array = new long[2048];
			array[0] = -9217L;
			for (int i = 1; i <= 1023; i++)
			{
				array[i] = -1L;
			}
			for (int j = 1024; j <= 2047; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001EE84 File Offset: 0x0001D084
		private static long[] mk_tokenSet_12_()
		{
			long[] array = new long[2048];
			array[0] = -145135534875649L;
			for (int i = 1; i <= 1023; i++)
			{
				array[i] = -1L;
			}
			for (int j = 1024; j <= 2047; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x04000E6B RID: 3691
		public const int EOF = 1;

		// Token: 0x04000E6C RID: 3692
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x04000E6D RID: 3693
		public const int Add = 4;

		// Token: 0x04000E6E RID: 3694
		public const int All = 5;

		// Token: 0x04000E6F RID: 3695
		public const int Alter = 6;

		// Token: 0x04000E70 RID: 3696
		public const int And = 7;

		// Token: 0x04000E71 RID: 3697
		public const int Any = 8;

		// Token: 0x04000E72 RID: 3698
		public const int As = 9;

		// Token: 0x04000E73 RID: 3699
		public const int Asc = 10;

		// Token: 0x04000E74 RID: 3700
		public const int Authorization = 11;

		// Token: 0x04000E75 RID: 3701
		public const int Backup = 12;

		// Token: 0x04000E76 RID: 3702
		public const int Begin = 13;

		// Token: 0x04000E77 RID: 3703
		public const int Between = 14;

		// Token: 0x04000E78 RID: 3704
		public const int Break = 15;

		// Token: 0x04000E79 RID: 3705
		public const int Browse = 16;

		// Token: 0x04000E7A RID: 3706
		public const int Bulk = 17;

		// Token: 0x04000E7B RID: 3707
		public const int By = 18;

		// Token: 0x04000E7C RID: 3708
		public const int Cascade = 19;

		// Token: 0x04000E7D RID: 3709
		public const int Case = 20;

		// Token: 0x04000E7E RID: 3710
		public const int Check = 21;

		// Token: 0x04000E7F RID: 3711
		public const int Checkpoint = 22;

		// Token: 0x04000E80 RID: 3712
		public const int Close = 23;

		// Token: 0x04000E81 RID: 3713
		public const int Clustered = 24;

		// Token: 0x04000E82 RID: 3714
		public const int Coalesce = 25;

		// Token: 0x04000E83 RID: 3715
		public const int Collate = 26;

		// Token: 0x04000E84 RID: 3716
		public const int Column = 27;

		// Token: 0x04000E85 RID: 3717
		public const int Commit = 28;

		// Token: 0x04000E86 RID: 3718
		public const int Compute = 29;

		// Token: 0x04000E87 RID: 3719
		public const int Constraint = 30;

		// Token: 0x04000E88 RID: 3720
		public const int Contains = 31;

		// Token: 0x04000E89 RID: 3721
		public const int ContainsTable = 32;

		// Token: 0x04000E8A RID: 3722
		public const int Continue = 33;

		// Token: 0x04000E8B RID: 3723
		public const int Convert = 34;

		// Token: 0x04000E8C RID: 3724
		public const int Create = 35;

		// Token: 0x04000E8D RID: 3725
		public const int Cross = 36;

		// Token: 0x04000E8E RID: 3726
		public const int Current = 37;

		// Token: 0x04000E8F RID: 3727
		public const int CurrentDate = 38;

		// Token: 0x04000E90 RID: 3728
		public const int CurrentTime = 39;

		// Token: 0x04000E91 RID: 3729
		public const int CurrentTimestamp = 40;

		// Token: 0x04000E92 RID: 3730
		public const int CurrentUser = 41;

		// Token: 0x04000E93 RID: 3731
		public const int Cursor = 42;

		// Token: 0x04000E94 RID: 3732
		public const int Database = 43;

		// Token: 0x04000E95 RID: 3733
		public const int Dbcc = 44;

		// Token: 0x04000E96 RID: 3734
		public const int Deallocate = 45;

		// Token: 0x04000E97 RID: 3735
		public const int Declare = 46;

		// Token: 0x04000E98 RID: 3736
		public const int Default = 47;

		// Token: 0x04000E99 RID: 3737
		public const int Delete = 48;

		// Token: 0x04000E9A RID: 3738
		public const int Deny = 49;

		// Token: 0x04000E9B RID: 3739
		public const int Desc = 50;

		// Token: 0x04000E9C RID: 3740
		public const int Distinct = 51;

		// Token: 0x04000E9D RID: 3741
		public const int Distributed = 52;

		// Token: 0x04000E9E RID: 3742
		public const int Double = 53;

		// Token: 0x04000E9F RID: 3743
		public const int Drop = 54;

		// Token: 0x04000EA0 RID: 3744
		public const int Else = 55;

		// Token: 0x04000EA1 RID: 3745
		public const int End = 56;

		// Token: 0x04000EA2 RID: 3746
		public const int Errlvl = 57;

		// Token: 0x04000EA3 RID: 3747
		public const int Escape = 58;

		// Token: 0x04000EA4 RID: 3748
		public const int Except = 59;

		// Token: 0x04000EA5 RID: 3749
		public const int Exec = 60;

		// Token: 0x04000EA6 RID: 3750
		public const int Execute = 61;

		// Token: 0x04000EA7 RID: 3751
		public const int Exists = 62;

		// Token: 0x04000EA8 RID: 3752
		public const int Exit = 63;

		// Token: 0x04000EA9 RID: 3753
		public const int Fetch = 64;

		// Token: 0x04000EAA RID: 3754
		public const int File = 65;

		// Token: 0x04000EAB RID: 3755
		public const int FillFactor = 66;

		// Token: 0x04000EAC RID: 3756
		public const int For = 67;

		// Token: 0x04000EAD RID: 3757
		public const int Foreign = 68;

		// Token: 0x04000EAE RID: 3758
		public const int FreeText = 69;

		// Token: 0x04000EAF RID: 3759
		public const int FreeTextTable = 70;

		// Token: 0x04000EB0 RID: 3760
		public const int From = 71;

		// Token: 0x04000EB1 RID: 3761
		public const int Full = 72;

		// Token: 0x04000EB2 RID: 3762
		public const int Function = 73;

		// Token: 0x04000EB3 RID: 3763
		public const int GoTo = 74;

		// Token: 0x04000EB4 RID: 3764
		public const int Grant = 75;

		// Token: 0x04000EB5 RID: 3765
		public const int Group = 76;

		// Token: 0x04000EB6 RID: 3766
		public const int Having = 77;

		// Token: 0x04000EB7 RID: 3767
		public const int HoldLock = 78;

		// Token: 0x04000EB8 RID: 3768
		public const int Identity = 79;

		// Token: 0x04000EB9 RID: 3769
		public const int IdentityInsert = 80;

		// Token: 0x04000EBA RID: 3770
		public const int IdentityColumn = 81;

		// Token: 0x04000EBB RID: 3771
		public const int If = 82;

		// Token: 0x04000EBC RID: 3772
		public const int In = 83;

		// Token: 0x04000EBD RID: 3773
		public const int Index = 84;

		// Token: 0x04000EBE RID: 3774
		public const int Inner = 85;

		// Token: 0x04000EBF RID: 3775
		public const int Insert = 86;

		// Token: 0x04000EC0 RID: 3776
		public const int Intersect = 87;

		// Token: 0x04000EC1 RID: 3777
		public const int Into = 88;

		// Token: 0x04000EC2 RID: 3778
		public const int Is = 89;

		// Token: 0x04000EC3 RID: 3779
		public const int Join = 90;

		// Token: 0x04000EC4 RID: 3780
		public const int Key = 91;

		// Token: 0x04000EC5 RID: 3781
		public const int Kill = 92;

		// Token: 0x04000EC6 RID: 3782
		public const int Left = 93;

		// Token: 0x04000EC7 RID: 3783
		public const int Like = 94;

		// Token: 0x04000EC8 RID: 3784
		public const int LineNo = 95;

		// Token: 0x04000EC9 RID: 3785
		public const int National = 96;

		// Token: 0x04000ECA RID: 3786
		public const int NoCheck = 97;

		// Token: 0x04000ECB RID: 3787
		public const int NonClustered = 98;

		// Token: 0x04000ECC RID: 3788
		public const int Not = 99;

		// Token: 0x04000ECD RID: 3789
		public const int Null = 100;

		// Token: 0x04000ECE RID: 3790
		public const int NullIf = 101;

		// Token: 0x04000ECF RID: 3791
		public const int Of = 102;

		// Token: 0x04000ED0 RID: 3792
		public const int Off = 103;

		// Token: 0x04000ED1 RID: 3793
		public const int Offsets = 104;

		// Token: 0x04000ED2 RID: 3794
		public const int On = 105;

		// Token: 0x04000ED3 RID: 3795
		public const int Open = 106;

		// Token: 0x04000ED4 RID: 3796
		public const int OpenDataSource = 107;

		// Token: 0x04000ED5 RID: 3797
		public const int OpenQuery = 108;

		// Token: 0x04000ED6 RID: 3798
		public const int OpenRowSet = 109;

		// Token: 0x04000ED7 RID: 3799
		public const int OpenXml = 110;

		// Token: 0x04000ED8 RID: 3800
		public const int Option = 111;

		// Token: 0x04000ED9 RID: 3801
		public const int Or = 112;

		// Token: 0x04000EDA RID: 3802
		public const int Order = 113;

		// Token: 0x04000EDB RID: 3803
		public const int Outer = 114;

		// Token: 0x04000EDC RID: 3804
		public const int Over = 115;

		// Token: 0x04000EDD RID: 3805
		public const int Percent = 116;

		// Token: 0x04000EDE RID: 3806
		public const int Plan = 117;

		// Token: 0x04000EDF RID: 3807
		public const int Primary = 118;

		// Token: 0x04000EE0 RID: 3808
		public const int Print = 119;

		// Token: 0x04000EE1 RID: 3809
		public const int Proc = 120;

		// Token: 0x04000EE2 RID: 3810
		public const int Procedure = 121;

		// Token: 0x04000EE3 RID: 3811
		public const int Public = 122;

		// Token: 0x04000EE4 RID: 3812
		public const int Raiserror = 123;

		// Token: 0x04000EE5 RID: 3813
		public const int Read = 124;

		// Token: 0x04000EE6 RID: 3814
		public const int ReadText = 125;

		// Token: 0x04000EE7 RID: 3815
		public const int Reconfigure = 126;

		// Token: 0x04000EE8 RID: 3816
		public const int References = 127;

		// Token: 0x04000EE9 RID: 3817
		public const int Replication = 128;

		// Token: 0x04000EEA RID: 3818
		public const int Restore = 129;

		// Token: 0x04000EEB RID: 3819
		public const int Restrict = 130;

		// Token: 0x04000EEC RID: 3820
		public const int Return = 131;

		// Token: 0x04000EED RID: 3821
		public const int Revoke = 132;

		// Token: 0x04000EEE RID: 3822
		public const int Right = 133;

		// Token: 0x04000EEF RID: 3823
		public const int Rollback = 134;

		// Token: 0x04000EF0 RID: 3824
		public const int RowCount = 135;

		// Token: 0x04000EF1 RID: 3825
		public const int RowGuidColumn = 136;

		// Token: 0x04000EF2 RID: 3826
		public const int Rule = 137;

		// Token: 0x04000EF3 RID: 3827
		public const int Save = 138;

		// Token: 0x04000EF4 RID: 3828
		public const int Schema = 139;

		// Token: 0x04000EF5 RID: 3829
		public const int Select = 140;

		// Token: 0x04000EF6 RID: 3830
		public const int SessionUser = 141;

		// Token: 0x04000EF7 RID: 3831
		public const int Set = 142;

		// Token: 0x04000EF8 RID: 3832
		public const int SetUser = 143;

		// Token: 0x04000EF9 RID: 3833
		public const int Shutdown = 144;

		// Token: 0x04000EFA RID: 3834
		public const int Some = 145;

		// Token: 0x04000EFB RID: 3835
		public const int Statistics = 146;

		// Token: 0x04000EFC RID: 3836
		public const int SystemUser = 147;

		// Token: 0x04000EFD RID: 3837
		public const int Table = 148;

		// Token: 0x04000EFE RID: 3838
		public const int TextSize = 149;

		// Token: 0x04000EFF RID: 3839
		public const int Then = 150;

		// Token: 0x04000F00 RID: 3840
		public const int To = 151;

		// Token: 0x04000F01 RID: 3841
		public const int Top = 152;

		// Token: 0x04000F02 RID: 3842
		public const int Tran = 153;

		// Token: 0x04000F03 RID: 3843
		public const int Transaction = 154;

		// Token: 0x04000F04 RID: 3844
		public const int Trigger = 155;

		// Token: 0x04000F05 RID: 3845
		public const int Truncate = 156;

		// Token: 0x04000F06 RID: 3846
		public const int TSEqual = 157;

		// Token: 0x04000F07 RID: 3847
		public const int Union = 158;

		// Token: 0x04000F08 RID: 3848
		public const int Unique = 159;

		// Token: 0x04000F09 RID: 3849
		public const int Update = 160;

		// Token: 0x04000F0A RID: 3850
		public const int UpdateText = 161;

		// Token: 0x04000F0B RID: 3851
		public const int Use = 162;

		// Token: 0x04000F0C RID: 3852
		public const int User = 163;

		// Token: 0x04000F0D RID: 3853
		public const int Values = 164;

		// Token: 0x04000F0E RID: 3854
		public const int Varying = 165;

		// Token: 0x04000F0F RID: 3855
		public const int View = 166;

		// Token: 0x04000F10 RID: 3856
		public const int WaitFor = 167;

		// Token: 0x04000F11 RID: 3857
		public const int When = 168;

		// Token: 0x04000F12 RID: 3858
		public const int Where = 169;

		// Token: 0x04000F13 RID: 3859
		public const int While = 170;

		// Token: 0x04000F14 RID: 3860
		public const int With = 171;

		// Token: 0x04000F15 RID: 3861
		public const int WriteText = 172;

		// Token: 0x04000F16 RID: 3862
		public const int Disk = 173;

		// Token: 0x04000F17 RID: 3863
		public const int Precision = 174;

		// Token: 0x04000F18 RID: 3864
		public const int External = 175;

		// Token: 0x04000F19 RID: 3865
		public const int Revert = 176;

		// Token: 0x04000F1A RID: 3866
		public const int Pivot = 177;

		// Token: 0x04000F1B RID: 3867
		public const int Unpivot = 178;

		// Token: 0x04000F1C RID: 3868
		public const int TableSample = 179;

		// Token: 0x04000F1D RID: 3869
		public const int Dump = 180;

		// Token: 0x04000F1E RID: 3870
		public const int Load = 181;

		// Token: 0x04000F1F RID: 3871
		public const int Merge = 182;

		// Token: 0x04000F20 RID: 3872
		public const int StopList = 183;

		// Token: 0x04000F21 RID: 3873
		public const int SemanticKeyPhraseTable = 184;

		// Token: 0x04000F22 RID: 3874
		public const int SemanticSimilarityTable = 185;

		// Token: 0x04000F23 RID: 3875
		public const int SemanticSimilarityDetailsTable = 186;

		// Token: 0x04000F24 RID: 3876
		public const int TryConvert = 187;

		// Token: 0x04000F25 RID: 3877
		public const int Bang = 188;

		// Token: 0x04000F26 RID: 3878
		public const int PercentSign = 189;

		// Token: 0x04000F27 RID: 3879
		public const int Ampersand = 190;

		// Token: 0x04000F28 RID: 3880
		public const int LeftParenthesis = 191;

		// Token: 0x04000F29 RID: 3881
		public const int RightParenthesis = 192;

		// Token: 0x04000F2A RID: 3882
		public const int LeftCurly = 193;

		// Token: 0x04000F2B RID: 3883
		public const int RightCurly = 194;

		// Token: 0x04000F2C RID: 3884
		public const int Star = 195;

		// Token: 0x04000F2D RID: 3885
		public const int MultiplyEquals = 196;

		// Token: 0x04000F2E RID: 3886
		public const int Plus = 197;

		// Token: 0x04000F2F RID: 3887
		public const int Comma = 198;

		// Token: 0x04000F30 RID: 3888
		public const int Minus = 199;

		// Token: 0x04000F31 RID: 3889
		public const int Dot = 200;

		// Token: 0x04000F32 RID: 3890
		public const int Divide = 201;

		// Token: 0x04000F33 RID: 3891
		public const int Colon = 202;

		// Token: 0x04000F34 RID: 3892
		public const int DoubleColon = 203;

		// Token: 0x04000F35 RID: 3893
		public const int Semicolon = 204;

		// Token: 0x04000F36 RID: 3894
		public const int LessThan = 205;

		// Token: 0x04000F37 RID: 3895
		public const int EqualsSign = 206;

		// Token: 0x04000F38 RID: 3896
		public const int RightOuterJoin = 207;

		// Token: 0x04000F39 RID: 3897
		public const int GreaterThan = 208;

		// Token: 0x04000F3A RID: 3898
		public const int Circumflex = 209;

		// Token: 0x04000F3B RID: 3899
		public const int VerticalLine = 210;

		// Token: 0x04000F3C RID: 3900
		public const int Tilde = 211;

		// Token: 0x04000F3D RID: 3901
		public const int AddEquals = 212;

		// Token: 0x04000F3E RID: 3902
		public const int SubtractEquals = 213;

		// Token: 0x04000F3F RID: 3903
		public const int DivideEquals = 214;

		// Token: 0x04000F40 RID: 3904
		public const int ModEquals = 215;

		// Token: 0x04000F41 RID: 3905
		public const int BitwiseAndEquals = 216;

		// Token: 0x04000F42 RID: 3906
		public const int BitwiseOrEquals = 217;

		// Token: 0x04000F43 RID: 3907
		public const int BitwiseXorEquals = 218;

		// Token: 0x04000F44 RID: 3908
		public const int Go = 219;

		// Token: 0x04000F45 RID: 3909
		public const int Label = 220;

		// Token: 0x04000F46 RID: 3910
		public const int Integer = 221;

		// Token: 0x04000F47 RID: 3911
		public const int Numeric = 222;

		// Token: 0x04000F48 RID: 3912
		public const int Real = 223;

		// Token: 0x04000F49 RID: 3913
		public const int HexLiteral = 224;

		// Token: 0x04000F4A RID: 3914
		public const int Money = 225;

		// Token: 0x04000F4B RID: 3915
		public const int SqlCommandIdentifier = 226;

		// Token: 0x04000F4C RID: 3916
		public const int PseudoColumn = 227;

		// Token: 0x04000F4D RID: 3917
		public const int DollarPartition = 228;

		// Token: 0x04000F4E RID: 3918
		public const int AsciiStringOrQuotedIdentifier = 229;

		// Token: 0x04000F4F RID: 3919
		public const int AsciiStringLiteral = 230;

		// Token: 0x04000F50 RID: 3920
		public const int UnicodeStringLiteral = 231;

		// Token: 0x04000F51 RID: 3921
		public const int Identifier = 232;

		// Token: 0x04000F52 RID: 3922
		public const int QuotedIdentifier = 233;

		// Token: 0x04000F53 RID: 3923
		public const int Variable = 234;

		// Token: 0x04000F54 RID: 3924
		public const int OdbcInitiator = 235;

		// Token: 0x04000F55 RID: 3925
		public const int ProcNameSemicolon = 236;

		// Token: 0x04000F56 RID: 3926
		public const int SingleLineComment = 237;

		// Token: 0x04000F57 RID: 3927
		public const int MultilineComment = 238;

		// Token: 0x04000F58 RID: 3928
		public const int WhiteSpace = 239;

		// Token: 0x04000F59 RID: 3929
		public const int Digit = 240;

		// Token: 0x04000F5A RID: 3930
		public const int FirstLetter = 241;

		// Token: 0x04000F5B RID: 3931
		public const int Letter = 242;

		// Token: 0x04000F5C RID: 3932
		public const int MoneySign = 243;

		// Token: 0x04000F5D RID: 3933
		public const int WS_CHAR_WO_NEWLINE = 244;

		// Token: 0x04000F5E RID: 3934
		public const int Number = 245;

		// Token: 0x04000F5F RID: 3935
		public const int Exponent = 246;

		// Token: 0x04000F60 RID: 3936
		public const int EndOfLine = 247;

		// Token: 0x04000F61 RID: 3937
		public static readonly BitSet tokenSet_0_ = new BitSet(TSql80LexerInternal.mk_tokenSet_0_());

		// Token: 0x04000F62 RID: 3938
		public static readonly BitSet tokenSet_1_ = new BitSet(TSql80LexerInternal.mk_tokenSet_1_());

		// Token: 0x04000F63 RID: 3939
		public static readonly BitSet tokenSet_2_ = new BitSet(TSql80LexerInternal.mk_tokenSet_2_());

		// Token: 0x04000F64 RID: 3940
		public static readonly BitSet tokenSet_3_ = new BitSet(TSql80LexerInternal.mk_tokenSet_3_());

		// Token: 0x04000F65 RID: 3941
		public static readonly BitSet tokenSet_4_ = new BitSet(TSql80LexerInternal.mk_tokenSet_4_());

		// Token: 0x04000F66 RID: 3942
		public static readonly BitSet tokenSet_5_ = new BitSet(TSql80LexerInternal.mk_tokenSet_5_());

		// Token: 0x04000F67 RID: 3943
		public static readonly BitSet tokenSet_6_ = new BitSet(TSql80LexerInternal.mk_tokenSet_6_());

		// Token: 0x04000F68 RID: 3944
		public static readonly BitSet tokenSet_7_ = new BitSet(TSql80LexerInternal.mk_tokenSet_7_());

		// Token: 0x04000F69 RID: 3945
		public static readonly BitSet tokenSet_8_ = new BitSet(TSql80LexerInternal.mk_tokenSet_8_());

		// Token: 0x04000F6A RID: 3946
		public static readonly BitSet tokenSet_9_ = new BitSet(TSql80LexerInternal.mk_tokenSet_9_());

		// Token: 0x04000F6B RID: 3947
		public static readonly BitSet tokenSet_10_ = new BitSet(TSql80LexerInternal.mk_tokenSet_10_());

		// Token: 0x04000F6C RID: 3948
		public static readonly BitSet tokenSet_11_ = new BitSet(TSql80LexerInternal.mk_tokenSet_11_());

		// Token: 0x04000F6D RID: 3949
		public static readonly BitSet tokenSet_12_ = new BitSet(TSql80LexerInternal.mk_tokenSet_12_());
	}
}
