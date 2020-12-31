using System;
using System.Collections.Generic;
using System.Globalization;
using antlr;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000034 RID: 52
	internal abstract class OptionsHelper<OptionType> where OptionType : struct, IConvertible
	{
		// Token: 0x0600019C RID: 412 RVA: 0x000059F0 File Offset: 0x00003BF0
		protected void AddOptionMapping(OptionType option, string identifier, SqlVersionFlags validVersions)
		{
			OptionsHelper<OptionType>.OptionInfo value = new OptionsHelper<OptionType>.OptionInfo(option, identifier, validVersions);
			this._optionToOptionInfo.Add(option, value);
			this._stringToOptionInfo.Add(identifier, value);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005A20 File Offset: 0x00003C20
		protected void AddOptionMapping(OptionType option, TSqlTokenType tokenId, SqlVersionFlags validVersions)
		{
			OptionsHelper<OptionType>.OptionInfo value = new OptionsHelper<OptionType>.OptionInfo(option, tokenId, validVersions);
			this._optionToOptionInfo.Add(option, value);
			this._stringToOptionInfo.Add(ScriptGeneratorSupporter.GetLowerCase(tokenId), value);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005A55 File Offset: 0x00003C55
		protected void AddOptionMapping(OptionType option, string identifier)
		{
			this.AddOptionMapping(option, identifier, SqlVersionFlags.TSqlAll);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005A61 File Offset: 0x00003C61
		protected void AddOptionMapping(OptionType option, TSqlTokenType tokenId)
		{
			this.AddOptionMapping(option, tokenId, SqlVersionFlags.TSqlAll);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005A6D File Offset: 0x00003C6D
		internal bool IsValidKeyword(IToken token)
		{
			return this._stringToOptionInfo.ContainsKey(token.getText());
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005A80 File Offset: 0x00003C80
		internal SqlVersionFlags MapSqlVersionToSqlVersionFlags(SqlVersion sqlVersion)
		{
			switch (sqlVersion)
			{
			case SqlVersion.Sql90:
				return SqlVersionFlags.TSql90;
			case SqlVersion.Sql80:
				return SqlVersionFlags.TSql80;
			case SqlVersion.Sql100:
				return SqlVersionFlags.TSql100;
			case SqlVersion.Sql110:
				return SqlVersionFlags.TSql110;
			case SqlVersion.Sql120:
				return SqlVersionFlags.TSql120;
			default:
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SqlScriptGeneratorResource.UnknownEnumValue, new object[]
				{
					sqlVersion,
					"SqlVersion"
				}), "sqlVersion");
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005AE8 File Offset: 0x00003CE8
		internal OptionType ParseOption(IToken token, SqlVersionFlags version)
		{
			OptionsHelper<OptionType>.OptionInfo optionInfo;
			if (this._stringToOptionInfo.TryGetValue(token.getText(), out optionInfo) && optionInfo.IsValidIn(version))
			{
				return optionInfo.Value;
			}
			throw this.GetMatchingException(token);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005B21 File Offset: 0x00003D21
		internal bool TryParseOption(IToken token, SqlVersionFlags version, out OptionType returnValue)
		{
			return this.TryParseOption(token.getText(), version, out returnValue);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005B34 File Offset: 0x00003D34
		internal bool TryParseOption(string tokenString, SqlVersionFlags version, out OptionType returnValue)
		{
			OptionsHelper<OptionType>.OptionInfo optionInfo;
			if (this._stringToOptionInfo.TryGetValue(tokenString, out optionInfo) && optionInfo.IsValidIn(version))
			{
				returnValue = optionInfo.Value;
				return true;
			}
			returnValue = default(OptionType);
			return false;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005B70 File Offset: 0x00003D70
		internal OptionType ParseOption(IToken token)
		{
			return this.ParseOption(token, SqlVersionFlags.TSqlAll);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00005B7B File Offset: 0x00003D7B
		internal bool TryParseOption(IToken token, out OptionType returnValue)
		{
			return this.TryParseOption(token, SqlVersionFlags.TSqlAll, out returnValue);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005B87 File Offset: 0x00003D87
		protected virtual TSqlParseErrorException GetMatchingException(IToken token)
		{
			return TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005B90 File Offset: 0x00003D90
		internal void GenerateSourceForOption(ScriptWriter writer, OptionType option)
		{
			OptionsHelper<OptionType>.OptionInfo optionInfo;
			if (this._optionToOptionInfo.TryGetValue(option, out optionInfo))
			{
				optionInfo.GenerateSource(writer);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005BB4 File Offset: 0x00003DB4
		internal bool TryGenerateSourceForOption(ScriptWriter writer, OptionType option)
		{
			OptionsHelper<OptionType>.OptionInfo optionInfo;
			if (this._optionToOptionInfo.TryGetValue(option, out optionInfo))
			{
				optionInfo.GenerateSource(writer);
				return true;
			}
			return false;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005BDC File Offset: 0x00003DDC
		internal void GenerateCommaSeparatedFlagOptions(ScriptWriter writer, OptionType options)
		{
			bool flag = true;
			long num = options.ToInt64(CultureInfo.InvariantCulture.NumberFormat);
			foreach (object obj in Enum.GetValues(typeof(OptionType)))
			{
				OptionType option = (OptionType)((object)obj);
				long num2 = option.ToInt64(CultureInfo.InvariantCulture.NumberFormat);
				if (!option.Equals(default(OptionType)) && (num & num2) == num2)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						writer.AddKeyword(TSqlTokenType.Comma);
						writer.AddToken(ScriptGeneratorSupporter.CreateWhitespaceToken(1));
					}
					this.GenerateSourceForOption(writer, option);
				}
			}
		}

		// Token: 0x040000C9 RID: 201
		private Dictionary<OptionType, OptionsHelper<OptionType>.OptionInfo> _optionToOptionInfo = new Dictionary<OptionType, OptionsHelper<OptionType>.OptionInfo>();

		// Token: 0x040000CA RID: 202
		private Dictionary<string, OptionsHelper<OptionType>.OptionInfo> _stringToOptionInfo = new Dictionary<string, OptionsHelper<OptionType>.OptionInfo>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x02000035 RID: 53
		private class OptionInfo
		{
			// Token: 0x060001AC RID: 428 RVA: 0x00005CDF File Offset: 0x00003EDF
			public OptionInfo(OptionType optionValue, TSqlTokenType tokenId, SqlVersionFlags appliesToVersion)
			{
				this._optionValue = optionValue;
				this._tokenId = tokenId;
				this._identifier = null;
				this._validVersions = appliesToVersion;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00005D03 File Offset: 0x00003F03
			public OptionInfo(OptionType optionValue, string identifier, SqlVersionFlags validVersions)
			{
				this._optionValue = optionValue;
				this._tokenId = TSqlTokenType.None;
				this._identifier = identifier;
				this._validVersions = validVersions;
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00005D27 File Offset: 0x00003F27
			public void GenerateSource(ScriptWriter writer)
			{
				if (this._identifier != null)
				{
					writer.AddIdentifierWithoutCasing(this._identifier);
					return;
				}
				writer.AddKeyword(this._tokenId);
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00005D4A File Offset: 0x00003F4A
			public bool IsValidIn(SqlVersionFlags version)
			{
				return (this._validVersions & version) != SqlVersionFlags.None;
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060001B0 RID: 432 RVA: 0x00005D5A File Offset: 0x00003F5A
			public OptionType Value
			{
				get
				{
					return this._optionValue;
				}
			}

			// Token: 0x040000CB RID: 203
			private readonly OptionType _optionValue;

			// Token: 0x040000CC RID: 204
			private readonly TSqlTokenType _tokenId;

			// Token: 0x040000CD RID: 205
			private readonly string _identifier;

			// Token: 0x040000CE RID: 206
			private readonly SqlVersionFlags _validVersions;
		}
	}
}
