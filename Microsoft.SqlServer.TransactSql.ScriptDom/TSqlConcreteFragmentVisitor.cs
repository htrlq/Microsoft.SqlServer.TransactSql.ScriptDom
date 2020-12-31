using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001A0 RID: 416
	public abstract class TSqlConcreteFragmentVisitor : TSqlFragmentVisitor
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x00020F34 File Offset: 0x0001F134
		protected TSqlConcreteFragmentVisitor() : base(false)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00020F3D File Offset: 0x0001F13D
		public sealed override void Visit(ExecutableEntity node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00020F46 File Offset: 0x0001F146
		public sealed override void ExplicitVisit(ExecutableEntity node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00020F4F File Offset: 0x0001F14F
		public sealed override void Visit(ViewStatementBody node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00020F58 File Offset: 0x0001F158
		public sealed override void ExplicitVisit(ViewStatementBody node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00020F61 File Offset: 0x0001F161
		public sealed override void Visit(TriggerStatementBody node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00020F6A File Offset: 0x0001F16A
		public sealed override void ExplicitVisit(TriggerStatementBody node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00020F73 File Offset: 0x0001F173
		public sealed override void Visit(ProcedureStatementBody node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00020F7C File Offset: 0x0001F17C
		public sealed override void ExplicitVisit(ProcedureStatementBody node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00020F85 File Offset: 0x0001F185
		public sealed override void Visit(ProcedureStatementBodyBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00020F8E File Offset: 0x0001F18E
		public sealed override void ExplicitVisit(ProcedureStatementBodyBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00020F97 File Offset: 0x0001F197
		public sealed override void Visit(FunctionStatementBody node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		public sealed override void ExplicitVisit(FunctionStatementBody node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00020FA9 File Offset: 0x0001F1A9
		public sealed override void Visit(XmlNamespacesElement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00020FB2 File Offset: 0x0001F1B2
		public sealed override void ExplicitVisit(XmlNamespacesElement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00020FBB File Offset: 0x0001F1BB
		public sealed override void Visit(FunctionReturnType node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00020FC4 File Offset: 0x0001F1C4
		public sealed override void ExplicitVisit(FunctionReturnType node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00020FCD File Offset: 0x0001F1CD
		public sealed override void Visit(DataTypeReference node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00020FD6 File Offset: 0x0001F1D6
		public sealed override void ExplicitVisit(DataTypeReference node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00020FDF File Offset: 0x0001F1DF
		public sealed override void Visit(ParameterizedDataTypeReference node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		public sealed override void ExplicitVisit(ParameterizedDataTypeReference node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00020FF1 File Offset: 0x0001F1F1
		public sealed override void Visit(StatementWithCtesAndXmlNamespaces node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00020FFA File Offset: 0x0001F1FA
		public sealed override void ExplicitVisit(StatementWithCtesAndXmlNamespaces node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00021003 File Offset: 0x0001F203
		public sealed override void Visit(ForClause node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002100C File Offset: 0x0001F20C
		public sealed override void ExplicitVisit(ForClause node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00021015 File Offset: 0x0001F215
		public sealed override void Visit(WhenClause node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0002101E File Offset: 0x0001F21E
		public sealed override void ExplicitVisit(WhenClause node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00021027 File Offset: 0x0001F227
		public sealed override void Visit(CaseExpression node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00021030 File Offset: 0x0001F230
		public sealed override void ExplicitVisit(CaseExpression node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00021039 File Offset: 0x0001F239
		public sealed override void Visit(CallTarget node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00021042 File Offset: 0x0001F242
		public sealed override void ExplicitVisit(CallTarget node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0002104B File Offset: 0x0001F24B
		public sealed override void Visit(AtomicBlockOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00021054 File Offset: 0x0001F254
		public sealed override void ExplicitVisit(AtomicBlockOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0002105D File Offset: 0x0001F25D
		public sealed override void Visit(TransactionStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00021066 File Offset: 0x0001F266
		public sealed override void ExplicitVisit(TransactionStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0002106F File Offset: 0x0001F26F
		public sealed override void Visit(UpdateDeleteSpecificationBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00021078 File Offset: 0x0001F278
		public sealed override void ExplicitVisit(UpdateDeleteSpecificationBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00021081 File Offset: 0x0001F281
		public sealed override void Visit(TextModificationStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002108A File Offset: 0x0001F28A
		public sealed override void ExplicitVisit(TextModificationStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00021093 File Offset: 0x0001F293
		public sealed override void Visit(SecurityStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0002109C File Offset: 0x0001F29C
		public sealed override void ExplicitVisit(SecurityStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000210A5 File Offset: 0x0001F2A5
		public sealed override void Visit(SecurityStatementBody80 node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000210AE File Offset: 0x0001F2AE
		public sealed override void ExplicitVisit(SecurityStatementBody80 node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000210B7 File Offset: 0x0001F2B7
		public sealed override void Visit(SecurityElement80 node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x000210C0 File Offset: 0x0001F2C0
		public sealed override void ExplicitVisit(SecurityElement80 node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000210C9 File Offset: 0x0001F2C9
		public sealed override void Visit(SetClause node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000210D2 File Offset: 0x0001F2D2
		public sealed override void ExplicitVisit(SetClause node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000210DB File Offset: 0x0001F2DB
		public sealed override void Visit(InsertSource node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000210E4 File Offset: 0x0001F2E4
		public sealed override void ExplicitVisit(InsertSource node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000210ED File Offset: 0x0001F2ED
		public sealed override void Visit(PrimaryExpression node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000210F6 File Offset: 0x0001F2F6
		public sealed override void ExplicitVisit(PrimaryExpression node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000210FF File Offset: 0x0001F2FF
		public sealed override void Visit(Literal node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00021108 File Offset: 0x0001F308
		public sealed override void ExplicitVisit(Literal node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00021111 File Offset: 0x0001F311
		public sealed override void Visit(ValueExpression node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0002111A File Offset: 0x0001F31A
		public sealed override void ExplicitVisit(ValueExpression node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00021123 File Offset: 0x0001F323
		public sealed override void Visit(OptionValue node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002112C File Offset: 0x0001F32C
		public sealed override void ExplicitVisit(OptionValue node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00021135 File Offset: 0x0001F335
		public sealed override void Visit(SequenceStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0002113E File Offset: 0x0001F33E
		public sealed override void ExplicitVisit(SequenceStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00021147 File Offset: 0x0001F347
		public sealed override void Visit(AssemblyStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00021150 File Offset: 0x0001F350
		public sealed override void ExplicitVisit(AssemblyStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00021159 File Offset: 0x0001F359
		public sealed override void Visit(AlterTableStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00021162 File Offset: 0x0001F362
		public sealed override void ExplicitVisit(AlterTableStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0002116B File Offset: 0x0001F36B
		public sealed override void Visit(TableOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00021174 File Offset: 0x0001F374
		public sealed override void ExplicitVisit(TableOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0002117D File Offset: 0x0001F37D
		public sealed override void Visit(TableSwitchOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00021186 File Offset: 0x0001F386
		public sealed override void ExplicitVisit(TableSwitchOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0002118F File Offset: 0x0001F38F
		public sealed override void Visit(DropClusteredConstraintOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00021198 File Offset: 0x0001F398
		public sealed override void ExplicitVisit(DropClusteredConstraintOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000211A1 File Offset: 0x0001F3A1
		public sealed override void Visit(CreateTypeStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000211AA File Offset: 0x0001F3AA
		public sealed override void ExplicitVisit(CreateTypeStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000211B3 File Offset: 0x0001F3B3
		public sealed override void Visit(RouteStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000211BC File Offset: 0x0001F3BC
		public sealed override void ExplicitVisit(RouteStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000211C5 File Offset: 0x0001F3C5
		public sealed override void Visit(QueueStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000211CE File Offset: 0x0001F3CE
		public sealed override void ExplicitVisit(QueueStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000211D7 File Offset: 0x0001F3D7
		public sealed override void Visit(IndexStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000211E0 File Offset: 0x0001F3E0
		public sealed override void ExplicitVisit(IndexStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000211E9 File Offset: 0x0001F3E9
		public sealed override void Visit(IndexOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000211F2 File Offset: 0x0001F3F2
		public sealed override void ExplicitVisit(IndexOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000211FB File Offset: 0x0001F3FB
		public sealed override void Visit(LowPriorityLockWaitOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00021204 File Offset: 0x0001F404
		public sealed override void ExplicitVisit(LowPriorityLockWaitOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0002120D File Offset: 0x0001F40D
		public sealed override void Visit(FullTextIndexOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00021216 File Offset: 0x0001F416
		public sealed override void ExplicitVisit(FullTextIndexOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0002121F File Offset: 0x0001F41F
		public sealed override void Visit(EventTypeGroupContainer node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00021228 File Offset: 0x0001F428
		public sealed override void ExplicitVisit(EventTypeGroupContainer node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00021231 File Offset: 0x0001F431
		public sealed override void Visit(MasterKeyStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0002123A File Offset: 0x0001F43A
		public sealed override void ExplicitVisit(MasterKeyStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00021243 File Offset: 0x0001F443
		public sealed override void Visit(ApplicationRoleStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0002124C File Offset: 0x0001F44C
		public sealed override void ExplicitVisit(ApplicationRoleStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00021255 File Offset: 0x0001F455
		public sealed override void Visit(RoleStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002125E File Offset: 0x0001F45E
		public sealed override void ExplicitVisit(RoleStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00021267 File Offset: 0x0001F467
		public sealed override void Visit(AlterRoleAction node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00021270 File Offset: 0x0001F470
		public sealed override void ExplicitVisit(AlterRoleAction node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00021279 File Offset: 0x0001F479
		public sealed override void Visit(UserStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00021282 File Offset: 0x0001F482
		public sealed override void ExplicitVisit(UserStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002128B File Offset: 0x0001F48B
		public sealed override void Visit(CursorStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00021294 File Offset: 0x0001F494
		public sealed override void ExplicitVisit(CursorStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002129D File Offset: 0x0001F49D
		public sealed override void Visit(DropUnownedObjectStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000212A6 File Offset: 0x0001F4A6
		public sealed override void ExplicitVisit(DropUnownedObjectStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000212AF File Offset: 0x0001F4AF
		public sealed override void Visit(DropObjectsStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public sealed override void ExplicitVisit(DropObjectsStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000212C1 File Offset: 0x0001F4C1
		public sealed override void Visit(DropChildObjectsStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000212CA File Offset: 0x0001F4CA
		public sealed override void ExplicitVisit(DropChildObjectsStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000212D3 File Offset: 0x0001F4D3
		public sealed override void Visit(DropIndexClauseBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000212DC File Offset: 0x0001F4DC
		public sealed override void ExplicitVisit(DropIndexClauseBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000212E5 File Offset: 0x0001F4E5
		public sealed override void Visit(SetOnOffStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000212EE File Offset: 0x0001F4EE
		public sealed override void ExplicitVisit(SetOnOffStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000212F7 File Offset: 0x0001F4F7
		public sealed override void Visit(SetCommand node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00021300 File Offset: 0x0001F500
		public sealed override void ExplicitVisit(SetCommand node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00021309 File Offset: 0x0001F509
		public sealed override void Visit(AlterDatabaseStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00021312 File Offset: 0x0001F512
		public sealed override void ExplicitVisit(AlterDatabaseStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002131B File Offset: 0x0001F51B
		public sealed override void Visit(ChangeTrackingOptionDetail node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00021324 File Offset: 0x0001F524
		public sealed override void ExplicitVisit(ChangeTrackingOptionDetail node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002132D File Offset: 0x0001F52D
		public sealed override void Visit(ConstraintDefinition node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00021336 File Offset: 0x0001F536
		public sealed override void ExplicitVisit(ConstraintDefinition node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002133F File Offset: 0x0001F53F
		public sealed override void Visit(BackupStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00021348 File Offset: 0x0001F548
		public sealed override void ExplicitVisit(BackupStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00021351 File Offset: 0x0001F551
		public sealed override void Visit(BulkInsertBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002135A File Offset: 0x0001F55A
		public sealed override void ExplicitVisit(BulkInsertBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00021363 File Offset: 0x0001F563
		public sealed override void Visit(RemoteServiceBindingStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002136C File Offset: 0x0001F56C
		public sealed override void ExplicitVisit(RemoteServiceBindingStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00021375 File Offset: 0x0001F575
		public sealed override void Visit(RemoteServiceBindingOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0002137E File Offset: 0x0001F57E
		public sealed override void ExplicitVisit(RemoteServiceBindingOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00021387 File Offset: 0x0001F587
		public sealed override void Visit(EncryptionSource node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00021390 File Offset: 0x0001F590
		public sealed override void ExplicitVisit(EncryptionSource node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00021399 File Offset: 0x0001F599
		public sealed override void Visit(CertificateStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000213A2 File Offset: 0x0001F5A2
		public sealed override void ExplicitVisit(CertificateStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000213AB File Offset: 0x0001F5AB
		public sealed override void Visit(CredentialStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000213B4 File Offset: 0x0001F5B4
		public sealed override void ExplicitVisit(CredentialStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000213BD File Offset: 0x0001F5BD
		public sealed override void Visit(MessageTypeStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000213C6 File Offset: 0x0001F5C6
		public sealed override void ExplicitVisit(MessageTypeStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000213CF File Offset: 0x0001F5CF
		public sealed override void Visit(AlterCreateEndpointStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000213D8 File Offset: 0x0001F5D8
		public sealed override void ExplicitVisit(AlterCreateEndpointStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000213E1 File Offset: 0x0001F5E1
		public sealed override void Visit(EndpointProtocolOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000213EA File Offset: 0x0001F5EA
		public sealed override void ExplicitVisit(EndpointProtocolOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000213F3 File Offset: 0x0001F5F3
		public sealed override void Visit(PayloadOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000213FC File Offset: 0x0001F5FC
		public sealed override void ExplicitVisit(PayloadOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00021405 File Offset: 0x0001F605
		public sealed override void Visit(SymmetricKeyStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002140E File Offset: 0x0001F60E
		public sealed override void ExplicitVisit(SymmetricKeyStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00021417 File Offset: 0x0001F617
		public sealed override void Visit(KeyOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00021420 File Offset: 0x0001F620
		public sealed override void ExplicitVisit(KeyOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00021429 File Offset: 0x0001F629
		public sealed override void Visit(FullTextCatalogStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00021432 File Offset: 0x0001F632
		public sealed override void ExplicitVisit(FullTextCatalogStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0002143B File Offset: 0x0001F63B
		public sealed override void Visit(FullTextCatalogOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00021444 File Offset: 0x0001F644
		public sealed override void ExplicitVisit(FullTextCatalogOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002144D File Offset: 0x0001F64D
		public sealed override void Visit(AlterCreateServiceStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00021456 File Offset: 0x0001F656
		public sealed override void ExplicitVisit(AlterCreateServiceStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0002145F File Offset: 0x0001F65F
		public sealed override void Visit(ScalarExpression node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00021468 File Offset: 0x0001F668
		public sealed override void ExplicitVisit(ScalarExpression node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00021471 File Offset: 0x0001F671
		public sealed override void Visit(BooleanExpression node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0002147A File Offset: 0x0001F67A
		public sealed override void ExplicitVisit(BooleanExpression node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00021483 File Offset: 0x0001F683
		public sealed override void Visit(GroupingSpecification node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0002148C File Offset: 0x0001F68C
		public sealed override void ExplicitVisit(GroupingSpecification node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00021495 File Offset: 0x0001F695
		public sealed override void Visit(JoinTableReference node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002149E File Offset: 0x0001F69E
		public sealed override void ExplicitVisit(JoinTableReference node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000214A7 File Offset: 0x0001F6A7
		public sealed override void Visit(QueryExpression node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000214B0 File Offset: 0x0001F6B0
		public sealed override void ExplicitVisit(QueryExpression node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000214B9 File Offset: 0x0001F6B9
		public sealed override void Visit(SelectElement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000214C2 File Offset: 0x0001F6C2
		public sealed override void ExplicitVisit(SelectElement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000214CB File Offset: 0x0001F6CB
		public sealed override void Visit(TableReference node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000214D4 File Offset: 0x0001F6D4
		public sealed override void ExplicitVisit(TableReference node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000214DD File Offset: 0x0001F6DD
		public sealed override void Visit(TableReferenceWithAlias node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000214E6 File Offset: 0x0001F6E6
		public sealed override void ExplicitVisit(TableReferenceWithAlias node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000214EF File Offset: 0x0001F6EF
		public sealed override void Visit(TableReferenceWithAliasAndColumns node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000214F8 File Offset: 0x0001F6F8
		public sealed override void ExplicitVisit(TableReferenceWithAliasAndColumns node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00021501 File Offset: 0x0001F701
		public sealed override void Visit(AlterFullTextIndexAction node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0002150A File Offset: 0x0001F70A
		public sealed override void ExplicitVisit(AlterFullTextIndexAction node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00021513 File Offset: 0x0001F713
		public sealed override void Visit(SearchPropertyListAction node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0002151C File Offset: 0x0001F71C
		public sealed override void ExplicitVisit(SearchPropertyListAction node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00021525 File Offset: 0x0001F725
		public sealed override void Visit(CreateLoginSource node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002152E File Offset: 0x0001F72E
		public sealed override void ExplicitVisit(CreateLoginSource node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00021537 File Offset: 0x0001F737
		public sealed override void Visit(AlterLoginStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00021540 File Offset: 0x0001F740
		public sealed override void ExplicitVisit(AlterLoginStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00021549 File Offset: 0x0001F749
		public sealed override void Visit(SignatureStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00021552 File Offset: 0x0001F752
		public sealed override void ExplicitVisit(SignatureStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0002155B File Offset: 0x0001F75B
		public sealed override void Visit(WaitForSupportedStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00021564 File Offset: 0x0001F764
		public sealed override void ExplicitVisit(WaitForSupportedStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0002156D File Offset: 0x0001F76D
		public sealed override void Visit(DialogOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00021576 File Offset: 0x0001F776
		public sealed override void ExplicitVisit(DialogOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0002157F File Offset: 0x0001F77F
		public sealed override void Visit(BackupRestoreMasterKeyStatementBase node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00021588 File Offset: 0x0001F788
		public sealed override void ExplicitVisit(BackupRestoreMasterKeyStatementBase node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00021591 File Offset: 0x0001F791
		public sealed override void Visit(TSqlStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0002159A File Offset: 0x0001F79A
		public sealed override void ExplicitVisit(TSqlStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000215A3 File Offset: 0x0001F7A3
		public sealed override void Visit(DataModificationStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000215AC File Offset: 0x0001F7AC
		public sealed override void ExplicitVisit(DataModificationStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000215B5 File Offset: 0x0001F7B5
		public sealed override void Visit(DataModificationSpecification node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000215BE File Offset: 0x0001F7BE
		public sealed override void ExplicitVisit(DataModificationSpecification node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000215C7 File Offset: 0x0001F7C7
		public sealed override void Visit(MergeAction node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000215D0 File Offset: 0x0001F7D0
		public sealed override void ExplicitVisit(MergeAction node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000215D9 File Offset: 0x0001F7D9
		public sealed override void Visit(AuditSpecificationStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000215E2 File Offset: 0x0001F7E2
		public sealed override void ExplicitVisit(AuditSpecificationStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000215EB File Offset: 0x0001F7EB
		public sealed override void Visit(AuditSpecificationDetail node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000215F4 File Offset: 0x0001F7F4
		public sealed override void ExplicitVisit(AuditSpecificationDetail node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000215FD File Offset: 0x0001F7FD
		public sealed override void Visit(ServerAuditStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00021606 File Offset: 0x0001F806
		public sealed override void ExplicitVisit(ServerAuditStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0002160F File Offset: 0x0001F80F
		public sealed override void Visit(AuditOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00021618 File Offset: 0x0001F818
		public sealed override void ExplicitVisit(AuditOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00021621 File Offset: 0x0001F821
		public sealed override void Visit(AuditTargetOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0002162A File Offset: 0x0001F82A
		public sealed override void ExplicitVisit(AuditTargetOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00021633 File Offset: 0x0001F833
		public sealed override void Visit(DatabaseEncryptionKeyStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0002163C File Offset: 0x0001F83C
		public sealed override void ExplicitVisit(DatabaseEncryptionKeyStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00021645 File Offset: 0x0001F845
		public sealed override void Visit(WorkloadGroupStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0002164E File Offset: 0x0001F84E
		public sealed override void ExplicitVisit(WorkloadGroupStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00021657 File Offset: 0x0001F857
		public sealed override void Visit(WorkloadGroupParameter node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00021660 File Offset: 0x0001F860
		public sealed override void ExplicitVisit(WorkloadGroupParameter node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00021669 File Offset: 0x0001F869
		public sealed override void Visit(BrokerPriorityStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00021672 File Offset: 0x0001F872
		public sealed override void ExplicitVisit(BrokerPriorityStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0002167B File Offset: 0x0001F87B
		public sealed override void Visit(SessionOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00021684 File Offset: 0x0001F884
		public sealed override void ExplicitVisit(SessionOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0002168D File Offset: 0x0001F88D
		public sealed override void Visit(SpatialIndexOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00021696 File Offset: 0x0001F896
		public sealed override void ExplicitVisit(SpatialIndexOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002169F File Offset: 0x0001F89F
		public sealed override void Visit(AvailabilityGroupStatement node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000216A8 File Offset: 0x0001F8A8
		public sealed override void ExplicitVisit(AvailabilityGroupStatement node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000216B1 File Offset: 0x0001F8B1
		public sealed override void Visit(AvailabilityReplicaOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x000216BA File Offset: 0x0001F8BA
		public sealed override void ExplicitVisit(AvailabilityReplicaOption node)
		{
			base.ExplicitVisit(node);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000216C3 File Offset: 0x0001F8C3
		public sealed override void Visit(AvailabilityGroupOption node)
		{
			base.Visit(node);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000216CC File Offset: 0x0001F8CC
		public sealed override void ExplicitVisit(AvailabilityGroupOption node)
		{
			base.ExplicitVisit(node);
		}
	}
}
