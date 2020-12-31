using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x0200019A RID: 410
	internal class ScriptWriter
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x0002079C File Offset: 0x0001E99C
		public ScriptWriter(SqlScriptGeneratorOptions options)
		{
			this._options = options;
			this._alignmentPointDataMap = new Dictionary<AlignmentPoint, ScriptWriter.AlignmentPointData>();
			this._alignmentPointNameMapForCurrentScope = new Dictionary<string, AlignmentPoint>();
			this._alignmentPointNameMaps = new Stack<Dictionary<string, AlignmentPoint>>();
			this._scriptWriterElements = new List<ScriptWriter.ScriptWriterElement>();
			this._newLineAlignmentPoints = new Stack<AlignmentPoint>();
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x000207F0 File Offset: 0x0001E9F0
		public void AddKeyword(TSqlTokenType keywordId)
		{
			string tokenString = ScriptGeneratorSupporter.GetTokenString(keywordId, this._options.KeywordCasing);
			TSqlParserToken token = new TSqlParserToken(keywordId, tokenString);
			this.AddToken(token);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002081E File Offset: 0x0001EA1E
		public void AddIdentifierWithCasing(string text)
		{
			ScriptGeneratorSupporter.CheckForNullReference(text, "text");
			this.AddIdentifier(text, true);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00020833 File Offset: 0x0001EA33
		public void AddIdentifierWithoutCasing(string text)
		{
			ScriptGeneratorSupporter.CheckForNullReference(text, "text");
			this.AddIdentifier(text, false);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00020848 File Offset: 0x0001EA48
		public void AddToken(TSqlParserToken token)
		{
			ScriptGeneratorSupporter.CheckForNullReference(token, "token");
			this.AddTokenWrapper(new ScriptWriter.TokenWrapper(token));
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00020861 File Offset: 0x0001EA61
		public void NewLine()
		{
			this.AddNewLine();
			if (this._newLineAlignmentPoints.Count > 0)
			{
				this.Mark(this._newLineAlignmentPoints.Peek());
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00020888 File Offset: 0x0001EA88
		public void Indent(int size)
		{
			this.AddSpace(size);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00020891 File Offset: 0x0001EA91
		public void Mark(AlignmentPoint ap)
		{
			if (!string.IsNullOrEmpty(ap.Name) && !this._alignmentPointNameMapForCurrentScope.ContainsKey(ap.Name))
			{
				this._alignmentPointNameMapForCurrentScope.Add(ap.Name, ap);
			}
			this.AddAlignmentPoint(ap);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000208CC File Offset: 0x0001EACC
		public void PushNewLineAlignmentPoint(AlignmentPoint ap)
		{
			this._newLineAlignmentPoints.Push(ap);
			this._alignmentPointNameMaps.Push(this._alignmentPointNameMapForCurrentScope);
			this._alignmentPointNameMapForCurrentScope = new Dictionary<string, AlignmentPoint>();
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000208F6 File Offset: 0x0001EAF6
		public void PopNewLineAlignmentPoint()
		{
			this._newLineAlignmentPoints.Pop();
			this._alignmentPointNameMapForCurrentScope = this._alignmentPointNameMaps.Pop();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00020918 File Offset: 0x0001EB18
		public AlignmentPoint FindOrCreateAlignmentPoint(string name)
		{
			AlignmentPoint alignmentPoint = null;
			if (!this._alignmentPointNameMapForCurrentScope.TryGetValue(name, out alignmentPoint))
			{
				alignmentPoint = null;
			}
			if (alignmentPoint == null)
			{
				alignmentPoint = new AlignmentPoint(name);
			}
			return alignmentPoint;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00020944 File Offset: 0x0001EB44
		public void WriteTo(TextWriter writer)
		{
			List<TSqlParserToken> list = this.TryGetAlignedTokens();
			foreach (TSqlParserToken tsqlParserToken in list)
			{
				writer.Write(tsqlParserToken.Text);
			}
			writer.Flush();
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000209A4 File Offset: 0x0001EBA4
		public void WriteTo(IList<TSqlParserToken> tokens)
		{
			List<TSqlParserToken> list = this.TryGetAlignedTokens();
			foreach (TSqlParserToken item in list)
			{
				tokens.Add(item);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000209FC File Offset: 0x0001EBFC
		private void AddIdentifier(string text, bool applyCasing)
		{
			if (applyCasing)
			{
				text = ScriptGeneratorSupporter.GetCasedString(text, this._options.KeywordCasing);
			}
			TSqlParserToken token = new TSqlParserToken(TSqlTokenType.Identifier, text);
			this.AddToken(token);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00020A32 File Offset: 0x0001EC32
		private void AddSpace(int count)
		{
			this.AddToken(ScriptGeneratorSupporter.CreateWhitespaceToken(count));
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00020A40 File Offset: 0x0001EC40
		private void AddTokenWrapper(ScriptWriter.TokenWrapper token)
		{
			this._scriptWriterElements.Add(token);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00020A4E File Offset: 0x0001EC4E
		private void AddAlignmentPoint(AlignmentPoint ap)
		{
			this._scriptWriterElements.Add(this.FindOrCreateAlignmentPointData(ap));
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00020A62 File Offset: 0x0001EC62
		private void AddNewLine()
		{
			this._scriptWriterElements.Add(ScriptWriter._newLine);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00020A74 File Offset: 0x0001EC74
		private ScriptWriter.ScriptWriterElement FindOrCreateAlignmentPointData(AlignmentPoint ap)
		{
			ScriptWriter.AlignmentPointData alignmentPointData;
			if (!this._alignmentPointDataMap.TryGetValue(ap, out alignmentPointData))
			{
				alignmentPointData = new ScriptWriter.AlignmentPointData(ap.Name);
				this._alignmentPointDataMap.Add(ap, alignmentPointData);
			}
			return alignmentPointData;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00020AAC File Offset: 0x0001ECAC
		private List<TSqlParserToken> TryGetAlignedTokens()
		{
			List<TSqlParserToken> list = this.Align();
			if (list == null)
			{
				list = this.GetAllTokens();
			}
			return list;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00020ACC File Offset: 0x0001ECCC
		private List<TSqlParserToken> Align()
		{
			HashSet<ScriptWriter.AlignmentPointData> hashSet = new HashSet<ScriptWriter.AlignmentPointData>();
			int num = 0;
			ScriptWriter.AlignmentPointData alignmentPointData = null;
			for (int i = 0; i < this._scriptWriterElements.Count; i++)
			{
				ScriptWriter.ScriptWriterElement scriptWriterElement = this._scriptWriterElements[i];
				switch (scriptWriterElement.ElementType)
				{
				case ScriptWriter.ScriptWriterElementType.AlignmentPoint:
				{
					ScriptWriter.AlignmentPointData alignmentPointData2 = scriptWriterElement as ScriptWriter.AlignmentPointData;
					hashSet.Add(alignmentPointData2);
					if (alignmentPointData != null)
					{
						alignmentPointData2.AddLeftPoint(alignmentPointData, num);
						alignmentPointData.AddRightPoint(alignmentPointData2);
					}
					else
					{
						alignmentPointData2.Offset = Math.Max(alignmentPointData2.Offset, num);
					}
					num = 0;
					alignmentPointData = alignmentPointData2;
					break;
				}
				case ScriptWriter.ScriptWriterElementType.Token:
				{
					ScriptWriter.TokenWrapper tokenWrapper = scriptWriterElement as ScriptWriter.TokenWrapper;
					if (tokenWrapper != null && tokenWrapper.Token != null && tokenWrapper.Token.Text != null)
					{
						num += tokenWrapper.Token.Text.Length;
					}
					break;
				}
				case ScriptWriter.ScriptWriterElementType.NewLine:
					num = 0;
					alignmentPointData = null;
					break;
				}
			}
			while (hashSet.Count != 0)
			{
				ScriptWriter.AlignmentPointData alignmentPointData3 = ScriptWriter.FindOneAlignmentPointWithOutDependent(hashSet);
				if (alignmentPointData3 == null)
				{
					return null;
				}
				HashSet<ScriptWriter.AlignmentPointData> rightPoints = alignmentPointData3.RightPoints;
				foreach (ScriptWriter.AlignmentPointData alignmentPointData4 in rightPoints)
				{
					alignmentPointData4.AlignAndRemoveLeftPoint(alignmentPointData3);
				}
				hashSet.Remove(alignmentPointData3);
			}
			List<TSqlParserToken> list = new List<TSqlParserToken>();
			int num2 = 0;
			for (int j = 0; j < this._scriptWriterElements.Count; j++)
			{
				ScriptWriter.ScriptWriterElement scriptWriterElement2 = this._scriptWriterElements[j];
				switch (scriptWriterElement2.ElementType)
				{
				case ScriptWriter.ScriptWriterElementType.AlignmentPoint:
				{
					ScriptWriter.AlignmentPointData alignmentPointData5 = scriptWriterElement2 as ScriptWriter.AlignmentPointData;
					if (alignmentPointData5.Offset > num2)
					{
						list.Add(ScriptGeneratorSupporter.CreateWhitespaceToken(alignmentPointData5.Offset - num2));
					}
					num2 = alignmentPointData5.Offset;
					break;
				}
				case ScriptWriter.ScriptWriterElementType.Token:
				{
					ScriptWriter.TokenWrapper tokenWrapper2 = scriptWriterElement2 as ScriptWriter.TokenWrapper;
					if (tokenWrapper2 != null && tokenWrapper2.Token != null && tokenWrapper2.Token.Text != null)
					{
						list.Add(tokenWrapper2.Token);
						num2 += tokenWrapper2.Token.Text.Length;
					}
					break;
				}
				case ScriptWriter.ScriptWriterElementType.NewLine:
					list.Add(ScriptWriter._newLineToken);
					num2 = 0;
					break;
				}
			}
			return list;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00020D0C File Offset: 0x0001EF0C
		private List<TSqlParserToken> GetAllTokens()
		{
			List<TSqlParserToken> list = new List<TSqlParserToken>();
			for (int i = 0; i < this._scriptWriterElements.Count; i++)
			{
				ScriptWriter.ScriptWriterElement scriptWriterElement = this._scriptWriterElements[i];
				switch (scriptWriterElement.ElementType)
				{
				case ScriptWriter.ScriptWriterElementType.Token:
				{
					ScriptWriter.TokenWrapper tokenWrapper = scriptWriterElement as ScriptWriter.TokenWrapper;
					list.Add(tokenWrapper.Token);
					break;
				}
				case ScriptWriter.ScriptWriterElementType.NewLine:
					list.Add(ScriptWriter._newLineToken);
					break;
				}
			}
			return list;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00020D80 File Offset: 0x0001EF80
		private static ScriptWriter.AlignmentPointData FindOneAlignmentPointWithOutDependent(HashSet<ScriptWriter.AlignmentPointData> points)
		{
			ScriptWriter.AlignmentPointData result = null;
			foreach (ScriptWriter.AlignmentPointData alignmentPointData in points)
			{
				if (alignmentPointData.HasNoLeftPoints)
				{
					result = alignmentPointData;
					break;
				}
			}
			return result;
		}

		// Token: 0x04000FD7 RID: 4055
		private static ScriptWriter.NewLineElement _newLine = new ScriptWriter.NewLineElement();

		// Token: 0x04000FD8 RID: 4056
		private static TSqlParserToken _newLineToken = new TSqlParserToken(TSqlTokenType.WhiteSpace, Environment.NewLine);

		// Token: 0x04000FD9 RID: 4057
		private SqlScriptGeneratorOptions _options;

		// Token: 0x04000FDA RID: 4058
		private Dictionary<AlignmentPoint, ScriptWriter.AlignmentPointData> _alignmentPointDataMap;

		// Token: 0x04000FDB RID: 4059
		private Dictionary<string, AlignmentPoint> _alignmentPointNameMapForCurrentScope;

		// Token: 0x04000FDC RID: 4060
		private Stack<Dictionary<string, AlignmentPoint>> _alignmentPointNameMaps;

		// Token: 0x04000FDD RID: 4061
		private List<ScriptWriter.ScriptWriterElement> _scriptWriterElements;

		// Token: 0x04000FDE RID: 4062
		private Stack<AlignmentPoint> _newLineAlignmentPoints;

		// Token: 0x0200019B RID: 411
		internal abstract class ScriptWriterElement
		{
			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00020E01 File Offset: 0x0001F001
			// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00020DF8 File Offset: 0x0001EFF8
			public ScriptWriter.ScriptWriterElementType ElementType { get; protected set; }
		}

		// Token: 0x0200019C RID: 412
		internal class AlignmentPointData : ScriptWriter.ScriptWriterElement
		{
			// Token: 0x06000B84 RID: 2948 RVA: 0x00020E11 File Offset: 0x0001F011
			public AlignmentPointData(string name)
			{
				base.ElementType = ScriptWriter.ScriptWriterElementType.AlignmentPoint;
				this.Name = name;
				this._leftPoints = new Dictionary<ScriptWriter.AlignmentPointData, int>();
				this._rightPoints = new HashSet<ScriptWriter.AlignmentPointData>();
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00020E3D File Offset: 0x0001F03D
			// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00020E45 File Offset: 0x0001F045
			public int Offset { get; set; }

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00020E4E File Offset: 0x0001F04E
			// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00020E56 File Offset: 0x0001F056
			public string Name { get; private set; }

			// Token: 0x06000B89 RID: 2953 RVA: 0x00020E60 File Offset: 0x0001F060
			public void AddLeftPoint(ScriptWriter.AlignmentPointData ap, int width)
			{
				int num;
				if (!this._leftPoints.TryGetValue(ap, out num))
				{
					this._leftPoints.Add(ap, width);
					return;
				}
				if (num < width)
				{
					this._leftPoints[ap] = width;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00020E9C File Offset: 0x0001F09C
			public bool HasNoLeftPoints
			{
				get
				{
					return this._leftPoints.Count == 0;
				}
			}

			// Token: 0x06000B8B RID: 2955 RVA: 0x00020EAC File Offset: 0x0001F0AC
			public void AddRightPoint(ScriptWriter.AlignmentPointData ap)
			{
				this._rightPoints.Add(ap);
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00020EBB File Offset: 0x0001F0BB
			public HashSet<ScriptWriter.AlignmentPointData> RightPoints
			{
				get
				{
					return this._rightPoints;
				}
			}

			// Token: 0x06000B8D RID: 2957 RVA: 0x00020EC4 File Offset: 0x0001F0C4
			public void AlignAndRemoveLeftPoint(ScriptWriter.AlignmentPointData ap)
			{
				int num;
				if (this._leftPoints.TryGetValue(ap, out num))
				{
					this.Offset = Math.Max(ap.Offset + num, this.Offset);
					this._leftPoints.Remove(ap);
				}
			}

			// Token: 0x04000FE0 RID: 4064
			private Dictionary<ScriptWriter.AlignmentPointData, int> _leftPoints;

			// Token: 0x04000FE1 RID: 4065
			private HashSet<ScriptWriter.AlignmentPointData> _rightPoints;
		}

		// Token: 0x0200019D RID: 413
		[DebuggerDisplay("NewLine==========")]
		internal class NewLineElement : ScriptWriter.ScriptWriterElement
		{
			// Token: 0x06000B8E RID: 2958 RVA: 0x00020F07 File Offset: 0x0001F107
			public NewLineElement()
			{
				base.ElementType = ScriptWriter.ScriptWriterElementType.NewLine;
			}
		}

		// Token: 0x0200019E RID: 414
		internal enum ScriptWriterElementType
		{
			// Token: 0x04000FE5 RID: 4069
			AlignmentPoint,
			// Token: 0x04000FE6 RID: 4070
			Token,
			// Token: 0x04000FE7 RID: 4071
			NewLine
		}

		// Token: 0x0200019F RID: 415
		[DebuggerDisplay("Token({_token.Text})")]
		internal class TokenWrapper : ScriptWriter.ScriptWriterElement
		{
			// Token: 0x06000B8F RID: 2959 RVA: 0x00020F16 File Offset: 0x0001F116
			public TokenWrapper(TSqlParserToken token)
			{
				this._token = token;
				base.ElementType = ScriptWriter.ScriptWriterElementType.Token;
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00020F2C File Offset: 0x0001F12C
			public TSqlParserToken Token
			{
				get
				{
					return this._token;
				}
			}

			// Token: 0x04000FE8 RID: 4072
			private TSqlParserToken _token;
		}
	}
}
