using System;
using System.Collections;
using System.IO;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B4 RID: 436
	internal class TSql90LexerInternal : TSqlLexerBaseInternal, TokenStream
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x0003707A File Offset: 0x0003527A
		public TSql90LexerInternal() : this(new StringReader(string.Empty))
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0003708C File Offset: 0x0003528C
		public TSql90LexerInternal(Stream ins) : this(new ByteBuffer(ins))
		{
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0003709A File Offset: 0x0003529A
		public TSql90LexerInternal(TextReader r) : this(new CharBuffer(r))
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x000370A8 File Offset: 0x000352A8
		public TSql90LexerInternal(InputBuffer ib) : this(new LexerSharedInputState(ib))
		{
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x000370B6 File Offset: 0x000352B6
		public TSql90LexerInternal(LexerSharedInputState state) : base(state)
		{
			this.initialize();
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x000370C8 File Offset: 0x000352C8
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
			this.literals.Add("pivot", 177);
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
			this.literals.Add("external", 175);
			this.literals.Add("execute", 61);
			this.literals.Add("reconfigure", 126);
			this.literals.Add("transaction", 154);
			this.literals.Add("proc", 120);
			this.literals.Add("tablesample", 179);
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
			this.literals.Add("unpivot", 178);
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
			this.literals.Add("revert", 176);
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

		// Token: 0x060010DB RID: 4315 RVA: 0x00038164 File Offset: 0x00036364
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
					else if (TSql90LexerInternal.tokenSet_0_.member((int)this.cached_LA1))
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

		// Token: 0x060010DC RID: 4316 RVA: 0x000386FC File Offset: 0x000368FC
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

		// Token: 0x060010DD RID: 4317 RVA: 0x00038764 File Offset: 0x00036964
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

		// Token: 0x060010DE RID: 4318 RVA: 0x000387CC File Offset: 0x000369CC
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

		// Token: 0x060010DF RID: 4319 RVA: 0x00038834 File Offset: 0x00036A34
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

		// Token: 0x060010E0 RID: 4320 RVA: 0x0003889C File Offset: 0x00036A9C
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

		// Token: 0x060010E1 RID: 4321 RVA: 0x00038904 File Offset: 0x00036B04
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

		// Token: 0x060010E2 RID: 4322 RVA: 0x0003896C File Offset: 0x00036B6C
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

		// Token: 0x060010E3 RID: 4323 RVA: 0x000389D4 File Offset: 0x00036BD4
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

		// Token: 0x060010E4 RID: 4324 RVA: 0x00038A3C File Offset: 0x00036C3C
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

		// Token: 0x060010E5 RID: 4325 RVA: 0x00038AA4 File Offset: 0x00036CA4
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

		// Token: 0x060010E6 RID: 4326 RVA: 0x00038B0C File Offset: 0x00036D0C
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

		// Token: 0x060010E7 RID: 4327 RVA: 0x00038B74 File Offset: 0x00036D74
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

		// Token: 0x060010E8 RID: 4328 RVA: 0x00038BDC File Offset: 0x00036DDC
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

		// Token: 0x060010E9 RID: 4329 RVA: 0x00038C3C File Offset: 0x00036E3C
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

		// Token: 0x060010EA RID: 4330 RVA: 0x00038CA4 File Offset: 0x00036EA4
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

		// Token: 0x060010EB RID: 4331 RVA: 0x00038D0C File Offset: 0x00036F0C
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

		// Token: 0x060010EC RID: 4332 RVA: 0x00038D74 File Offset: 0x00036F74
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

		// Token: 0x060010ED RID: 4333 RVA: 0x00038DDC File Offset: 0x00036FDC
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

		// Token: 0x060010EE RID: 4334 RVA: 0x00038E44 File Offset: 0x00037044
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

		// Token: 0x060010EF RID: 4335 RVA: 0x00038EAC File Offset: 0x000370AC
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

		// Token: 0x060010F0 RID: 4336 RVA: 0x00038F14 File Offset: 0x00037114
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

		// Token: 0x060010F1 RID: 4337 RVA: 0x00038F7C File Offset: 0x0003717C
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

		// Token: 0x060010F2 RID: 4338 RVA: 0x00038FE4 File Offset: 0x000371E4
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

		// Token: 0x060010F3 RID: 4339 RVA: 0x0003904C File Offset: 0x0003724C
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

		// Token: 0x060010F4 RID: 4340 RVA: 0x000390B4 File Offset: 0x000372B4
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

		// Token: 0x060010F5 RID: 4341 RVA: 0x0003911C File Offset: 0x0003731C
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

		// Token: 0x060010F6 RID: 4342 RVA: 0x00039270 File Offset: 0x00037470
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

		// Token: 0x060010F7 RID: 4343 RVA: 0x000393E8 File Offset: 0x000375E8
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

		// Token: 0x060010F8 RID: 4344 RVA: 0x000395FC File Offset: 0x000377FC
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
					while (TSql90LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
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

		// Token: 0x060010F9 RID: 4345 RVA: 0x00039730 File Offset: 0x00037930
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

		// Token: 0x060010FA RID: 4346 RVA: 0x000399A0 File Offset: 0x00037BA0
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

		// Token: 0x060010FB RID: 4347 RVA: 0x00039CC0 File Offset: 0x00037EC0
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
				while (TSql90LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
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

		// Token: 0x060010FC RID: 4348 RVA: 0x00039E68 File Offset: 0x00038068
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

		// Token: 0x060010FD RID: 4349 RVA: 0x00039F40 File Offset: 0x00038140
		public void mGo(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 219;
			if (base.CurrentOffset != this._acceptableGoOffset)
			{
				throw new SemanticException(" (CurrentOffset==_acceptableGoOffset) ");
			}
			this.match("go");
			for (;;)
			{
				if (TSql90LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x060010FE RID: 4350 RVA: 0x0003A0B0 File Offset: 0x000382B0
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

		// Token: 0x060010FF RID: 4351 RVA: 0x0003A110 File Offset: 0x00038310
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

		// Token: 0x06001100 RID: 4352 RVA: 0x0003A170 File Offset: 0x00038370
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

		// Token: 0x06001101 RID: 4353 RVA: 0x0003A1D0 File Offset: 0x000383D0
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

		// Token: 0x06001102 RID: 4354 RVA: 0x0003A230 File Offset: 0x00038430
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

		// Token: 0x06001103 RID: 4355 RVA: 0x0003A290 File Offset: 0x00038490
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

		// Token: 0x06001104 RID: 4356 RVA: 0x0003A344 File Offset: 0x00038544
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

		// Token: 0x06001105 RID: 4357 RVA: 0x0003A3A4 File Offset: 0x000385A4
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

		// Token: 0x06001106 RID: 4358 RVA: 0x0003A404 File Offset: 0x00038604
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

		// Token: 0x06001107 RID: 4359 RVA: 0x0003A464 File Offset: 0x00038664
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

		// Token: 0x06001108 RID: 4360 RVA: 0x0003A4C4 File Offset: 0x000386C4
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

		// Token: 0x06001109 RID: 4361 RVA: 0x0003A524 File Offset: 0x00038724
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
				else if (TSql90LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql90LexerInternal.tokenSet_3_);
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

		// Token: 0x0600110A RID: 4362 RVA: 0x0003A61C File Offset: 0x0003881C
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
				else if (TSql90LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql90LexerInternal.tokenSet_3_);
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

		// Token: 0x0600110B RID: 4363 RVA: 0x0003A71C File Offset: 0x0003891C
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
					if (TSql90LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.SqlCommandIdentifier);
						}
						this.match(TSql90LexerInternal.tokenSet_4_);
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
				if (this.cached_LA1 == '$' && TSql90LexerInternal.tokenSet_5_.member((int)this.cached_LA2))
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
							if (!TSql90LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
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
						if (!TSql90LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
					}
					for (;;)
					{
						if (TSql90LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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
					if (TSql90LexerInternal.tokenSet_7_.member((int)this.cached_LA1) && TSql90LexerInternal.tokenSet_8_.member((int)this.cached_LA2))
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
						if (!TSql90LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
						for (;;)
						{
							if (TSql90LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600110C RID: 4364 RVA: 0x0003AD2C File Offset: 0x00038F2C
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
					else if (TSql90LexerInternal.tokenSet_9_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql90LexerInternal.tokenSet_9_);
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
					else if (TSql90LexerInternal.tokenSet_10_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql90LexerInternal.tokenSet_10_);
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

		// Token: 0x0600110D RID: 4365 RVA: 0x0003AF50 File Offset: 0x00039150
		public void mVariable(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 234;
			this.match('@');
			for (;;)
			{
				if (TSql90LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600110E RID: 4366 RVA: 0x0003AFF0 File Offset: 0x000391F0
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

		// Token: 0x0600110F RID: 4367 RVA: 0x0003B050 File Offset: 0x00039250
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
				while (TSql90LexerInternal.tokenSet_11_.member((int)this.cached_LA1) && this.LA(1) != CharScanner.EOF_CHAR)
				{
					this.match(TSql90LexerInternal.tokenSet_11_);
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

		// Token: 0x06001110 RID: 4368 RVA: 0x0003B19C File Offset: 0x0003939C
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
					if (!TSql90LexerInternal.tokenSet_12_.member((int)this.cached_LA1))
					{
						break;
					}
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.MultiLineComment);
					}
					this.match(TSql90LexerInternal.tokenSet_12_);
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

		// Token: 0x06001111 RID: 4369 RVA: 0x0003B330 File Offset: 0x00039530
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

		// Token: 0x06001112 RID: 4370 RVA: 0x0003B3A0 File Offset: 0x000395A0
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

		// Token: 0x06001113 RID: 4371 RVA: 0x0003B3DC File Offset: 0x000395DC
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

		// Token: 0x06001114 RID: 4372 RVA: 0x0003B44C File Offset: 0x0003964C
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

		// Token: 0x06001115 RID: 4373 RVA: 0x0003B4A0 File Offset: 0x000396A0
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

		// Token: 0x06001116 RID: 4374 RVA: 0x0003B4F4 File Offset: 0x000396F4
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

		// Token: 0x06001117 RID: 4375 RVA: 0x0003B564 File Offset: 0x00039764
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

		// Token: 0x06001118 RID: 4376 RVA: 0x0003B5D4 File Offset: 0x000397D4
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

		// Token: 0x06001119 RID: 4377 RVA: 0x0003B690 File Offset: 0x00039890
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

		// Token: 0x0600111A RID: 4378 RVA: 0x0003B6CC File Offset: 0x000398CC
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

		// Token: 0x0600111B RID: 4379 RVA: 0x0003B728 File Offset: 0x00039928
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

		// Token: 0x0600111C RID: 4380 RVA: 0x0003B77C File Offset: 0x0003997C
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

		// Token: 0x0600111D RID: 4381 RVA: 0x0003B7CC File Offset: 0x000399CC
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

		// Token: 0x0400117C RID: 4476
		public const int EOF = 1;

		// Token: 0x0400117D RID: 4477
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x0400117E RID: 4478
		public const int Add = 4;

		// Token: 0x0400117F RID: 4479
		public const int All = 5;

		// Token: 0x04001180 RID: 4480
		public const int Alter = 6;

		// Token: 0x04001181 RID: 4481
		public const int And = 7;

		// Token: 0x04001182 RID: 4482
		public const int Any = 8;

		// Token: 0x04001183 RID: 4483
		public const int As = 9;

		// Token: 0x04001184 RID: 4484
		public const int Asc = 10;

		// Token: 0x04001185 RID: 4485
		public const int Authorization = 11;

		// Token: 0x04001186 RID: 4486
		public const int Backup = 12;

		// Token: 0x04001187 RID: 4487
		public const int Begin = 13;

		// Token: 0x04001188 RID: 4488
		public const int Between = 14;

		// Token: 0x04001189 RID: 4489
		public const int Break = 15;

		// Token: 0x0400118A RID: 4490
		public const int Browse = 16;

		// Token: 0x0400118B RID: 4491
		public const int Bulk = 17;

		// Token: 0x0400118C RID: 4492
		public const int By = 18;

		// Token: 0x0400118D RID: 4493
		public const int Cascade = 19;

		// Token: 0x0400118E RID: 4494
		public const int Case = 20;

		// Token: 0x0400118F RID: 4495
		public const int Check = 21;

		// Token: 0x04001190 RID: 4496
		public const int Checkpoint = 22;

		// Token: 0x04001191 RID: 4497
		public const int Close = 23;

		// Token: 0x04001192 RID: 4498
		public const int Clustered = 24;

		// Token: 0x04001193 RID: 4499
		public const int Coalesce = 25;

		// Token: 0x04001194 RID: 4500
		public const int Collate = 26;

		// Token: 0x04001195 RID: 4501
		public const int Column = 27;

		// Token: 0x04001196 RID: 4502
		public const int Commit = 28;

		// Token: 0x04001197 RID: 4503
		public const int Compute = 29;

		// Token: 0x04001198 RID: 4504
		public const int Constraint = 30;

		// Token: 0x04001199 RID: 4505
		public const int Contains = 31;

		// Token: 0x0400119A RID: 4506
		public const int ContainsTable = 32;

		// Token: 0x0400119B RID: 4507
		public const int Continue = 33;

		// Token: 0x0400119C RID: 4508
		public const int Convert = 34;

		// Token: 0x0400119D RID: 4509
		public const int Create = 35;

		// Token: 0x0400119E RID: 4510
		public const int Cross = 36;

		// Token: 0x0400119F RID: 4511
		public const int Current = 37;

		// Token: 0x040011A0 RID: 4512
		public const int CurrentDate = 38;

		// Token: 0x040011A1 RID: 4513
		public const int CurrentTime = 39;

		// Token: 0x040011A2 RID: 4514
		public const int CurrentTimestamp = 40;

		// Token: 0x040011A3 RID: 4515
		public const int CurrentUser = 41;

		// Token: 0x040011A4 RID: 4516
		public const int Cursor = 42;

		// Token: 0x040011A5 RID: 4517
		public const int Database = 43;

		// Token: 0x040011A6 RID: 4518
		public const int Dbcc = 44;

		// Token: 0x040011A7 RID: 4519
		public const int Deallocate = 45;

		// Token: 0x040011A8 RID: 4520
		public const int Declare = 46;

		// Token: 0x040011A9 RID: 4521
		public const int Default = 47;

		// Token: 0x040011AA RID: 4522
		public const int Delete = 48;

		// Token: 0x040011AB RID: 4523
		public const int Deny = 49;

		// Token: 0x040011AC RID: 4524
		public const int Desc = 50;

		// Token: 0x040011AD RID: 4525
		public const int Distinct = 51;

		// Token: 0x040011AE RID: 4526
		public const int Distributed = 52;

		// Token: 0x040011AF RID: 4527
		public const int Double = 53;

		// Token: 0x040011B0 RID: 4528
		public const int Drop = 54;

		// Token: 0x040011B1 RID: 4529
		public const int Else = 55;

		// Token: 0x040011B2 RID: 4530
		public const int End = 56;

		// Token: 0x040011B3 RID: 4531
		public const int Errlvl = 57;

		// Token: 0x040011B4 RID: 4532
		public const int Escape = 58;

		// Token: 0x040011B5 RID: 4533
		public const int Except = 59;

		// Token: 0x040011B6 RID: 4534
		public const int Exec = 60;

		// Token: 0x040011B7 RID: 4535
		public const int Execute = 61;

		// Token: 0x040011B8 RID: 4536
		public const int Exists = 62;

		// Token: 0x040011B9 RID: 4537
		public const int Exit = 63;

		// Token: 0x040011BA RID: 4538
		public const int Fetch = 64;

		// Token: 0x040011BB RID: 4539
		public const int File = 65;

		// Token: 0x040011BC RID: 4540
		public const int FillFactor = 66;

		// Token: 0x040011BD RID: 4541
		public const int For = 67;

		// Token: 0x040011BE RID: 4542
		public const int Foreign = 68;

		// Token: 0x040011BF RID: 4543
		public const int FreeText = 69;

		// Token: 0x040011C0 RID: 4544
		public const int FreeTextTable = 70;

		// Token: 0x040011C1 RID: 4545
		public const int From = 71;

		// Token: 0x040011C2 RID: 4546
		public const int Full = 72;

		// Token: 0x040011C3 RID: 4547
		public const int Function = 73;

		// Token: 0x040011C4 RID: 4548
		public const int GoTo = 74;

		// Token: 0x040011C5 RID: 4549
		public const int Grant = 75;

		// Token: 0x040011C6 RID: 4550
		public const int Group = 76;

		// Token: 0x040011C7 RID: 4551
		public const int Having = 77;

		// Token: 0x040011C8 RID: 4552
		public const int HoldLock = 78;

		// Token: 0x040011C9 RID: 4553
		public const int Identity = 79;

		// Token: 0x040011CA RID: 4554
		public const int IdentityInsert = 80;

		// Token: 0x040011CB RID: 4555
		public const int IdentityColumn = 81;

		// Token: 0x040011CC RID: 4556
		public const int If = 82;

		// Token: 0x040011CD RID: 4557
		public const int In = 83;

		// Token: 0x040011CE RID: 4558
		public const int Index = 84;

		// Token: 0x040011CF RID: 4559
		public const int Inner = 85;

		// Token: 0x040011D0 RID: 4560
		public const int Insert = 86;

		// Token: 0x040011D1 RID: 4561
		public const int Intersect = 87;

		// Token: 0x040011D2 RID: 4562
		public const int Into = 88;

		// Token: 0x040011D3 RID: 4563
		public const int Is = 89;

		// Token: 0x040011D4 RID: 4564
		public const int Join = 90;

		// Token: 0x040011D5 RID: 4565
		public const int Key = 91;

		// Token: 0x040011D6 RID: 4566
		public const int Kill = 92;

		// Token: 0x040011D7 RID: 4567
		public const int Left = 93;

		// Token: 0x040011D8 RID: 4568
		public const int Like = 94;

		// Token: 0x040011D9 RID: 4569
		public const int LineNo = 95;

		// Token: 0x040011DA RID: 4570
		public const int National = 96;

		// Token: 0x040011DB RID: 4571
		public const int NoCheck = 97;

		// Token: 0x040011DC RID: 4572
		public const int NonClustered = 98;

		// Token: 0x040011DD RID: 4573
		public const int Not = 99;

		// Token: 0x040011DE RID: 4574
		public const int Null = 100;

		// Token: 0x040011DF RID: 4575
		public const int NullIf = 101;

		// Token: 0x040011E0 RID: 4576
		public const int Of = 102;

		// Token: 0x040011E1 RID: 4577
		public const int Off = 103;

		// Token: 0x040011E2 RID: 4578
		public const int Offsets = 104;

		// Token: 0x040011E3 RID: 4579
		public const int On = 105;

		// Token: 0x040011E4 RID: 4580
		public const int Open = 106;

		// Token: 0x040011E5 RID: 4581
		public const int OpenDataSource = 107;

		// Token: 0x040011E6 RID: 4582
		public const int OpenQuery = 108;

		// Token: 0x040011E7 RID: 4583
		public const int OpenRowSet = 109;

		// Token: 0x040011E8 RID: 4584
		public const int OpenXml = 110;

		// Token: 0x040011E9 RID: 4585
		public const int Option = 111;

		// Token: 0x040011EA RID: 4586
		public const int Or = 112;

		// Token: 0x040011EB RID: 4587
		public const int Order = 113;

		// Token: 0x040011EC RID: 4588
		public const int Outer = 114;

		// Token: 0x040011ED RID: 4589
		public const int Over = 115;

		// Token: 0x040011EE RID: 4590
		public const int Percent = 116;

		// Token: 0x040011EF RID: 4591
		public const int Plan = 117;

		// Token: 0x040011F0 RID: 4592
		public const int Primary = 118;

		// Token: 0x040011F1 RID: 4593
		public const int Print = 119;

		// Token: 0x040011F2 RID: 4594
		public const int Proc = 120;

		// Token: 0x040011F3 RID: 4595
		public const int Procedure = 121;

		// Token: 0x040011F4 RID: 4596
		public const int Public = 122;

		// Token: 0x040011F5 RID: 4597
		public const int Raiserror = 123;

		// Token: 0x040011F6 RID: 4598
		public const int Read = 124;

		// Token: 0x040011F7 RID: 4599
		public const int ReadText = 125;

		// Token: 0x040011F8 RID: 4600
		public const int Reconfigure = 126;

		// Token: 0x040011F9 RID: 4601
		public const int References = 127;

		// Token: 0x040011FA RID: 4602
		public const int Replication = 128;

		// Token: 0x040011FB RID: 4603
		public const int Restore = 129;

		// Token: 0x040011FC RID: 4604
		public const int Restrict = 130;

		// Token: 0x040011FD RID: 4605
		public const int Return = 131;

		// Token: 0x040011FE RID: 4606
		public const int Revoke = 132;

		// Token: 0x040011FF RID: 4607
		public const int Right = 133;

		// Token: 0x04001200 RID: 4608
		public const int Rollback = 134;

		// Token: 0x04001201 RID: 4609
		public const int RowCount = 135;

		// Token: 0x04001202 RID: 4610
		public const int RowGuidColumn = 136;

		// Token: 0x04001203 RID: 4611
		public const int Rule = 137;

		// Token: 0x04001204 RID: 4612
		public const int Save = 138;

		// Token: 0x04001205 RID: 4613
		public const int Schema = 139;

		// Token: 0x04001206 RID: 4614
		public const int Select = 140;

		// Token: 0x04001207 RID: 4615
		public const int SessionUser = 141;

		// Token: 0x04001208 RID: 4616
		public const int Set = 142;

		// Token: 0x04001209 RID: 4617
		public const int SetUser = 143;

		// Token: 0x0400120A RID: 4618
		public const int Shutdown = 144;

		// Token: 0x0400120B RID: 4619
		public const int Some = 145;

		// Token: 0x0400120C RID: 4620
		public const int Statistics = 146;

		// Token: 0x0400120D RID: 4621
		public const int SystemUser = 147;

		// Token: 0x0400120E RID: 4622
		public const int Table = 148;

		// Token: 0x0400120F RID: 4623
		public const int TextSize = 149;

		// Token: 0x04001210 RID: 4624
		public const int Then = 150;

		// Token: 0x04001211 RID: 4625
		public const int To = 151;

		// Token: 0x04001212 RID: 4626
		public const int Top = 152;

		// Token: 0x04001213 RID: 4627
		public const int Tran = 153;

		// Token: 0x04001214 RID: 4628
		public const int Transaction = 154;

		// Token: 0x04001215 RID: 4629
		public const int Trigger = 155;

		// Token: 0x04001216 RID: 4630
		public const int Truncate = 156;

		// Token: 0x04001217 RID: 4631
		public const int TSEqual = 157;

		// Token: 0x04001218 RID: 4632
		public const int Union = 158;

		// Token: 0x04001219 RID: 4633
		public const int Unique = 159;

		// Token: 0x0400121A RID: 4634
		public const int Update = 160;

		// Token: 0x0400121B RID: 4635
		public const int UpdateText = 161;

		// Token: 0x0400121C RID: 4636
		public const int Use = 162;

		// Token: 0x0400121D RID: 4637
		public const int User = 163;

		// Token: 0x0400121E RID: 4638
		public const int Values = 164;

		// Token: 0x0400121F RID: 4639
		public const int Varying = 165;

		// Token: 0x04001220 RID: 4640
		public const int View = 166;

		// Token: 0x04001221 RID: 4641
		public const int WaitFor = 167;

		// Token: 0x04001222 RID: 4642
		public const int When = 168;

		// Token: 0x04001223 RID: 4643
		public const int Where = 169;

		// Token: 0x04001224 RID: 4644
		public const int While = 170;

		// Token: 0x04001225 RID: 4645
		public const int With = 171;

		// Token: 0x04001226 RID: 4646
		public const int WriteText = 172;

		// Token: 0x04001227 RID: 4647
		public const int Disk = 173;

		// Token: 0x04001228 RID: 4648
		public const int Precision = 174;

		// Token: 0x04001229 RID: 4649
		public const int External = 175;

		// Token: 0x0400122A RID: 4650
		public const int Revert = 176;

		// Token: 0x0400122B RID: 4651
		public const int Pivot = 177;

		// Token: 0x0400122C RID: 4652
		public const int Unpivot = 178;

		// Token: 0x0400122D RID: 4653
		public const int TableSample = 179;

		// Token: 0x0400122E RID: 4654
		public const int Dump = 180;

		// Token: 0x0400122F RID: 4655
		public const int Load = 181;

		// Token: 0x04001230 RID: 4656
		public const int Merge = 182;

		// Token: 0x04001231 RID: 4657
		public const int StopList = 183;

		// Token: 0x04001232 RID: 4658
		public const int SemanticKeyPhraseTable = 184;

		// Token: 0x04001233 RID: 4659
		public const int SemanticSimilarityTable = 185;

		// Token: 0x04001234 RID: 4660
		public const int SemanticSimilarityDetailsTable = 186;

		// Token: 0x04001235 RID: 4661
		public const int TryConvert = 187;

		// Token: 0x04001236 RID: 4662
		public const int Bang = 188;

		// Token: 0x04001237 RID: 4663
		public const int PercentSign = 189;

		// Token: 0x04001238 RID: 4664
		public const int Ampersand = 190;

		// Token: 0x04001239 RID: 4665
		public const int LeftParenthesis = 191;

		// Token: 0x0400123A RID: 4666
		public const int RightParenthesis = 192;

		// Token: 0x0400123B RID: 4667
		public const int LeftCurly = 193;

		// Token: 0x0400123C RID: 4668
		public const int RightCurly = 194;

		// Token: 0x0400123D RID: 4669
		public const int Star = 195;

		// Token: 0x0400123E RID: 4670
		public const int MultiplyEquals = 196;

		// Token: 0x0400123F RID: 4671
		public const int Plus = 197;

		// Token: 0x04001240 RID: 4672
		public const int Comma = 198;

		// Token: 0x04001241 RID: 4673
		public const int Minus = 199;

		// Token: 0x04001242 RID: 4674
		public const int Dot = 200;

		// Token: 0x04001243 RID: 4675
		public const int Divide = 201;

		// Token: 0x04001244 RID: 4676
		public const int Colon = 202;

		// Token: 0x04001245 RID: 4677
		public const int DoubleColon = 203;

		// Token: 0x04001246 RID: 4678
		public const int Semicolon = 204;

		// Token: 0x04001247 RID: 4679
		public const int LessThan = 205;

		// Token: 0x04001248 RID: 4680
		public const int EqualsSign = 206;

		// Token: 0x04001249 RID: 4681
		public const int RightOuterJoin = 207;

		// Token: 0x0400124A RID: 4682
		public const int GreaterThan = 208;

		// Token: 0x0400124B RID: 4683
		public const int Circumflex = 209;

		// Token: 0x0400124C RID: 4684
		public const int VerticalLine = 210;

		// Token: 0x0400124D RID: 4685
		public const int Tilde = 211;

		// Token: 0x0400124E RID: 4686
		public const int AddEquals = 212;

		// Token: 0x0400124F RID: 4687
		public const int SubtractEquals = 213;

		// Token: 0x04001250 RID: 4688
		public const int DivideEquals = 214;

		// Token: 0x04001251 RID: 4689
		public const int ModEquals = 215;

		// Token: 0x04001252 RID: 4690
		public const int BitwiseAndEquals = 216;

		// Token: 0x04001253 RID: 4691
		public const int BitwiseOrEquals = 217;

		// Token: 0x04001254 RID: 4692
		public const int BitwiseXorEquals = 218;

		// Token: 0x04001255 RID: 4693
		public const int Go = 219;

		// Token: 0x04001256 RID: 4694
		public const int Label = 220;

		// Token: 0x04001257 RID: 4695
		public const int Integer = 221;

		// Token: 0x04001258 RID: 4696
		public const int Numeric = 222;

		// Token: 0x04001259 RID: 4697
		public const int Real = 223;

		// Token: 0x0400125A RID: 4698
		public const int HexLiteral = 224;

		// Token: 0x0400125B RID: 4699
		public const int Money = 225;

		// Token: 0x0400125C RID: 4700
		public const int SqlCommandIdentifier = 226;

		// Token: 0x0400125D RID: 4701
		public const int PseudoColumn = 227;

		// Token: 0x0400125E RID: 4702
		public const int DollarPartition = 228;

		// Token: 0x0400125F RID: 4703
		public const int AsciiStringOrQuotedIdentifier = 229;

		// Token: 0x04001260 RID: 4704
		public const int AsciiStringLiteral = 230;

		// Token: 0x04001261 RID: 4705
		public const int UnicodeStringLiteral = 231;

		// Token: 0x04001262 RID: 4706
		public const int Identifier = 232;

		// Token: 0x04001263 RID: 4707
		public const int QuotedIdentifier = 233;

		// Token: 0x04001264 RID: 4708
		public const int Variable = 234;

		// Token: 0x04001265 RID: 4709
		public const int OdbcInitiator = 235;

		// Token: 0x04001266 RID: 4710
		public const int ProcNameSemicolon = 236;

		// Token: 0x04001267 RID: 4711
		public const int SingleLineComment = 237;

		// Token: 0x04001268 RID: 4712
		public const int MultilineComment = 238;

		// Token: 0x04001269 RID: 4713
		public const int WhiteSpace = 239;

		// Token: 0x0400126A RID: 4714
		public const int Digit = 240;

		// Token: 0x0400126B RID: 4715
		public const int FirstLetter = 241;

		// Token: 0x0400126C RID: 4716
		public const int Letter = 242;

		// Token: 0x0400126D RID: 4717
		public const int MoneySign = 243;

		// Token: 0x0400126E RID: 4718
		public const int WS_CHAR_WO_NEWLINE = 244;

		// Token: 0x0400126F RID: 4719
		public const int Number = 245;

		// Token: 0x04001270 RID: 4720
		public const int Exponent = 246;

		// Token: 0x04001271 RID: 4721
		public const int EndOfLine = 247;

		// Token: 0x04001272 RID: 4722
		public static readonly BitSet tokenSet_0_ = new BitSet(TSql90LexerInternal.mk_tokenSet_0_());

		// Token: 0x04001273 RID: 4723
		public static readonly BitSet tokenSet_1_ = new BitSet(TSql90LexerInternal.mk_tokenSet_1_());

		// Token: 0x04001274 RID: 4724
		public static readonly BitSet tokenSet_2_ = new BitSet(TSql90LexerInternal.mk_tokenSet_2_());

		// Token: 0x04001275 RID: 4725
		public static readonly BitSet tokenSet_3_ = new BitSet(TSql90LexerInternal.mk_tokenSet_3_());

		// Token: 0x04001276 RID: 4726
		public static readonly BitSet tokenSet_4_ = new BitSet(TSql90LexerInternal.mk_tokenSet_4_());

		// Token: 0x04001277 RID: 4727
		public static readonly BitSet tokenSet_5_ = new BitSet(TSql90LexerInternal.mk_tokenSet_5_());

		// Token: 0x04001278 RID: 4728
		public static readonly BitSet tokenSet_6_ = new BitSet(TSql90LexerInternal.mk_tokenSet_6_());

		// Token: 0x04001279 RID: 4729
		public static readonly BitSet tokenSet_7_ = new BitSet(TSql90LexerInternal.mk_tokenSet_7_());

		// Token: 0x0400127A RID: 4730
		public static readonly BitSet tokenSet_8_ = new BitSet(TSql90LexerInternal.mk_tokenSet_8_());

		// Token: 0x0400127B RID: 4731
		public static readonly BitSet tokenSet_9_ = new BitSet(TSql90LexerInternal.mk_tokenSet_9_());

		// Token: 0x0400127C RID: 4732
		public static readonly BitSet tokenSet_10_ = new BitSet(TSql90LexerInternal.mk_tokenSet_10_());

		// Token: 0x0400127D RID: 4733
		public static readonly BitSet tokenSet_11_ = new BitSet(TSql90LexerInternal.mk_tokenSet_11_());

		// Token: 0x0400127E RID: 4734
		public static readonly BitSet tokenSet_12_ = new BitSet(TSql90LexerInternal.mk_tokenSet_12_());
	}
}
