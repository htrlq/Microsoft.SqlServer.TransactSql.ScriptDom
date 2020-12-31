using System;
using System.Collections;
using System.IO;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B5 RID: 437
	internal class TSql100LexerInternal : TSqlLexerBaseInternal, TokenStream
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x0003B8F0 File Offset: 0x00039AF0
		public TSql100LexerInternal() : this(new StringReader(string.Empty))
		{
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0003B902 File Offset: 0x00039B02
		public TSql100LexerInternal(Stream ins) : this(new ByteBuffer(ins))
		{
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0003B910 File Offset: 0x00039B10
		public TSql100LexerInternal(TextReader r) : this(new CharBuffer(r))
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0003B91E File Offset: 0x00039B1E
		public TSql100LexerInternal(InputBuffer ib) : this(new LexerSharedInputState(ib))
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0003B92C File Offset: 0x00039B2C
		public TSql100LexerInternal(LexerSharedInputState state) : base(state)
		{
			this.initialize();
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0003B93C File Offset: 0x00039B3C
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
			this.literals.Add("stoplist", 183);
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
			this.literals.Add("merge", 182);
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
			this.literals.Add("from", 71);
			this.literals.Add("openxml", 110);
			this.literals.Add("read", 124);
			this.literals.Add("setuser", 143);
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

		// Token: 0x06001125 RID: 4389 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		public override IToken nextToken()
		{
			IToken returnToken_41;
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
						goto IL_66C;
					}
					case '!':
					{
						this.mBang(true);
						IToken returnToken_2 = this.returnToken_;
						goto IL_66C;
					}
					case '"':
					case '[':
					{
						this.mQuotedIdentifier(true);
						IToken returnToken_3 = this.returnToken_;
						goto IL_66C;
					}
					case '#':
					case '$':
					case '%':
					case '&':
					case '*':
					case '+':
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
						break;
					case '\'':
					{
						this.mAsciiStringLiteral(true);
						IToken returnToken_4 = this.returnToken_;
						goto IL_66C;
					}
					case '(':
					{
						this.mLeftParenthesis(true);
						IToken returnToken_5 = this.returnToken_;
						goto IL_66C;
					}
					case ')':
					{
						this.mRightParenthesis(true);
						IToken returnToken_6 = this.returnToken_;
						goto IL_66C;
					}
					case ',':
					{
						this.mComma(true);
						IToken returnToken_7 = this.returnToken_;
						goto IL_66C;
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
						IToken returnToken_8 = this.returnToken_;
						goto IL_66C;
					}
					case ';':
					{
						this.mProcNameSemicolon(true);
						IToken returnToken_9 = this.returnToken_;
						goto IL_66C;
					}
					case '<':
					{
						this.mLessThan(true);
						IToken returnToken_10 = this.returnToken_;
						goto IL_66C;
					}
					case '>':
					{
						this.mGreaterThan(true);
						IToken returnToken_11 = this.returnToken_;
						goto IL_66C;
					}
					case '@':
					{
						this.mVariable(true);
						IToken returnToken_12 = this.returnToken_;
						goto IL_66C;
					}
					default:
						switch (cached_LA)
						{
						case '{':
						{
							this.mLeftCurly(true);
							IToken returnToken_13 = this.returnToken_;
							goto IL_66C;
						}
						case '}':
						{
							this.mRightCurly(true);
							IToken returnToken_14 = this.returnToken_;
							goto IL_66C;
						}
						case '~':
						{
							this.mTilde(true);
							IToken returnToken_15 = this.returnToken_;
							goto IL_66C;
						}
						}
						break;
					}
					if (this.cached_LA1 == '*' && this.cached_LA2 == '=')
					{
						this.mMultiplyEquals(true);
						IToken returnToken_16 = this.returnToken_;
					}
					else if (this.cached_LA1 == ':' && this.cached_LA2 == ':')
					{
						this.mDoubleColon(true);
						IToken returnToken_17 = this.returnToken_;
					}
					else if (this.cached_LA1 == '=' && this.cached_LA2 == '*')
					{
						this.mRightOuterJoin(true);
						IToken returnToken_18 = this.returnToken_;
					}
					else if (this.cached_LA1 == '+' && this.cached_LA2 == '=')
					{
						this.mAddEquals(true);
						IToken returnToken_19 = this.returnToken_;
					}
					else if (this.cached_LA1 == '-' && this.cached_LA2 == '=')
					{
						this.mSubtractEquals(true);
						IToken returnToken_20 = this.returnToken_;
					}
					else if (this.cached_LA1 == '/' && this.cached_LA2 == '=')
					{
						this.mDivideEquals(true);
						IToken returnToken_21 = this.returnToken_;
					}
					else if (this.cached_LA1 == '%' && this.cached_LA2 == '=')
					{
						this.mModEquals(true);
						IToken returnToken_22 = this.returnToken_;
					}
					else if (this.cached_LA1 == '&' && this.cached_LA2 == '=')
					{
						this.mBitwiseAndEquals(true);
						IToken returnToken_23 = this.returnToken_;
					}
					else if (this.cached_LA1 == '|' && this.cached_LA2 == '=')
					{
						this.mBitwiseOrEquals(true);
						IToken returnToken_24 = this.returnToken_;
					}
					else if (this.cached_LA1 == '^' && this.cached_LA2 == '=')
					{
						this.mBitwiseXorEquals(true);
						IToken returnToken_25 = this.returnToken_;
					}
					else if (this.cached_LA1 == 'g' && this.cached_LA2 == 'o' && base.CurrentOffset == this._acceptableGoOffset)
					{
						this.mGo(true);
						IToken returnToken_26 = this.returnToken_;
					}
					else if (this.cached_LA1 == 'n' && this.cached_LA2 == '\'')
					{
						this.mUnicodeStringLiteral(true);
						IToken returnToken_27 = this.returnToken_;
					}
					else if (this.cached_LA1 == '-' && this.cached_LA2 == '-')
					{
						this.mSingleLineComment(true);
						IToken returnToken_28 = this.returnToken_;
					}
					else if (this.cached_LA1 == '/' && this.cached_LA2 == '*')
					{
						this.mMultilineComment(true);
						IToken returnToken_29 = this.returnToken_;
					}
					else if (this.cached_LA1 == '%')
					{
						this.mPercentSign(true);
						IToken returnToken_30 = this.returnToken_;
					}
					else if (this.cached_LA1 == '&')
					{
						this.mAmpersand(true);
						IToken returnToken_31 = this.returnToken_;
					}
					else if (this.cached_LA1 == '*')
					{
						this.mStar(true);
						IToken returnToken_32 = this.returnToken_;
					}
					else if (this.cached_LA1 == '+')
					{
						this.mPlus(true);
						IToken returnToken_33 = this.returnToken_;
					}
					else if (this.cached_LA1 == '-')
					{
						this.mMinus(true);
						IToken returnToken_34 = this.returnToken_;
					}
					else if (this.cached_LA1 == '/')
					{
						this.mDivide(true);
						IToken returnToken_35 = this.returnToken_;
					}
					else if (this.cached_LA1 == ':')
					{
						this.mColon(true);
						IToken returnToken_36 = this.returnToken_;
					}
					else if (this.cached_LA1 == '=')
					{
						this.mEqualsSign(true);
						IToken returnToken_37 = this.returnToken_;
					}
					else if (this.cached_LA1 == '^')
					{
						this.mCircumflex(true);
						IToken returnToken_38 = this.returnToken_;
					}
					else if (this.cached_LA1 == '|')
					{
						this.mVerticalLine(true);
						IToken returnToken_39 = this.returnToken_;
					}
					else if (TSql100LexerInternal.tokenSet_0_.member((int)this.cached_LA1))
					{
						this.mIdentifier(true);
						IToken returnToken_40 = this.returnToken_;
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
					IL_66C:
					if (this.returnToken_ == null)
					{
						continue;
					}
					int type = this.returnToken_.Type;
					this.returnToken_.Type = type;
					returnToken_41 = this.returnToken_;
				}
				catch (RecognitionException re)
				{
					throw new TokenStreamRecognitionException(re);
				}
				break;
			}
			return returnToken_41;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0003D0A4 File Offset: 0x0003B2A4
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

		// Token: 0x06001127 RID: 4391 RVA: 0x0003D10C File Offset: 0x0003B30C
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

		// Token: 0x06001128 RID: 4392 RVA: 0x0003D174 File Offset: 0x0003B374
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

		// Token: 0x06001129 RID: 4393 RVA: 0x0003D1DC File Offset: 0x0003B3DC
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

		// Token: 0x0600112A RID: 4394 RVA: 0x0003D244 File Offset: 0x0003B444
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

		// Token: 0x0600112B RID: 4395 RVA: 0x0003D2AC File Offset: 0x0003B4AC
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

		// Token: 0x0600112C RID: 4396 RVA: 0x0003D314 File Offset: 0x0003B514
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

		// Token: 0x0600112D RID: 4397 RVA: 0x0003D37C File Offset: 0x0003B57C
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

		// Token: 0x0600112E RID: 4398 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
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

		// Token: 0x0600112F RID: 4399 RVA: 0x0003D44C File Offset: 0x0003B64C
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

		// Token: 0x06001130 RID: 4400 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
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

		// Token: 0x06001131 RID: 4401 RVA: 0x0003D51C File Offset: 0x0003B71C
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

		// Token: 0x06001132 RID: 4402 RVA: 0x0003D584 File Offset: 0x0003B784
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

		// Token: 0x06001133 RID: 4403 RVA: 0x0003D5E4 File Offset: 0x0003B7E4
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

		// Token: 0x06001134 RID: 4404 RVA: 0x0003D64C File Offset: 0x0003B84C
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

		// Token: 0x06001135 RID: 4405 RVA: 0x0003D6B4 File Offset: 0x0003B8B4
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

		// Token: 0x06001136 RID: 4406 RVA: 0x0003D71C File Offset: 0x0003B91C
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

		// Token: 0x06001137 RID: 4407 RVA: 0x0003D784 File Offset: 0x0003B984
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

		// Token: 0x06001138 RID: 4408 RVA: 0x0003D7EC File Offset: 0x0003B9EC
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

		// Token: 0x06001139 RID: 4409 RVA: 0x0003D854 File Offset: 0x0003BA54
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

		// Token: 0x0600113A RID: 4410 RVA: 0x0003D8BC File Offset: 0x0003BABC
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

		// Token: 0x0600113B RID: 4411 RVA: 0x0003D924 File Offset: 0x0003BB24
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

		// Token: 0x0600113C RID: 4412 RVA: 0x0003D98C File Offset: 0x0003BB8C
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

		// Token: 0x0600113D RID: 4413 RVA: 0x0003D9F4 File Offset: 0x0003BBF4
		public void mAddEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 212;
			this.match("+=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0003DA5C File Offset: 0x0003BC5C
		public void mSubtractEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 213;
			this.match("-=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0003DAC4 File Offset: 0x0003BCC4
		public void mDivideEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 214;
			this.match("/=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0003DB2C File Offset: 0x0003BD2C
		public void mModEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 215;
			this.match("%=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0003DB94 File Offset: 0x0003BD94
		public void mBitwiseAndEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 216;
			this.match("&=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		public void mBitwiseOrEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 217;
			this.match("|=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0003DC64 File Offset: 0x0003BE64
		public void mBitwiseXorEquals(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 218;
			this.match("^=");
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0003DCCC File Offset: 0x0003BECC
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

		// Token: 0x06001145 RID: 4421 RVA: 0x0003DD34 File Offset: 0x0003BF34
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

		// Token: 0x06001146 RID: 4422 RVA: 0x0003DD9C File Offset: 0x0003BF9C
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

		// Token: 0x06001147 RID: 4423 RVA: 0x0003DEF0 File Offset: 0x0003C0F0
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

		// Token: 0x06001148 RID: 4424 RVA: 0x0003E068 File Offset: 0x0003C268
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

		// Token: 0x06001149 RID: 4425 RVA: 0x0003E27C File Offset: 0x0003C47C
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
					while (TSql100LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
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

		// Token: 0x0600114A RID: 4426 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
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

		// Token: 0x0600114B RID: 4427 RVA: 0x0003E620 File Offset: 0x0003C820
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

		// Token: 0x0600114C RID: 4428 RVA: 0x0003E940 File Offset: 0x0003CB40
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
				while (TSql100LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
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

		// Token: 0x0600114D RID: 4429 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
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

		// Token: 0x0600114E RID: 4430 RVA: 0x0003EBC0 File Offset: 0x0003CDC0
		public void mGo(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 219;
			if (base.CurrentOffset != this._acceptableGoOffset)
			{
				throw new SemanticException("CurrentOffset==_acceptableGoOffset");
			}
			this.match("go");
			for (;;)
			{
				if (TSql100LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600114F RID: 4431 RVA: 0x0003ED30 File Offset: 0x0003CF30
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

		// Token: 0x06001150 RID: 4432 RVA: 0x0003ED90 File Offset: 0x0003CF90
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

		// Token: 0x06001151 RID: 4433 RVA: 0x0003EDF0 File Offset: 0x0003CFF0
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

		// Token: 0x06001152 RID: 4434 RVA: 0x0003EE50 File Offset: 0x0003D050
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

		// Token: 0x06001153 RID: 4435 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
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

		// Token: 0x06001154 RID: 4436 RVA: 0x0003EF10 File Offset: 0x0003D110
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

		// Token: 0x06001155 RID: 4437 RVA: 0x0003EFC4 File Offset: 0x0003D1C4
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

		// Token: 0x06001156 RID: 4438 RVA: 0x0003F024 File Offset: 0x0003D224
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

		// Token: 0x06001157 RID: 4439 RVA: 0x0003F084 File Offset: 0x0003D284
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

		// Token: 0x06001158 RID: 4440 RVA: 0x0003F0E4 File Offset: 0x0003D2E4
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

		// Token: 0x06001159 RID: 4441 RVA: 0x0003F144 File Offset: 0x0003D344
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

		// Token: 0x0600115A RID: 4442 RVA: 0x0003F1A4 File Offset: 0x0003D3A4
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
				else if (TSql100LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql100LexerInternal.tokenSet_3_);
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

		// Token: 0x0600115B RID: 4443 RVA: 0x0003F29C File Offset: 0x0003D49C
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
				else if (TSql100LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql100LexerInternal.tokenSet_3_);
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

		// Token: 0x0600115C RID: 4444 RVA: 0x0003F39C File Offset: 0x0003D59C
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
					if (TSql100LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.SqlCommandIdentifier);
						}
						this.match(TSql100LexerInternal.tokenSet_4_);
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
				if (this.cached_LA1 == '$' && TSql100LexerInternal.tokenSet_5_.member((int)this.cached_LA2))
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
							if (!TSql100LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
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
						if (!TSql100LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
					}
					for (;;)
					{
						if (TSql100LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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
					if (TSql100LexerInternal.tokenSet_7_.member((int)this.cached_LA1) && TSql100LexerInternal.tokenSet_8_.member((int)this.cached_LA2))
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
						if (!TSql100LexerInternal.tokenSet_6_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
						for (;;)
						{
							if (TSql100LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600115D RID: 4445 RVA: 0x0003F9AC File Offset: 0x0003DBAC
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
					else if (TSql100LexerInternal.tokenSet_9_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql100LexerInternal.tokenSet_9_);
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
					else if (TSql100LexerInternal.tokenSet_10_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql100LexerInternal.tokenSet_10_);
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

		// Token: 0x0600115E RID: 4446 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
		public void mVariable(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 234;
			this.match('@');
			for (;;)
			{
				if (TSql100LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600115F RID: 4447 RVA: 0x0003FC70 File Offset: 0x0003DE70
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

		// Token: 0x06001160 RID: 4448 RVA: 0x0003FCD0 File Offset: 0x0003DED0
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
				while (TSql100LexerInternal.tokenSet_11_.member((int)this.cached_LA1) && this.LA(1) != CharScanner.EOF_CHAR)
				{
					this.match(TSql100LexerInternal.tokenSet_11_);
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

		// Token: 0x06001161 RID: 4449 RVA: 0x0003FE1C File Offset: 0x0003E01C
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
					if (!TSql100LexerInternal.tokenSet_12_.member((int)this.cached_LA1))
					{
						break;
					}
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.MultiLineComment);
					}
					this.match(TSql100LexerInternal.tokenSet_12_);
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

		// Token: 0x06001162 RID: 4450 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
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

		// Token: 0x06001163 RID: 4451 RVA: 0x00040020 File Offset: 0x0003E220
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

		// Token: 0x06001164 RID: 4452 RVA: 0x0004005C File Offset: 0x0003E25C
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

		// Token: 0x06001165 RID: 4453 RVA: 0x000400CC File Offset: 0x0003E2CC
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

		// Token: 0x06001166 RID: 4454 RVA: 0x00040120 File Offset: 0x0003E320
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

		// Token: 0x06001167 RID: 4455 RVA: 0x00040174 File Offset: 0x0003E374
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

		// Token: 0x06001168 RID: 4456 RVA: 0x000401E4 File Offset: 0x0003E3E4
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

		// Token: 0x06001169 RID: 4457 RVA: 0x00040254 File Offset: 0x0003E454
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

		// Token: 0x0600116A RID: 4458 RVA: 0x00040310 File Offset: 0x0003E510
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

		// Token: 0x0600116B RID: 4459 RVA: 0x0004034C File Offset: 0x0003E54C
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

		// Token: 0x0600116C RID: 4460 RVA: 0x000403A8 File Offset: 0x0003E5A8
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

		// Token: 0x0600116D RID: 4461 RVA: 0x000403FC File Offset: 0x0003E5FC
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

		// Token: 0x0600116E RID: 4462 RVA: 0x0004044C File Offset: 0x0003E64C
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

		// Token: 0x0400127F RID: 4735
		public const int EOF = 1;

		// Token: 0x04001280 RID: 4736
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x04001281 RID: 4737
		public const int Add = 4;

		// Token: 0x04001282 RID: 4738
		public const int All = 5;

		// Token: 0x04001283 RID: 4739
		public const int Alter = 6;

		// Token: 0x04001284 RID: 4740
		public const int And = 7;

		// Token: 0x04001285 RID: 4741
		public const int Any = 8;

		// Token: 0x04001286 RID: 4742
		public const int As = 9;

		// Token: 0x04001287 RID: 4743
		public const int Asc = 10;

		// Token: 0x04001288 RID: 4744
		public const int Authorization = 11;

		// Token: 0x04001289 RID: 4745
		public const int Backup = 12;

		// Token: 0x0400128A RID: 4746
		public const int Begin = 13;

		// Token: 0x0400128B RID: 4747
		public const int Between = 14;

		// Token: 0x0400128C RID: 4748
		public const int Break = 15;

		// Token: 0x0400128D RID: 4749
		public const int Browse = 16;

		// Token: 0x0400128E RID: 4750
		public const int Bulk = 17;

		// Token: 0x0400128F RID: 4751
		public const int By = 18;

		// Token: 0x04001290 RID: 4752
		public const int Cascade = 19;

		// Token: 0x04001291 RID: 4753
		public const int Case = 20;

		// Token: 0x04001292 RID: 4754
		public const int Check = 21;

		// Token: 0x04001293 RID: 4755
		public const int Checkpoint = 22;

		// Token: 0x04001294 RID: 4756
		public const int Close = 23;

		// Token: 0x04001295 RID: 4757
		public const int Clustered = 24;

		// Token: 0x04001296 RID: 4758
		public const int Coalesce = 25;

		// Token: 0x04001297 RID: 4759
		public const int Collate = 26;

		// Token: 0x04001298 RID: 4760
		public const int Column = 27;

		// Token: 0x04001299 RID: 4761
		public const int Commit = 28;

		// Token: 0x0400129A RID: 4762
		public const int Compute = 29;

		// Token: 0x0400129B RID: 4763
		public const int Constraint = 30;

		// Token: 0x0400129C RID: 4764
		public const int Contains = 31;

		// Token: 0x0400129D RID: 4765
		public const int ContainsTable = 32;

		// Token: 0x0400129E RID: 4766
		public const int Continue = 33;

		// Token: 0x0400129F RID: 4767
		public const int Convert = 34;

		// Token: 0x040012A0 RID: 4768
		public const int Create = 35;

		// Token: 0x040012A1 RID: 4769
		public const int Cross = 36;

		// Token: 0x040012A2 RID: 4770
		public const int Current = 37;

		// Token: 0x040012A3 RID: 4771
		public const int CurrentDate = 38;

		// Token: 0x040012A4 RID: 4772
		public const int CurrentTime = 39;

		// Token: 0x040012A5 RID: 4773
		public const int CurrentTimestamp = 40;

		// Token: 0x040012A6 RID: 4774
		public const int CurrentUser = 41;

		// Token: 0x040012A7 RID: 4775
		public const int Cursor = 42;

		// Token: 0x040012A8 RID: 4776
		public const int Database = 43;

		// Token: 0x040012A9 RID: 4777
		public const int Dbcc = 44;

		// Token: 0x040012AA RID: 4778
		public const int Deallocate = 45;

		// Token: 0x040012AB RID: 4779
		public const int Declare = 46;

		// Token: 0x040012AC RID: 4780
		public const int Default = 47;

		// Token: 0x040012AD RID: 4781
		public const int Delete = 48;

		// Token: 0x040012AE RID: 4782
		public const int Deny = 49;

		// Token: 0x040012AF RID: 4783
		public const int Desc = 50;

		// Token: 0x040012B0 RID: 4784
		public const int Distinct = 51;

		// Token: 0x040012B1 RID: 4785
		public const int Distributed = 52;

		// Token: 0x040012B2 RID: 4786
		public const int Double = 53;

		// Token: 0x040012B3 RID: 4787
		public const int Drop = 54;

		// Token: 0x040012B4 RID: 4788
		public const int Else = 55;

		// Token: 0x040012B5 RID: 4789
		public const int End = 56;

		// Token: 0x040012B6 RID: 4790
		public const int Errlvl = 57;

		// Token: 0x040012B7 RID: 4791
		public const int Escape = 58;

		// Token: 0x040012B8 RID: 4792
		public const int Except = 59;

		// Token: 0x040012B9 RID: 4793
		public const int Exec = 60;

		// Token: 0x040012BA RID: 4794
		public const int Execute = 61;

		// Token: 0x040012BB RID: 4795
		public const int Exists = 62;

		// Token: 0x040012BC RID: 4796
		public const int Exit = 63;

		// Token: 0x040012BD RID: 4797
		public const int Fetch = 64;

		// Token: 0x040012BE RID: 4798
		public const int File = 65;

		// Token: 0x040012BF RID: 4799
		public const int FillFactor = 66;

		// Token: 0x040012C0 RID: 4800
		public const int For = 67;

		// Token: 0x040012C1 RID: 4801
		public const int Foreign = 68;

		// Token: 0x040012C2 RID: 4802
		public const int FreeText = 69;

		// Token: 0x040012C3 RID: 4803
		public const int FreeTextTable = 70;

		// Token: 0x040012C4 RID: 4804
		public const int From = 71;

		// Token: 0x040012C5 RID: 4805
		public const int Full = 72;

		// Token: 0x040012C6 RID: 4806
		public const int Function = 73;

		// Token: 0x040012C7 RID: 4807
		public const int GoTo = 74;

		// Token: 0x040012C8 RID: 4808
		public const int Grant = 75;

		// Token: 0x040012C9 RID: 4809
		public const int Group = 76;

		// Token: 0x040012CA RID: 4810
		public const int Having = 77;

		// Token: 0x040012CB RID: 4811
		public const int HoldLock = 78;

		// Token: 0x040012CC RID: 4812
		public const int Identity = 79;

		// Token: 0x040012CD RID: 4813
		public const int IdentityInsert = 80;

		// Token: 0x040012CE RID: 4814
		public const int IdentityColumn = 81;

		// Token: 0x040012CF RID: 4815
		public const int If = 82;

		// Token: 0x040012D0 RID: 4816
		public const int In = 83;

		// Token: 0x040012D1 RID: 4817
		public const int Index = 84;

		// Token: 0x040012D2 RID: 4818
		public const int Inner = 85;

		// Token: 0x040012D3 RID: 4819
		public const int Insert = 86;

		// Token: 0x040012D4 RID: 4820
		public const int Intersect = 87;

		// Token: 0x040012D5 RID: 4821
		public const int Into = 88;

		// Token: 0x040012D6 RID: 4822
		public const int Is = 89;

		// Token: 0x040012D7 RID: 4823
		public const int Join = 90;

		// Token: 0x040012D8 RID: 4824
		public const int Key = 91;

		// Token: 0x040012D9 RID: 4825
		public const int Kill = 92;

		// Token: 0x040012DA RID: 4826
		public const int Left = 93;

		// Token: 0x040012DB RID: 4827
		public const int Like = 94;

		// Token: 0x040012DC RID: 4828
		public const int LineNo = 95;

		// Token: 0x040012DD RID: 4829
		public const int National = 96;

		// Token: 0x040012DE RID: 4830
		public const int NoCheck = 97;

		// Token: 0x040012DF RID: 4831
		public const int NonClustered = 98;

		// Token: 0x040012E0 RID: 4832
		public const int Not = 99;

		// Token: 0x040012E1 RID: 4833
		public const int Null = 100;

		// Token: 0x040012E2 RID: 4834
		public const int NullIf = 101;

		// Token: 0x040012E3 RID: 4835
		public const int Of = 102;

		// Token: 0x040012E4 RID: 4836
		public const int Off = 103;

		// Token: 0x040012E5 RID: 4837
		public const int Offsets = 104;

		// Token: 0x040012E6 RID: 4838
		public const int On = 105;

		// Token: 0x040012E7 RID: 4839
		public const int Open = 106;

		// Token: 0x040012E8 RID: 4840
		public const int OpenDataSource = 107;

		// Token: 0x040012E9 RID: 4841
		public const int OpenQuery = 108;

		// Token: 0x040012EA RID: 4842
		public const int OpenRowSet = 109;

		// Token: 0x040012EB RID: 4843
		public const int OpenXml = 110;

		// Token: 0x040012EC RID: 4844
		public const int Option = 111;

		// Token: 0x040012ED RID: 4845
		public const int Or = 112;

		// Token: 0x040012EE RID: 4846
		public const int Order = 113;

		// Token: 0x040012EF RID: 4847
		public const int Outer = 114;

		// Token: 0x040012F0 RID: 4848
		public const int Over = 115;

		// Token: 0x040012F1 RID: 4849
		public const int Percent = 116;

		// Token: 0x040012F2 RID: 4850
		public const int Plan = 117;

		// Token: 0x040012F3 RID: 4851
		public const int Primary = 118;

		// Token: 0x040012F4 RID: 4852
		public const int Print = 119;

		// Token: 0x040012F5 RID: 4853
		public const int Proc = 120;

		// Token: 0x040012F6 RID: 4854
		public const int Procedure = 121;

		// Token: 0x040012F7 RID: 4855
		public const int Public = 122;

		// Token: 0x040012F8 RID: 4856
		public const int Raiserror = 123;

		// Token: 0x040012F9 RID: 4857
		public const int Read = 124;

		// Token: 0x040012FA RID: 4858
		public const int ReadText = 125;

		// Token: 0x040012FB RID: 4859
		public const int Reconfigure = 126;

		// Token: 0x040012FC RID: 4860
		public const int References = 127;

		// Token: 0x040012FD RID: 4861
		public const int Replication = 128;

		// Token: 0x040012FE RID: 4862
		public const int Restore = 129;

		// Token: 0x040012FF RID: 4863
		public const int Restrict = 130;

		// Token: 0x04001300 RID: 4864
		public const int Return = 131;

		// Token: 0x04001301 RID: 4865
		public const int Revoke = 132;

		// Token: 0x04001302 RID: 4866
		public const int Right = 133;

		// Token: 0x04001303 RID: 4867
		public const int Rollback = 134;

		// Token: 0x04001304 RID: 4868
		public const int RowCount = 135;

		// Token: 0x04001305 RID: 4869
		public const int RowGuidColumn = 136;

		// Token: 0x04001306 RID: 4870
		public const int Rule = 137;

		// Token: 0x04001307 RID: 4871
		public const int Save = 138;

		// Token: 0x04001308 RID: 4872
		public const int Schema = 139;

		// Token: 0x04001309 RID: 4873
		public const int Select = 140;

		// Token: 0x0400130A RID: 4874
		public const int SessionUser = 141;

		// Token: 0x0400130B RID: 4875
		public const int Set = 142;

		// Token: 0x0400130C RID: 4876
		public const int SetUser = 143;

		// Token: 0x0400130D RID: 4877
		public const int Shutdown = 144;

		// Token: 0x0400130E RID: 4878
		public const int Some = 145;

		// Token: 0x0400130F RID: 4879
		public const int Statistics = 146;

		// Token: 0x04001310 RID: 4880
		public const int SystemUser = 147;

		// Token: 0x04001311 RID: 4881
		public const int Table = 148;

		// Token: 0x04001312 RID: 4882
		public const int TextSize = 149;

		// Token: 0x04001313 RID: 4883
		public const int Then = 150;

		// Token: 0x04001314 RID: 4884
		public const int To = 151;

		// Token: 0x04001315 RID: 4885
		public const int Top = 152;

		// Token: 0x04001316 RID: 4886
		public const int Tran = 153;

		// Token: 0x04001317 RID: 4887
		public const int Transaction = 154;

		// Token: 0x04001318 RID: 4888
		public const int Trigger = 155;

		// Token: 0x04001319 RID: 4889
		public const int Truncate = 156;

		// Token: 0x0400131A RID: 4890
		public const int TSEqual = 157;

		// Token: 0x0400131B RID: 4891
		public const int Union = 158;

		// Token: 0x0400131C RID: 4892
		public const int Unique = 159;

		// Token: 0x0400131D RID: 4893
		public const int Update = 160;

		// Token: 0x0400131E RID: 4894
		public const int UpdateText = 161;

		// Token: 0x0400131F RID: 4895
		public const int Use = 162;

		// Token: 0x04001320 RID: 4896
		public const int User = 163;

		// Token: 0x04001321 RID: 4897
		public const int Values = 164;

		// Token: 0x04001322 RID: 4898
		public const int Varying = 165;

		// Token: 0x04001323 RID: 4899
		public const int View = 166;

		// Token: 0x04001324 RID: 4900
		public const int WaitFor = 167;

		// Token: 0x04001325 RID: 4901
		public const int When = 168;

		// Token: 0x04001326 RID: 4902
		public const int Where = 169;

		// Token: 0x04001327 RID: 4903
		public const int While = 170;

		// Token: 0x04001328 RID: 4904
		public const int With = 171;

		// Token: 0x04001329 RID: 4905
		public const int WriteText = 172;

		// Token: 0x0400132A RID: 4906
		public const int Disk = 173;

		// Token: 0x0400132B RID: 4907
		public const int Precision = 174;

		// Token: 0x0400132C RID: 4908
		public const int External = 175;

		// Token: 0x0400132D RID: 4909
		public const int Revert = 176;

		// Token: 0x0400132E RID: 4910
		public const int Pivot = 177;

		// Token: 0x0400132F RID: 4911
		public const int Unpivot = 178;

		// Token: 0x04001330 RID: 4912
		public const int TableSample = 179;

		// Token: 0x04001331 RID: 4913
		public const int Dump = 180;

		// Token: 0x04001332 RID: 4914
		public const int Load = 181;

		// Token: 0x04001333 RID: 4915
		public const int Merge = 182;

		// Token: 0x04001334 RID: 4916
		public const int StopList = 183;

		// Token: 0x04001335 RID: 4917
		public const int SemanticKeyPhraseTable = 184;

		// Token: 0x04001336 RID: 4918
		public const int SemanticSimilarityTable = 185;

		// Token: 0x04001337 RID: 4919
		public const int SemanticSimilarityDetailsTable = 186;

		// Token: 0x04001338 RID: 4920
		public const int TryConvert = 187;

		// Token: 0x04001339 RID: 4921
		public const int Bang = 188;

		// Token: 0x0400133A RID: 4922
		public const int PercentSign = 189;

		// Token: 0x0400133B RID: 4923
		public const int Ampersand = 190;

		// Token: 0x0400133C RID: 4924
		public const int LeftParenthesis = 191;

		// Token: 0x0400133D RID: 4925
		public const int RightParenthesis = 192;

		// Token: 0x0400133E RID: 4926
		public const int LeftCurly = 193;

		// Token: 0x0400133F RID: 4927
		public const int RightCurly = 194;

		// Token: 0x04001340 RID: 4928
		public const int Star = 195;

		// Token: 0x04001341 RID: 4929
		public const int MultiplyEquals = 196;

		// Token: 0x04001342 RID: 4930
		public const int Plus = 197;

		// Token: 0x04001343 RID: 4931
		public const int Comma = 198;

		// Token: 0x04001344 RID: 4932
		public const int Minus = 199;

		// Token: 0x04001345 RID: 4933
		public const int Dot = 200;

		// Token: 0x04001346 RID: 4934
		public const int Divide = 201;

		// Token: 0x04001347 RID: 4935
		public const int Colon = 202;

		// Token: 0x04001348 RID: 4936
		public const int DoubleColon = 203;

		// Token: 0x04001349 RID: 4937
		public const int Semicolon = 204;

		// Token: 0x0400134A RID: 4938
		public const int LessThan = 205;

		// Token: 0x0400134B RID: 4939
		public const int EqualsSign = 206;

		// Token: 0x0400134C RID: 4940
		public const int RightOuterJoin = 207;

		// Token: 0x0400134D RID: 4941
		public const int GreaterThan = 208;

		// Token: 0x0400134E RID: 4942
		public const int Circumflex = 209;

		// Token: 0x0400134F RID: 4943
		public const int VerticalLine = 210;

		// Token: 0x04001350 RID: 4944
		public const int Tilde = 211;

		// Token: 0x04001351 RID: 4945
		public const int AddEquals = 212;

		// Token: 0x04001352 RID: 4946
		public const int SubtractEquals = 213;

		// Token: 0x04001353 RID: 4947
		public const int DivideEquals = 214;

		// Token: 0x04001354 RID: 4948
		public const int ModEquals = 215;

		// Token: 0x04001355 RID: 4949
		public const int BitwiseAndEquals = 216;

		// Token: 0x04001356 RID: 4950
		public const int BitwiseOrEquals = 217;

		// Token: 0x04001357 RID: 4951
		public const int BitwiseXorEquals = 218;

		// Token: 0x04001358 RID: 4952
		public const int Go = 219;

		// Token: 0x04001359 RID: 4953
		public const int Label = 220;

		// Token: 0x0400135A RID: 4954
		public const int Integer = 221;

		// Token: 0x0400135B RID: 4955
		public const int Numeric = 222;

		// Token: 0x0400135C RID: 4956
		public const int Real = 223;

		// Token: 0x0400135D RID: 4957
		public const int HexLiteral = 224;

		// Token: 0x0400135E RID: 4958
		public const int Money = 225;

		// Token: 0x0400135F RID: 4959
		public const int SqlCommandIdentifier = 226;

		// Token: 0x04001360 RID: 4960
		public const int PseudoColumn = 227;

		// Token: 0x04001361 RID: 4961
		public const int DollarPartition = 228;

		// Token: 0x04001362 RID: 4962
		public const int AsciiStringOrQuotedIdentifier = 229;

		// Token: 0x04001363 RID: 4963
		public const int AsciiStringLiteral = 230;

		// Token: 0x04001364 RID: 4964
		public const int UnicodeStringLiteral = 231;

		// Token: 0x04001365 RID: 4965
		public const int Identifier = 232;

		// Token: 0x04001366 RID: 4966
		public const int QuotedIdentifier = 233;

		// Token: 0x04001367 RID: 4967
		public const int Variable = 234;

		// Token: 0x04001368 RID: 4968
		public const int OdbcInitiator = 235;

		// Token: 0x04001369 RID: 4969
		public const int ProcNameSemicolon = 236;

		// Token: 0x0400136A RID: 4970
		public const int SingleLineComment = 237;

		// Token: 0x0400136B RID: 4971
		public const int MultilineComment = 238;

		// Token: 0x0400136C RID: 4972
		public const int WhiteSpace = 239;

		// Token: 0x0400136D RID: 4973
		public const int Digit = 240;

		// Token: 0x0400136E RID: 4974
		public const int FirstLetter = 241;

		// Token: 0x0400136F RID: 4975
		public const int Letter = 242;

		// Token: 0x04001370 RID: 4976
		public const int MoneySign = 243;

		// Token: 0x04001371 RID: 4977
		public const int WS_CHAR_WO_NEWLINE = 244;

		// Token: 0x04001372 RID: 4978
		public const int Number = 245;

		// Token: 0x04001373 RID: 4979
		public const int Exponent = 246;

		// Token: 0x04001374 RID: 4980
		public const int EndOfLine = 247;

		// Token: 0x04001375 RID: 4981
		public static readonly BitSet tokenSet_0_ = new BitSet(TSql100LexerInternal.mk_tokenSet_0_());

		// Token: 0x04001376 RID: 4982
		public static readonly BitSet tokenSet_1_ = new BitSet(TSql100LexerInternal.mk_tokenSet_1_());

		// Token: 0x04001377 RID: 4983
		public static readonly BitSet tokenSet_2_ = new BitSet(TSql100LexerInternal.mk_tokenSet_2_());

		// Token: 0x04001378 RID: 4984
		public static readonly BitSet tokenSet_3_ = new BitSet(TSql100LexerInternal.mk_tokenSet_3_());

		// Token: 0x04001379 RID: 4985
		public static readonly BitSet tokenSet_4_ = new BitSet(TSql100LexerInternal.mk_tokenSet_4_());

		// Token: 0x0400137A RID: 4986
		public static readonly BitSet tokenSet_5_ = new BitSet(TSql100LexerInternal.mk_tokenSet_5_());

		// Token: 0x0400137B RID: 4987
		public static readonly BitSet tokenSet_6_ = new BitSet(TSql100LexerInternal.mk_tokenSet_6_());

		// Token: 0x0400137C RID: 4988
		public static readonly BitSet tokenSet_7_ = new BitSet(TSql100LexerInternal.mk_tokenSet_7_());

		// Token: 0x0400137D RID: 4989
		public static readonly BitSet tokenSet_8_ = new BitSet(TSql100LexerInternal.mk_tokenSet_8_());

		// Token: 0x0400137E RID: 4990
		public static readonly BitSet tokenSet_9_ = new BitSet(TSql100LexerInternal.mk_tokenSet_9_());

		// Token: 0x0400137F RID: 4991
		public static readonly BitSet tokenSet_10_ = new BitSet(TSql100LexerInternal.mk_tokenSet_10_());

		// Token: 0x04001380 RID: 4992
		public static readonly BitSet tokenSet_11_ = new BitSet(TSql100LexerInternal.mk_tokenSet_11_());

		// Token: 0x04001381 RID: 4993
		public static readonly BitSet tokenSet_12_ = new BitSet(TSql100LexerInternal.mk_tokenSet_12_());
	}
}
