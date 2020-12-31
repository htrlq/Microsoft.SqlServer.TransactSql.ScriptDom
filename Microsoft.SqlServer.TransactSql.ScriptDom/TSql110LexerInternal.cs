using System;
using System.Collections;
using System.IO;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B6 RID: 438
	internal class TSql110LexerInternal : TSqlLexerBaseInternal, TokenStream
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x00040570 File Offset: 0x0003E770
		public TSql110LexerInternal() : this(new StringReader(string.Empty))
		{
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00040582 File Offset: 0x0003E782
		public TSql110LexerInternal(Stream ins) : this(new ByteBuffer(ins))
		{
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00040590 File Offset: 0x0003E790
		public TSql110LexerInternal(TextReader r) : this(new CharBuffer(r))
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0004059E File Offset: 0x0003E79E
		public TSql110LexerInternal(InputBuffer ib) : this(new LexerSharedInputState(ib))
		{
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000405AC File Offset: 0x0003E7AC
		public TSql110LexerInternal(LexerSharedInputState state) : base(state)
		{
			this.initialize();
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000405BC File Offset: 0x0003E7BC
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

		// Token: 0x06001176 RID: 4470 RVA: 0x000416C0 File Offset: 0x0003F8C0
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
					else if (TSql110LexerInternal.tokenSet_0_.member((int)this.cached_LA1))
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

		// Token: 0x06001177 RID: 4471 RVA: 0x00041E4C File Offset: 0x0004004C
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

		// Token: 0x06001178 RID: 4472 RVA: 0x00041EB4 File Offset: 0x000400B4
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

		// Token: 0x06001179 RID: 4473 RVA: 0x00041F1C File Offset: 0x0004011C
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

		// Token: 0x0600117A RID: 4474 RVA: 0x00041F84 File Offset: 0x00040184
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

		// Token: 0x0600117B RID: 4475 RVA: 0x00041FEC File Offset: 0x000401EC
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

		// Token: 0x0600117C RID: 4476 RVA: 0x00042054 File Offset: 0x00040254
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

		// Token: 0x0600117D RID: 4477 RVA: 0x000420BC File Offset: 0x000402BC
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

		// Token: 0x0600117E RID: 4478 RVA: 0x00042124 File Offset: 0x00040324
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

		// Token: 0x0600117F RID: 4479 RVA: 0x0004218C File Offset: 0x0004038C
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

		// Token: 0x06001180 RID: 4480 RVA: 0x000421F4 File Offset: 0x000403F4
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

		// Token: 0x06001181 RID: 4481 RVA: 0x0004225C File Offset: 0x0004045C
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

		// Token: 0x06001182 RID: 4482 RVA: 0x000422C4 File Offset: 0x000404C4
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

		// Token: 0x06001183 RID: 4483 RVA: 0x0004232C File Offset: 0x0004052C
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

		// Token: 0x06001184 RID: 4484 RVA: 0x0004238C File Offset: 0x0004058C
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

		// Token: 0x06001185 RID: 4485 RVA: 0x000423F4 File Offset: 0x000405F4
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

		// Token: 0x06001186 RID: 4486 RVA: 0x0004245C File Offset: 0x0004065C
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

		// Token: 0x06001187 RID: 4487 RVA: 0x000424C4 File Offset: 0x000406C4
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

		// Token: 0x06001188 RID: 4488 RVA: 0x0004252C File Offset: 0x0004072C
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

		// Token: 0x06001189 RID: 4489 RVA: 0x00042594 File Offset: 0x00040794
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

		// Token: 0x0600118A RID: 4490 RVA: 0x000425FC File Offset: 0x000407FC
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

		// Token: 0x0600118B RID: 4491 RVA: 0x00042664 File Offset: 0x00040864
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

		// Token: 0x0600118C RID: 4492 RVA: 0x000426CC File Offset: 0x000408CC
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

		// Token: 0x0600118D RID: 4493 RVA: 0x00042734 File Offset: 0x00040934
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

		// Token: 0x0600118E RID: 4494 RVA: 0x0004279C File Offset: 0x0004099C
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

		// Token: 0x0600118F RID: 4495 RVA: 0x00042804 File Offset: 0x00040A04
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

		// Token: 0x06001190 RID: 4496 RVA: 0x0004286C File Offset: 0x00040A6C
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

		// Token: 0x06001191 RID: 4497 RVA: 0x000428D4 File Offset: 0x00040AD4
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

		// Token: 0x06001192 RID: 4498 RVA: 0x0004293C File Offset: 0x00040B3C
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

		// Token: 0x06001193 RID: 4499 RVA: 0x000429A4 File Offset: 0x00040BA4
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

		// Token: 0x06001194 RID: 4500 RVA: 0x00042A0C File Offset: 0x00040C0C
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

		// Token: 0x06001195 RID: 4501 RVA: 0x00042A74 File Offset: 0x00040C74
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

		// Token: 0x06001196 RID: 4502 RVA: 0x00042ADC File Offset: 0x00040CDC
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

		// Token: 0x06001197 RID: 4503 RVA: 0x00042B44 File Offset: 0x00040D44
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
				if (!TSql110LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
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

		// Token: 0x06001198 RID: 4504 RVA: 0x00042C84 File Offset: 0x00040E84
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

		// Token: 0x06001199 RID: 4505 RVA: 0x00043008 File Offset: 0x00041208
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
					if (!TSql110LexerInternal.tokenSet_1_.member((int)this.cached_LA1))
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

		// Token: 0x0600119A RID: 4506 RVA: 0x00043170 File Offset: 0x00041370
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

		// Token: 0x0600119B RID: 4507 RVA: 0x00043384 File Offset: 0x00041584
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
					while (TSql110LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600119C RID: 4508 RVA: 0x000434B8 File Offset: 0x000416B8
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

		// Token: 0x0600119D RID: 4509 RVA: 0x00043768 File Offset: 0x00041968
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

		// Token: 0x0600119E RID: 4510 RVA: 0x00043A88 File Offset: 0x00041C88
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
			while (TSql110LexerInternal.tokenSet_2_.member((int)this.cached_LA1))
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

		// Token: 0x0600119F RID: 4511 RVA: 0x00043CF0 File Offset: 0x00041EF0
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

		// Token: 0x060011A0 RID: 4512 RVA: 0x00043DC8 File Offset: 0x00041FC8
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
				if (TSql110LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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

		// Token: 0x060011A1 RID: 4513 RVA: 0x00043F38 File Offset: 0x00042138
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

		// Token: 0x060011A2 RID: 4514 RVA: 0x00043F98 File Offset: 0x00042198
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

		// Token: 0x060011A3 RID: 4515 RVA: 0x00043FF8 File Offset: 0x000421F8
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

		// Token: 0x060011A4 RID: 4516 RVA: 0x00044058 File Offset: 0x00042258
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

		// Token: 0x060011A5 RID: 4517 RVA: 0x000440B8 File Offset: 0x000422B8
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

		// Token: 0x060011A6 RID: 4518 RVA: 0x00044118 File Offset: 0x00042318
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

		// Token: 0x060011A7 RID: 4519 RVA: 0x000441CC File Offset: 0x000423CC
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

		// Token: 0x060011A8 RID: 4520 RVA: 0x0004422C File Offset: 0x0004242C
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

		// Token: 0x060011A9 RID: 4521 RVA: 0x0004428C File Offset: 0x0004248C
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

		// Token: 0x060011AA RID: 4522 RVA: 0x000442EC File Offset: 0x000424EC
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

		// Token: 0x060011AB RID: 4523 RVA: 0x0004434C File Offset: 0x0004254C
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

		// Token: 0x060011AC RID: 4524 RVA: 0x000443AC File Offset: 0x000425AC
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
				else if (TSql110LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql110LexerInternal.tokenSet_4_);
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

		// Token: 0x060011AD RID: 4525 RVA: 0x000444A4 File Offset: 0x000426A4
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
				else if (TSql110LexerInternal.tokenSet_4_.member((int)this.cached_LA1))
				{
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.String);
					}
					this.match(TSql110LexerInternal.tokenSet_4_);
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

		// Token: 0x060011AE RID: 4526 RVA: 0x000445A4 File Offset: 0x000427A4
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
					if (TSql110LexerInternal.tokenSet_5_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.SqlCommandIdentifier);
						}
						this.match(TSql110LexerInternal.tokenSet_5_);
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
				if (this.cached_LA1 == '$' && TSql110LexerInternal.tokenSet_6_.member((int)this.cached_LA2))
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
							if (!TSql110LexerInternal.tokenSet_7_.member((int)this.cached_LA1))
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
						if (!TSql110LexerInternal.tokenSet_7_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
					}
					for (;;)
					{
						if (TSql110LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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
					if (TSql110LexerInternal.tokenSet_8_.member((int)this.cached_LA1) && TSql110LexerInternal.tokenSet_9_.member((int)this.cached_LA2))
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
						if (!TSql110LexerInternal.tokenSet_7_.member((int)this.cached_LA1))
						{
							throw new NoViableAltForCharException(this.cached_LA1, this.getFilename(), this.getLine(), this.getColumn());
						}
						this.mFirstLetter(false);
						for (;;)
						{
							if (TSql110LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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

		// Token: 0x060011AF RID: 4527 RVA: 0x00044BB4 File Offset: 0x00042DB4
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
					else if (TSql110LexerInternal.tokenSet_10_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql110LexerInternal.tokenSet_10_);
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
					else if (TSql110LexerInternal.tokenSet_11_.member((int)this.cached_LA1))
					{
						if (this.inputState.guessing == 0)
						{
							base.checkEOF(TSqlLexerBaseInternal.TokenKind.QuotedIdentifier);
						}
						this.match(TSql110LexerInternal.tokenSet_11_);
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

		// Token: 0x060011B0 RID: 4528 RVA: 0x00044DD8 File Offset: 0x00042FD8
		public void mVariable(bool _createToken)
		{
			IToken token = null;
			int length = this.text.Length;
			int num = 234;
			this.match('@');
			for (;;)
			{
				if (TSql110LexerInternal.tokenSet_3_.member((int)this.cached_LA1))
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

		// Token: 0x060011B1 RID: 4529 RVA: 0x00044E78 File Offset: 0x00043078
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

		// Token: 0x060011B2 RID: 4530 RVA: 0x00044ED8 File Offset: 0x000430D8
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
				while (TSql110LexerInternal.tokenSet_12_.member((int)this.cached_LA1) && this.LA(1) != CharScanner.EOF_CHAR)
				{
					this.match(TSql110LexerInternal.tokenSet_12_);
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

		// Token: 0x060011B3 RID: 4531 RVA: 0x00045024 File Offset: 0x00043224
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
					if (!TSql110LexerInternal.tokenSet_13_.member((int)this.cached_LA1))
					{
						break;
					}
					if (this.inputState.guessing == 0)
					{
						base.checkEOF(TSqlLexerBaseInternal.TokenKind.MultiLineComment);
					}
					this.match(TSql110LexerInternal.tokenSet_13_);
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

		// Token: 0x060011B4 RID: 4532 RVA: 0x000451B8 File Offset: 0x000433B8
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

		// Token: 0x060011B5 RID: 4533 RVA: 0x000452C0 File Offset: 0x000434C0
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

		// Token: 0x060011B6 RID: 4534 RVA: 0x000453C4 File Offset: 0x000435C4
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

		// Token: 0x060011B7 RID: 4535 RVA: 0x00045484 File Offset: 0x00043684
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

		// Token: 0x060011B8 RID: 4536 RVA: 0x0004558C File Offset: 0x0004378C
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

		// Token: 0x060011B9 RID: 4537 RVA: 0x000455E0 File Offset: 0x000437E0
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

		// Token: 0x060011BA RID: 4538 RVA: 0x00045634 File Offset: 0x00043834
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

		// Token: 0x060011BB RID: 4539 RVA: 0x0004573C File Offset: 0x0004393C
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

		// Token: 0x060011BC RID: 4540 RVA: 0x00045844 File Offset: 0x00043A44
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

		// Token: 0x060011BD RID: 4541 RVA: 0x00045900 File Offset: 0x00043B00
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

		// Token: 0x060011BE RID: 4542 RVA: 0x0004593C File Offset: 0x00043B3C
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

		// Token: 0x060011BF RID: 4543 RVA: 0x00045998 File Offset: 0x00043B98
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

		// Token: 0x060011C0 RID: 4544 RVA: 0x000459EC File Offset: 0x00043BEC
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

		// Token: 0x060011C1 RID: 4545 RVA: 0x00045A3C File Offset: 0x00043C3C
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

		// Token: 0x04001382 RID: 4994
		public const int EOF = 1;

		// Token: 0x04001383 RID: 4995
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x04001384 RID: 4996
		public const int Add = 4;

		// Token: 0x04001385 RID: 4997
		public const int All = 5;

		// Token: 0x04001386 RID: 4998
		public const int Alter = 6;

		// Token: 0x04001387 RID: 4999
		public const int And = 7;

		// Token: 0x04001388 RID: 5000
		public const int Any = 8;

		// Token: 0x04001389 RID: 5001
		public const int As = 9;

		// Token: 0x0400138A RID: 5002
		public const int Asc = 10;

		// Token: 0x0400138B RID: 5003
		public const int Authorization = 11;

		// Token: 0x0400138C RID: 5004
		public const int Backup = 12;

		// Token: 0x0400138D RID: 5005
		public const int Begin = 13;

		// Token: 0x0400138E RID: 5006
		public const int Between = 14;

		// Token: 0x0400138F RID: 5007
		public const int Break = 15;

		// Token: 0x04001390 RID: 5008
		public const int Browse = 16;

		// Token: 0x04001391 RID: 5009
		public const int Bulk = 17;

		// Token: 0x04001392 RID: 5010
		public const int By = 18;

		// Token: 0x04001393 RID: 5011
		public const int Cascade = 19;

		// Token: 0x04001394 RID: 5012
		public const int Case = 20;

		// Token: 0x04001395 RID: 5013
		public const int Check = 21;

		// Token: 0x04001396 RID: 5014
		public const int Checkpoint = 22;

		// Token: 0x04001397 RID: 5015
		public const int Close = 23;

		// Token: 0x04001398 RID: 5016
		public const int Clustered = 24;

		// Token: 0x04001399 RID: 5017
		public const int Coalesce = 25;

		// Token: 0x0400139A RID: 5018
		public const int Collate = 26;

		// Token: 0x0400139B RID: 5019
		public const int Column = 27;

		// Token: 0x0400139C RID: 5020
		public const int Commit = 28;

		// Token: 0x0400139D RID: 5021
		public const int Compute = 29;

		// Token: 0x0400139E RID: 5022
		public const int Constraint = 30;

		// Token: 0x0400139F RID: 5023
		public const int Contains = 31;

		// Token: 0x040013A0 RID: 5024
		public const int ContainsTable = 32;

		// Token: 0x040013A1 RID: 5025
		public const int Continue = 33;

		// Token: 0x040013A2 RID: 5026
		public const int Convert = 34;

		// Token: 0x040013A3 RID: 5027
		public const int Create = 35;

		// Token: 0x040013A4 RID: 5028
		public const int Cross = 36;

		// Token: 0x040013A5 RID: 5029
		public const int Current = 37;

		// Token: 0x040013A6 RID: 5030
		public const int CurrentDate = 38;

		// Token: 0x040013A7 RID: 5031
		public const int CurrentTime = 39;

		// Token: 0x040013A8 RID: 5032
		public const int CurrentTimestamp = 40;

		// Token: 0x040013A9 RID: 5033
		public const int CurrentUser = 41;

		// Token: 0x040013AA RID: 5034
		public const int Cursor = 42;

		// Token: 0x040013AB RID: 5035
		public const int Database = 43;

		// Token: 0x040013AC RID: 5036
		public const int Dbcc = 44;

		// Token: 0x040013AD RID: 5037
		public const int Deallocate = 45;

		// Token: 0x040013AE RID: 5038
		public const int Declare = 46;

		// Token: 0x040013AF RID: 5039
		public const int Default = 47;

		// Token: 0x040013B0 RID: 5040
		public const int Delete = 48;

		// Token: 0x040013B1 RID: 5041
		public const int Deny = 49;

		// Token: 0x040013B2 RID: 5042
		public const int Desc = 50;

		// Token: 0x040013B3 RID: 5043
		public const int Distinct = 51;

		// Token: 0x040013B4 RID: 5044
		public const int Distributed = 52;

		// Token: 0x040013B5 RID: 5045
		public const int Double = 53;

		// Token: 0x040013B6 RID: 5046
		public const int Drop = 54;

		// Token: 0x040013B7 RID: 5047
		public const int Else = 55;

		// Token: 0x040013B8 RID: 5048
		public const int End = 56;

		// Token: 0x040013B9 RID: 5049
		public const int Errlvl = 57;

		// Token: 0x040013BA RID: 5050
		public const int Escape = 58;

		// Token: 0x040013BB RID: 5051
		public const int Except = 59;

		// Token: 0x040013BC RID: 5052
		public const int Exec = 60;

		// Token: 0x040013BD RID: 5053
		public const int Execute = 61;

		// Token: 0x040013BE RID: 5054
		public const int Exists = 62;

		// Token: 0x040013BF RID: 5055
		public const int Exit = 63;

		// Token: 0x040013C0 RID: 5056
		public const int Fetch = 64;

		// Token: 0x040013C1 RID: 5057
		public const int File = 65;

		// Token: 0x040013C2 RID: 5058
		public const int FillFactor = 66;

		// Token: 0x040013C3 RID: 5059
		public const int For = 67;

		// Token: 0x040013C4 RID: 5060
		public const int Foreign = 68;

		// Token: 0x040013C5 RID: 5061
		public const int FreeText = 69;

		// Token: 0x040013C6 RID: 5062
		public const int FreeTextTable = 70;

		// Token: 0x040013C7 RID: 5063
		public const int From = 71;

		// Token: 0x040013C8 RID: 5064
		public const int Full = 72;

		// Token: 0x040013C9 RID: 5065
		public const int Function = 73;

		// Token: 0x040013CA RID: 5066
		public const int GoTo = 74;

		// Token: 0x040013CB RID: 5067
		public const int Grant = 75;

		// Token: 0x040013CC RID: 5068
		public const int Group = 76;

		// Token: 0x040013CD RID: 5069
		public const int Having = 77;

		// Token: 0x040013CE RID: 5070
		public const int HoldLock = 78;

		// Token: 0x040013CF RID: 5071
		public const int Identity = 79;

		// Token: 0x040013D0 RID: 5072
		public const int IdentityInsert = 80;

		// Token: 0x040013D1 RID: 5073
		public const int IdentityColumn = 81;

		// Token: 0x040013D2 RID: 5074
		public const int If = 82;

		// Token: 0x040013D3 RID: 5075
		public const int In = 83;

		// Token: 0x040013D4 RID: 5076
		public const int Index = 84;

		// Token: 0x040013D5 RID: 5077
		public const int Inner = 85;

		// Token: 0x040013D6 RID: 5078
		public const int Insert = 86;

		// Token: 0x040013D7 RID: 5079
		public const int Intersect = 87;

		// Token: 0x040013D8 RID: 5080
		public const int Into = 88;

		// Token: 0x040013D9 RID: 5081
		public const int Is = 89;

		// Token: 0x040013DA RID: 5082
		public const int Join = 90;

		// Token: 0x040013DB RID: 5083
		public const int Key = 91;

		// Token: 0x040013DC RID: 5084
		public const int Kill = 92;

		// Token: 0x040013DD RID: 5085
		public const int Left = 93;

		// Token: 0x040013DE RID: 5086
		public const int Like = 94;

		// Token: 0x040013DF RID: 5087
		public const int LineNo = 95;

		// Token: 0x040013E0 RID: 5088
		public const int National = 96;

		// Token: 0x040013E1 RID: 5089
		public const int NoCheck = 97;

		// Token: 0x040013E2 RID: 5090
		public const int NonClustered = 98;

		// Token: 0x040013E3 RID: 5091
		public const int Not = 99;

		// Token: 0x040013E4 RID: 5092
		public const int Null = 100;

		// Token: 0x040013E5 RID: 5093
		public const int NullIf = 101;

		// Token: 0x040013E6 RID: 5094
		public const int Of = 102;

		// Token: 0x040013E7 RID: 5095
		public const int Off = 103;

		// Token: 0x040013E8 RID: 5096
		public const int Offsets = 104;

		// Token: 0x040013E9 RID: 5097
		public const int On = 105;

		// Token: 0x040013EA RID: 5098
		public const int Open = 106;

		// Token: 0x040013EB RID: 5099
		public const int OpenDataSource = 107;

		// Token: 0x040013EC RID: 5100
		public const int OpenQuery = 108;

		// Token: 0x040013ED RID: 5101
		public const int OpenRowSet = 109;

		// Token: 0x040013EE RID: 5102
		public const int OpenXml = 110;

		// Token: 0x040013EF RID: 5103
		public const int Option = 111;

		// Token: 0x040013F0 RID: 5104
		public const int Or = 112;

		// Token: 0x040013F1 RID: 5105
		public const int Order = 113;

		// Token: 0x040013F2 RID: 5106
		public const int Outer = 114;

		// Token: 0x040013F3 RID: 5107
		public const int Over = 115;

		// Token: 0x040013F4 RID: 5108
		public const int Percent = 116;

		// Token: 0x040013F5 RID: 5109
		public const int Plan = 117;

		// Token: 0x040013F6 RID: 5110
		public const int Primary = 118;

		// Token: 0x040013F7 RID: 5111
		public const int Print = 119;

		// Token: 0x040013F8 RID: 5112
		public const int Proc = 120;

		// Token: 0x040013F9 RID: 5113
		public const int Procedure = 121;

		// Token: 0x040013FA RID: 5114
		public const int Public = 122;

		// Token: 0x040013FB RID: 5115
		public const int Raiserror = 123;

		// Token: 0x040013FC RID: 5116
		public const int Read = 124;

		// Token: 0x040013FD RID: 5117
		public const int ReadText = 125;

		// Token: 0x040013FE RID: 5118
		public const int Reconfigure = 126;

		// Token: 0x040013FF RID: 5119
		public const int References = 127;

		// Token: 0x04001400 RID: 5120
		public const int Replication = 128;

		// Token: 0x04001401 RID: 5121
		public const int Restore = 129;

		// Token: 0x04001402 RID: 5122
		public const int Restrict = 130;

		// Token: 0x04001403 RID: 5123
		public const int Return = 131;

		// Token: 0x04001404 RID: 5124
		public const int Revoke = 132;

		// Token: 0x04001405 RID: 5125
		public const int Right = 133;

		// Token: 0x04001406 RID: 5126
		public const int Rollback = 134;

		// Token: 0x04001407 RID: 5127
		public const int RowCount = 135;

		// Token: 0x04001408 RID: 5128
		public const int RowGuidColumn = 136;

		// Token: 0x04001409 RID: 5129
		public const int Rule = 137;

		// Token: 0x0400140A RID: 5130
		public const int Save = 138;

		// Token: 0x0400140B RID: 5131
		public const int Schema = 139;

		// Token: 0x0400140C RID: 5132
		public const int Select = 140;

		// Token: 0x0400140D RID: 5133
		public const int SessionUser = 141;

		// Token: 0x0400140E RID: 5134
		public const int Set = 142;

		// Token: 0x0400140F RID: 5135
		public const int SetUser = 143;

		// Token: 0x04001410 RID: 5136
		public const int Shutdown = 144;

		// Token: 0x04001411 RID: 5137
		public const int Some = 145;

		// Token: 0x04001412 RID: 5138
		public const int Statistics = 146;

		// Token: 0x04001413 RID: 5139
		public const int SystemUser = 147;

		// Token: 0x04001414 RID: 5140
		public const int Table = 148;

		// Token: 0x04001415 RID: 5141
		public const int TextSize = 149;

		// Token: 0x04001416 RID: 5142
		public const int Then = 150;

		// Token: 0x04001417 RID: 5143
		public const int To = 151;

		// Token: 0x04001418 RID: 5144
		public const int Top = 152;

		// Token: 0x04001419 RID: 5145
		public const int Tran = 153;

		// Token: 0x0400141A RID: 5146
		public const int Transaction = 154;

		// Token: 0x0400141B RID: 5147
		public const int Trigger = 155;

		// Token: 0x0400141C RID: 5148
		public const int Truncate = 156;

		// Token: 0x0400141D RID: 5149
		public const int TSEqual = 157;

		// Token: 0x0400141E RID: 5150
		public const int Union = 158;

		// Token: 0x0400141F RID: 5151
		public const int Unique = 159;

		// Token: 0x04001420 RID: 5152
		public const int Update = 160;

		// Token: 0x04001421 RID: 5153
		public const int UpdateText = 161;

		// Token: 0x04001422 RID: 5154
		public const int Use = 162;

		// Token: 0x04001423 RID: 5155
		public const int User = 163;

		// Token: 0x04001424 RID: 5156
		public const int Values = 164;

		// Token: 0x04001425 RID: 5157
		public const int Varying = 165;

		// Token: 0x04001426 RID: 5158
		public const int View = 166;

		// Token: 0x04001427 RID: 5159
		public const int WaitFor = 167;

		// Token: 0x04001428 RID: 5160
		public const int When = 168;

		// Token: 0x04001429 RID: 5161
		public const int Where = 169;

		// Token: 0x0400142A RID: 5162
		public const int While = 170;

		// Token: 0x0400142B RID: 5163
		public const int With = 171;

		// Token: 0x0400142C RID: 5164
		public const int WriteText = 172;

		// Token: 0x0400142D RID: 5165
		public const int Disk = 173;

		// Token: 0x0400142E RID: 5166
		public const int Precision = 174;

		// Token: 0x0400142F RID: 5167
		public const int External = 175;

		// Token: 0x04001430 RID: 5168
		public const int Revert = 176;

		// Token: 0x04001431 RID: 5169
		public const int Pivot = 177;

		// Token: 0x04001432 RID: 5170
		public const int Unpivot = 178;

		// Token: 0x04001433 RID: 5171
		public const int TableSample = 179;

		// Token: 0x04001434 RID: 5172
		public const int Dump = 180;

		// Token: 0x04001435 RID: 5173
		public const int Load = 181;

		// Token: 0x04001436 RID: 5174
		public const int Merge = 182;

		// Token: 0x04001437 RID: 5175
		public const int StopList = 183;

		// Token: 0x04001438 RID: 5176
		public const int SemanticKeyPhraseTable = 184;

		// Token: 0x04001439 RID: 5177
		public const int SemanticSimilarityTable = 185;

		// Token: 0x0400143A RID: 5178
		public const int SemanticSimilarityDetailsTable = 186;

		// Token: 0x0400143B RID: 5179
		public const int TryConvert = 187;

		// Token: 0x0400143C RID: 5180
		public const int Bang = 188;

		// Token: 0x0400143D RID: 5181
		public const int PercentSign = 189;

		// Token: 0x0400143E RID: 5182
		public const int Ampersand = 190;

		// Token: 0x0400143F RID: 5183
		public const int LeftParenthesis = 191;

		// Token: 0x04001440 RID: 5184
		public const int RightParenthesis = 192;

		// Token: 0x04001441 RID: 5185
		public const int LeftCurly = 193;

		// Token: 0x04001442 RID: 5186
		public const int RightCurly = 194;

		// Token: 0x04001443 RID: 5187
		public const int Star = 195;

		// Token: 0x04001444 RID: 5188
		public const int MultiplyEquals = 196;

		// Token: 0x04001445 RID: 5189
		public const int Plus = 197;

		// Token: 0x04001446 RID: 5190
		public const int Comma = 198;

		// Token: 0x04001447 RID: 5191
		public const int Minus = 199;

		// Token: 0x04001448 RID: 5192
		public const int Dot = 200;

		// Token: 0x04001449 RID: 5193
		public const int Divide = 201;

		// Token: 0x0400144A RID: 5194
		public const int Colon = 202;

		// Token: 0x0400144B RID: 5195
		public const int DoubleColon = 203;

		// Token: 0x0400144C RID: 5196
		public const int Semicolon = 204;

		// Token: 0x0400144D RID: 5197
		public const int LessThan = 205;

		// Token: 0x0400144E RID: 5198
		public const int EqualsSign = 206;

		// Token: 0x0400144F RID: 5199
		public const int RightOuterJoin = 207;

		// Token: 0x04001450 RID: 5200
		public const int GreaterThan = 208;

		// Token: 0x04001451 RID: 5201
		public const int Circumflex = 209;

		// Token: 0x04001452 RID: 5202
		public const int VerticalLine = 210;

		// Token: 0x04001453 RID: 5203
		public const int Tilde = 211;

		// Token: 0x04001454 RID: 5204
		public const int AddEquals = 212;

		// Token: 0x04001455 RID: 5205
		public const int SubtractEquals = 213;

		// Token: 0x04001456 RID: 5206
		public const int DivideEquals = 214;

		// Token: 0x04001457 RID: 5207
		public const int ModEquals = 215;

		// Token: 0x04001458 RID: 5208
		public const int BitwiseAndEquals = 216;

		// Token: 0x04001459 RID: 5209
		public const int BitwiseOrEquals = 217;

		// Token: 0x0400145A RID: 5210
		public const int BitwiseXorEquals = 218;

		// Token: 0x0400145B RID: 5211
		public const int Go = 219;

		// Token: 0x0400145C RID: 5212
		public const int Label = 220;

		// Token: 0x0400145D RID: 5213
		public const int Integer = 221;

		// Token: 0x0400145E RID: 5214
		public const int Numeric = 222;

		// Token: 0x0400145F RID: 5215
		public const int Real = 223;

		// Token: 0x04001460 RID: 5216
		public const int HexLiteral = 224;

		// Token: 0x04001461 RID: 5217
		public const int Money = 225;

		// Token: 0x04001462 RID: 5218
		public const int SqlCommandIdentifier = 226;

		// Token: 0x04001463 RID: 5219
		public const int PseudoColumn = 227;

		// Token: 0x04001464 RID: 5220
		public const int DollarPartition = 228;

		// Token: 0x04001465 RID: 5221
		public const int AsciiStringOrQuotedIdentifier = 229;

		// Token: 0x04001466 RID: 5222
		public const int AsciiStringLiteral = 230;

		// Token: 0x04001467 RID: 5223
		public const int UnicodeStringLiteral = 231;

		// Token: 0x04001468 RID: 5224
		public const int Identifier = 232;

		// Token: 0x04001469 RID: 5225
		public const int QuotedIdentifier = 233;

		// Token: 0x0400146A RID: 5226
		public const int Variable = 234;

		// Token: 0x0400146B RID: 5227
		public const int OdbcInitiator = 235;

		// Token: 0x0400146C RID: 5228
		public const int ProcNameSemicolon = 236;

		// Token: 0x0400146D RID: 5229
		public const int SingleLineComment = 237;

		// Token: 0x0400146E RID: 5230
		public const int MultilineComment = 238;

		// Token: 0x0400146F RID: 5231
		public const int WhiteSpace = 239;

		// Token: 0x04001470 RID: 5232
		public const int Digit = 240;

		// Token: 0x04001471 RID: 5233
		public const int FirstLetter = 241;

		// Token: 0x04001472 RID: 5234
		public const int Letter = 242;

		// Token: 0x04001473 RID: 5235
		public const int CharHighNotWhitespace = 243;

		// Token: 0x04001474 RID: 5236
		public const int MoneySign = 244;

		// Token: 0x04001475 RID: 5237
		public const int WS_CHAR_WO_NEWLINE = 245;

		// Token: 0x04001476 RID: 5238
		public const int Number = 246;

		// Token: 0x04001477 RID: 5239
		public const int Exponent = 247;

		// Token: 0x04001478 RID: 5240
		public const int EndOfLine = 248;

		// Token: 0x04001479 RID: 5241
		public static readonly BitSet tokenSet_0_ = new BitSet(TSql110LexerInternal.mk_tokenSet_0_());

		// Token: 0x0400147A RID: 5242
		public static readonly BitSet tokenSet_1_ = new BitSet(TSql110LexerInternal.mk_tokenSet_1_());

		// Token: 0x0400147B RID: 5243
		public static readonly BitSet tokenSet_2_ = new BitSet(TSql110LexerInternal.mk_tokenSet_2_());

		// Token: 0x0400147C RID: 5244
		public static readonly BitSet tokenSet_3_ = new BitSet(TSql110LexerInternal.mk_tokenSet_3_());

		// Token: 0x0400147D RID: 5245
		public static readonly BitSet tokenSet_4_ = new BitSet(TSql110LexerInternal.mk_tokenSet_4_());

		// Token: 0x0400147E RID: 5246
		public static readonly BitSet tokenSet_5_ = new BitSet(TSql110LexerInternal.mk_tokenSet_5_());

		// Token: 0x0400147F RID: 5247
		public static readonly BitSet tokenSet_6_ = new BitSet(TSql110LexerInternal.mk_tokenSet_6_());

		// Token: 0x04001480 RID: 5248
		public static readonly BitSet tokenSet_7_ = new BitSet(TSql110LexerInternal.mk_tokenSet_7_());

		// Token: 0x04001481 RID: 5249
		public static readonly BitSet tokenSet_8_ = new BitSet(TSql110LexerInternal.mk_tokenSet_8_());

		// Token: 0x04001482 RID: 5250
		public static readonly BitSet tokenSet_9_ = new BitSet(TSql110LexerInternal.mk_tokenSet_9_());

		// Token: 0x04001483 RID: 5251
		public static readonly BitSet tokenSet_10_ = new BitSet(TSql110LexerInternal.mk_tokenSet_10_());

		// Token: 0x04001484 RID: 5252
		public static readonly BitSet tokenSet_11_ = new BitSet(TSql110LexerInternal.mk_tokenSet_11_());

		// Token: 0x04001485 RID: 5253
		public static readonly BitSet tokenSet_12_ = new BitSet(TSql110LexerInternal.mk_tokenSet_12_());

		// Token: 0x04001486 RID: 5254
		public static readonly BitSet tokenSet_13_ = new BitSet(TSql110LexerInternal.mk_tokenSet_13_());
	}
}
