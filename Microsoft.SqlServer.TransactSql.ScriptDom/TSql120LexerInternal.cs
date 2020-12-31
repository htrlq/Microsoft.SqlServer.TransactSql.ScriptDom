using System;
using System.Collections;
using System.IO;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B7 RID: 439
	internal class TSql120LexerInternal : TSqlLexerBaseInternal, TokenStream
	{
		// Token: 0x060011C3 RID: 4547 RVA: 0x00045B6F File Offset: 0x00043D6F
		public TSql120LexerInternal() : this(new StringReader(string.Empty))
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00045B81 File Offset: 0x00043D81
		public TSql120LexerInternal(Stream ins) : this(new ByteBuffer(ins))
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00045B8F File Offset: 0x00043D8F
		public TSql120LexerInternal(TextReader r) : this(new CharBuffer(r))
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00045B9D File Offset: 0x00043D9D
		public TSql120LexerInternal(InputBuffer ib) : this(new LexerSharedInputState(ib))
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00045BAB File Offset: 0x00043DAB
		public TSql120LexerInternal(LexerSharedInputState state) : base(state)
		{
			this.initialize();
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00045BBC File Offset: 0x00043DBC
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
			this.literals.Add("semanticsimilaritydetailstable", 186);
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
			this.literals.Add("try_convert", 187);
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
			this.literals.Add("semanticsimilaritytable", 185);
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
			this.literals.Add("semantickeyphrasetable", 184);
			this.literals.Add("double", 53);
			this.literals.Add("default", 47);
			this.literals.Add("trigger", 155);
			this.literals.Add("rollback", 134);
			this.literals.Add("group", 76);
			this.literals.Add("exit", 63);
			this.literals.Add("table", 148);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00046CC0 File Offset: 0x00044EC0
		public override IToken nextToken()
		{
			IToken returnToken_41;
			for (;;)
			{
				this.resetText();
				try
				{
					char cached_LA = this.cached_LA1;
					if (cached_LA <= '\u1680')
					{
						if (cached_LA <= '~')
						{
							switch (cached_LA)
							{
							case '\0':
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
								break;
							case '!':
							{
								this.mBang(true);
								IToken returnToken_ = this.returnToken_;
								goto IL_72A;
							}
							case '"':
							case '[':
							{
								this.mQuotedIdentifier(true);
								IToken returnToken_2 = this.returnToken_;
								goto IL_72A;
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
								goto IL_37C;
							case '\'':
							{
								this.mAsciiStringLiteral(true);
								IToken returnToken_3 = this.returnToken_;
								goto IL_72A;
							}
							case '(':
							{
								this.mLeftParenthesis(true);
								IToken returnToken_4 = this.returnToken_;
								goto IL_72A;
							}
							case ')':
							{
								this.mRightParenthesis(true);
								IToken returnToken_5 = this.returnToken_;
								goto IL_72A;
							}
							case ',':
							{
								this.mComma(true);
								IToken returnToken_6 = this.returnToken_;
								goto IL_72A;
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
								IToken returnToken_7 = this.returnToken_;
								goto IL_72A;
							}
							case ';':
							{
								this.mProcNameSemicolon(true);
								IToken returnToken_8 = this.returnToken_;
								goto IL_72A;
							}
							case '<':
							{
								this.mLessThan(true);
								IToken returnToken_9 = this.returnToken_;
								goto IL_72A;
							}
							case '>':
							{
								this.mGreaterThan(true);
								IToken returnToken_10 = this.returnToken_;
								goto IL_72A;
							}
							case '@':
							{
								this.mVariable(true);
								IToken returnToken_11 = this.returnToken_;
								goto IL_72A;
							}
							default:
								switch (cached_LA)
								{
								case '{':
								{
									this.mLeftCurly(true);
									IToken returnToken_12 = this.returnToken_;
									goto IL_72A;
								}
								case '|':
									goto IL_37C;
								case '}':
								{
									this.mRightCurly(true);
									IToken returnToken_13 = this.returnToken_;
									goto IL_72A;
								}
								case '~':
								{
									this.mTilde(true);
									IToken returnToken_14 = this.returnToken_;
									goto IL_72A;
								}
								default:
									goto IL_37C;
								}
								break;
							}
						}
						else if (cached_LA != '\u0085' && cached_LA != '\u00a0' && cached_LA != '\u1680')
						{
							goto IL_37C;
						}
					}
					else if (cached_LA <= '\u2029')
					{
						switch (cached_LA)
						{
						case '\u2000':
						case '\u2001':
						case '\u2002':
						case '\u2003':
						case '\u2004':
						case '\u2005':
						case '\u2006':
						case '\u2007':
						case '\u2008':
						case '\u2009':
						case '\u200a':
						case '​':
							break;
						default:
							switch (cached_LA)
							{
							case '\u2028':
							case '\u2029':
								break;
							default:
								goto IL_37C;
							}
							break;
						}
					}
					else if (cached_LA != '\u202f' && cached_LA != '\u205f' && cached_LA != '\u3000')
					{
						goto IL_37C;
					}
					this.mWhiteSpace(true);
					IToken returnToken_15 = this.returnToken_;
					goto IL_72A;
					IL_37C:
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
					else if (TSql120LexerInternal.tokenSet_0_.member((int)this.cached_LA1))
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
					IL_72A:
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

		// Token: 0x060011CA RID: 4554 RVA: 0x0004744C File Offset: 0x0004564C
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

		// Token: 0x060011CB RID: 4555 RVA: 0x000474B4 File Offset: 0x000456B4
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

		// Token: 0x060011CC RID: 4556 RVA: 0x0004751C File Offset: 0x0004571C
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

		// Token: 0x060011CD RID: 4557 RVA: 0x00047584 File Offset: 0x00045784
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

		// Token: 0x060011CE RID: 4558 RVA: 0x000475EC File Offset: 0x000457EC
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

		// Token: 0x060011CF RID: 4559 RVA: 0x00047654 File Offset: 0x00045854
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

		// Token: 0x060011D0 RID: 4560 RVA: 0x000476BC File Offset: 0x000458BC
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

		// Token: 0x060011D1 RID: 4561 RVA: 0x00047724 File Offset: 0x00045924
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

		// Token: 0x060011D2 RID: 4562 RVA: 0x0004778C File Offset: 0x0004598C
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

		// Token: 0x060011D3 RID: 4563 RVA: 0x000477F4 File Offset: 0x000459F4
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

		// Token: 0x060011D4 RID: 4564 RVA: 0x0004785C File Offset: 0x00045A5C
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

		// Token: 0x060011D5 RID: 4565 RVA: 0x000478C4 File Offset: 0x00045AC4
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

		// Token: 0x060011D6 RID: 4566 RVA: 0x0004792C File Offset: 0x00045B2C
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

		// Token: 0x060011D7 RID: 4567 RVA: 0x0004798C File Offset: 0x00045B8C
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

		// Token: 0x060011D8 RID: 4568 RVA: 0x000479F4 File Offset: 0x00045BF4
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

		// Token: 0x060011D9 RID: 4569 RVA: 0x00047A5C File Offset: 0x00045C5C
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

		// Token: 0x060011DA RID: 4570 RVA: 0x00047AC4 File Offset: 0x00045CC4
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

		// Token: 0x060011DB RID: 4571 RVA: 0x00047B2C File Offset: 0x00045D2C
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

		// Token: 0x060011DC RID: 4572 RVA: 0x00047B94 File Offset: 0x00045D94
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

		// Token: 0x060011DD RID: 4573 RVA: 0x00047BFC File Offset: 0x00045DFC
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

		// Token: 0x060011DE RID: 4574 RVA: 0x00047C64 File Offset: 0x00045E64
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

		// Token: 0x060011DF RID: 4575 RVA: 0x00047CCC File Offset: 0x00045ECC
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

		// Token: 0x060011E0 RID: 4576 RVA: 0x00047D34 File Offset: 0x00045F34
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

		// Token: 0x060011E1 RID: 4577 RVA: 0x00047D9C File Offset: 0x00045F9C
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

		// Token: 0x060011E2 RID: 4578 RVA: 0x00047E04 File Offset: 0x00046004
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

		// Token: 0x060011E3 RID: 4579 RVA: 0x00047E6C File Offset: 0x0004606C
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

		// Token: 0x060011E4 RID: 4580 RVA: 0x00047ED4 File Offset: 0x000460D4
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

		// Token: 0x060011E5 RID: 4581 RVA: 0x00047F3C File Offset: 0x0004613C
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

		// Token: 0x060011E6 RID: 4582 RVA: 0x00047FA4 File Offset: 0x000461A4
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

		// Token: 0x060011E7 RID: 4583 RVA: 0x0004800C File Offset: 0x0004620C
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

		// Token: 0x060011E8 RID: 4584 RVA: 0x00048074 File Offset: 0x00046274
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

		// Token: 0x060011E9 RID: 4585 RVA: 0x000480DC File Offset: 0x000462DC
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

		// Token: 0x060011EA RID: 4586 RVA: 0x00048144 File Offset: 0x00046344
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
					goto IL_F7;
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
					goto IL_F7;
				}
				if (!TSql120LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.mCharHighNotWhitespace(false);
			}
			else
			{
				this.match('#');
			}
			IL_F7:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00048284 File Offset: 0x00046484
		protected void mCharHighNotWhitespace(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 243;
			char cached_LA = this.cached_LA1;
			switch (cached_LA)
			{
			case '\u0080':
			case '\u0081':
			case '\u0082':
			case '\u0083':
			case '\u0084':
				this.matchRange('\u0080', '\u0084');
				goto IL_33B;
			case '\u0085':
				break;
			case '\u0086':
			case '\u0087':
			case '\u0088':
			case '\u0089':
			case '\u008a':
			case '\u008b':
			case '\u008c':
			case '\u008d':
			case '\u008e':
			case '\u008f':
			case '\u0090':
			case '\u0091':
			case '\u0092':
			case '\u0093':
			case '\u0094':
			case '\u0095':
			case '\u0096':
			case '\u0097':
			case '\u0098':
			case '\u0099':
			case '\u009a':
			case '\u009b':
			case '\u009c':
			case '\u009d':
			case '\u009e':
			case '\u009f':
				this.matchRange('\u0086', '\u009f');
				goto IL_33B;
			default:
				switch (cached_LA)
				{
				case '‌':
				case '‍':
				case '‎':
				case '‏':
				case '‐':
				case '‑':
				case '‒':
				case '–':
				case '—':
				case '―':
				case '‖':
				case '‗':
				case '‘':
				case '’':
				case '‚':
				case '‛':
				case '“':
				case '”':
				case '„':
				case '‟':
				case '†':
				case '‡':
				case '•':
				case '‣':
				case '․':
				case '‥':
				case '…':
				case '‧':
					this.matchRange('‌', '‧');
					goto IL_33B;
				case '‪':
				case '‫':
				case '‬':
				case '‭':
				case '‮':
					this.matchRange('‪', '‮');
					goto IL_33B;
				case '‰':
				case '‱':
				case '′':
				case '″':
				case '‴':
				case '‵':
				case '‶':
				case '‷':
				case '‸':
				case '‹':
				case '›':
				case '※':
				case '‼':
				case '‽':
				case '‾':
				case '‿':
				case '⁀':
				case '⁁':
				case '⁂':
				case '⁃':
				case '⁄':
				case '⁅':
				case '⁆':
				case '⁇':
				case '⁈':
				case '⁉':
				case '⁊':
				case '⁋':
				case '⁌':
				case '⁍':
				case '⁎':
				case '⁏':
				case '⁐':
				case '⁑':
				case '⁒':
				case '⁓':
				case '⁔':
				case '⁕':
				case '⁖':
				case '⁗':
				case '⁘':
				case '⁙':
				case '⁚':
				case '⁛':
				case '⁜':
				case '⁝':
				case '⁞':
					this.matchRange('‰', '⁞');
					goto IL_33B;
				}
				break;
			}
			if (this.cached_LA1 >= '¡' && this.cached_LA1 <= 'ᙹ')
			{
				this.matchRange('¡', 'ᙹ');
			}
			else if (this.cached_LA1 >= 'ᚁ' && this.cached_LA1 <= '῿')
			{
				this.matchRange('ᚁ', '῿');
			}
			else if (this.cached_LA1 >= '⁠' && this.cached_LA1 <= '⿿')
			{
				this.matchRange('⁠', '⿿');
			}
			else
			{
				if (this.cached_LA1 < '、' || this.cached_LA1 > '￾')
				{
					throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
				}
				this.matchRange('、', '￾');
			}
			IL_33B:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00048608 File Offset: 0x00046808
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
						goto IL_11C;
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
						goto IL_11C;
					}
					if (!TSql120LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
					{
						throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
					}
					this.mCharHighNotWhitespace(false);
				}
				else
				{
					this.match('@');
				}
				break;
			}
			IL_11C:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00048770 File Offset: 0x00046970
		protected void mMoneySign(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 244;
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

		// Token: 0x060011EE RID: 4590 RVA: 0x00048984 File Offset: 0x00046B84
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
					while (TSql120LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x060011EF RID: 4591 RVA: 0x00048AB8 File Offset: 0x00046CB8
		protected void mWS_CHAR_WO_NEWLINE(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 245;
			char cached_LA = this.cached_LA1;
			if (cached_LA <= '\u1680')
			{
				if (cached_LA <= '\u0085')
				{
					switch (cached_LA)
					{
					case '\0':
					case '\u0001':
					case '\u0002':
					case '\u0003':
					case '\u0004':
					case '\u0005':
					case '\u0006':
					case '\a':
					case '\b':
						this.matchRange('\0', '\b');
						goto IL_264;
					case '\t':
						this.match('\t');
						goto IL_264;
					case '\n':
					case '\r':
						break;
					case '\v':
						this.match('\v');
						goto IL_264;
					case '\f':
						this.match('\f');
						goto IL_264;
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
						this.matchRange('\u000e', '\u001f');
						goto IL_264;
					case ' ':
						this.match(' ');
						goto IL_264;
					default:
						if (cached_LA == '\u0085')
						{
							this.match('\u0085');
							goto IL_264;
						}
						break;
					}
				}
				else
				{
					if (cached_LA == '\u00a0')
					{
						this.match('\u00a0');
						goto IL_264;
					}
					if (cached_LA == '\u1680')
					{
						this.match('\u1680');
						goto IL_264;
					}
				}
			}
			else if (cached_LA <= '\u2029')
			{
				switch (cached_LA)
				{
				case '\u2000':
				case '\u2001':
				case '\u2002':
				case '\u2003':
				case '\u2004':
				case '\u2005':
				case '\u2006':
				case '\u2007':
				case '\u2008':
				case '\u2009':
				case '\u200a':
					this.matchRange('\u2000', '\u200a');
					goto IL_264;
				case '​':
					this.match('​');
					goto IL_264;
				default:
					switch (cached_LA)
					{
					case '\u2028':
						this.match('\u2028');
						goto IL_264;
					case '\u2029':
						this.match('\u2029');
						goto IL_264;
					}
					break;
				}
			}
			else
			{
				if (cached_LA == '\u202f')
				{
					this.match('\u202f');
					goto IL_264;
				}
				if (cached_LA == '\u205f')
				{
					this.match('\u205f');
					goto IL_264;
				}
				if (cached_LA == '\u3000')
				{
					this.match('\u3000');
					goto IL_264;
				}
			}
			throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
			IL_264:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00048D68 File Offset: 0x00046F68
		public void mNumber(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 246;
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

		// Token: 0x060011F1 RID: 4593 RVA: 0x00049088 File Offset: 0x00047288
		public void mWhiteSpace(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 239;
			bool flag = base.CurrentOffset == this._acceptableGoOffset;
			char cached_LA = this.cached_LA1;
			if (cached_LA <= '\u1680')
			{
				if (cached_LA <= '\u0085')
				{
					switch (cached_LA)
					{
					case '\0':
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
						break;
					case '\n':
					case '\r':
						this.mEndOfLine(false);
						if (this.inputState.guessing == 0)
						{
							this._acceptableGoOffset = base.CurrentOffset;
							goto IL_21F;
						}
						goto IL_21F;
					default:
						if (cached_LA != '\u0085')
						{
							goto IL_201;
						}
						break;
					}
				}
				else if (cached_LA != '\u00a0' && cached_LA != '\u1680')
				{
					goto IL_201;
				}
			}
			else if (cached_LA <= '\u2029')
			{
				switch (cached_LA)
				{
				case '\u2000':
				case '\u2001':
				case '\u2002':
				case '\u2003':
				case '\u2004':
				case '\u2005':
				case '\u2006':
				case '\u2007':
				case '\u2008':
				case '\u2009':
				case '\u200a':
				case '​':
					break;
				default:
					switch (cached_LA)
					{
					case '\u2028':
					case '\u2029':
						break;
					default:
						goto IL_201;
					}
					break;
				}
			}
			else if (cached_LA != '\u202f' && cached_LA != '\u205f' && cached_LA != '\u3000')
			{
				goto IL_201;
			}
			int num2 = 0;
			while (TSql120LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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
			goto IL_21F;
			IL_201:
			throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
			IL_21F:
			if (_createToken && token == null && num != Token.SKIP)
			{
				token = this.makeToken(num);
				token.setText(this.text.ToString(length, this.text.Length - length));
			}
			this.returnToken_ = token;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000492F0 File Offset: 0x000474F0
		protected void mEndOfLine(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 248;
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

		// Token: 0x060011F3 RID: 4595 RVA: 0x000493C8 File Offset: 0x000475C8
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
				if (TSql120LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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

		// Token: 0x060011F4 RID: 4596 RVA: 0x00049538 File Offset: 0x00047738
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

		// Token: 0x060011F5 RID: 4597 RVA: 0x00049598 File Offset: 0x00047798
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

		// Token: 0x060011F6 RID: 4598 RVA: 0x000495F8 File Offset: 0x000477F8
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

		// Token: 0x060011F7 RID: 4599 RVA: 0x00049658 File Offset: 0x00047858
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

		// Token: 0x060011F8 RID: 4600 RVA: 0x000496B8 File Offset: 0x000478B8
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

		// Token: 0x060011F9 RID: 4601 RVA: 0x00049718 File Offset: 0x00047918
		protected void mExponent(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 247;
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

		// Token: 0x060011FA RID: 4602 RVA: 0x000497CC File Offset: 0x000479CC
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

		// Token: 0x060011FB RID: 4603 RVA: 0x0004982C File Offset: 0x00047A2C
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

		// Token: 0x060011FC RID: 4604 RVA: 0x0004988C File Offset: 0x00047A8C
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

		// Token: 0x060011FD RID: 4605 RVA: 0x000498EC File Offset: 0x00047AEC
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

		// Token: 0x060011FE RID: 4606 RVA: 0x0004994C File Offset: 0x00047B4C
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

		// Token: 0x060011FF RID: 4607 RVA: 0x000499AC File Offset: 0x00047BAC
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
				else if (TSql120LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql120LexerInternal.tokenSet_4_);
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

		// Token: 0x06001200 RID: 4608 RVA: 0x00049AA4 File Offset: 0x00047CA4
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
				else if (TSql120LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql120LexerInternal.tokenSet_4_);
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

		// Token: 0x06001201 RID: 4609 RVA: 0x00049BA4 File Offset: 0x00047DA4
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
					if (TSql120LexerInternal.tokenSet_5_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.SqlCommandIdentifier);
						}
						this.match(TSql120LexerInternal.tokenSet_5_);
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
				if (this.cached_LA1 == '$' && TSql120LexerInternal.tokenSet_6_.member((int)this.cached_LA2))
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
							if (!TSql120LexerInternal.tokenSet_7_.member((int)this.cached_LA1))
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
						if (!TSql120LexerInternal.tokenSet_7_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
					}
					for (;;)
					{
						if (TSql120LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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
					if (TSql120LexerInternal.tokenSet_8_.member((int)this.cached_LA1) && TSql120LexerInternal.tokenSet_9_.member((int)this.cached_LA2))
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
						if (!TSql120LexerInternal.tokenSet_7_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
						for (;;)
						{
							if (TSql120LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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

		// Token: 0x06001202 RID: 4610 RVA: 0x0004A1B4 File Offset: 0x000483B4
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
					else if (TSql120LexerInternal.tokenSet_10_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql120LexerInternal.tokenSet_10_);
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
					else if (TSql120LexerInternal.tokenSet_11_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql120LexerInternal.tokenSet_11_);
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

		// Token: 0x06001203 RID: 4611 RVA: 0x0004A3D8 File Offset: 0x000485D8
		public void mVariable(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 234;
			this.match('@');
			for (;;)
			{
				if (TSql120LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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

		// Token: 0x06001204 RID: 4612 RVA: 0x0004A478 File Offset: 0x00048678
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

		// Token: 0x06001205 RID: 4613 RVA: 0x0004A4D8 File Offset: 0x000486D8
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
				while (TSql120LexerInternal.tokenSet_12_.member((int)this.cached_LA1) && this.LA(1) != CharScanner.EOF_CHAR)
				{
					this.match(TSql120LexerInternal.tokenSet_12_);
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

		// Token: 0x06001206 RID: 4614 RVA: 0x0004A624 File Offset: 0x00048824
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
					if (!TSql120LexerInternal.tokenSet_13_.member((int)this.cached_LA1))
					{
						break;
					}
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.MultiLineComment);
					}
					this.match(TSql120LexerInternal.tokenSet_13_);
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

		// Token: 0x06001207 RID: 4615 RVA: 0x0004A7B8 File Offset: 0x000489B8
		private static long[] mk_tokenSet_0_()
		{
			long[] array = new long[3088];
			array[0] = 103079215104L;
			array[1] = 576460745860972544L;
			array[2] = -4294967329L;
			for (int i = 3; i <= 88; i++)
			{
				array[i] = -1L;
			}
			array[89] = 288230376151711743L;
			array[90] = -2L;
			for (int j = 91; j <= 127; j++)
			{
				array[j] = -1L;
			}
			array[128] = -144036023242752L;
			array[129] = -2147483649L;
			for (int k = 130; k <= 191; k++)
			{
				array[k] = -1L;
			}
			array[192] = -2L;
			for (int l = 193; l <= 1022; l++)
			{
				array[l] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int m = 1024; m <= 3087; m++)
			{
				array[m] = 0L;
			}
			return array;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0004A8C0 File Offset: 0x00048AC0
		private static long[] mk_tokenSet_1_()
		{
			long[] array = new long[3088];
			for (int i = 0; i <= 1; i++)
			{
				array[i] = 0L;
			}
			array[2] = -4294967329L;
			for (int j = 3; j <= 88; j++)
			{
				array[j] = -1L;
			}
			array[89] = 288230376151711743L;
			array[90] = -2L;
			for (int k = 91; k <= 127; k++)
			{
				array[k] = -1L;
			}
			array[128] = -144036023242752L;
			array[129] = -2147483649L;
			for (int l = 130; l <= 191; l++)
			{
				array[l] = -1L;
			}
			array[192] = -2L;
			for (int m = 193; m <= 1022; m++)
			{
				array[m] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int n = 1024; n <= 3087; n++)
			{
				array[n] = 0L;
			}
			return array;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0004A9C4 File Offset: 0x00048BC4
		private static long[] mk_tokenSet_2_()
		{
			long[] array = new long[1025];
			array[0] = 8589925375L;
			array[1] = 0L;
			array[2] = 4294967328L;
			for (int i = 3; i <= 89; i++)
			{
				array[i] = 0L;
			}
			array[90] = 1L;
			for (int j = 91; j <= 127; j++)
			{
				array[j] = 0L;
			}
			array[128] = 144036023242751L;
			array[129] = (long)(int.MinValue);
			for (int k = 130; k <= 191; k++)
			{
				array[k] = 0L;
			}
			array[192] = 1L;
			for (int l = 193; l <= 1024; l++)
			{
				array[l] = 0L;
			}
			return array;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0004AA84 File Offset: 0x00048C84
		private static long[] mk_tokenSet_3_()
		{
			long[] array = new long[3088];
			array[0] = 103079215104L;
			array[1] = 576460745860972545L;
			array[2] = -4294967329L;
			for (int i = 3; i <= 88; i++)
			{
				array[i] = -1L;
			}
			array[89] = 288230376151711743L;
			array[90] = -2L;
			for (int j = 91; j <= 127; j++)
			{
				array[j] = -1L;
			}
			array[128] = -144036023242752L;
			array[129] = -2147483649L;
			for (int k = 130; k <= 191; k++)
			{
				array[k] = -1L;
			}
			array[192] = -2L;
			for (int l = 193; l <= 1022; l++)
			{
				array[l] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int m = 1024; m <= 3087; m++)
			{
				array[m] = 0L;
			}
			return array;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0004AB8C File Offset: 0x00048D8C
		private static long[] mk_tokenSet_4_()
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

		// Token: 0x0600120C RID: 4620 RVA: 0x0004ABE0 File Offset: 0x00048DE0
		private static long[] mk_tokenSet_5_()
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

		// Token: 0x0600120D RID: 4621 RVA: 0x0004AC34 File Offset: 0x00048E34
		private static long[] mk_tokenSet_6_()
		{
			long[] array = new long[3088];
			array[0] = 34359738368L;
			array[1] = 576460745860972545L;
			array[2] = -4294967329L;
			for (int i = 3; i <= 88; i++)
			{
				array[i] = -1L;
			}
			array[89] = 288230376151711743L;
			array[90] = -2L;
			for (int j = 91; j <= 127; j++)
			{
				array[j] = -1L;
			}
			array[128] = -144036023242752L;
			array[129] = -2147483649L;
			for (int k = 130; k <= 191; k++)
			{
				array[k] = -1L;
			}
			array[192] = -2L;
			for (int l = 193; l <= 1022; l++)
			{
				array[l] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int m = 1024; m <= 3087; m++)
			{
				array[m] = 0L;
			}
			return array;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0004AD3C File Offset: 0x00048F3C
		private static long[] mk_tokenSet_7_()
		{
			long[] array = new long[3088];
			array[0] = 34359738368L;
			array[1] = 576460745860972544L;
			array[2] = -4294967329L;
			for (int i = 3; i <= 88; i++)
			{
				array[i] = -1L;
			}
			array[89] = 288230376151711743L;
			array[90] = -2L;
			for (int j = 91; j <= 127; j++)
			{
				array[j] = -1L;
			}
			array[128] = -144036023242752L;
			array[129] = -2147483649L;
			for (int k = 130; k <= 191; k++)
			{
				array[k] = -1L;
			}
			array[192] = -2L;
			for (int l = 193; l <= 1022; l++)
			{
				array[l] = -1L;
			}
			array[1023] = long.MaxValue;
			for (int m = 1024; m <= 3087; m++)
			{
				array[m] = 0L;
			}
			return array;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0004AE44 File Offset: 0x00049044
		private static long[] mk_tokenSet_8_()
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

		// Token: 0x06001210 RID: 4624 RVA: 0x0004AF00 File Offset: 0x00049100
		private static long[] mk_tokenSet_9_()
		{
			long[] array = new long[1025];
			array[0] = 287992885935079424L;
			for (int i = 1; i <= 1024; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0004AF3C File Offset: 0x0004913C
		private static long[] mk_tokenSet_10_()
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

		// Token: 0x06001212 RID: 4626 RVA: 0x0004AF98 File Offset: 0x00049198
		private static long[] mk_tokenSet_11_()
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

		// Token: 0x06001213 RID: 4627 RVA: 0x0004AFEC File Offset: 0x000491EC
		private static long[] mk_tokenSet_12_()
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

		// Token: 0x06001214 RID: 4628 RVA: 0x0004B03C File Offset: 0x0004923C
		private static long[] mk_tokenSet_13_()
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

		// Token: 0x04001487 RID: 5255
		public const int EOF = 1;

		// Token: 0x04001488 RID: 5256
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x04001489 RID: 5257
		public const int Add = 4;

		// Token: 0x0400148A RID: 5258
		public const int All = 5;

		// Token: 0x0400148B RID: 5259
		public const int Alter = 6;

		// Token: 0x0400148C RID: 5260
		public const int And = 7;

		// Token: 0x0400148D RID: 5261
		public const int Any = 8;

		// Token: 0x0400148E RID: 5262
		public const int As = 9;

		// Token: 0x0400148F RID: 5263
		public const int Asc = 10;

		// Token: 0x04001490 RID: 5264
		public const int Authorization = 11;

		// Token: 0x04001491 RID: 5265
		public const int Backup = 12;

		// Token: 0x04001492 RID: 5266
		public const int Begin = 13;

		// Token: 0x04001493 RID: 5267
		public const int Between = 14;

		// Token: 0x04001494 RID: 5268
		public const int Break = 15;

		// Token: 0x04001495 RID: 5269
		public const int Browse = 16;

		// Token: 0x04001496 RID: 5270
		public const int Bulk = 17;

		// Token: 0x04001497 RID: 5271
		public const int By = 18;

		// Token: 0x04001498 RID: 5272
		public const int Cascade = 19;

		// Token: 0x04001499 RID: 5273
		public const int Case = 20;

		// Token: 0x0400149A RID: 5274
		public const int Check = 21;

		// Token: 0x0400149B RID: 5275
		public const int Checkpoint = 22;

		// Token: 0x0400149C RID: 5276
		public const int Close = 23;

		// Token: 0x0400149D RID: 5277
		public const int Clustered = 24;

		// Token: 0x0400149E RID: 5278
		public const int Coalesce = 25;

		// Token: 0x0400149F RID: 5279
		public const int Collate = 26;

		// Token: 0x040014A0 RID: 5280
		public const int Column = 27;

		// Token: 0x040014A1 RID: 5281
		public const int Commit = 28;

		// Token: 0x040014A2 RID: 5282
		public const int Compute = 29;

		// Token: 0x040014A3 RID: 5283
		public const int Constraint = 30;

		// Token: 0x040014A4 RID: 5284
		public const int Contains = 31;

		// Token: 0x040014A5 RID: 5285
		public const int ContainsTable = 32;

		// Token: 0x040014A6 RID: 5286
		public const int Continue = 33;

		// Token: 0x040014A7 RID: 5287
		public const int Convert = 34;

		// Token: 0x040014A8 RID: 5288
		public const int Create = 35;

		// Token: 0x040014A9 RID: 5289
		public const int Cross = 36;

		// Token: 0x040014AA RID: 5290
		public const int Current = 37;

		// Token: 0x040014AB RID: 5291
		public const int CurrentDate = 38;

		// Token: 0x040014AC RID: 5292
		public const int CurrentTime = 39;

		// Token: 0x040014AD RID: 5293
		public const int CurrentTimestamp = 40;

		// Token: 0x040014AE RID: 5294
		public const int CurrentUser = 41;

		// Token: 0x040014AF RID: 5295
		public const int Cursor = 42;

		// Token: 0x040014B0 RID: 5296
		public const int Database = 43;

		// Token: 0x040014B1 RID: 5297
		public const int Dbcc = 44;

		// Token: 0x040014B2 RID: 5298
		public const int Deallocate = 45;

		// Token: 0x040014B3 RID: 5299
		public const int Declare = 46;

		// Token: 0x040014B4 RID: 5300
		public const int Default = 47;

		// Token: 0x040014B5 RID: 5301
		public const int Delete = 48;

		// Token: 0x040014B6 RID: 5302
		public const int Deny = 49;

		// Token: 0x040014B7 RID: 5303
		public const int Desc = 50;

		// Token: 0x040014B8 RID: 5304
		public const int Distinct = 51;

		// Token: 0x040014B9 RID: 5305
		public const int Distributed = 52;

		// Token: 0x040014BA RID: 5306
		public const int Double = 53;

		// Token: 0x040014BB RID: 5307
		public const int Drop = 54;

		// Token: 0x040014BC RID: 5308
		public const int Else = 55;

		// Token: 0x040014BD RID: 5309
		public const int End = 56;

		// Token: 0x040014BE RID: 5310
		public const int Errlvl = 57;

		// Token: 0x040014BF RID: 5311
		public const int Escape = 58;

		// Token: 0x040014C0 RID: 5312
		public const int Except = 59;

		// Token: 0x040014C1 RID: 5313
		public const int Exec = 60;

		// Token: 0x040014C2 RID: 5314
		public const int Execute = 61;

		// Token: 0x040014C3 RID: 5315
		public const int Exists = 62;

		// Token: 0x040014C4 RID: 5316
		public const int Exit = 63;

		// Token: 0x040014C5 RID: 5317
		public const int Fetch = 64;

		// Token: 0x040014C6 RID: 5318
		public const int File = 65;

		// Token: 0x040014C7 RID: 5319
		public const int FillFactor = 66;

		// Token: 0x040014C8 RID: 5320
		public const int For = 67;

		// Token: 0x040014C9 RID: 5321
		public const int Foreign = 68;

		// Token: 0x040014CA RID: 5322
		public const int FreeText = 69;

		// Token: 0x040014CB RID: 5323
		public const int FreeTextTable = 70;

		// Token: 0x040014CC RID: 5324
		public const int From = 71;

		// Token: 0x040014CD RID: 5325
		public const int Full = 72;

		// Token: 0x040014CE RID: 5326
		public const int Function = 73;

		// Token: 0x040014CF RID: 5327
		public const int GoTo = 74;

		// Token: 0x040014D0 RID: 5328
		public const int Grant = 75;

		// Token: 0x040014D1 RID: 5329
		public const int Group = 76;

		// Token: 0x040014D2 RID: 5330
		public const int Having = 77;

		// Token: 0x040014D3 RID: 5331
		public const int HoldLock = 78;

		// Token: 0x040014D4 RID: 5332
		public const int Identity = 79;

		// Token: 0x040014D5 RID: 5333
		public const int IdentityInsert = 80;

		// Token: 0x040014D6 RID: 5334
		public const int IdentityColumn = 81;

		// Token: 0x040014D7 RID: 5335
		public const int If = 82;

		// Token: 0x040014D8 RID: 5336
		public const int In = 83;

		// Token: 0x040014D9 RID: 5337
		public const int Index = 84;

		// Token: 0x040014DA RID: 5338
		public const int Inner = 85;

		// Token: 0x040014DB RID: 5339
		public const int Insert = 86;

		// Token: 0x040014DC RID: 5340
		public const int Intersect = 87;

		// Token: 0x040014DD RID: 5341
		public const int Into = 88;

		// Token: 0x040014DE RID: 5342
		public const int Is = 89;

		// Token: 0x040014DF RID: 5343
		public const int Join = 90;

		// Token: 0x040014E0 RID: 5344
		public const int Key = 91;

		// Token: 0x040014E1 RID: 5345
		public const int Kill = 92;

		// Token: 0x040014E2 RID: 5346
		public const int Left = 93;

		// Token: 0x040014E3 RID: 5347
		public const int Like = 94;

		// Token: 0x040014E4 RID: 5348
		public const int LineNo = 95;

		// Token: 0x040014E5 RID: 5349
		public const int National = 96;

		// Token: 0x040014E6 RID: 5350
		public const int NoCheck = 97;

		// Token: 0x040014E7 RID: 5351
		public const int NonClustered = 98;

		// Token: 0x040014E8 RID: 5352
		public const int Not = 99;

		// Token: 0x040014E9 RID: 5353
		public const int Null = 100;

		// Token: 0x040014EA RID: 5354
		public const int NullIf = 101;

		// Token: 0x040014EB RID: 5355
		public const int Of = 102;

		// Token: 0x040014EC RID: 5356
		public const int Off = 103;

		// Token: 0x040014ED RID: 5357
		public const int Offsets = 104;

		// Token: 0x040014EE RID: 5358
		public const int On = 105;

		// Token: 0x040014EF RID: 5359
		public const int Open = 106;

		// Token: 0x040014F0 RID: 5360
		public const int OpenDataSource = 107;

		// Token: 0x040014F1 RID: 5361
		public const int OpenQuery = 108;

		// Token: 0x040014F2 RID: 5362
		public const int OpenRowSet = 109;

		// Token: 0x040014F3 RID: 5363
		public const int OpenXml = 110;

		// Token: 0x040014F4 RID: 5364
		public const int Option = 111;

		// Token: 0x040014F5 RID: 5365
		public const int Or = 112;

		// Token: 0x040014F6 RID: 5366
		public const int Order = 113;

		// Token: 0x040014F7 RID: 5367
		public const int Outer = 114;

		// Token: 0x040014F8 RID: 5368
		public const int Over = 115;

		// Token: 0x040014F9 RID: 5369
		public const int Percent = 116;

		// Token: 0x040014FA RID: 5370
		public const int Plan = 117;

		// Token: 0x040014FB RID: 5371
		public const int Primary = 118;

		// Token: 0x040014FC RID: 5372
		public const int Print = 119;

		// Token: 0x040014FD RID: 5373
		public const int Proc = 120;

		// Token: 0x040014FE RID: 5374
		public const int Procedure = 121;

		// Token: 0x040014FF RID: 5375
		public const int Public = 122;

		// Token: 0x04001500 RID: 5376
		public const int Raiserror = 123;

		// Token: 0x04001501 RID: 5377
		public const int Read = 124;

		// Token: 0x04001502 RID: 5378
		public const int ReadText = 125;

		// Token: 0x04001503 RID: 5379
		public const int Reconfigure = 126;

		// Token: 0x04001504 RID: 5380
		public const int References = 127;

		// Token: 0x04001505 RID: 5381
		public const int Replication = 128;

		// Token: 0x04001506 RID: 5382
		public const int Restore = 129;

		// Token: 0x04001507 RID: 5383
		public const int Restrict = 130;

		// Token: 0x04001508 RID: 5384
		public const int Return = 131;

		// Token: 0x04001509 RID: 5385
		public const int Revoke = 132;

		// Token: 0x0400150A RID: 5386
		public const int Right = 133;

		// Token: 0x0400150B RID: 5387
		public const int Rollback = 134;

		// Token: 0x0400150C RID: 5388
		public const int RowCount = 135;

		// Token: 0x0400150D RID: 5389
		public const int RowGuidColumn = 136;

		// Token: 0x0400150E RID: 5390
		public const int Rule = 137;

		// Token: 0x0400150F RID: 5391
		public const int Save = 138;

		// Token: 0x04001510 RID: 5392
		public const int Schema = 139;

		// Token: 0x04001511 RID: 5393
		public const int Select = 140;

		// Token: 0x04001512 RID: 5394
		public const int SessionUser = 141;

		// Token: 0x04001513 RID: 5395
		public const int Set = 142;

		// Token: 0x04001514 RID: 5396
		public const int SetUser = 143;

		// Token: 0x04001515 RID: 5397
		public const int Shutdown = 144;

		// Token: 0x04001516 RID: 5398
		public const int Some = 145;

		// Token: 0x04001517 RID: 5399
		public const int Statistics = 146;

		// Token: 0x04001518 RID: 5400
		public const int SystemUser = 147;

		// Token: 0x04001519 RID: 5401
		public const int Table = 148;

		// Token: 0x0400151A RID: 5402
		public const int TextSize = 149;

		// Token: 0x0400151B RID: 5403
		public const int Then = 150;

		// Token: 0x0400151C RID: 5404
		public const int To = 151;

		// Token: 0x0400151D RID: 5405
		public const int Top = 152;

		// Token: 0x0400151E RID: 5406
		public const int Tran = 153;

		// Token: 0x0400151F RID: 5407
		public const int Transaction = 154;

		// Token: 0x04001520 RID: 5408
		public const int Trigger = 155;

		// Token: 0x04001521 RID: 5409
		public const int Truncate = 156;

		// Token: 0x04001522 RID: 5410
		public const int TSEqual = 157;

		// Token: 0x04001523 RID: 5411
		public const int Union = 158;

		// Token: 0x04001524 RID: 5412
		public const int Unique = 159;

		// Token: 0x04001525 RID: 5413
		public const int Update = 160;

		// Token: 0x04001526 RID: 5414
		public const int UpdateText = 161;

		// Token: 0x04001527 RID: 5415
		public const int Use = 162;

		// Token: 0x04001528 RID: 5416
		public const int User = 163;

		// Token: 0x04001529 RID: 5417
		public const int Values = 164;

		// Token: 0x0400152A RID: 5418
		public const int Varying = 165;

		// Token: 0x0400152B RID: 5419
		public const int View = 166;

		// Token: 0x0400152C RID: 5420
		public const int WaitFor = 167;

		// Token: 0x0400152D RID: 5421
		public const int When = 168;

		// Token: 0x0400152E RID: 5422
		public const int Where = 169;

		// Token: 0x0400152F RID: 5423
		public const int While = 170;

		// Token: 0x04001530 RID: 5424
		public const int With = 171;

		// Token: 0x04001531 RID: 5425
		public const int WriteText = 172;

		// Token: 0x04001532 RID: 5426
		public const int Disk = 173;

		// Token: 0x04001533 RID: 5427
		public const int Precision = 174;

		// Token: 0x04001534 RID: 5428
		public const int External = 175;

		// Token: 0x04001535 RID: 5429
		public const int Revert = 176;

		// Token: 0x04001536 RID: 5430
		public const int Pivot = 177;

		// Token: 0x04001537 RID: 5431
		public const int Unpivot = 178;

		// Token: 0x04001538 RID: 5432
		public const int TableSample = 179;

		// Token: 0x04001539 RID: 5433
		public const int Dump = 180;

		// Token: 0x0400153A RID: 5434
		public const int Load = 181;

		// Token: 0x0400153B RID: 5435
		public const int Merge = 182;

		// Token: 0x0400153C RID: 5436
		public const int StopList = 183;

		// Token: 0x0400153D RID: 5437
		public const int SemanticKeyPhraseTable = 184;

		// Token: 0x0400153E RID: 5438
		public const int SemanticSimilarityTable = 185;

		// Token: 0x0400153F RID: 5439
		public const int SemanticSimilarityDetailsTable = 186;

		// Token: 0x04001540 RID: 5440
		public const int TryConvert = 187;

		// Token: 0x04001541 RID: 5441
		public const int Bang = 188;

		// Token: 0x04001542 RID: 5442
		public const int PercentSign = 189;

		// Token: 0x04001543 RID: 5443
		public const int Ampersand = 190;

		// Token: 0x04001544 RID: 5444
		public const int LeftParenthesis = 191;

		// Token: 0x04001545 RID: 5445
		public const int RightParenthesis = 192;

		// Token: 0x04001546 RID: 5446
		public const int LeftCurly = 193;

		// Token: 0x04001547 RID: 5447
		public const int RightCurly = 194;

		// Token: 0x04001548 RID: 5448
		public const int Star = 195;

		// Token: 0x04001549 RID: 5449
		public const int MultiplyEquals = 196;

		// Token: 0x0400154A RID: 5450
		public const int Plus = 197;

		// Token: 0x0400154B RID: 5451
		public const int Comma = 198;

		// Token: 0x0400154C RID: 5452
		public const int Minus = 199;

		// Token: 0x0400154D RID: 5453
		public const int Dot = 200;

		// Token: 0x0400154E RID: 5454
		public const int Divide = 201;

		// Token: 0x0400154F RID: 5455
		public const int Colon = 202;

		// Token: 0x04001550 RID: 5456
		public const int DoubleColon = 203;

		// Token: 0x04001551 RID: 5457
		public const int Semicolon = 204;

		// Token: 0x04001552 RID: 5458
		public const int LessThan = 205;

		// Token: 0x04001553 RID: 5459
		public const int EqualsSign = 206;

		// Token: 0x04001554 RID: 5460
		public const int RightOuterJoin = 207;

		// Token: 0x04001555 RID: 5461
		public const int GreaterThan = 208;

		// Token: 0x04001556 RID: 5462
		public const int Circumflex = 209;

		// Token: 0x04001557 RID: 5463
		public const int VerticalLine = 210;

		// Token: 0x04001558 RID: 5464
		public const int Tilde = 211;

		// Token: 0x04001559 RID: 5465
		public const int AddEquals = 212;

		// Token: 0x0400155A RID: 5466
		public const int SubtractEquals = 213;

		// Token: 0x0400155B RID: 5467
		public const int DivideEquals = 214;

		// Token: 0x0400155C RID: 5468
		public const int ModEquals = 215;

		// Token: 0x0400155D RID: 5469
		public const int BitwiseAndEquals = 216;

		// Token: 0x0400155E RID: 5470
		public const int BitwiseOrEquals = 217;

		// Token: 0x0400155F RID: 5471
		public const int BitwiseXorEquals = 218;

		// Token: 0x04001560 RID: 5472
		public const int Go = 219;

		// Token: 0x04001561 RID: 5473
		public const int Label = 220;

		// Token: 0x04001562 RID: 5474
		public const int Integer = 221;

		// Token: 0x04001563 RID: 5475
		public const int Numeric = 222;

		// Token: 0x04001564 RID: 5476
		public const int Real = 223;

		// Token: 0x04001565 RID: 5477
		public const int HexLiteral = 224;

		// Token: 0x04001566 RID: 5478
		public const int Money = 225;

		// Token: 0x04001567 RID: 5479
		public const int SqlCommandIdentifier = 226;

		// Token: 0x04001568 RID: 5480
		public const int PseudoColumn = 227;

		// Token: 0x04001569 RID: 5481
		public const int DollarPartition = 228;

		// Token: 0x0400156A RID: 5482
		public const int AsciiStringOrQuotedIdentifier = 229;

		// Token: 0x0400156B RID: 5483
		public const int AsciiStringLiteral = 230;

		// Token: 0x0400156C RID: 5484
		public const int UnicodeStringLiteral = 231;

		// Token: 0x0400156D RID: 5485
		public const int Identifier = 232;

		// Token: 0x0400156E RID: 5486
		public const int QuotedIdentifier = 233;

		// Token: 0x0400156F RID: 5487
		public const int Variable = 234;

		// Token: 0x04001570 RID: 5488
		public const int OdbcInitiator = 235;

		// Token: 0x04001571 RID: 5489
		public const int ProcNameSemicolon = 236;

		// Token: 0x04001572 RID: 5490
		public const int SingleLineComment = 237;

		// Token: 0x04001573 RID: 5491
		public const int MultilineComment = 238;

		// Token: 0x04001574 RID: 5492
		public const int WhiteSpace = 239;

		// Token: 0x04001575 RID: 5493
		public const int Digit = 240;

		// Token: 0x04001576 RID: 5494
		public const int FirstLetter = 241;

		// Token: 0x04001577 RID: 5495
		public const int Letter = 242;

		// Token: 0x04001578 RID: 5496
		public const int CharHighNotWhitespace = 243;

		// Token: 0x04001579 RID: 5497
		public const int MoneySign = 244;

		// Token: 0x0400157A RID: 5498
		public const int WS_CHAR_WO_NEWLINE = 245;

		// Token: 0x0400157B RID: 5499
		public const int Number = 246;

		// Token: 0x0400157C RID: 5500
		public const int Exponent = 247;

		// Token: 0x0400157D RID: 5501
		public const int EndOfLine = 248;

		// Token: 0x0400157E RID: 5502
		public static readonly BitSet tokenSet_0_ = new BitSet(TSql120LexerInternal.mk_tokenSet_0_());

		// Token: 0x0400157F RID: 5503
		public static readonly BitSet tokenSet_1_ = new BitSet(TSql120LexerInternal.mk_tokenSet_1_());

		// Token: 0x04001580 RID: 5504
		public static readonly BitSet tokenSet_2_ = new BitSet(TSql120LexerInternal.mk_tokenSet_2_());

		// Token: 0x04001581 RID: 5505
		public static readonly BitSet tokenSet_3_ = new BitSet(TSql120LexerInternal.mk_tokenSet_3_());

		// Token: 0x04001582 RID: 5506
		public static readonly BitSet tokenSet_4_ = new BitSet(TSql120LexerInternal.mk_tokenSet_4_());

		// Token: 0x04001583 RID: 5507
		public static readonly BitSet tokenSet_5_ = new BitSet(TSql120LexerInternal.mk_tokenSet_5_());

		// Token: 0x04001584 RID: 5508
		public static readonly BitSet tokenSet_6_ = new BitSet(TSql120LexerInternal.mk_tokenSet_6_());

		// Token: 0x04001585 RID: 5509
		public static readonly BitSet tokenSet_7_ = new BitSet(TSql120LexerInternal.mk_tokenSet_7_());

		// Token: 0x04001586 RID: 5510
		public static readonly BitSet tokenSet_8_ = new BitSet(TSql120LexerInternal.mk_tokenSet_8_());

		// Token: 0x04001587 RID: 5511
		public static readonly BitSet tokenSet_9_ = new BitSet(TSql120LexerInternal.mk_tokenSet_9_());

		// Token: 0x04001588 RID: 5512
		public static readonly BitSet tokenSet_10_ = new BitSet(TSql120LexerInternal.mk_tokenSet_10_());

		// Token: 0x04001589 RID: 5513
		public static readonly BitSet tokenSet_11_ = new BitSet(TSql120LexerInternal.mk_tokenSet_11_());

		// Token: 0x0400158A RID: 5514
		public static readonly BitSet tokenSet_12_ = new BitSet(TSql120LexerInternal.mk_tokenSet_12_());

		// Token: 0x0400158B RID: 5515
		public static readonly BitSet tokenSet_13_ = new BitSet(TSql120LexerInternal.mk_tokenSet_13_());
	}
}
