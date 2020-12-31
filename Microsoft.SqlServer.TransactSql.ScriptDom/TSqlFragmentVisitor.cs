using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000166 RID: 358
	public abstract class TSqlFragmentVisitor
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0000B378 File Offset: 0x00009578
		protected TSqlFragmentVisitor() : this(true)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000B381 File Offset: 0x00009581
		internal TSqlFragmentVisitor(bool visitBaseType)
		{
			this._visitBaseType = visitBaseType;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000B390 File Offset: 0x00009590
		internal bool VisitBaseType
		{
			get
			{
				return this._visitBaseType;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000B398 File Offset: 0x00009598
		public virtual void Visit(TSqlFragment fragment)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000B39A File Offset: 0x0000959A
		public virtual void Visit(StatementList node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000B3AB File Offset: 0x000095AB
		public virtual void ExplicitVisit(StatementList node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000B3CA File Offset: 0x000095CA
		public virtual void Visit(ExecuteStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000B3DB File Offset: 0x000095DB
		public virtual void ExplicitVisit(ExecuteStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000B401 File Offset: 0x00009601
		public virtual void Visit(ExecuteOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000B412 File Offset: 0x00009612
		public virtual void ExplicitVisit(ExecuteOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B431 File Offset: 0x00009631
		public virtual void Visit(ResultSetsExecuteOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B442 File Offset: 0x00009642
		public virtual void ExplicitVisit(ResultSetsExecuteOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B468 File Offset: 0x00009668
		public virtual void Visit(ResultSetDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000B479 File Offset: 0x00009679
		public virtual void ExplicitVisit(ResultSetDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000B498 File Offset: 0x00009698
		public virtual void Visit(InlineResultSetDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000B4A9 File Offset: 0x000096A9
		public virtual void ExplicitVisit(InlineResultSetDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000B4CF File Offset: 0x000096CF
		public virtual void Visit(ResultColumnDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public virtual void ExplicitVisit(ResultColumnDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000B4FF File Offset: 0x000096FF
		public virtual void Visit(SchemaObjectResultSetDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000B510 File Offset: 0x00009710
		public virtual void ExplicitVisit(SchemaObjectResultSetDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000B536 File Offset: 0x00009736
		public virtual void Visit(ExecuteSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000B547 File Offset: 0x00009747
		public virtual void ExplicitVisit(ExecuteSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000B566 File Offset: 0x00009766
		public virtual void Visit(ExecuteContext node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000B577 File Offset: 0x00009777
		public virtual void ExplicitVisit(ExecuteContext node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000B596 File Offset: 0x00009796
		public virtual void Visit(ExecuteParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000B5A7 File Offset: 0x000097A7
		public virtual void ExplicitVisit(ExecuteParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000B5C6 File Offset: 0x000097C6
		public virtual void Visit(ExecutableEntity node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000B5D7 File Offset: 0x000097D7
		public virtual void ExplicitVisit(ExecutableEntity node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000B5F6 File Offset: 0x000097F6
		public virtual void Visit(ProcedureReferenceName node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000B607 File Offset: 0x00009807
		public virtual void ExplicitVisit(ProcedureReferenceName node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000B626 File Offset: 0x00009826
		public virtual void Visit(ExecutableProcedureReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000B637 File Offset: 0x00009837
		public virtual void ExplicitVisit(ExecutableProcedureReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000B65D File Offset: 0x0000985D
		public virtual void Visit(ExecutableStringList node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000B66E File Offset: 0x0000986E
		public virtual void ExplicitVisit(ExecutableStringList node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000B694 File Offset: 0x00009894
		public virtual void Visit(AdHocDataSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000B6A5 File Offset: 0x000098A5
		public virtual void ExplicitVisit(AdHocDataSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public virtual void Visit(ViewOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000B6D5 File Offset: 0x000098D5
		public virtual void ExplicitVisit(ViewOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000B6F4 File Offset: 0x000098F4
		public virtual void Visit(AlterViewStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000B705 File Offset: 0x00009905
		public virtual void ExplicitVisit(AlterViewStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000B732 File Offset: 0x00009932
		public virtual void Visit(CreateViewStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000B743 File Offset: 0x00009943
		public virtual void ExplicitVisit(CreateViewStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000B770 File Offset: 0x00009970
		public virtual void Visit(ViewStatementBody node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000B781 File Offset: 0x00009981
		public virtual void ExplicitVisit(ViewStatementBody node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000B7A7 File Offset: 0x000099A7
		public virtual void Visit(TriggerObject node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000B7B8 File Offset: 0x000099B8
		public virtual void ExplicitVisit(TriggerObject node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000B7D7 File Offset: 0x000099D7
		public virtual void Visit(TriggerOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000B7E8 File Offset: 0x000099E8
		public virtual void ExplicitVisit(TriggerOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000B807 File Offset: 0x00009A07
		public virtual void Visit(ExecuteAsTriggerOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000B818 File Offset: 0x00009A18
		public virtual void ExplicitVisit(ExecuteAsTriggerOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B83E File Offset: 0x00009A3E
		public virtual void Visit(TriggerAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B84F File Offset: 0x00009A4F
		public virtual void ExplicitVisit(TriggerAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B86E File Offset: 0x00009A6E
		public virtual void Visit(AlterTriggerStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B87F File Offset: 0x00009A7F
		public virtual void ExplicitVisit(AlterTriggerStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000B8AC File Offset: 0x00009AAC
		public virtual void Visit(CreateTriggerStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000B8BD File Offset: 0x00009ABD
		public virtual void ExplicitVisit(CreateTriggerStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000B8EA File Offset: 0x00009AEA
		public virtual void Visit(TriggerStatementBody node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000B8FB File Offset: 0x00009AFB
		public virtual void ExplicitVisit(TriggerStatementBody node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000B921 File Offset: 0x00009B21
		public virtual void Visit(Identifier node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000B932 File Offset: 0x00009B32
		public virtual void ExplicitVisit(Identifier node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000B951 File Offset: 0x00009B51
		public virtual void Visit(AlterProcedureStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000B962 File Offset: 0x00009B62
		public virtual void ExplicitVisit(AlterProcedureStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000B996 File Offset: 0x00009B96
		public virtual void Visit(CreateProcedureStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000B9A7 File Offset: 0x00009BA7
		public virtual void ExplicitVisit(CreateProcedureStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000B9DB File Offset: 0x00009BDB
		public virtual void Visit(ProcedureReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public virtual void ExplicitVisit(ProcedureReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000BA0B File Offset: 0x00009C0B
		public virtual void Visit(MethodSpecifier node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000BA1C File Offset: 0x00009C1C
		public virtual void ExplicitVisit(MethodSpecifier node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000BA3B File Offset: 0x00009C3B
		public virtual void Visit(ProcedureStatementBody node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000BA4C File Offset: 0x00009C4C
		public virtual void ExplicitVisit(ProcedureStatementBody node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000BA79 File Offset: 0x00009C79
		public virtual void Visit(ProcedureStatementBodyBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000BA8A File Offset: 0x00009C8A
		public virtual void ExplicitVisit(ProcedureStatementBodyBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		public virtual void Visit(FunctionStatementBody node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000BAC1 File Offset: 0x00009CC1
		public virtual void ExplicitVisit(FunctionStatementBody node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000BAEE File Offset: 0x00009CEE
		public virtual void Visit(ProcedureOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000BAFF File Offset: 0x00009CFF
		public virtual void ExplicitVisit(ProcedureOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000BB1E File Offset: 0x00009D1E
		public virtual void Visit(ExecuteAsProcedureOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000BB2F File Offset: 0x00009D2F
		public virtual void ExplicitVisit(ExecuteAsProcedureOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000BB55 File Offset: 0x00009D55
		public virtual void Visit(FunctionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000BB66 File Offset: 0x00009D66
		public virtual void ExplicitVisit(FunctionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000BB85 File Offset: 0x00009D85
		public virtual void Visit(ExecuteAsFunctionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000BB96 File Offset: 0x00009D96
		public virtual void ExplicitVisit(ExecuteAsFunctionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000BBBC File Offset: 0x00009DBC
		public virtual void Visit(XmlNamespaces node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000BBCD File Offset: 0x00009DCD
		public virtual void ExplicitVisit(XmlNamespaces node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000BBEC File Offset: 0x00009DEC
		public virtual void Visit(XmlNamespacesElement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000BBFD File Offset: 0x00009DFD
		public virtual void ExplicitVisit(XmlNamespacesElement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000BC1C File Offset: 0x00009E1C
		public virtual void Visit(XmlNamespacesDefaultElement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000BC2D File Offset: 0x00009E2D
		public virtual void ExplicitVisit(XmlNamespacesDefaultElement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000BC53 File Offset: 0x00009E53
		public virtual void Visit(XmlNamespacesAliasElement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000BC64 File Offset: 0x00009E64
		public virtual void ExplicitVisit(XmlNamespacesAliasElement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000BC8A File Offset: 0x00009E8A
		public virtual void Visit(CommonTableExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000BC9B File Offset: 0x00009E9B
		public virtual void ExplicitVisit(CommonTableExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000BCBA File Offset: 0x00009EBA
		public virtual void Visit(WithCtesAndXmlNamespaces node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000BCCB File Offset: 0x00009ECB
		public virtual void ExplicitVisit(WithCtesAndXmlNamespaces node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000BCEA File Offset: 0x00009EEA
		public virtual void Visit(FunctionReturnType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000BCFB File Offset: 0x00009EFB
		public virtual void ExplicitVisit(FunctionReturnType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000BD1A File Offset: 0x00009F1A
		public virtual void Visit(TableValuedFunctionReturnType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000BD2B File Offset: 0x00009F2B
		public virtual void ExplicitVisit(TableValuedFunctionReturnType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000BD51 File Offset: 0x00009F51
		public virtual void Visit(DataTypeReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000BD62 File Offset: 0x00009F62
		public virtual void ExplicitVisit(DataTypeReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000BD81 File Offset: 0x00009F81
		public virtual void Visit(ParameterizedDataTypeReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000BD92 File Offset: 0x00009F92
		public virtual void ExplicitVisit(ParameterizedDataTypeReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		public virtual void Visit(SqlDataTypeReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000BDC9 File Offset: 0x00009FC9
		public virtual void ExplicitVisit(SqlDataTypeReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000BDF6 File Offset: 0x00009FF6
		public virtual void Visit(UserDataTypeReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000BE07 File Offset: 0x0000A007
		public virtual void ExplicitVisit(UserDataTypeReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000BE34 File Offset: 0x0000A034
		public virtual void Visit(XmlDataTypeReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000BE45 File Offset: 0x0000A045
		public virtual void ExplicitVisit(XmlDataTypeReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000BE6B File Offset: 0x0000A06B
		public virtual void Visit(ScalarFunctionReturnType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000BE7C File Offset: 0x0000A07C
		public virtual void ExplicitVisit(ScalarFunctionReturnType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000BEA2 File Offset: 0x0000A0A2
		public virtual void Visit(SelectFunctionReturnType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000BEB3 File Offset: 0x0000A0B3
		public virtual void ExplicitVisit(SelectFunctionReturnType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000BED9 File Offset: 0x0000A0D9
		public virtual void Visit(TableDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000BEEA File Offset: 0x0000A0EA
		public virtual void ExplicitVisit(TableDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000BF09 File Offset: 0x0000A109
		public virtual void Visit(DeclareTableVariableBody node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000BF1A File Offset: 0x0000A11A
		public virtual void ExplicitVisit(DeclareTableVariableBody node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000BF39 File Offset: 0x0000A139
		public virtual void Visit(DeclareTableVariableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000BF4A File Offset: 0x0000A14A
		public virtual void ExplicitVisit(DeclareTableVariableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BF70 File Offset: 0x0000A170
		public virtual void Visit(NamedTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000BF81 File Offset: 0x0000A181
		public virtual void ExplicitVisit(NamedTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000BFAE File Offset: 0x0000A1AE
		public virtual void Visit(SchemaObjectFunctionTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000BFBF File Offset: 0x0000A1BF
		public virtual void ExplicitVisit(SchemaObjectFunctionTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		public virtual void Visit(TableHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000C004 File Offset: 0x0000A204
		public virtual void ExplicitVisit(TableHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C023 File Offset: 0x0000A223
		public virtual void Visit(IndexTableHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C034 File Offset: 0x0000A234
		public virtual void ExplicitVisit(IndexTableHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C05A File Offset: 0x0000A25A
		public virtual void Visit(LiteralTableHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000C06B File Offset: 0x0000A26B
		public virtual void ExplicitVisit(LiteralTableHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C091 File Offset: 0x0000A291
		public virtual void Visit(QueryDerivedTable node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C0A2 File Offset: 0x0000A2A2
		public virtual void ExplicitVisit(QueryDerivedTable node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C0D6 File Offset: 0x0000A2D6
		public virtual void Visit(InlineDerivedTable node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000C0E7 File Offset: 0x0000A2E7
		public virtual void ExplicitVisit(InlineDerivedTable node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000C11B File Offset: 0x0000A31B
		public virtual void Visit(SubqueryComparisonPredicate node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000C12C File Offset: 0x0000A32C
		public virtual void ExplicitVisit(SubqueryComparisonPredicate node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000C152 File Offset: 0x0000A352
		public virtual void Visit(ExistsPredicate node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000C163 File Offset: 0x0000A363
		public virtual void ExplicitVisit(ExistsPredicate node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000C189 File Offset: 0x0000A389
		public virtual void Visit(LikePredicate node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000C19A File Offset: 0x0000A39A
		public virtual void ExplicitVisit(LikePredicate node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		public virtual void Visit(InPredicate node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000C1D1 File Offset: 0x0000A3D1
		public virtual void ExplicitVisit(InPredicate node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000C1F7 File Offset: 0x0000A3F7
		public virtual void Visit(FullTextPredicate node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C208 File Offset: 0x0000A408
		public virtual void ExplicitVisit(FullTextPredicate node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000C22E File Offset: 0x0000A42E
		public virtual void Visit(UserDefinedTypePropertyAccess node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000C23F File Offset: 0x0000A43F
		public virtual void ExplicitVisit(UserDefinedTypePropertyAccess node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000C26C File Offset: 0x0000A46C
		public virtual void Visit(StatementWithCtesAndXmlNamespaces node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000C27D File Offset: 0x0000A47D
		public virtual void ExplicitVisit(StatementWithCtesAndXmlNamespaces node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000C2A3 File Offset: 0x0000A4A3
		public virtual void Visit(SelectStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		public virtual void ExplicitVisit(SelectStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000C2E1 File Offset: 0x0000A4E1
		public virtual void Visit(ForClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000C2F2 File Offset: 0x0000A4F2
		public virtual void ExplicitVisit(ForClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000C311 File Offset: 0x0000A511
		public virtual void Visit(BrowseForClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000C322 File Offset: 0x0000A522
		public virtual void ExplicitVisit(BrowseForClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000C348 File Offset: 0x0000A548
		public virtual void Visit(ReadOnlyForClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C359 File Offset: 0x0000A559
		public virtual void ExplicitVisit(ReadOnlyForClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C37F File Offset: 0x0000A57F
		public virtual void Visit(XmlForClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C390 File Offset: 0x0000A590
		public virtual void ExplicitVisit(XmlForClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000C3B6 File Offset: 0x0000A5B6
		public virtual void Visit(XmlForClauseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C3C7 File Offset: 0x0000A5C7
		public virtual void ExplicitVisit(XmlForClauseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000C3ED File Offset: 0x0000A5ED
		public virtual void Visit(UpdateForClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000C3FE File Offset: 0x0000A5FE
		public virtual void ExplicitVisit(UpdateForClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000C424 File Offset: 0x0000A624
		public virtual void Visit(OptimizerHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000C435 File Offset: 0x0000A635
		public virtual void ExplicitVisit(OptimizerHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000C454 File Offset: 0x0000A654
		public virtual void Visit(LiteralOptimizerHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000C465 File Offset: 0x0000A665
		public virtual void ExplicitVisit(LiteralOptimizerHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000C48B File Offset: 0x0000A68B
		public virtual void Visit(TableHintsOptimizerHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000C49C File Offset: 0x0000A69C
		public virtual void ExplicitVisit(TableHintsOptimizerHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000C4C2 File Offset: 0x0000A6C2
		public virtual void Visit(ForceSeekTableHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000C4D3 File Offset: 0x0000A6D3
		public virtual void ExplicitVisit(ForceSeekTableHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000C4F9 File Offset: 0x0000A6F9
		public virtual void Visit(OptimizeForOptimizerHint node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000C50A File Offset: 0x0000A70A
		public virtual void ExplicitVisit(OptimizeForOptimizerHint node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000C530 File Offset: 0x0000A730
		public virtual void Visit(VariableValuePair node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000C541 File Offset: 0x0000A741
		public virtual void ExplicitVisit(VariableValuePair node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000C560 File Offset: 0x0000A760
		public virtual void Visit(WhenClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000C571 File Offset: 0x0000A771
		public virtual void ExplicitVisit(WhenClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000C590 File Offset: 0x0000A790
		public virtual void Visit(SimpleWhenClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000C5A1 File Offset: 0x0000A7A1
		public virtual void ExplicitVisit(SimpleWhenClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000C5C7 File Offset: 0x0000A7C7
		public virtual void Visit(SearchedWhenClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
		public virtual void ExplicitVisit(SearchedWhenClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000C5FE File Offset: 0x0000A7FE
		public virtual void Visit(CaseExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000C60F File Offset: 0x0000A80F
		public virtual void ExplicitVisit(CaseExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000C63C File Offset: 0x0000A83C
		public virtual void Visit(SimpleCaseExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000C64D File Offset: 0x0000A84D
		public virtual void ExplicitVisit(SimpleCaseExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000C681 File Offset: 0x0000A881
		public virtual void Visit(SearchedCaseExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000C692 File Offset: 0x0000A892
		public virtual void ExplicitVisit(SearchedCaseExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000C6C6 File Offset: 0x0000A8C6
		public virtual void Visit(NullIfExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000C6D7 File Offset: 0x0000A8D7
		public virtual void ExplicitVisit(NullIfExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000C704 File Offset: 0x0000A904
		public virtual void Visit(CoalesceExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000C715 File Offset: 0x0000A915
		public virtual void ExplicitVisit(CoalesceExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000C742 File Offset: 0x0000A942
		public virtual void Visit(IIfCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000C753 File Offset: 0x0000A953
		public virtual void ExplicitVisit(IIfCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000C780 File Offset: 0x0000A980
		public virtual void Visit(FullTextTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000C791 File Offset: 0x0000A991
		public virtual void ExplicitVisit(FullTextTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000C7BE File Offset: 0x0000A9BE
		public virtual void Visit(SemanticTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000C7CF File Offset: 0x0000A9CF
		public virtual void ExplicitVisit(SemanticTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		public virtual void Visit(OpenXmlTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000C80D File Offset: 0x0000AA0D
		public virtual void ExplicitVisit(OpenXmlTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000C83A File Offset: 0x0000AA3A
		public virtual void Visit(OpenRowsetTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000C84B File Offset: 0x0000AA4B
		public virtual void ExplicitVisit(OpenRowsetTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000C878 File Offset: 0x0000AA78
		public virtual void Visit(InternalOpenRowset node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000C889 File Offset: 0x0000AA89
		public virtual void ExplicitVisit(InternalOpenRowset node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000C8B6 File Offset: 0x0000AAB6
		public virtual void Visit(BulkOpenRowset node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000C8C7 File Offset: 0x0000AAC7
		public virtual void ExplicitVisit(BulkOpenRowset node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000C8FB File Offset: 0x0000AAFB
		public virtual void Visit(OpenQueryTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000C90C File Offset: 0x0000AB0C
		public virtual void ExplicitVisit(OpenQueryTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000C939 File Offset: 0x0000AB39
		public virtual void Visit(AdHocTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000C94A File Offset: 0x0000AB4A
		public virtual void ExplicitVisit(AdHocTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000C977 File Offset: 0x0000AB77
		public virtual void Visit(SchemaDeclarationItem node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000C988 File Offset: 0x0000AB88
		public virtual void ExplicitVisit(SchemaDeclarationItem node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000C9A7 File Offset: 0x0000ABA7
		public virtual void Visit(ConvertCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		public virtual void ExplicitVisit(ConvertCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000C9E5 File Offset: 0x0000ABE5
		public virtual void Visit(TryConvertCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000C9F6 File Offset: 0x0000ABF6
		public virtual void ExplicitVisit(TryConvertCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000CA23 File Offset: 0x0000AC23
		public virtual void Visit(ParseCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public virtual void ExplicitVisit(ParseCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000CA61 File Offset: 0x0000AC61
		public virtual void Visit(TryParseCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000CA72 File Offset: 0x0000AC72
		public virtual void ExplicitVisit(TryParseCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000CA9F File Offset: 0x0000AC9F
		public virtual void Visit(CastCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		public virtual void ExplicitVisit(CastCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000CADD File Offset: 0x0000ACDD
		public virtual void Visit(TryCastCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000CAEE File Offset: 0x0000ACEE
		public virtual void ExplicitVisit(TryCastCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000CB1B File Offset: 0x0000AD1B
		public virtual void Visit(FunctionCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		public virtual void ExplicitVisit(FunctionCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000CB59 File Offset: 0x0000AD59
		public virtual void Visit(CallTarget node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000CB6A File Offset: 0x0000AD6A
		public virtual void ExplicitVisit(CallTarget node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000CB89 File Offset: 0x0000AD89
		public virtual void Visit(ExpressionCallTarget node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		public virtual void ExplicitVisit(ExpressionCallTarget node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		public virtual void Visit(MultiPartIdentifierCallTarget node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000CBD1 File Offset: 0x0000ADD1
		public virtual void ExplicitVisit(MultiPartIdentifierCallTarget node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000CBF7 File Offset: 0x0000ADF7
		public virtual void Visit(UserDefinedTypeCallTarget node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000CC08 File Offset: 0x0000AE08
		public virtual void ExplicitVisit(UserDefinedTypeCallTarget node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000CC2E File Offset: 0x0000AE2E
		public virtual void Visit(LeftFunctionCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000CC3F File Offset: 0x0000AE3F
		public virtual void ExplicitVisit(LeftFunctionCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		public virtual void Visit(RightFunctionCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000CC7D File Offset: 0x0000AE7D
		public virtual void ExplicitVisit(RightFunctionCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000CCAA File Offset: 0x0000AEAA
		public virtual void Visit(PartitionFunctionCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000CCBB File Offset: 0x0000AEBB
		public virtual void ExplicitVisit(PartitionFunctionCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		public virtual void Visit(OverClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000CCF9 File Offset: 0x0000AEF9
		public virtual void ExplicitVisit(OverClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000CD18 File Offset: 0x0000AF18
		public virtual void Visit(ParameterlessCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000CD29 File Offset: 0x0000AF29
		public virtual void ExplicitVisit(ParameterlessCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000CD56 File Offset: 0x0000AF56
		public virtual void Visit(ScalarSubquery node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000CD67 File Offset: 0x0000AF67
		public virtual void ExplicitVisit(ScalarSubquery node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000CD94 File Offset: 0x0000AF94
		public virtual void Visit(OdbcFunctionCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000CDA5 File Offset: 0x0000AFA5
		public virtual void ExplicitVisit(OdbcFunctionCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000CDD2 File Offset: 0x0000AFD2
		public virtual void Visit(ExtractFromExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000CDE3 File Offset: 0x0000AFE3
		public virtual void ExplicitVisit(ExtractFromExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000CE09 File Offset: 0x0000B009
		public virtual void Visit(OdbcConvertSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000CE1A File Offset: 0x0000B01A
		public virtual void ExplicitVisit(OdbcConvertSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000CE40 File Offset: 0x0000B040
		public virtual void Visit(AlterFunctionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000CE51 File Offset: 0x0000B051
		public virtual void ExplicitVisit(AlterFunctionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000CE85 File Offset: 0x0000B085
		public virtual void Visit(BeginEndBlockStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000CE96 File Offset: 0x0000B096
		public virtual void ExplicitVisit(BeginEndBlockStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public virtual void Visit(BeginEndAtomicBlockStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000CECD File Offset: 0x0000B0CD
		public virtual void ExplicitVisit(BeginEndAtomicBlockStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000CEFA File Offset: 0x0000B0FA
		public virtual void Visit(AtomicBlockOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000CF0B File Offset: 0x0000B10B
		public virtual void ExplicitVisit(AtomicBlockOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000CF2A File Offset: 0x0000B12A
		public virtual void Visit(LiteralAtomicBlockOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000CF3B File Offset: 0x0000B13B
		public virtual void ExplicitVisit(LiteralAtomicBlockOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000CF61 File Offset: 0x0000B161
		public virtual void Visit(IdentifierAtomicBlockOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000CF72 File Offset: 0x0000B172
		public virtual void ExplicitVisit(IdentifierAtomicBlockOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000CF98 File Offset: 0x0000B198
		public virtual void Visit(OnOffAtomicBlockOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000CFA9 File Offset: 0x0000B1A9
		public virtual void ExplicitVisit(OnOffAtomicBlockOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000CFCF File Offset: 0x0000B1CF
		public virtual void Visit(BeginTransactionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
		public virtual void ExplicitVisit(BeginTransactionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000D00D File Offset: 0x0000B20D
		public virtual void Visit(BreakStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000D01E File Offset: 0x0000B21E
		public virtual void ExplicitVisit(BreakStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000D044 File Offset: 0x0000B244
		public virtual void Visit(ColumnWithSortOrder node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000D055 File Offset: 0x0000B255
		public virtual void ExplicitVisit(ColumnWithSortOrder node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000D074 File Offset: 0x0000B274
		public virtual void Visit(CommitTransactionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000D085 File Offset: 0x0000B285
		public virtual void ExplicitVisit(CommitTransactionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000D0B2 File Offset: 0x0000B2B2
		public virtual void Visit(RollbackTransactionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000D0C3 File Offset: 0x0000B2C3
		public virtual void ExplicitVisit(RollbackTransactionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		public virtual void Visit(SaveTransactionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000D101 File Offset: 0x0000B301
		public virtual void ExplicitVisit(SaveTransactionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000D12E File Offset: 0x0000B32E
		public virtual void Visit(ContinueStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000D13F File Offset: 0x0000B33F
		public virtual void ExplicitVisit(ContinueStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000D165 File Offset: 0x0000B365
		public virtual void Visit(CreateDefaultStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000D176 File Offset: 0x0000B376
		public virtual void ExplicitVisit(CreateDefaultStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000D19C File Offset: 0x0000B39C
		public virtual void Visit(CreateFunctionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000D1AD File Offset: 0x0000B3AD
		public virtual void ExplicitVisit(CreateFunctionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000D1E1 File Offset: 0x0000B3E1
		public virtual void Visit(CreateRuleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000D1F2 File Offset: 0x0000B3F2
		public virtual void ExplicitVisit(CreateRuleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000D218 File Offset: 0x0000B418
		public virtual void Visit(DeclareVariableElement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000D229 File Offset: 0x0000B429
		public virtual void ExplicitVisit(DeclareVariableElement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000D248 File Offset: 0x0000B448
		public virtual void Visit(DeclareVariableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000D259 File Offset: 0x0000B459
		public virtual void ExplicitVisit(DeclareVariableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000D27F File Offset: 0x0000B47F
		public virtual void Visit(GoToStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000D290 File Offset: 0x0000B490
		public virtual void ExplicitVisit(GoToStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000D2B6 File Offset: 0x0000B4B6
		public virtual void Visit(IfStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000D2C7 File Offset: 0x0000B4C7
		public virtual void ExplicitVisit(IfStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000D2ED File Offset: 0x0000B4ED
		public virtual void Visit(LabelStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000D2FE File Offset: 0x0000B4FE
		public virtual void ExplicitVisit(LabelStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000D324 File Offset: 0x0000B524
		public virtual void Visit(MultiPartIdentifier node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000D335 File Offset: 0x0000B535
		public virtual void ExplicitVisit(MultiPartIdentifier node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000D354 File Offset: 0x0000B554
		public virtual void Visit(SchemaObjectName node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000D365 File Offset: 0x0000B565
		public virtual void ExplicitVisit(SchemaObjectName node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000D38B File Offset: 0x0000B58B
		public virtual void Visit(ChildObjectName node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000D39C File Offset: 0x0000B59C
		public virtual void ExplicitVisit(ChildObjectName node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000D3C9 File Offset: 0x0000B5C9
		public virtual void Visit(ProcedureParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000D3DA File Offset: 0x0000B5DA
		public virtual void ExplicitVisit(ProcedureParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000D400 File Offset: 0x0000B600
		public virtual void Visit(TransactionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000D411 File Offset: 0x0000B611
		public virtual void ExplicitVisit(TransactionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000D437 File Offset: 0x0000B637
		public virtual void Visit(WhileStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000D448 File Offset: 0x0000B648
		public virtual void ExplicitVisit(WhileStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000D46E File Offset: 0x0000B66E
		public virtual void Visit(DeleteStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000D47F File Offset: 0x0000B67F
		public virtual void ExplicitVisit(DeleteStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000D4B3 File Offset: 0x0000B6B3
		public virtual void Visit(UpdateDeleteSpecificationBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		public virtual void ExplicitVisit(UpdateDeleteSpecificationBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000D4EA File Offset: 0x0000B6EA
		public virtual void Visit(DeleteSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000D4FB File Offset: 0x0000B6FB
		public virtual void ExplicitVisit(DeleteSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000D528 File Offset: 0x0000B728
		public virtual void Visit(InsertStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000D539 File Offset: 0x0000B739
		public virtual void ExplicitVisit(InsertStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000D56D File Offset: 0x0000B76D
		public virtual void Visit(InsertSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000D57E File Offset: 0x0000B77E
		public virtual void ExplicitVisit(InsertSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
		public virtual void Visit(UpdateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000D5B5 File Offset: 0x0000B7B5
		public virtual void ExplicitVisit(UpdateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000D5E9 File Offset: 0x0000B7E9
		public virtual void Visit(UpdateSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000D5FA File Offset: 0x0000B7FA
		public virtual void ExplicitVisit(UpdateSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000D627 File Offset: 0x0000B827
		public virtual void Visit(CreateSchemaStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000D638 File Offset: 0x0000B838
		public virtual void ExplicitVisit(CreateSchemaStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000D65E File Offset: 0x0000B85E
		public virtual void Visit(WaitForStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000D66F File Offset: 0x0000B86F
		public virtual void ExplicitVisit(WaitForStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000D695 File Offset: 0x0000B895
		public virtual void Visit(ReadTextStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000D6A6 File Offset: 0x0000B8A6
		public virtual void ExplicitVisit(ReadTextStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		public virtual void Visit(UpdateTextStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000D6DD File Offset: 0x0000B8DD
		public virtual void ExplicitVisit(UpdateTextStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000D70A File Offset: 0x0000B90A
		public virtual void Visit(WriteTextStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000D71B File Offset: 0x0000B91B
		public virtual void ExplicitVisit(WriteTextStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000D748 File Offset: 0x0000B948
		public virtual void Visit(TextModificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000D759 File Offset: 0x0000B959
		public virtual void ExplicitVisit(TextModificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000D77F File Offset: 0x0000B97F
		public virtual void Visit(LineNoStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000D790 File Offset: 0x0000B990
		public virtual void ExplicitVisit(LineNoStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000D7B6 File Offset: 0x0000B9B6
		public virtual void Visit(SecurityStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000D7C7 File Offset: 0x0000B9C7
		public virtual void ExplicitVisit(SecurityStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000D7ED File Offset: 0x0000B9ED
		public virtual void Visit(GrantStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000D7FE File Offset: 0x0000B9FE
		public virtual void ExplicitVisit(GrantStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000D82B File Offset: 0x0000BA2B
		public virtual void Visit(DenyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000D83C File Offset: 0x0000BA3C
		public virtual void ExplicitVisit(DenyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000D869 File Offset: 0x0000BA69
		public virtual void Visit(RevokeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000D87A File Offset: 0x0000BA7A
		public virtual void ExplicitVisit(RevokeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000D8A7 File Offset: 0x0000BAA7
		public virtual void Visit(AlterAuthorizationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
		public virtual void ExplicitVisit(AlterAuthorizationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000D8DE File Offset: 0x0000BADE
		public virtual void Visit(Permission node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000D8EF File Offset: 0x0000BAEF
		public virtual void ExplicitVisit(Permission node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000D90E File Offset: 0x0000BB0E
		public virtual void Visit(SecurityTargetObject node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000D91F File Offset: 0x0000BB1F
		public virtual void ExplicitVisit(SecurityTargetObject node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000D93E File Offset: 0x0000BB3E
		public virtual void Visit(SecurityTargetObjectName node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000D94F File Offset: 0x0000BB4F
		public virtual void ExplicitVisit(SecurityTargetObjectName node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000D96E File Offset: 0x0000BB6E
		public virtual void Visit(SecurityPrincipal node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000D97F File Offset: 0x0000BB7F
		public virtual void ExplicitVisit(SecurityPrincipal node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000D99E File Offset: 0x0000BB9E
		public virtual void Visit(SecurityStatementBody80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000D9AF File Offset: 0x0000BBAF
		public virtual void ExplicitVisit(SecurityStatementBody80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000D9D5 File Offset: 0x0000BBD5
		public virtual void Visit(GrantStatement80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000D9E6 File Offset: 0x0000BBE6
		public virtual void ExplicitVisit(GrantStatement80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000DA13 File Offset: 0x0000BC13
		public virtual void Visit(DenyStatement80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000DA24 File Offset: 0x0000BC24
		public virtual void ExplicitVisit(DenyStatement80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000DA51 File Offset: 0x0000BC51
		public virtual void Visit(RevokeStatement80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000DA62 File Offset: 0x0000BC62
		public virtual void ExplicitVisit(RevokeStatement80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000DA8F File Offset: 0x0000BC8F
		public virtual void Visit(SecurityElement80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		public virtual void ExplicitVisit(SecurityElement80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000DABF File Offset: 0x0000BCBF
		public virtual void Visit(CommandSecurityElement80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		public virtual void ExplicitVisit(CommandSecurityElement80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000DAF6 File Offset: 0x0000BCF6
		public virtual void Visit(PrivilegeSecurityElement80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000DB07 File Offset: 0x0000BD07
		public virtual void ExplicitVisit(PrivilegeSecurityElement80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000DB2D File Offset: 0x0000BD2D
		public virtual void Visit(Privilege80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000DB3E File Offset: 0x0000BD3E
		public virtual void ExplicitVisit(Privilege80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000DB5D File Offset: 0x0000BD5D
		public virtual void Visit(SecurityUserClause80 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000DB6E File Offset: 0x0000BD6E
		public virtual void ExplicitVisit(SecurityUserClause80 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000DB8D File Offset: 0x0000BD8D
		public virtual void Visit(SqlCommandIdentifier node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000DB9E File Offset: 0x0000BD9E
		public virtual void ExplicitVisit(SqlCommandIdentifier node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000DBC4 File Offset: 0x0000BDC4
		public virtual void Visit(SetClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000DBD5 File Offset: 0x0000BDD5
		public virtual void ExplicitVisit(SetClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		public virtual void Visit(AssignmentSetClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000DC05 File Offset: 0x0000BE05
		public virtual void ExplicitVisit(AssignmentSetClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000DC2B File Offset: 0x0000BE2B
		public virtual void Visit(FunctionCallSetClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		public virtual void ExplicitVisit(FunctionCallSetClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000DC62 File Offset: 0x0000BE62
		public virtual void Visit(InsertSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000DC73 File Offset: 0x0000BE73
		public virtual void ExplicitVisit(InsertSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000DC92 File Offset: 0x0000BE92
		public virtual void Visit(ValuesInsertSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000DCA3 File Offset: 0x0000BEA3
		public virtual void ExplicitVisit(ValuesInsertSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000DCC9 File Offset: 0x0000BEC9
		public virtual void Visit(SelectInsertSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000DCDA File Offset: 0x0000BEDA
		public virtual void ExplicitVisit(SelectInsertSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000DD00 File Offset: 0x0000BF00
		public virtual void Visit(ExecuteInsertSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000DD11 File Offset: 0x0000BF11
		public virtual void ExplicitVisit(ExecuteInsertSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000DD37 File Offset: 0x0000BF37
		public virtual void Visit(RowValue node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000DD48 File Offset: 0x0000BF48
		public virtual void ExplicitVisit(RowValue node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000DD67 File Offset: 0x0000BF67
		public virtual void Visit(PrintStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public virtual void ExplicitVisit(PrintStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000DD9E File Offset: 0x0000BF9E
		public virtual void Visit(UpdateCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000DDAF File Offset: 0x0000BFAF
		public virtual void ExplicitVisit(UpdateCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000DDD5 File Offset: 0x0000BFD5
		public virtual void Visit(TSEqualCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000DDE6 File Offset: 0x0000BFE6
		public virtual void ExplicitVisit(TSEqualCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000DE0C File Offset: 0x0000C00C
		public virtual void Visit(PrimaryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000DE1D File Offset: 0x0000C01D
		public virtual void ExplicitVisit(PrimaryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000DE43 File Offset: 0x0000C043
		public virtual void Visit(Literal node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000DE54 File Offset: 0x0000C054
		public virtual void ExplicitVisit(Literal node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000DE88 File Offset: 0x0000C088
		public virtual void Visit(IntegerLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000DE99 File Offset: 0x0000C099
		public virtual void ExplicitVisit(IntegerLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		public virtual void Visit(NumericLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000DEE5 File Offset: 0x0000C0E5
		public virtual void ExplicitVisit(NumericLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000DF20 File Offset: 0x0000C120
		public virtual void Visit(RealLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000DF31 File Offset: 0x0000C131
		public virtual void ExplicitVisit(RealLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000DF6C File Offset: 0x0000C16C
		public virtual void Visit(MoneyLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000DF7D File Offset: 0x0000C17D
		public virtual void ExplicitVisit(MoneyLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		public virtual void Visit(BinaryLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000DFC9 File Offset: 0x0000C1C9
		public virtual void ExplicitVisit(BinaryLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000E004 File Offset: 0x0000C204
		public virtual void Visit(StringLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000E015 File Offset: 0x0000C215
		public virtual void ExplicitVisit(StringLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000E050 File Offset: 0x0000C250
		public virtual void Visit(NullLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000E061 File Offset: 0x0000C261
		public virtual void ExplicitVisit(NullLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000E09C File Offset: 0x0000C29C
		public virtual void Visit(IdentifierLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000E0AD File Offset: 0x0000C2AD
		public virtual void ExplicitVisit(IdentifierLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		public virtual void Visit(DefaultLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		public virtual void ExplicitVisit(DefaultLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000E134 File Offset: 0x0000C334
		public virtual void Visit(MaxLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000E145 File Offset: 0x0000C345
		public virtual void ExplicitVisit(MaxLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000E180 File Offset: 0x0000C380
		public virtual void Visit(OdbcLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000E191 File Offset: 0x0000C391
		public virtual void ExplicitVisit(OdbcLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		public virtual void Visit(LiteralRange node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000E1DD File Offset: 0x0000C3DD
		public virtual void ExplicitVisit(LiteralRange node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		public virtual void Visit(ValueExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000E20D File Offset: 0x0000C40D
		public virtual void ExplicitVisit(ValueExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000E23A File Offset: 0x0000C43A
		public virtual void Visit(VariableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000E24B File Offset: 0x0000C44B
		public virtual void ExplicitVisit(VariableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000E27F File Offset: 0x0000C47F
		public virtual void Visit(OptionValue node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000E290 File Offset: 0x0000C490
		public virtual void ExplicitVisit(OptionValue node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000E2AF File Offset: 0x0000C4AF
		public virtual void Visit(OnOffOptionValue node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		public virtual void ExplicitVisit(OnOffOptionValue node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000E2E6 File Offset: 0x0000C4E6
		public virtual void Visit(LiteralOptionValue node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000E2F7 File Offset: 0x0000C4F7
		public virtual void ExplicitVisit(LiteralOptionValue node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000E31D File Offset: 0x0000C51D
		public virtual void Visit(GlobalVariableExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000E32E File Offset: 0x0000C52E
		public virtual void ExplicitVisit(GlobalVariableExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000E362 File Offset: 0x0000C562
		public virtual void Visit(IdentifierOrValueExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000E373 File Offset: 0x0000C573
		public virtual void ExplicitVisit(IdentifierOrValueExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000E392 File Offset: 0x0000C592
		public virtual void Visit(SchemaObjectNameOrValueExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000E3A3 File Offset: 0x0000C5A3
		public virtual void ExplicitVisit(SchemaObjectNameOrValueExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000E3C2 File Offset: 0x0000C5C2
		public virtual void Visit(ParenthesisExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000E3D3 File Offset: 0x0000C5D3
		public virtual void ExplicitVisit(ParenthesisExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000E400 File Offset: 0x0000C600
		public virtual void Visit(ColumnReferenceExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000E411 File Offset: 0x0000C611
		public virtual void ExplicitVisit(ColumnReferenceExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000E43E File Offset: 0x0000C63E
		public virtual void Visit(NextValueForExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000E44F File Offset: 0x0000C64F
		public virtual void ExplicitVisit(NextValueForExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000E47C File Offset: 0x0000C67C
		public virtual void Visit(SequenceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000E48D File Offset: 0x0000C68D
		public virtual void ExplicitVisit(SequenceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000E4B3 File Offset: 0x0000C6B3
		public virtual void Visit(SequenceOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		public virtual void ExplicitVisit(SequenceOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000E4E3 File Offset: 0x0000C6E3
		public virtual void Visit(DataTypeSequenceOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public virtual void ExplicitVisit(DataTypeSequenceOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000E51A File Offset: 0x0000C71A
		public virtual void Visit(ScalarExpressionSequenceOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000E52B File Offset: 0x0000C72B
		public virtual void ExplicitVisit(ScalarExpressionSequenceOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000E551 File Offset: 0x0000C751
		public virtual void Visit(CreateSequenceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000E562 File Offset: 0x0000C762
		public virtual void ExplicitVisit(CreateSequenceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000E58F File Offset: 0x0000C78F
		public virtual void Visit(AlterSequenceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		public virtual void ExplicitVisit(AlterSequenceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000E5CD File Offset: 0x0000C7CD
		public virtual void Visit(DropSequenceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000E5DE File Offset: 0x0000C7DE
		public virtual void ExplicitVisit(DropSequenceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000E60B File Offset: 0x0000C80B
		public virtual void Visit(AssemblyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000E61C File Offset: 0x0000C81C
		public virtual void ExplicitVisit(AssemblyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000E642 File Offset: 0x0000C842
		public virtual void Visit(CreateAssemblyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000E653 File Offset: 0x0000C853
		public virtual void ExplicitVisit(CreateAssemblyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000E680 File Offset: 0x0000C880
		public virtual void Visit(AlterAssemblyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000E691 File Offset: 0x0000C891
		public virtual void ExplicitVisit(AlterAssemblyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000E6BE File Offset: 0x0000C8BE
		public virtual void Visit(AssemblyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000E6CF File Offset: 0x0000C8CF
		public virtual void ExplicitVisit(AssemblyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000E6EE File Offset: 0x0000C8EE
		public virtual void Visit(OnOffAssemblyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000E6FF File Offset: 0x0000C8FF
		public virtual void ExplicitVisit(OnOffAssemblyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000E725 File Offset: 0x0000C925
		public virtual void Visit(PermissionSetAssemblyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000E736 File Offset: 0x0000C936
		public virtual void ExplicitVisit(PermissionSetAssemblyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000E75C File Offset: 0x0000C95C
		public virtual void Visit(AddFileSpec node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000E76D File Offset: 0x0000C96D
		public virtual void ExplicitVisit(AddFileSpec node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000E78C File Offset: 0x0000C98C
		public virtual void Visit(CreateXmlSchemaCollectionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000E79D File Offset: 0x0000C99D
		public virtual void ExplicitVisit(CreateXmlSchemaCollectionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000E7C3 File Offset: 0x0000C9C3
		public virtual void Visit(AlterXmlSchemaCollectionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		public virtual void ExplicitVisit(AlterXmlSchemaCollectionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000E7FA File Offset: 0x0000C9FA
		public virtual void Visit(DropXmlSchemaCollectionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000E80B File Offset: 0x0000CA0B
		public virtual void ExplicitVisit(DropXmlSchemaCollectionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000E831 File Offset: 0x0000CA31
		public virtual void Visit(AssemblyName node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000E842 File Offset: 0x0000CA42
		public virtual void ExplicitVisit(AssemblyName node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000E861 File Offset: 0x0000CA61
		public virtual void Visit(AlterTableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000E872 File Offset: 0x0000CA72
		public virtual void ExplicitVisit(AlterTableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000E898 File Offset: 0x0000CA98
		public virtual void Visit(AlterTableRebuildStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000E8A9 File Offset: 0x0000CAA9
		public virtual void ExplicitVisit(AlterTableRebuildStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000E8D6 File Offset: 0x0000CAD6
		public virtual void Visit(AlterTableChangeTrackingModificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000E8E7 File Offset: 0x0000CAE7
		public virtual void ExplicitVisit(AlterTableChangeTrackingModificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000E914 File Offset: 0x0000CB14
		public virtual void Visit(AlterTableFileTableNamespaceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000E925 File Offset: 0x0000CB25
		public virtual void ExplicitVisit(AlterTableFileTableNamespaceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000E952 File Offset: 0x0000CB52
		public virtual void Visit(AlterTableSetStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000E963 File Offset: 0x0000CB63
		public virtual void ExplicitVisit(AlterTableSetStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000E990 File Offset: 0x0000CB90
		public virtual void Visit(TableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000E9A1 File Offset: 0x0000CBA1
		public virtual void ExplicitVisit(TableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		public virtual void Visit(LockEscalationTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000E9D1 File Offset: 0x0000CBD1
		public virtual void ExplicitVisit(LockEscalationTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000E9F7 File Offset: 0x0000CBF7
		public virtual void Visit(FileStreamOnTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000EA08 File Offset: 0x0000CC08
		public virtual void ExplicitVisit(FileStreamOnTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000EA2E File Offset: 0x0000CC2E
		public virtual void Visit(FileTableDirectoryTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000EA3F File Offset: 0x0000CC3F
		public virtual void ExplicitVisit(FileTableDirectoryTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000EA65 File Offset: 0x0000CC65
		public virtual void Visit(FileTableCollateFileNameTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000EA76 File Offset: 0x0000CC76
		public virtual void ExplicitVisit(FileTableCollateFileNameTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000EA9C File Offset: 0x0000CC9C
		public virtual void Visit(FileTableConstraintNameTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000EAAD File Offset: 0x0000CCAD
		public virtual void ExplicitVisit(FileTableConstraintNameTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000EAD3 File Offset: 0x0000CCD3
		public virtual void Visit(MemoryOptimizedTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		public virtual void ExplicitVisit(MemoryOptimizedTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000EB0A File Offset: 0x0000CD0A
		public virtual void Visit(DurabilityTableOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000EB1B File Offset: 0x0000CD1B
		public virtual void ExplicitVisit(DurabilityTableOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000EB41 File Offset: 0x0000CD41
		public virtual void Visit(AlterTableAddTableElementStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000EB52 File Offset: 0x0000CD52
		public virtual void ExplicitVisit(AlterTableAddTableElementStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000EB7F File Offset: 0x0000CD7F
		public virtual void Visit(AlterTableConstraintModificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000EB90 File Offset: 0x0000CD90
		public virtual void ExplicitVisit(AlterTableConstraintModificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000EBBD File Offset: 0x0000CDBD
		public virtual void Visit(AlterTableSwitchStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000EBCE File Offset: 0x0000CDCE
		public virtual void ExplicitVisit(AlterTableSwitchStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000EBFB File Offset: 0x0000CDFB
		public virtual void Visit(TableSwitchOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		public virtual void ExplicitVisit(TableSwitchOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000EC2B File Offset: 0x0000CE2B
		public virtual void Visit(LowPriorityLockWaitTableSwitchOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		public virtual void ExplicitVisit(LowPriorityLockWaitTableSwitchOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000EC62 File Offset: 0x0000CE62
		public virtual void Visit(DropClusteredConstraintOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000EC73 File Offset: 0x0000CE73
		public virtual void ExplicitVisit(DropClusteredConstraintOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000EC92 File Offset: 0x0000CE92
		public virtual void Visit(DropClusteredConstraintStateOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000ECA3 File Offset: 0x0000CEA3
		public virtual void ExplicitVisit(DropClusteredConstraintStateOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000ECC9 File Offset: 0x0000CEC9
		public virtual void Visit(DropClusteredConstraintValueOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000ECDA File Offset: 0x0000CEDA
		public virtual void ExplicitVisit(DropClusteredConstraintValueOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public virtual void Visit(DropClusteredConstraintMoveOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000ED11 File Offset: 0x0000CF11
		public virtual void ExplicitVisit(DropClusteredConstraintMoveOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000ED37 File Offset: 0x0000CF37
		public virtual void Visit(AlterTableDropTableElement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000ED48 File Offset: 0x0000CF48
		public virtual void ExplicitVisit(AlterTableDropTableElement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000ED67 File Offset: 0x0000CF67
		public virtual void Visit(AlterTableDropTableElementStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000ED78 File Offset: 0x0000CF78
		public virtual void ExplicitVisit(AlterTableDropTableElementStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000EDA5 File Offset: 0x0000CFA5
		public virtual void Visit(AlterTableTriggerModificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000EDB6 File Offset: 0x0000CFB6
		public virtual void ExplicitVisit(AlterTableTriggerModificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
		public virtual void Visit(EnableDisableTriggerStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		public virtual void ExplicitVisit(EnableDisableTriggerStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000EE1A File Offset: 0x0000D01A
		public virtual void Visit(TryCatchStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000EE2B File Offset: 0x0000D02B
		public virtual void ExplicitVisit(TryCatchStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000EE51 File Offset: 0x0000D051
		public virtual void Visit(CreateTypeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000EE62 File Offset: 0x0000D062
		public virtual void ExplicitVisit(CreateTypeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000EE88 File Offset: 0x0000D088
		public virtual void Visit(CreateTypeUdtStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000EE99 File Offset: 0x0000D099
		public virtual void ExplicitVisit(CreateTypeUdtStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000EEC6 File Offset: 0x0000D0C6
		public virtual void Visit(CreateTypeUddtStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000EED7 File Offset: 0x0000D0D7
		public virtual void ExplicitVisit(CreateTypeUddtStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000EF04 File Offset: 0x0000D104
		public virtual void Visit(CreateSynonymStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000EF15 File Offset: 0x0000D115
		public virtual void ExplicitVisit(CreateSynonymStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000EF3B File Offset: 0x0000D13B
		public virtual void Visit(ExecuteAsClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000EF4C File Offset: 0x0000D14C
		public virtual void ExplicitVisit(ExecuteAsClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000EF6B File Offset: 0x0000D16B
		public virtual void Visit(QueueOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000EF7C File Offset: 0x0000D17C
		public virtual void ExplicitVisit(QueueOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000EF9B File Offset: 0x0000D19B
		public virtual void Visit(QueueStateOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		public virtual void ExplicitVisit(QueueStateOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000EFD2 File Offset: 0x0000D1D2
		public virtual void Visit(QueueProcedureOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000EFE3 File Offset: 0x0000D1E3
		public virtual void ExplicitVisit(QueueProcedureOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000F009 File Offset: 0x0000D209
		public virtual void Visit(QueueValueOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000F01A File Offset: 0x0000D21A
		public virtual void ExplicitVisit(QueueValueOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000F040 File Offset: 0x0000D240
		public virtual void Visit(QueueExecuteAsOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000F051 File Offset: 0x0000D251
		public virtual void ExplicitVisit(QueueExecuteAsOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000F077 File Offset: 0x0000D277
		public virtual void Visit(RouteOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000F088 File Offset: 0x0000D288
		public virtual void ExplicitVisit(RouteOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000F0A7 File Offset: 0x0000D2A7
		public virtual void Visit(RouteStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
		public virtual void ExplicitVisit(RouteStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000F0DE File Offset: 0x0000D2DE
		public virtual void Visit(AlterRouteStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000F0EF File Offset: 0x0000D2EF
		public virtual void ExplicitVisit(AlterRouteStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000F11C File Offset: 0x0000D31C
		public virtual void Visit(CreateRouteStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000F12D File Offset: 0x0000D32D
		public virtual void ExplicitVisit(CreateRouteStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000F15A File Offset: 0x0000D35A
		public virtual void Visit(QueueStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000F16B File Offset: 0x0000D36B
		public virtual void ExplicitVisit(QueueStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000F191 File Offset: 0x0000D391
		public virtual void Visit(AlterQueueStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000F1A2 File Offset: 0x0000D3A2
		public virtual void ExplicitVisit(AlterQueueStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000F1CF File Offset: 0x0000D3CF
		public virtual void Visit(CreateQueueStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		public virtual void ExplicitVisit(CreateQueueStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000F20D File Offset: 0x0000D40D
		public virtual void Visit(IndexDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000F21E File Offset: 0x0000D41E
		public virtual void ExplicitVisit(IndexDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000F244 File Offset: 0x0000D444
		public virtual void Visit(IndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000F255 File Offset: 0x0000D455
		public virtual void ExplicitVisit(IndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000F27B File Offset: 0x0000D47B
		public virtual void Visit(IndexType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000F28C File Offset: 0x0000D48C
		public virtual void ExplicitVisit(IndexType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000F2AB File Offset: 0x0000D4AB
		public virtual void Visit(PartitionSpecifier node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		public virtual void ExplicitVisit(PartitionSpecifier node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000F2DB File Offset: 0x0000D4DB
		public virtual void Visit(AlterIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		public virtual void ExplicitVisit(AlterIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000F319 File Offset: 0x0000D519
		public virtual void Visit(CreateXmlIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000F32A File Offset: 0x0000D52A
		public virtual void ExplicitVisit(CreateXmlIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000F357 File Offset: 0x0000D557
		public virtual void Visit(CreateSelectiveXmlIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000F368 File Offset: 0x0000D568
		public virtual void ExplicitVisit(CreateSelectiveXmlIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000F395 File Offset: 0x0000D595
		public virtual void Visit(FileGroupOrPartitionScheme node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000F3A6 File Offset: 0x0000D5A6
		public virtual void ExplicitVisit(FileGroupOrPartitionScheme node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000F3C5 File Offset: 0x0000D5C5
		public virtual void Visit(CreateIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000F3D6 File Offset: 0x0000D5D6
		public virtual void ExplicitVisit(CreateIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000F403 File Offset: 0x0000D603
		public virtual void Visit(IndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000F414 File Offset: 0x0000D614
		public virtual void ExplicitVisit(IndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000F433 File Offset: 0x0000D633
		public virtual void Visit(IndexStateOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000F444 File Offset: 0x0000D644
		public virtual void ExplicitVisit(IndexStateOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000F46A File Offset: 0x0000D66A
		public virtual void Visit(IndexExpressionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000F47B File Offset: 0x0000D67B
		public virtual void ExplicitVisit(IndexExpressionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0000F4A1 File Offset: 0x0000D6A1
		public virtual void Visit(OnlineIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0000F4B2 File Offset: 0x0000D6B2
		public virtual void ExplicitVisit(OnlineIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000F4DF File Offset: 0x0000D6DF
		public virtual void Visit(OnlineIndexLowPriorityLockWaitOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		public virtual void ExplicitVisit(OnlineIndexLowPriorityLockWaitOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000F50F File Offset: 0x0000D70F
		public virtual void Visit(LowPriorityLockWaitOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000F520 File Offset: 0x0000D720
		public virtual void ExplicitVisit(LowPriorityLockWaitOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000F53F File Offset: 0x0000D73F
		public virtual void Visit(LowPriorityLockWaitMaxDurationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000F550 File Offset: 0x0000D750
		public virtual void ExplicitVisit(LowPriorityLockWaitMaxDurationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000F576 File Offset: 0x0000D776
		public virtual void Visit(LowPriorityLockWaitAbortAfterWaitOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000F587 File Offset: 0x0000D787
		public virtual void ExplicitVisit(LowPriorityLockWaitAbortAfterWaitOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000F5AD File Offset: 0x0000D7AD
		public virtual void Visit(FullTextIndexColumn node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000F5BE File Offset: 0x0000D7BE
		public virtual void ExplicitVisit(FullTextIndexColumn node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000F5DD File Offset: 0x0000D7DD
		public virtual void Visit(CreateFullTextIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000F5EE File Offset: 0x0000D7EE
		public virtual void ExplicitVisit(CreateFullTextIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000F614 File Offset: 0x0000D814
		public virtual void Visit(FullTextIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000F625 File Offset: 0x0000D825
		public virtual void ExplicitVisit(FullTextIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000F644 File Offset: 0x0000D844
		public virtual void Visit(ChangeTrackingFullTextIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000F655 File Offset: 0x0000D855
		public virtual void ExplicitVisit(ChangeTrackingFullTextIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000F67B File Offset: 0x0000D87B
		public virtual void Visit(StopListFullTextIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000F68C File Offset: 0x0000D88C
		public virtual void ExplicitVisit(StopListFullTextIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000F6B2 File Offset: 0x0000D8B2
		public virtual void Visit(SearchPropertyListFullTextIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000F6C3 File Offset: 0x0000D8C3
		public virtual void ExplicitVisit(SearchPropertyListFullTextIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000F6E9 File Offset: 0x0000D8E9
		public virtual void Visit(FullTextCatalogAndFileGroup node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000F6FA File Offset: 0x0000D8FA
		public virtual void ExplicitVisit(FullTextCatalogAndFileGroup node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000F719 File Offset: 0x0000D919
		public virtual void Visit(EventTypeGroupContainer node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000F72A File Offset: 0x0000D92A
		public virtual void ExplicitVisit(EventTypeGroupContainer node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000F749 File Offset: 0x0000D949
		public virtual void Visit(EventTypeContainer node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000F75A File Offset: 0x0000D95A
		public virtual void ExplicitVisit(EventTypeContainer node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000F780 File Offset: 0x0000D980
		public virtual void Visit(EventGroupContainer node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000F791 File Offset: 0x0000D991
		public virtual void ExplicitVisit(EventGroupContainer node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000F7B7 File Offset: 0x0000D9B7
		public virtual void Visit(CreateEventNotificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		public virtual void ExplicitVisit(CreateEventNotificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000F7EE File Offset: 0x0000D9EE
		public virtual void Visit(EventNotificationObjectScope node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000F7FF File Offset: 0x0000D9FF
		public virtual void ExplicitVisit(EventNotificationObjectScope node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000F81E File Offset: 0x0000DA1E
		public virtual void Visit(MasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000F82F File Offset: 0x0000DA2F
		public virtual void ExplicitVisit(MasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000F855 File Offset: 0x0000DA55
		public virtual void Visit(CreateMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000F866 File Offset: 0x0000DA66
		public virtual void ExplicitVisit(CreateMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000F893 File Offset: 0x0000DA93
		public virtual void Visit(AlterMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public virtual void ExplicitVisit(AlterMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000F8D1 File Offset: 0x0000DAD1
		public virtual void Visit(ApplicationRoleOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000F8E2 File Offset: 0x0000DAE2
		public virtual void ExplicitVisit(ApplicationRoleOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000F901 File Offset: 0x0000DB01
		public virtual void Visit(ApplicationRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000F912 File Offset: 0x0000DB12
		public virtual void ExplicitVisit(ApplicationRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000F938 File Offset: 0x0000DB38
		public virtual void Visit(CreateApplicationRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000F949 File Offset: 0x0000DB49
		public virtual void ExplicitVisit(CreateApplicationRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000F976 File Offset: 0x0000DB76
		public virtual void Visit(AlterApplicationRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000F987 File Offset: 0x0000DB87
		public virtual void ExplicitVisit(AlterApplicationRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		public virtual void Visit(RoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000F9C5 File Offset: 0x0000DBC5
		public virtual void ExplicitVisit(RoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000F9EB File Offset: 0x0000DBEB
		public virtual void Visit(CreateRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		public virtual void ExplicitVisit(CreateRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000FA29 File Offset: 0x0000DC29
		public virtual void Visit(AlterRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000FA3A File Offset: 0x0000DC3A
		public virtual void ExplicitVisit(AlterRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000FA67 File Offset: 0x0000DC67
		public virtual void Visit(AlterRoleAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000FA78 File Offset: 0x0000DC78
		public virtual void ExplicitVisit(AlterRoleAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000FA97 File Offset: 0x0000DC97
		public virtual void Visit(RenameAlterRoleAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		public virtual void ExplicitVisit(RenameAlterRoleAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public virtual void Visit(AddMemberAlterRoleAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000FADF File Offset: 0x0000DCDF
		public virtual void ExplicitVisit(AddMemberAlterRoleAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000FB05 File Offset: 0x0000DD05
		public virtual void Visit(DropMemberAlterRoleAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000FB16 File Offset: 0x0000DD16
		public virtual void ExplicitVisit(DropMemberAlterRoleAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		public virtual void Visit(CreateServerRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000FB4D File Offset: 0x0000DD4D
		public virtual void ExplicitVisit(CreateServerRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000FB81 File Offset: 0x0000DD81
		public virtual void Visit(AlterServerRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000FB92 File Offset: 0x0000DD92
		public virtual void ExplicitVisit(AlterServerRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000FBC6 File Offset: 0x0000DDC6
		public virtual void Visit(DropServerRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000FBD7 File Offset: 0x0000DDD7
		public virtual void ExplicitVisit(DropServerRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public virtual void Visit(UserLoginOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000FC15 File Offset: 0x0000DE15
		public virtual void ExplicitVisit(UserLoginOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000FC34 File Offset: 0x0000DE34
		public virtual void Visit(UserStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000FC45 File Offset: 0x0000DE45
		public virtual void ExplicitVisit(UserStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000FC6B File Offset: 0x0000DE6B
		public virtual void Visit(CreateUserStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000FC7C File Offset: 0x0000DE7C
		public virtual void ExplicitVisit(CreateUserStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000FCA9 File Offset: 0x0000DEA9
		public virtual void Visit(AlterUserStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000FCBA File Offset: 0x0000DEBA
		public virtual void ExplicitVisit(AlterUserStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000FCE7 File Offset: 0x0000DEE7
		public virtual void Visit(StatisticsOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		public virtual void ExplicitVisit(StatisticsOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000FD17 File Offset: 0x0000DF17
		public virtual void Visit(ResampleStatisticsOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000FD28 File Offset: 0x0000DF28
		public virtual void ExplicitVisit(ResampleStatisticsOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000FD4E File Offset: 0x0000DF4E
		public virtual void Visit(StatisticsPartitionRange node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000FD5F File Offset: 0x0000DF5F
		public virtual void ExplicitVisit(StatisticsPartitionRange node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000FD7E File Offset: 0x0000DF7E
		public virtual void Visit(OnOffStatisticsOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000FD8F File Offset: 0x0000DF8F
		public virtual void ExplicitVisit(OnOffStatisticsOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000FDB5 File Offset: 0x0000DFB5
		public virtual void Visit(LiteralStatisticsOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000FDC6 File Offset: 0x0000DFC6
		public virtual void ExplicitVisit(LiteralStatisticsOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		public virtual void Visit(CreateStatisticsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000FDFD File Offset: 0x0000DFFD
		public virtual void ExplicitVisit(CreateStatisticsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000FE23 File Offset: 0x0000E023
		public virtual void Visit(UpdateStatisticsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000FE34 File Offset: 0x0000E034
		public virtual void ExplicitVisit(UpdateStatisticsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000FE5A File Offset: 0x0000E05A
		public virtual void Visit(ReturnStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000FE6B File Offset: 0x0000E06B
		public virtual void ExplicitVisit(ReturnStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0000FE91 File Offset: 0x0000E091
		public virtual void Visit(DeclareCursorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000FEA2 File Offset: 0x0000E0A2
		public virtual void ExplicitVisit(DeclareCursorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		public virtual void Visit(CursorDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000FED9 File Offset: 0x0000E0D9
		public virtual void ExplicitVisit(CursorDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		public virtual void Visit(CursorOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000FF09 File Offset: 0x0000E109
		public virtual void ExplicitVisit(CursorOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000FF28 File Offset: 0x0000E128
		public virtual void Visit(SetVariableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000FF39 File Offset: 0x0000E139
		public virtual void ExplicitVisit(SetVariableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000FF5F File Offset: 0x0000E15F
		public virtual void Visit(CursorId node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000FF70 File Offset: 0x0000E170
		public virtual void ExplicitVisit(CursorId node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000FF8F File Offset: 0x0000E18F
		public virtual void Visit(CursorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
		public virtual void ExplicitVisit(CursorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000FFC6 File Offset: 0x0000E1C6
		public virtual void Visit(OpenCursorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000FFD7 File Offset: 0x0000E1D7
		public virtual void ExplicitVisit(OpenCursorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00010004 File Offset: 0x0000E204
		public virtual void Visit(CloseCursorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00010015 File Offset: 0x0000E215
		public virtual void ExplicitVisit(CloseCursorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00010042 File Offset: 0x0000E242
		public virtual void Visit(CryptoMechanism node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00010053 File Offset: 0x0000E253
		public virtual void ExplicitVisit(CryptoMechanism node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00010072 File Offset: 0x0000E272
		public virtual void Visit(OpenSymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00010083 File Offset: 0x0000E283
		public virtual void ExplicitVisit(OpenSymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000100A9 File Offset: 0x0000E2A9
		public virtual void Visit(CloseSymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000100BA File Offset: 0x0000E2BA
		public virtual void ExplicitVisit(CloseSymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public virtual void Visit(OpenMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000100F1 File Offset: 0x0000E2F1
		public virtual void ExplicitVisit(OpenMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00010117 File Offset: 0x0000E317
		public virtual void Visit(CloseMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00010128 File Offset: 0x0000E328
		public virtual void ExplicitVisit(CloseMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001014E File Offset: 0x0000E34E
		public virtual void Visit(DeallocateCursorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001015F File Offset: 0x0000E35F
		public virtual void ExplicitVisit(DeallocateCursorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001018C File Offset: 0x0000E38C
		public virtual void Visit(FetchType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001019D File Offset: 0x0000E39D
		public virtual void ExplicitVisit(FetchType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000101BC File Offset: 0x0000E3BC
		public virtual void Visit(FetchCursorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000101CD File Offset: 0x0000E3CD
		public virtual void ExplicitVisit(FetchCursorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000101FA File Offset: 0x0000E3FA
		public virtual void Visit(WhereClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001020B File Offset: 0x0000E40B
		public virtual void ExplicitVisit(WhereClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001022A File Offset: 0x0000E42A
		public virtual void Visit(DropUnownedObjectStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001023B File Offset: 0x0000E43B
		public virtual void ExplicitVisit(DropUnownedObjectStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00010261 File Offset: 0x0000E461
		public virtual void Visit(DropObjectsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00010272 File Offset: 0x0000E472
		public virtual void ExplicitVisit(DropObjectsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00010298 File Offset: 0x0000E498
		public virtual void Visit(DropDatabaseStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000102A9 File Offset: 0x0000E4A9
		public virtual void ExplicitVisit(DropDatabaseStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000102CF File Offset: 0x0000E4CF
		public virtual void Visit(DropChildObjectsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000102E0 File Offset: 0x0000E4E0
		public virtual void ExplicitVisit(DropChildObjectsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00010306 File Offset: 0x0000E506
		public virtual void Visit(DropIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00010317 File Offset: 0x0000E517
		public virtual void ExplicitVisit(DropIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001033D File Offset: 0x0000E53D
		public virtual void Visit(DropIndexClauseBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001034E File Offset: 0x0000E54E
		public virtual void ExplicitVisit(DropIndexClauseBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001036D File Offset: 0x0000E56D
		public virtual void Visit(BackwardsCompatibleDropIndexClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001037E File Offset: 0x0000E57E
		public virtual void ExplicitVisit(BackwardsCompatibleDropIndexClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000103A4 File Offset: 0x0000E5A4
		public virtual void Visit(DropIndexClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000103B5 File Offset: 0x0000E5B5
		public virtual void ExplicitVisit(DropIndexClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000103DB File Offset: 0x0000E5DB
		public virtual void Visit(MoveToDropIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000103EC File Offset: 0x0000E5EC
		public virtual void ExplicitVisit(MoveToDropIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00010412 File Offset: 0x0000E612
		public virtual void Visit(FileStreamOnDropIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00010423 File Offset: 0x0000E623
		public virtual void ExplicitVisit(FileStreamOnDropIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00010449 File Offset: 0x0000E649
		public virtual void Visit(DropStatisticsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001045A File Offset: 0x0000E65A
		public virtual void ExplicitVisit(DropStatisticsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00010487 File Offset: 0x0000E687
		public virtual void Visit(DropTableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00010498 File Offset: 0x0000E698
		public virtual void ExplicitVisit(DropTableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000104C5 File Offset: 0x0000E6C5
		public virtual void Visit(DropProcedureStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000104D6 File Offset: 0x0000E6D6
		public virtual void ExplicitVisit(DropProcedureStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00010503 File Offset: 0x0000E703
		public virtual void Visit(DropFunctionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00010514 File Offset: 0x0000E714
		public virtual void ExplicitVisit(DropFunctionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00010541 File Offset: 0x0000E741
		public virtual void Visit(DropViewStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00010552 File Offset: 0x0000E752
		public virtual void ExplicitVisit(DropViewStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001057F File Offset: 0x0000E77F
		public virtual void Visit(DropDefaultStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00010590 File Offset: 0x0000E790
		public virtual void ExplicitVisit(DropDefaultStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000105BD File Offset: 0x0000E7BD
		public virtual void Visit(DropRuleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000105CE File Offset: 0x0000E7CE
		public virtual void ExplicitVisit(DropRuleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000105FB File Offset: 0x0000E7FB
		public virtual void Visit(DropTriggerStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001060C File Offset: 0x0000E80C
		public virtual void ExplicitVisit(DropTriggerStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00010639 File Offset: 0x0000E839
		public virtual void Visit(DropSchemaStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001064A File Offset: 0x0000E84A
		public virtual void ExplicitVisit(DropSchemaStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00010670 File Offset: 0x0000E870
		public virtual void Visit(RaiseErrorLegacyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00010681 File Offset: 0x0000E881
		public virtual void ExplicitVisit(RaiseErrorLegacyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000106A7 File Offset: 0x0000E8A7
		public virtual void Visit(RaiseErrorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000106B8 File Offset: 0x0000E8B8
		public virtual void ExplicitVisit(RaiseErrorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000106DE File Offset: 0x0000E8DE
		public virtual void Visit(ThrowStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000106EF File Offset: 0x0000E8EF
		public virtual void ExplicitVisit(ThrowStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00010715 File Offset: 0x0000E915
		public virtual void Visit(UseStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00010726 File Offset: 0x0000E926
		public virtual void ExplicitVisit(UseStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001074C File Offset: 0x0000E94C
		public virtual void Visit(KillStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001075D File Offset: 0x0000E95D
		public virtual void ExplicitVisit(KillStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00010783 File Offset: 0x0000E983
		public virtual void Visit(KillQueryNotificationSubscriptionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00010794 File Offset: 0x0000E994
		public virtual void ExplicitVisit(KillQueryNotificationSubscriptionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000107BA File Offset: 0x0000E9BA
		public virtual void Visit(KillStatsJobStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000107CB File Offset: 0x0000E9CB
		public virtual void ExplicitVisit(KillStatsJobStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000107F1 File Offset: 0x0000E9F1
		public virtual void Visit(CheckpointStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00010802 File Offset: 0x0000EA02
		public virtual void ExplicitVisit(CheckpointStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00010828 File Offset: 0x0000EA28
		public virtual void Visit(ReconfigureStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00010839 File Offset: 0x0000EA39
		public virtual void ExplicitVisit(ReconfigureStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001085F File Offset: 0x0000EA5F
		public virtual void Visit(ShutdownStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00010870 File Offset: 0x0000EA70
		public virtual void ExplicitVisit(ShutdownStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00010896 File Offset: 0x0000EA96
		public virtual void Visit(SetUserStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000108A7 File Offset: 0x0000EAA7
		public virtual void ExplicitVisit(SetUserStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000108CD File Offset: 0x0000EACD
		public virtual void Visit(TruncateTableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000108DE File Offset: 0x0000EADE
		public virtual void ExplicitVisit(TruncateTableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00010904 File Offset: 0x0000EB04
		public virtual void Visit(SetOnOffStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00010915 File Offset: 0x0000EB15
		public virtual void ExplicitVisit(SetOnOffStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001093B File Offset: 0x0000EB3B
		public virtual void Visit(PredicateSetStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001094C File Offset: 0x0000EB4C
		public virtual void ExplicitVisit(PredicateSetStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00010979 File Offset: 0x0000EB79
		public virtual void Visit(SetStatisticsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001098A File Offset: 0x0000EB8A
		public virtual void ExplicitVisit(SetStatisticsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000109B7 File Offset: 0x0000EBB7
		public virtual void Visit(SetRowCountStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000109C8 File Offset: 0x0000EBC8
		public virtual void ExplicitVisit(SetRowCountStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000109EE File Offset: 0x0000EBEE
		public virtual void Visit(SetOffsetsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000109FF File Offset: 0x0000EBFF
		public virtual void ExplicitVisit(SetOffsetsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00010A2C File Offset: 0x0000EC2C
		public virtual void Visit(SetCommand node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00010A3D File Offset: 0x0000EC3D
		public virtual void ExplicitVisit(SetCommand node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00010A5C File Offset: 0x0000EC5C
		public virtual void Visit(GeneralSetCommand node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00010A6D File Offset: 0x0000EC6D
		public virtual void ExplicitVisit(GeneralSetCommand node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00010A93 File Offset: 0x0000EC93
		public virtual void Visit(SetFipsFlaggerCommand node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		public virtual void ExplicitVisit(SetFipsFlaggerCommand node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00010ACA File Offset: 0x0000ECCA
		public virtual void Visit(SetCommandStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00010ADB File Offset: 0x0000ECDB
		public virtual void ExplicitVisit(SetCommandStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00010B01 File Offset: 0x0000ED01
		public virtual void Visit(SetTransactionIsolationLevelStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00010B12 File Offset: 0x0000ED12
		public virtual void ExplicitVisit(SetTransactionIsolationLevelStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00010B38 File Offset: 0x0000ED38
		public virtual void Visit(SetTextSizeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00010B49 File Offset: 0x0000ED49
		public virtual void ExplicitVisit(SetTextSizeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00010B6F File Offset: 0x0000ED6F
		public virtual void Visit(SetIdentityInsertStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00010B80 File Offset: 0x0000ED80
		public virtual void ExplicitVisit(SetIdentityInsertStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00010BAD File Offset: 0x0000EDAD
		public virtual void Visit(SetErrorLevelStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00010BBE File Offset: 0x0000EDBE
		public virtual void ExplicitVisit(SetErrorLevelStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		public virtual void Visit(CreateDatabaseStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00010BF5 File Offset: 0x0000EDF5
		public virtual void ExplicitVisit(CreateDatabaseStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00010C1B File Offset: 0x0000EE1B
		public virtual void Visit(FileDeclaration node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00010C2C File Offset: 0x0000EE2C
		public virtual void ExplicitVisit(FileDeclaration node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00010C4B File Offset: 0x0000EE4B
		public virtual void Visit(FileDeclarationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00010C5C File Offset: 0x0000EE5C
		public virtual void ExplicitVisit(FileDeclarationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00010C7B File Offset: 0x0000EE7B
		public virtual void Visit(NameFileDeclarationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public virtual void ExplicitVisit(NameFileDeclarationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00010CB2 File Offset: 0x0000EEB2
		public virtual void Visit(FileNameFileDeclarationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00010CC3 File Offset: 0x0000EEC3
		public virtual void ExplicitVisit(FileNameFileDeclarationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00010CE9 File Offset: 0x0000EEE9
		public virtual void Visit(SizeFileDeclarationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00010CFA File Offset: 0x0000EEFA
		public virtual void ExplicitVisit(SizeFileDeclarationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00010D20 File Offset: 0x0000EF20
		public virtual void Visit(MaxSizeFileDeclarationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00010D31 File Offset: 0x0000EF31
		public virtual void ExplicitVisit(MaxSizeFileDeclarationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00010D57 File Offset: 0x0000EF57
		public virtual void Visit(FileGrowthFileDeclarationOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00010D68 File Offset: 0x0000EF68
		public virtual void ExplicitVisit(FileGrowthFileDeclarationOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00010D8E File Offset: 0x0000EF8E
		public virtual void Visit(FileGroupDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00010D9F File Offset: 0x0000EF9F
		public virtual void ExplicitVisit(FileGroupDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00010DBE File Offset: 0x0000EFBE
		public virtual void Visit(AlterDatabaseStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00010DCF File Offset: 0x0000EFCF
		public virtual void ExplicitVisit(AlterDatabaseStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00010DF5 File Offset: 0x0000EFF5
		public virtual void Visit(AlterDatabaseCollateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00010E06 File Offset: 0x0000F006
		public virtual void ExplicitVisit(AlterDatabaseCollateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00010E33 File Offset: 0x0000F033
		public virtual void Visit(AlterDatabaseRebuildLogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00010E44 File Offset: 0x0000F044
		public virtual void ExplicitVisit(AlterDatabaseRebuildLogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00010E71 File Offset: 0x0000F071
		public virtual void Visit(AlterDatabaseAddFileStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00010E82 File Offset: 0x0000F082
		public virtual void ExplicitVisit(AlterDatabaseAddFileStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00010EAF File Offset: 0x0000F0AF
		public virtual void Visit(AlterDatabaseAddFileGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		public virtual void ExplicitVisit(AlterDatabaseAddFileGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00010EED File Offset: 0x0000F0ED
		public virtual void Visit(AlterDatabaseRemoveFileGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00010EFE File Offset: 0x0000F0FE
		public virtual void ExplicitVisit(AlterDatabaseRemoveFileGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00010F2B File Offset: 0x0000F12B
		public virtual void Visit(AlterDatabaseRemoveFileStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00010F3C File Offset: 0x0000F13C
		public virtual void ExplicitVisit(AlterDatabaseRemoveFileStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00010F69 File Offset: 0x0000F169
		public virtual void Visit(AlterDatabaseModifyNameStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00010F7A File Offset: 0x0000F17A
		public virtual void ExplicitVisit(AlterDatabaseModifyNameStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00010FA7 File Offset: 0x0000F1A7
		public virtual void Visit(AlterDatabaseModifyFileStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00010FB8 File Offset: 0x0000F1B8
		public virtual void ExplicitVisit(AlterDatabaseModifyFileStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00010FE5 File Offset: 0x0000F1E5
		public virtual void Visit(AlterDatabaseModifyFileGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00010FF6 File Offset: 0x0000F1F6
		public virtual void ExplicitVisit(AlterDatabaseModifyFileGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00011023 File Offset: 0x0000F223
		public virtual void Visit(AlterDatabaseTermination node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00011034 File Offset: 0x0000F234
		public virtual void ExplicitVisit(AlterDatabaseTermination node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00011053 File Offset: 0x0000F253
		public virtual void Visit(AlterDatabaseSetStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00011064 File Offset: 0x0000F264
		public virtual void ExplicitVisit(AlterDatabaseSetStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00011091 File Offset: 0x0000F291
		public virtual void Visit(DatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000110A2 File Offset: 0x0000F2A2
		public virtual void ExplicitVisit(DatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000110C1 File Offset: 0x0000F2C1
		public virtual void Visit(OnOffDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000110D2 File Offset: 0x0000F2D2
		public virtual void ExplicitVisit(OnOffDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public virtual void Visit(AutoCreateStatisticsDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00011109 File Offset: 0x0000F309
		public virtual void ExplicitVisit(AutoCreateStatisticsDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00011136 File Offset: 0x0000F336
		public virtual void Visit(ContainmentDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00011147 File Offset: 0x0000F347
		public virtual void ExplicitVisit(ContainmentDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001116D File Offset: 0x0000F36D
		public virtual void Visit(HadrDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001117E File Offset: 0x0000F37E
		public virtual void ExplicitVisit(HadrDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000111A4 File Offset: 0x0000F3A4
		public virtual void Visit(HadrAvailabilityGroupDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000111B5 File Offset: 0x0000F3B5
		public virtual void ExplicitVisit(HadrAvailabilityGroupDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000111E2 File Offset: 0x0000F3E2
		public virtual void Visit(DelayedDurabilityDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000111F3 File Offset: 0x0000F3F3
		public virtual void ExplicitVisit(DelayedDurabilityDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00011219 File Offset: 0x0000F419
		public virtual void Visit(CursorDefaultDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001122A File Offset: 0x0000F42A
		public virtual void ExplicitVisit(CursorDefaultDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00011250 File Offset: 0x0000F450
		public virtual void Visit(RecoveryDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00011261 File Offset: 0x0000F461
		public virtual void ExplicitVisit(RecoveryDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00011287 File Offset: 0x0000F487
		public virtual void Visit(TargetRecoveryTimeDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00011298 File Offset: 0x0000F498
		public virtual void ExplicitVisit(TargetRecoveryTimeDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000112BE File Offset: 0x0000F4BE
		public virtual void Visit(PageVerifyDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000112CF File Offset: 0x0000F4CF
		public virtual void ExplicitVisit(PageVerifyDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000112F5 File Offset: 0x0000F4F5
		public virtual void Visit(PartnerDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00011306 File Offset: 0x0000F506
		public virtual void ExplicitVisit(PartnerDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001132C File Offset: 0x0000F52C
		public virtual void Visit(WitnessDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001133D File Offset: 0x0000F53D
		public virtual void ExplicitVisit(WitnessDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00011363 File Offset: 0x0000F563
		public virtual void Visit(ParameterizationDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00011374 File Offset: 0x0000F574
		public virtual void ExplicitVisit(ParameterizationDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001139A File Offset: 0x0000F59A
		public virtual void Visit(LiteralDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000113AB File Offset: 0x0000F5AB
		public virtual void ExplicitVisit(LiteralDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000113D1 File Offset: 0x0000F5D1
		public virtual void Visit(IdentifierDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000113E2 File Offset: 0x0000F5E2
		public virtual void ExplicitVisit(IdentifierDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00011408 File Offset: 0x0000F608
		public virtual void Visit(ChangeTrackingDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00011419 File Offset: 0x0000F619
		public virtual void ExplicitVisit(ChangeTrackingDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001143F File Offset: 0x0000F63F
		public virtual void Visit(ChangeTrackingOptionDetail node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00011450 File Offset: 0x0000F650
		public virtual void ExplicitVisit(ChangeTrackingOptionDetail node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001146F File Offset: 0x0000F66F
		public virtual void Visit(AutoCleanupChangeTrackingOptionDetail node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00011480 File Offset: 0x0000F680
		public virtual void ExplicitVisit(AutoCleanupChangeTrackingOptionDetail node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000114A6 File Offset: 0x0000F6A6
		public virtual void Visit(ChangeRetentionChangeTrackingOptionDetail node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000114B7 File Offset: 0x0000F6B7
		public virtual void ExplicitVisit(ChangeRetentionChangeTrackingOptionDetail node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000114DD File Offset: 0x0000F6DD
		public virtual void Visit(FileStreamDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000114EE File Offset: 0x0000F6EE
		public virtual void ExplicitVisit(FileStreamDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00011514 File Offset: 0x0000F714
		public virtual void Visit(MaxSizeDatabaseOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00011525 File Offset: 0x0000F725
		public virtual void ExplicitVisit(MaxSizeDatabaseOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001154B File Offset: 0x0000F74B
		public virtual void Visit(AlterTableAlterColumnStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001155C File Offset: 0x0000F75C
		public virtual void ExplicitVisit(AlterTableAlterColumnStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00011589 File Offset: 0x0000F789
		public virtual void Visit(ColumnDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001159A File Offset: 0x0000F79A
		public virtual void ExplicitVisit(ColumnDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000115C0 File Offset: 0x0000F7C0
		public virtual void Visit(IdentityOptions node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000115D1 File Offset: 0x0000F7D1
		public virtual void ExplicitVisit(IdentityOptions node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000115F0 File Offset: 0x0000F7F0
		public virtual void Visit(ColumnStorageOptions node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00011601 File Offset: 0x0000F801
		public virtual void ExplicitVisit(ColumnStorageOptions node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00011620 File Offset: 0x0000F820
		public virtual void Visit(ConstraintDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00011631 File Offset: 0x0000F831
		public virtual void ExplicitVisit(ConstraintDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00011650 File Offset: 0x0000F850
		public virtual void Visit(CreateTableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00011661 File Offset: 0x0000F861
		public virtual void ExplicitVisit(CreateTableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00011687 File Offset: 0x0000F887
		public virtual void Visit(FederationScheme node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00011698 File Offset: 0x0000F898
		public virtual void ExplicitVisit(FederationScheme node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000116B7 File Offset: 0x0000F8B7
		public virtual void Visit(TableDataCompressionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000116C8 File Offset: 0x0000F8C8
		public virtual void ExplicitVisit(TableDataCompressionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000116EE File Offset: 0x0000F8EE
		public virtual void Visit(DataCompressionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000116FF File Offset: 0x0000F8FF
		public virtual void ExplicitVisit(DataCompressionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00011725 File Offset: 0x0000F925
		public virtual void Visit(CompressionPartitionRange node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00011736 File Offset: 0x0000F936
		public virtual void ExplicitVisit(CompressionPartitionRange node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00011755 File Offset: 0x0000F955
		public virtual void Visit(CheckConstraintDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00011766 File Offset: 0x0000F966
		public virtual void ExplicitVisit(CheckConstraintDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001178C File Offset: 0x0000F98C
		public virtual void Visit(DefaultConstraintDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001179D File Offset: 0x0000F99D
		public virtual void ExplicitVisit(DefaultConstraintDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000117C3 File Offset: 0x0000F9C3
		public virtual void Visit(ForeignKeyConstraintDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000117D4 File Offset: 0x0000F9D4
		public virtual void ExplicitVisit(ForeignKeyConstraintDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000117FA File Offset: 0x0000F9FA
		public virtual void Visit(NullableConstraintDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001180B File Offset: 0x0000FA0B
		public virtual void ExplicitVisit(NullableConstraintDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00011831 File Offset: 0x0000FA31
		public virtual void Visit(UniqueConstraintDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00011842 File Offset: 0x0000FA42
		public virtual void ExplicitVisit(UniqueConstraintDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00011868 File Offset: 0x0000FA68
		public virtual void Visit(BackupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00011879 File Offset: 0x0000FA79
		public virtual void ExplicitVisit(BackupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001189F File Offset: 0x0000FA9F
		public virtual void Visit(BackupDatabaseStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000118B0 File Offset: 0x0000FAB0
		public virtual void ExplicitVisit(BackupDatabaseStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000118DD File Offset: 0x0000FADD
		public virtual void Visit(BackupTransactionLogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000118EE File Offset: 0x0000FAEE
		public virtual void ExplicitVisit(BackupTransactionLogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001191B File Offset: 0x0000FB1B
		public virtual void Visit(RestoreStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001192C File Offset: 0x0000FB2C
		public virtual void ExplicitVisit(RestoreStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00011952 File Offset: 0x0000FB52
		public virtual void Visit(RestoreOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00011963 File Offset: 0x0000FB63
		public virtual void ExplicitVisit(RestoreOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00011982 File Offset: 0x0000FB82
		public virtual void Visit(ScalarExpressionRestoreOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00011993 File Offset: 0x0000FB93
		public virtual void ExplicitVisit(ScalarExpressionRestoreOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000119B9 File Offset: 0x0000FBB9
		public virtual void Visit(MoveRestoreOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000119CA File Offset: 0x0000FBCA
		public virtual void ExplicitVisit(MoveRestoreOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000119F0 File Offset: 0x0000FBF0
		public virtual void Visit(StopRestoreOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00011A01 File Offset: 0x0000FC01
		public virtual void ExplicitVisit(StopRestoreOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00011A27 File Offset: 0x0000FC27
		public virtual void Visit(FileStreamRestoreOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00011A38 File Offset: 0x0000FC38
		public virtual void ExplicitVisit(FileStreamRestoreOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00011A5E File Offset: 0x0000FC5E
		public virtual void Visit(BackupOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00011A6F File Offset: 0x0000FC6F
		public virtual void ExplicitVisit(BackupOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00011A8E File Offset: 0x0000FC8E
		public virtual void Visit(BackupEncryptionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00011A9F File Offset: 0x0000FC9F
		public virtual void ExplicitVisit(BackupEncryptionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00011AC5 File Offset: 0x0000FCC5
		public virtual void Visit(DeviceInfo node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00011AD6 File Offset: 0x0000FCD6
		public virtual void ExplicitVisit(DeviceInfo node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00011AF5 File Offset: 0x0000FCF5
		public virtual void Visit(MirrorToClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00011B06 File Offset: 0x0000FD06
		public virtual void ExplicitVisit(MirrorToClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00011B25 File Offset: 0x0000FD25
		public virtual void Visit(BackupRestoreFileInfo node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00011B36 File Offset: 0x0000FD36
		public virtual void ExplicitVisit(BackupRestoreFileInfo node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00011B55 File Offset: 0x0000FD55
		public virtual void Visit(BulkInsertBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00011B66 File Offset: 0x0000FD66
		public virtual void ExplicitVisit(BulkInsertBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public virtual void Visit(BulkInsertStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00011B9D File Offset: 0x0000FD9D
		public virtual void ExplicitVisit(BulkInsertStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00011BCA File Offset: 0x0000FDCA
		public virtual void Visit(InsertBulkStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00011BDB File Offset: 0x0000FDDB
		public virtual void ExplicitVisit(InsertBulkStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00011C08 File Offset: 0x0000FE08
		public virtual void Visit(BulkInsertOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00011C19 File Offset: 0x0000FE19
		public virtual void ExplicitVisit(BulkInsertOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00011C38 File Offset: 0x0000FE38
		public virtual void Visit(LiteralBulkInsertOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00011C49 File Offset: 0x0000FE49
		public virtual void ExplicitVisit(LiteralBulkInsertOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00011C6F File Offset: 0x0000FE6F
		public virtual void Visit(OrderBulkInsertOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00011C80 File Offset: 0x0000FE80
		public virtual void ExplicitVisit(OrderBulkInsertOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00011CA6 File Offset: 0x0000FEA6
		public virtual void Visit(ColumnDefinitionBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00011CB7 File Offset: 0x0000FEB7
		public virtual void ExplicitVisit(ColumnDefinitionBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00011CD6 File Offset: 0x0000FED6
		public virtual void Visit(InsertBulkColumnDefinition node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00011CE7 File Offset: 0x0000FEE7
		public virtual void ExplicitVisit(InsertBulkColumnDefinition node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00011D06 File Offset: 0x0000FF06
		public virtual void Visit(DbccStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00011D17 File Offset: 0x0000FF17
		public virtual void ExplicitVisit(DbccStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00011D3D File Offset: 0x0000FF3D
		public virtual void Visit(DbccOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00011D4E File Offset: 0x0000FF4E
		public virtual void ExplicitVisit(DbccOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00011D6D File Offset: 0x0000FF6D
		public virtual void Visit(DbccNamedLiteral node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00011D7E File Offset: 0x0000FF7E
		public virtual void ExplicitVisit(DbccNamedLiteral node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00011D9D File Offset: 0x0000FF9D
		public virtual void Visit(CreateAsymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00011DAE File Offset: 0x0000FFAE
		public virtual void ExplicitVisit(CreateAsymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		public virtual void Visit(CreatePartitionFunctionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public virtual void ExplicitVisit(CreatePartitionFunctionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00011E0B File Offset: 0x0001000B
		public virtual void Visit(PartitionParameterType node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00011E1C File Offset: 0x0001001C
		public virtual void ExplicitVisit(PartitionParameterType node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00011E3B File Offset: 0x0001003B
		public virtual void Visit(CreatePartitionSchemeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00011E4C File Offset: 0x0001004C
		public virtual void ExplicitVisit(CreatePartitionSchemeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00011E72 File Offset: 0x00010072
		public virtual void Visit(RemoteServiceBindingStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00011E83 File Offset: 0x00010083
		public virtual void ExplicitVisit(RemoteServiceBindingStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00011EA9 File Offset: 0x000100A9
		public virtual void Visit(RemoteServiceBindingOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00011EBA File Offset: 0x000100BA
		public virtual void ExplicitVisit(RemoteServiceBindingOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00011ED9 File Offset: 0x000100D9
		public virtual void Visit(OnOffRemoteServiceBindingOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00011EEA File Offset: 0x000100EA
		public virtual void ExplicitVisit(OnOffRemoteServiceBindingOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00011F10 File Offset: 0x00010110
		public virtual void Visit(UserRemoteServiceBindingOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00011F21 File Offset: 0x00010121
		public virtual void ExplicitVisit(UserRemoteServiceBindingOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00011F47 File Offset: 0x00010147
		public virtual void Visit(CreateRemoteServiceBindingStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00011F58 File Offset: 0x00010158
		public virtual void ExplicitVisit(CreateRemoteServiceBindingStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00011F85 File Offset: 0x00010185
		public virtual void Visit(AlterRemoteServiceBindingStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00011F96 File Offset: 0x00010196
		public virtual void ExplicitVisit(AlterRemoteServiceBindingStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00011FC3 File Offset: 0x000101C3
		public virtual void Visit(EncryptionSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00011FD4 File Offset: 0x000101D4
		public virtual void ExplicitVisit(EncryptionSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00011FF3 File Offset: 0x000101F3
		public virtual void Visit(AssemblyEncryptionSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00012004 File Offset: 0x00010204
		public virtual void ExplicitVisit(AssemblyEncryptionSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001202A File Offset: 0x0001022A
		public virtual void Visit(FileEncryptionSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001203B File Offset: 0x0001023B
		public virtual void ExplicitVisit(FileEncryptionSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00012061 File Offset: 0x00010261
		public virtual void Visit(ProviderEncryptionSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00012072 File Offset: 0x00010272
		public virtual void ExplicitVisit(ProviderEncryptionSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00012098 File Offset: 0x00010298
		public virtual void Visit(CertificateStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000120A9 File Offset: 0x000102A9
		public virtual void ExplicitVisit(CertificateStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000120CF File Offset: 0x000102CF
		public virtual void Visit(AlterCertificateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000120E0 File Offset: 0x000102E0
		public virtual void ExplicitVisit(AlterCertificateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001210D File Offset: 0x0001030D
		public virtual void Visit(CreateCertificateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001211E File Offset: 0x0001031E
		public virtual void ExplicitVisit(CreateCertificateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001214B File Offset: 0x0001034B
		public virtual void Visit(CertificateOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001215C File Offset: 0x0001035C
		public virtual void ExplicitVisit(CertificateOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001217B File Offset: 0x0001037B
		public virtual void Visit(CreateContractStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001218C File Offset: 0x0001038C
		public virtual void ExplicitVisit(CreateContractStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000121B2 File Offset: 0x000103B2
		public virtual void Visit(ContractMessage node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000121C3 File Offset: 0x000103C3
		public virtual void ExplicitVisit(ContractMessage node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000121E2 File Offset: 0x000103E2
		public virtual void Visit(CredentialStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000121F3 File Offset: 0x000103F3
		public virtual void ExplicitVisit(CredentialStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00012219 File Offset: 0x00010419
		public virtual void Visit(CreateCredentialStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001222A File Offset: 0x0001042A
		public virtual void ExplicitVisit(CreateCredentialStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00012257 File Offset: 0x00010457
		public virtual void Visit(AlterCredentialStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00012268 File Offset: 0x00010468
		public virtual void ExplicitVisit(AlterCredentialStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00012295 File Offset: 0x00010495
		public virtual void Visit(MessageTypeStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000122A6 File Offset: 0x000104A6
		public virtual void ExplicitVisit(MessageTypeStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000122CC File Offset: 0x000104CC
		public virtual void Visit(CreateMessageTypeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000122DD File Offset: 0x000104DD
		public virtual void ExplicitVisit(CreateMessageTypeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001230A File Offset: 0x0001050A
		public virtual void Visit(AlterMessageTypeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001231B File Offset: 0x0001051B
		public virtual void ExplicitVisit(AlterMessageTypeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00012348 File Offset: 0x00010548
		public virtual void Visit(CreateAggregateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00012359 File Offset: 0x00010559
		public virtual void ExplicitVisit(CreateAggregateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001237F File Offset: 0x0001057F
		public virtual void Visit(CreateEndpointStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00012390 File Offset: 0x00010590
		public virtual void ExplicitVisit(CreateEndpointStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000123BD File Offset: 0x000105BD
		public virtual void Visit(AlterEndpointStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000123CE File Offset: 0x000105CE
		public virtual void ExplicitVisit(AlterEndpointStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000123FB File Offset: 0x000105FB
		public virtual void Visit(AlterCreateEndpointStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001240C File Offset: 0x0001060C
		public virtual void ExplicitVisit(AlterCreateEndpointStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00012432 File Offset: 0x00010632
		public virtual void Visit(EndpointAffinity node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00012443 File Offset: 0x00010643
		public virtual void ExplicitVisit(EndpointAffinity node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00012462 File Offset: 0x00010662
		public virtual void Visit(EndpointProtocolOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00012473 File Offset: 0x00010673
		public virtual void ExplicitVisit(EndpointProtocolOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00012492 File Offset: 0x00010692
		public virtual void Visit(LiteralEndpointProtocolOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000124A3 File Offset: 0x000106A3
		public virtual void ExplicitVisit(LiteralEndpointProtocolOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000124C9 File Offset: 0x000106C9
		public virtual void Visit(AuthenticationEndpointProtocolOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000124DA File Offset: 0x000106DA
		public virtual void ExplicitVisit(AuthenticationEndpointProtocolOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00012500 File Offset: 0x00010700
		public virtual void Visit(PortsEndpointProtocolOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00012511 File Offset: 0x00010711
		public virtual void ExplicitVisit(PortsEndpointProtocolOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00012537 File Offset: 0x00010737
		public virtual void Visit(CompressionEndpointProtocolOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00012548 File Offset: 0x00010748
		public virtual void ExplicitVisit(CompressionEndpointProtocolOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001256E File Offset: 0x0001076E
		public virtual void Visit(ListenerIPEndpointProtocolOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001257F File Offset: 0x0001077F
		public virtual void ExplicitVisit(ListenerIPEndpointProtocolOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000125A5 File Offset: 0x000107A5
		public virtual void Visit(IPv4 node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000125B6 File Offset: 0x000107B6
		public virtual void ExplicitVisit(IPv4 node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000125D5 File Offset: 0x000107D5
		public virtual void Visit(SoapMethod node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000125E6 File Offset: 0x000107E6
		public virtual void ExplicitVisit(SoapMethod node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001260C File Offset: 0x0001080C
		public virtual void Visit(PayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001261D File Offset: 0x0001081D
		public virtual void ExplicitVisit(PayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001263C File Offset: 0x0001083C
		public virtual void Visit(EnabledDisabledPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0001264D File Offset: 0x0001084D
		public virtual void ExplicitVisit(EnabledDisabledPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00012673 File Offset: 0x00010873
		public virtual void Visit(WsdlPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00012684 File Offset: 0x00010884
		public virtual void ExplicitVisit(WsdlPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000126AA File Offset: 0x000108AA
		public virtual void Visit(LoginTypePayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000126BB File Offset: 0x000108BB
		public virtual void ExplicitVisit(LoginTypePayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000126E1 File Offset: 0x000108E1
		public virtual void Visit(LiteralPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000126F2 File Offset: 0x000108F2
		public virtual void ExplicitVisit(LiteralPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00012718 File Offset: 0x00010918
		public virtual void Visit(SessionTimeoutPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00012729 File Offset: 0x00010929
		public virtual void ExplicitVisit(SessionTimeoutPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001274F File Offset: 0x0001094F
		public virtual void Visit(SchemaPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00012760 File Offset: 0x00010960
		public virtual void ExplicitVisit(SchemaPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00012786 File Offset: 0x00010986
		public virtual void Visit(CharacterSetPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00012797 File Offset: 0x00010997
		public virtual void ExplicitVisit(CharacterSetPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000127BD File Offset: 0x000109BD
		public virtual void Visit(RolePayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000127CE File Offset: 0x000109CE
		public virtual void ExplicitVisit(RolePayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000127F4 File Offset: 0x000109F4
		public virtual void Visit(AuthenticationPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00012805 File Offset: 0x00010A05
		public virtual void ExplicitVisit(AuthenticationPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001282B File Offset: 0x00010A2B
		public virtual void Visit(EncryptionPayloadOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001283C File Offset: 0x00010A3C
		public virtual void ExplicitVisit(EncryptionPayloadOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00012862 File Offset: 0x00010A62
		public virtual void Visit(SymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00012873 File Offset: 0x00010A73
		public virtual void ExplicitVisit(SymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00012899 File Offset: 0x00010A99
		public virtual void Visit(CreateSymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000128AA File Offset: 0x00010AAA
		public virtual void ExplicitVisit(CreateSymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000128D7 File Offset: 0x00010AD7
		public virtual void Visit(KeyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000128E8 File Offset: 0x00010AE8
		public virtual void ExplicitVisit(KeyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00012907 File Offset: 0x00010B07
		public virtual void Visit(KeySourceKeyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00012918 File Offset: 0x00010B18
		public virtual void ExplicitVisit(KeySourceKeyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001293E File Offset: 0x00010B3E
		public virtual void Visit(AlgorithmKeyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001294F File Offset: 0x00010B4F
		public virtual void ExplicitVisit(AlgorithmKeyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00012975 File Offset: 0x00010B75
		public virtual void Visit(IdentityValueKeyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00012986 File Offset: 0x00010B86
		public virtual void ExplicitVisit(IdentityValueKeyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000129AC File Offset: 0x00010BAC
		public virtual void Visit(ProviderKeyNameKeyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000129BD File Offset: 0x00010BBD
		public virtual void ExplicitVisit(ProviderKeyNameKeyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000129E3 File Offset: 0x00010BE3
		public virtual void Visit(CreationDispositionKeyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000129F4 File Offset: 0x00010BF4
		public virtual void ExplicitVisit(CreationDispositionKeyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00012A1A File Offset: 0x00010C1A
		public virtual void Visit(AlterSymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00012A2B File Offset: 0x00010C2B
		public virtual void ExplicitVisit(AlterSymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00012A58 File Offset: 0x00010C58
		public virtual void Visit(FullTextCatalogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00012A69 File Offset: 0x00010C69
		public virtual void ExplicitVisit(FullTextCatalogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00012A8F File Offset: 0x00010C8F
		public virtual void Visit(FullTextCatalogOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00012AA0 File Offset: 0x00010CA0
		public virtual void ExplicitVisit(FullTextCatalogOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00012ABF File Offset: 0x00010CBF
		public virtual void Visit(OnOffFullTextCatalogOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00012AD0 File Offset: 0x00010CD0
		public virtual void ExplicitVisit(OnOffFullTextCatalogOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00012AF6 File Offset: 0x00010CF6
		public virtual void Visit(CreateFullTextCatalogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00012B07 File Offset: 0x00010D07
		public virtual void ExplicitVisit(CreateFullTextCatalogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00012B34 File Offset: 0x00010D34
		public virtual void Visit(AlterFullTextCatalogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00012B45 File Offset: 0x00010D45
		public virtual void ExplicitVisit(AlterFullTextCatalogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00012B72 File Offset: 0x00010D72
		public virtual void Visit(AlterCreateServiceStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00012B83 File Offset: 0x00010D83
		public virtual void ExplicitVisit(AlterCreateServiceStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00012BA9 File Offset: 0x00010DA9
		public virtual void Visit(CreateServiceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00012BBA File Offset: 0x00010DBA
		public virtual void ExplicitVisit(CreateServiceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00012BE7 File Offset: 0x00010DE7
		public virtual void Visit(AlterServiceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00012BF8 File Offset: 0x00010DF8
		public virtual void ExplicitVisit(AlterServiceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00012C25 File Offset: 0x00010E25
		public virtual void Visit(ServiceContract node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00012C36 File Offset: 0x00010E36
		public virtual void ExplicitVisit(ServiceContract node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00012C55 File Offset: 0x00010E55
		public virtual void Visit(BinaryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00012C66 File Offset: 0x00010E66
		public virtual void ExplicitVisit(BinaryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00012C8C File Offset: 0x00010E8C
		public virtual void Visit(BuiltInFunctionTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00012C9D File Offset: 0x00010E9D
		public virtual void ExplicitVisit(BuiltInFunctionTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00012CCA File Offset: 0x00010ECA
		public virtual void Visit(ComputeClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00012CDB File Offset: 0x00010EDB
		public virtual void ExplicitVisit(ComputeClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00012CFA File Offset: 0x00010EFA
		public virtual void Visit(ComputeFunction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00012D0B File Offset: 0x00010F0B
		public virtual void ExplicitVisit(ComputeFunction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00012D2A File Offset: 0x00010F2A
		public virtual void Visit(PivotedTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00012D3B File Offset: 0x00010F3B
		public virtual void ExplicitVisit(PivotedTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00012D68 File Offset: 0x00010F68
		public virtual void Visit(UnpivotedTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00012D79 File Offset: 0x00010F79
		public virtual void ExplicitVisit(UnpivotedTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00012DA6 File Offset: 0x00010FA6
		public virtual void Visit(UnqualifiedJoin node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00012DB7 File Offset: 0x00010FB7
		public virtual void ExplicitVisit(UnqualifiedJoin node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00012DE4 File Offset: 0x00010FE4
		public virtual void Visit(TableSampleClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00012DF5 File Offset: 0x00010FF5
		public virtual void ExplicitVisit(TableSampleClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00012E14 File Offset: 0x00011014
		public virtual void Visit(ScalarExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00012E25 File Offset: 0x00011025
		public virtual void ExplicitVisit(ScalarExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00012E44 File Offset: 0x00011044
		public virtual void Visit(BooleanExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00012E55 File Offset: 0x00011055
		public virtual void ExplicitVisit(BooleanExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00012E74 File Offset: 0x00011074
		public virtual void Visit(BooleanNotExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00012E85 File Offset: 0x00011085
		public virtual void ExplicitVisit(BooleanNotExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00012EAB File Offset: 0x000110AB
		public virtual void Visit(BooleanParenthesisExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00012EBC File Offset: 0x000110BC
		public virtual void ExplicitVisit(BooleanParenthesisExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00012EE2 File Offset: 0x000110E2
		public virtual void Visit(BooleanComparisonExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00012EF3 File Offset: 0x000110F3
		public virtual void ExplicitVisit(BooleanComparisonExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00012F19 File Offset: 0x00011119
		public virtual void Visit(BooleanBinaryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00012F2A File Offset: 0x0001112A
		public virtual void ExplicitVisit(BooleanBinaryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00012F50 File Offset: 0x00011150
		public virtual void Visit(BooleanIsNullExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00012F61 File Offset: 0x00011161
		public virtual void ExplicitVisit(BooleanIsNullExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00012F87 File Offset: 0x00011187
		public virtual void Visit(ExpressionWithSortOrder node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00012F98 File Offset: 0x00011198
		public virtual void ExplicitVisit(ExpressionWithSortOrder node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00012FB7 File Offset: 0x000111B7
		public virtual void Visit(GroupByClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00012FC8 File Offset: 0x000111C8
		public virtual void ExplicitVisit(GroupByClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00012FE7 File Offset: 0x000111E7
		public virtual void Visit(GroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00012FF8 File Offset: 0x000111F8
		public virtual void ExplicitVisit(GroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00013017 File Offset: 0x00011217
		public virtual void Visit(ExpressionGroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00013028 File Offset: 0x00011228
		public virtual void ExplicitVisit(ExpressionGroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001304E File Offset: 0x0001124E
		public virtual void Visit(CompositeGroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001305F File Offset: 0x0001125F
		public virtual void ExplicitVisit(CompositeGroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00013085 File Offset: 0x00011285
		public virtual void Visit(CubeGroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00013096 File Offset: 0x00011296
		public virtual void ExplicitVisit(CubeGroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000130BC File Offset: 0x000112BC
		public virtual void Visit(RollupGroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000130CD File Offset: 0x000112CD
		public virtual void ExplicitVisit(RollupGroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000130F3 File Offset: 0x000112F3
		public virtual void Visit(GrandTotalGroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00013104 File Offset: 0x00011304
		public virtual void ExplicitVisit(GrandTotalGroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0001312A File Offset: 0x0001132A
		public virtual void Visit(GroupingSetsGroupingSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001313B File Offset: 0x0001133B
		public virtual void ExplicitVisit(GroupingSetsGroupingSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00013161 File Offset: 0x00011361
		public virtual void Visit(OutputClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00013172 File Offset: 0x00011372
		public virtual void ExplicitVisit(OutputClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00013191 File Offset: 0x00011391
		public virtual void Visit(OutputIntoClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000131A2 File Offset: 0x000113A2
		public virtual void ExplicitVisit(OutputIntoClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000131C1 File Offset: 0x000113C1
		public virtual void Visit(HavingClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000131D2 File Offset: 0x000113D2
		public virtual void ExplicitVisit(HavingClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000131F1 File Offset: 0x000113F1
		public virtual void Visit(IdentityFunctionCall node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00013202 File Offset: 0x00011402
		public virtual void ExplicitVisit(IdentityFunctionCall node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00013228 File Offset: 0x00011428
		public virtual void Visit(JoinParenthesisTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00013239 File Offset: 0x00011439
		public virtual void ExplicitVisit(JoinParenthesisTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0001325F File Offset: 0x0001145F
		public virtual void Visit(OrderByClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00013270 File Offset: 0x00011470
		public virtual void ExplicitVisit(OrderByClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001328F File Offset: 0x0001148F
		public virtual void Visit(JoinTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000132A0 File Offset: 0x000114A0
		public virtual void ExplicitVisit(JoinTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000132C6 File Offset: 0x000114C6
		public virtual void Visit(QualifiedJoin node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000132D7 File Offset: 0x000114D7
		public virtual void ExplicitVisit(QualifiedJoin node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00013304 File Offset: 0x00011504
		public virtual void Visit(OdbcQualifiedJoinTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00013315 File Offset: 0x00011515
		public virtual void ExplicitVisit(OdbcQualifiedJoinTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0001333B File Offset: 0x0001153B
		public virtual void Visit(QueryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0001334C File Offset: 0x0001154C
		public virtual void ExplicitVisit(QueryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0001336B File Offset: 0x0001156B
		public virtual void Visit(QueryParenthesisExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0001337C File Offset: 0x0001157C
		public virtual void ExplicitVisit(QueryParenthesisExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000133A2 File Offset: 0x000115A2
		public virtual void Visit(QuerySpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000133B3 File Offset: 0x000115B3
		public virtual void ExplicitVisit(QuerySpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000133D9 File Offset: 0x000115D9
		public virtual void Visit(FromClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000133EA File Offset: 0x000115EA
		public virtual void ExplicitVisit(FromClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00013409 File Offset: 0x00011609
		public virtual void Visit(SelectElement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0001341A File Offset: 0x0001161A
		public virtual void ExplicitVisit(SelectElement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00013439 File Offset: 0x00011639
		public virtual void Visit(SelectScalarExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0001344A File Offset: 0x0001164A
		public virtual void ExplicitVisit(SelectScalarExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00013470 File Offset: 0x00011670
		public virtual void Visit(SelectStarExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00013481 File Offset: 0x00011681
		public virtual void ExplicitVisit(SelectStarExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000134A7 File Offset: 0x000116A7
		public virtual void Visit(SelectSetVariable node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000134B8 File Offset: 0x000116B8
		public virtual void ExplicitVisit(SelectSetVariable node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000134DE File Offset: 0x000116DE
		public virtual void Visit(TableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000134EF File Offset: 0x000116EF
		public virtual void ExplicitVisit(TableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001350E File Offset: 0x0001170E
		public virtual void Visit(TableReferenceWithAlias node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001351F File Offset: 0x0001171F
		public virtual void ExplicitVisit(TableReferenceWithAlias node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00013545 File Offset: 0x00011745
		public virtual void Visit(TableReferenceWithAliasAndColumns node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00013556 File Offset: 0x00011756
		public virtual void ExplicitVisit(TableReferenceWithAliasAndColumns node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00013583 File Offset: 0x00011783
		public virtual void Visit(DataModificationTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00013594 File Offset: 0x00011794
		public virtual void ExplicitVisit(DataModificationTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000135C8 File Offset: 0x000117C8
		public virtual void Visit(ChangeTableChangesTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000135D9 File Offset: 0x000117D9
		public virtual void ExplicitVisit(ChangeTableChangesTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0001360D File Offset: 0x0001180D
		public virtual void Visit(ChangeTableVersionTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0001361E File Offset: 0x0001181E
		public virtual void ExplicitVisit(ChangeTableVersionTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00013652 File Offset: 0x00011852
		public virtual void Visit(BooleanTernaryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00013663 File Offset: 0x00011863
		public virtual void ExplicitVisit(BooleanTernaryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00013689 File Offset: 0x00011889
		public virtual void Visit(TopRowFilter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0001369A File Offset: 0x0001189A
		public virtual void ExplicitVisit(TopRowFilter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000136B9 File Offset: 0x000118B9
		public virtual void Visit(OffsetClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000136CA File Offset: 0x000118CA
		public virtual void ExplicitVisit(OffsetClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000136E9 File Offset: 0x000118E9
		public virtual void Visit(UnaryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000136FA File Offset: 0x000118FA
		public virtual void ExplicitVisit(UnaryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00013720 File Offset: 0x00011920
		public virtual void Visit(BinaryQueryExpression node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00013731 File Offset: 0x00011931
		public virtual void ExplicitVisit(BinaryQueryExpression node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00013757 File Offset: 0x00011957
		public virtual void Visit(VariableTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00013768 File Offset: 0x00011968
		public virtual void ExplicitVisit(VariableTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00013795 File Offset: 0x00011995
		public virtual void Visit(VariableMethodCallTableReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000137A6 File Offset: 0x000119A6
		public virtual void ExplicitVisit(VariableMethodCallTableReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000137DA File Offset: 0x000119DA
		public virtual void Visit(DropPartitionFunctionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000137EB File Offset: 0x000119EB
		public virtual void ExplicitVisit(DropPartitionFunctionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00013818 File Offset: 0x00011A18
		public virtual void Visit(DropPartitionSchemeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00013829 File Offset: 0x00011A29
		public virtual void ExplicitVisit(DropPartitionSchemeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00013856 File Offset: 0x00011A56
		public virtual void Visit(DropSynonymStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00013867 File Offset: 0x00011A67
		public virtual void ExplicitVisit(DropSynonymStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00013894 File Offset: 0x00011A94
		public virtual void Visit(DropAggregateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000138A5 File Offset: 0x00011AA5
		public virtual void ExplicitVisit(DropAggregateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000138D2 File Offset: 0x00011AD2
		public virtual void Visit(DropAssemblyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000138E3 File Offset: 0x00011AE3
		public virtual void ExplicitVisit(DropAssemblyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00013910 File Offset: 0x00011B10
		public virtual void Visit(DropApplicationRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00013921 File Offset: 0x00011B21
		public virtual void ExplicitVisit(DropApplicationRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0001394E File Offset: 0x00011B4E
		public virtual void Visit(DropFullTextCatalogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0001395F File Offset: 0x00011B5F
		public virtual void ExplicitVisit(DropFullTextCatalogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0001398C File Offset: 0x00011B8C
		public virtual void Visit(DropFullTextIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0001399D File Offset: 0x00011B9D
		public virtual void ExplicitVisit(DropFullTextIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000139C3 File Offset: 0x00011BC3
		public virtual void Visit(DropLoginStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000139D4 File Offset: 0x00011BD4
		public virtual void ExplicitVisit(DropLoginStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00013A01 File Offset: 0x00011C01
		public virtual void Visit(DropRoleStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00013A12 File Offset: 0x00011C12
		public virtual void ExplicitVisit(DropRoleStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00013A3F File Offset: 0x00011C3F
		public virtual void Visit(DropTypeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00013A50 File Offset: 0x00011C50
		public virtual void ExplicitVisit(DropTypeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00013A76 File Offset: 0x00011C76
		public virtual void Visit(DropUserStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00013A87 File Offset: 0x00011C87
		public virtual void ExplicitVisit(DropUserStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00013AB4 File Offset: 0x00011CB4
		public virtual void Visit(DropMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00013AC5 File Offset: 0x00011CC5
		public virtual void ExplicitVisit(DropMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00013AEB File Offset: 0x00011CEB
		public virtual void Visit(DropSymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00013AFC File Offset: 0x00011CFC
		public virtual void ExplicitVisit(DropSymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00013B29 File Offset: 0x00011D29
		public virtual void Visit(DropAsymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00013B3A File Offset: 0x00011D3A
		public virtual void ExplicitVisit(DropAsymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00013B67 File Offset: 0x00011D67
		public virtual void Visit(DropCertificateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00013B78 File Offset: 0x00011D78
		public virtual void ExplicitVisit(DropCertificateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00013BA5 File Offset: 0x00011DA5
		public virtual void Visit(DropCredentialStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00013BB6 File Offset: 0x00011DB6
		public virtual void ExplicitVisit(DropCredentialStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00013BE3 File Offset: 0x00011DE3
		public virtual void Visit(AlterPartitionFunctionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00013BF4 File Offset: 0x00011DF4
		public virtual void ExplicitVisit(AlterPartitionFunctionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00013C1A File Offset: 0x00011E1A
		public virtual void Visit(AlterPartitionSchemeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00013C2B File Offset: 0x00011E2B
		public virtual void ExplicitVisit(AlterPartitionSchemeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00013C51 File Offset: 0x00011E51
		public virtual void Visit(AlterFullTextIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00013C62 File Offset: 0x00011E62
		public virtual void ExplicitVisit(AlterFullTextIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00013C88 File Offset: 0x00011E88
		public virtual void Visit(AlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00013C99 File Offset: 0x00011E99
		public virtual void ExplicitVisit(AlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00013CB8 File Offset: 0x00011EB8
		public virtual void Visit(SimpleAlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00013CC9 File Offset: 0x00011EC9
		public virtual void ExplicitVisit(SimpleAlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00013CEF File Offset: 0x00011EEF
		public virtual void Visit(SetStopListAlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00013D00 File Offset: 0x00011F00
		public virtual void ExplicitVisit(SetStopListAlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00013D26 File Offset: 0x00011F26
		public virtual void Visit(SetSearchPropertyListAlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00013D37 File Offset: 0x00011F37
		public virtual void ExplicitVisit(SetSearchPropertyListAlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00013D5D File Offset: 0x00011F5D
		public virtual void Visit(DropAlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00013D6E File Offset: 0x00011F6E
		public virtual void ExplicitVisit(DropAlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00013D94 File Offset: 0x00011F94
		public virtual void Visit(AddAlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00013DA5 File Offset: 0x00011FA5
		public virtual void ExplicitVisit(AddAlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00013DCB File Offset: 0x00011FCB
		public virtual void Visit(AlterColumnAlterFullTextIndexAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00013DDC File Offset: 0x00011FDC
		public virtual void ExplicitVisit(AlterColumnAlterFullTextIndexAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00013E02 File Offset: 0x00012002
		public virtual void Visit(CreateSearchPropertyListStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00013E13 File Offset: 0x00012013
		public virtual void ExplicitVisit(CreateSearchPropertyListStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00013E39 File Offset: 0x00012039
		public virtual void Visit(AlterSearchPropertyListStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00013E4A File Offset: 0x0001204A
		public virtual void ExplicitVisit(AlterSearchPropertyListStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00013E70 File Offset: 0x00012070
		public virtual void Visit(SearchPropertyListAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00013E81 File Offset: 0x00012081
		public virtual void ExplicitVisit(SearchPropertyListAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00013EA0 File Offset: 0x000120A0
		public virtual void Visit(AddSearchPropertyListAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00013EB1 File Offset: 0x000120B1
		public virtual void ExplicitVisit(AddSearchPropertyListAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00013ED7 File Offset: 0x000120D7
		public virtual void Visit(DropSearchPropertyListAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00013EE8 File Offset: 0x000120E8
		public virtual void ExplicitVisit(DropSearchPropertyListAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00013F0E File Offset: 0x0001210E
		public virtual void Visit(DropSearchPropertyListStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00013F1F File Offset: 0x0001211F
		public virtual void ExplicitVisit(DropSearchPropertyListStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00013F4C File Offset: 0x0001214C
		public virtual void Visit(CreateLoginStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00013F5D File Offset: 0x0001215D
		public virtual void ExplicitVisit(CreateLoginStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00013F83 File Offset: 0x00012183
		public virtual void Visit(CreateLoginSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00013F94 File Offset: 0x00012194
		public virtual void ExplicitVisit(CreateLoginSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00013FB3 File Offset: 0x000121B3
		public virtual void Visit(PasswordCreateLoginSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00013FC4 File Offset: 0x000121C4
		public virtual void ExplicitVisit(PasswordCreateLoginSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00013FEA File Offset: 0x000121EA
		public virtual void Visit(PrincipalOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00013FFB File Offset: 0x000121FB
		public virtual void ExplicitVisit(PrincipalOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0001401A File Offset: 0x0001221A
		public virtual void Visit(OnOffPrincipalOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001402B File Offset: 0x0001222B
		public virtual void ExplicitVisit(OnOffPrincipalOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00014051 File Offset: 0x00012251
		public virtual void Visit(LiteralPrincipalOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00014062 File Offset: 0x00012262
		public virtual void ExplicitVisit(LiteralPrincipalOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00014088 File Offset: 0x00012288
		public virtual void Visit(IdentifierPrincipalOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00014099 File Offset: 0x00012299
		public virtual void ExplicitVisit(IdentifierPrincipalOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000140BF File Offset: 0x000122BF
		public virtual void Visit(WindowsCreateLoginSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000140D0 File Offset: 0x000122D0
		public virtual void ExplicitVisit(WindowsCreateLoginSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000140F6 File Offset: 0x000122F6
		public virtual void Visit(CertificateCreateLoginSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00014107 File Offset: 0x00012307
		public virtual void ExplicitVisit(CertificateCreateLoginSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0001412D File Offset: 0x0001232D
		public virtual void Visit(AsymmetricKeyCreateLoginSource node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0001413E File Offset: 0x0001233E
		public virtual void ExplicitVisit(AsymmetricKeyCreateLoginSource node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00014164 File Offset: 0x00012364
		public virtual void Visit(PasswordAlterPrincipalOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00014175 File Offset: 0x00012375
		public virtual void ExplicitVisit(PasswordAlterPrincipalOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001419B File Offset: 0x0001239B
		public virtual void Visit(AlterLoginStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000141AC File Offset: 0x000123AC
		public virtual void ExplicitVisit(AlterLoginStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000141D2 File Offset: 0x000123D2
		public virtual void Visit(AlterLoginOptionsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000141E3 File Offset: 0x000123E3
		public virtual void ExplicitVisit(AlterLoginOptionsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00014210 File Offset: 0x00012410
		public virtual void Visit(AlterLoginEnableDisableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00014221 File Offset: 0x00012421
		public virtual void ExplicitVisit(AlterLoginEnableDisableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0001424E File Offset: 0x0001244E
		public virtual void Visit(AlterLoginAddDropCredentialStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0001425F File Offset: 0x0001245F
		public virtual void ExplicitVisit(AlterLoginAddDropCredentialStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0001428C File Offset: 0x0001248C
		public virtual void Visit(RevertStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0001429D File Offset: 0x0001249D
		public virtual void ExplicitVisit(RevertStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000142C3 File Offset: 0x000124C3
		public virtual void Visit(DropContractStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000142D4 File Offset: 0x000124D4
		public virtual void ExplicitVisit(DropContractStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00014301 File Offset: 0x00012501
		public virtual void Visit(DropEndpointStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00014312 File Offset: 0x00012512
		public virtual void ExplicitVisit(DropEndpointStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0001433F File Offset: 0x0001253F
		public virtual void Visit(DropMessageTypeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00014350 File Offset: 0x00012550
		public virtual void ExplicitVisit(DropMessageTypeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0001437D File Offset: 0x0001257D
		public virtual void Visit(DropQueueStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0001438E File Offset: 0x0001258E
		public virtual void ExplicitVisit(DropQueueStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000143B4 File Offset: 0x000125B4
		public virtual void Visit(DropRemoteServiceBindingStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000143C5 File Offset: 0x000125C5
		public virtual void ExplicitVisit(DropRemoteServiceBindingStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000143F2 File Offset: 0x000125F2
		public virtual void Visit(DropRouteStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00014403 File Offset: 0x00012603
		public virtual void ExplicitVisit(DropRouteStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00014430 File Offset: 0x00012630
		public virtual void Visit(DropServiceStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00014441 File Offset: 0x00012641
		public virtual void ExplicitVisit(DropServiceStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0001446E File Offset: 0x0001266E
		public virtual void Visit(SignatureStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0001447F File Offset: 0x0001267F
		public virtual void ExplicitVisit(SignatureStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000144A5 File Offset: 0x000126A5
		public virtual void Visit(AddSignatureStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000144B6 File Offset: 0x000126B6
		public virtual void ExplicitVisit(AddSignatureStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000144E3 File Offset: 0x000126E3
		public virtual void Visit(DropSignatureStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000144F4 File Offset: 0x000126F4
		public virtual void ExplicitVisit(DropSignatureStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00014521 File Offset: 0x00012721
		public virtual void Visit(DropEventNotificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00014532 File Offset: 0x00012732
		public virtual void ExplicitVisit(DropEventNotificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00014558 File Offset: 0x00012758
		public virtual void Visit(ExecuteAsStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00014569 File Offset: 0x00012769
		public virtual void ExplicitVisit(ExecuteAsStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001458F File Offset: 0x0001278F
		public virtual void Visit(EndConversationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000145A0 File Offset: 0x000127A0
		public virtual void ExplicitVisit(EndConversationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000145C6 File Offset: 0x000127C6
		public virtual void Visit(MoveConversationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000145D7 File Offset: 0x000127D7
		public virtual void ExplicitVisit(MoveConversationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000145FD File Offset: 0x000127FD
		public virtual void Visit(GetConversationGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001460E File Offset: 0x0001280E
		public virtual void ExplicitVisit(GetConversationGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001463B File Offset: 0x0001283B
		public virtual void Visit(ReceiveStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001464C File Offset: 0x0001284C
		public virtual void ExplicitVisit(ReceiveStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00014679 File Offset: 0x00012879
		public virtual void Visit(SendStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001468A File Offset: 0x0001288A
		public virtual void ExplicitVisit(SendStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000146B0 File Offset: 0x000128B0
		public virtual void Visit(WaitForSupportedStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000146C1 File Offset: 0x000128C1
		public virtual void ExplicitVisit(WaitForSupportedStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000146E7 File Offset: 0x000128E7
		public virtual void Visit(AlterSchemaStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000146F8 File Offset: 0x000128F8
		public virtual void ExplicitVisit(AlterSchemaStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001471E File Offset: 0x0001291E
		public virtual void Visit(AlterAsymmetricKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001472F File Offset: 0x0001292F
		public virtual void ExplicitVisit(AlterAsymmetricKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00014755 File Offset: 0x00012955
		public virtual void Visit(AlterServiceMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00014766 File Offset: 0x00012966
		public virtual void ExplicitVisit(AlterServiceMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0001478C File Offset: 0x0001298C
		public virtual void Visit(BeginConversationTimerStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001479D File Offset: 0x0001299D
		public virtual void ExplicitVisit(BeginConversationTimerStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000147C3 File Offset: 0x000129C3
		public virtual void Visit(BeginDialogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000147D4 File Offset: 0x000129D4
		public virtual void ExplicitVisit(BeginDialogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000147FA File Offset: 0x000129FA
		public virtual void Visit(DialogOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0001480B File Offset: 0x00012A0B
		public virtual void ExplicitVisit(DialogOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001482A File Offset: 0x00012A2A
		public virtual void Visit(ScalarExpressionDialogOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001483B File Offset: 0x00012A3B
		public virtual void ExplicitVisit(ScalarExpressionDialogOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00014861 File Offset: 0x00012A61
		public virtual void Visit(OnOffDialogOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00014872 File Offset: 0x00012A72
		public virtual void ExplicitVisit(OnOffDialogOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00014898 File Offset: 0x00012A98
		public virtual void Visit(BackupCertificateStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000148A9 File Offset: 0x00012AA9
		public virtual void ExplicitVisit(BackupCertificateStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000148D6 File Offset: 0x00012AD6
		public virtual void Visit(BackupRestoreMasterKeyStatementBase node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000148E7 File Offset: 0x00012AE7
		public virtual void ExplicitVisit(BackupRestoreMasterKeyStatementBase node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0001490D File Offset: 0x00012B0D
		public virtual void Visit(BackupServiceMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0001491E File Offset: 0x00012B1E
		public virtual void ExplicitVisit(BackupServiceMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0001494B File Offset: 0x00012B4B
		public virtual void Visit(RestoreServiceMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0001495C File Offset: 0x00012B5C
		public virtual void ExplicitVisit(RestoreServiceMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00014989 File Offset: 0x00012B89
		public virtual void Visit(BackupMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001499A File Offset: 0x00012B9A
		public virtual void ExplicitVisit(BackupMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000149C7 File Offset: 0x00012BC7
		public virtual void Visit(RestoreMasterKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000149D8 File Offset: 0x00012BD8
		public virtual void ExplicitVisit(RestoreMasterKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00014A05 File Offset: 0x00012C05
		public virtual void Visit(ScalarExpressionSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00014A16 File Offset: 0x00012C16
		public virtual void ExplicitVisit(ScalarExpressionSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00014A3C File Offset: 0x00012C3C
		public virtual void Visit(BooleanExpressionSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00014A4D File Offset: 0x00012C4D
		public virtual void ExplicitVisit(BooleanExpressionSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00014A73 File Offset: 0x00012C73
		public virtual void Visit(StatementListSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00014A84 File Offset: 0x00012C84
		public virtual void ExplicitVisit(StatementListSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00014AAA File Offset: 0x00012CAA
		public virtual void Visit(SelectStatementSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00014ABB File Offset: 0x00012CBB
		public virtual void ExplicitVisit(SelectStatementSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00014AEF File Offset: 0x00012CEF
		public virtual void Visit(SchemaObjectNameSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00014B00 File Offset: 0x00012D00
		public virtual void ExplicitVisit(SchemaObjectNameSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00014B2D File Offset: 0x00012D2D
		public virtual void Visit(TSqlFragmentSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00014B3E File Offset: 0x00012D3E
		public virtual void ExplicitVisit(TSqlFragmentSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00014B5D File Offset: 0x00012D5D
		public virtual void Visit(TSqlStatementSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00014B6E File Offset: 0x00012D6E
		public virtual void ExplicitVisit(TSqlStatementSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00014B94 File Offset: 0x00012D94
		public virtual void Visit(IdentifierSnippet node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00014BA5 File Offset: 0x00012DA5
		public virtual void ExplicitVisit(IdentifierSnippet node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00014BCB File Offset: 0x00012DCB
		public virtual void Visit(TSqlScript node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00014BDC File Offset: 0x00012DDC
		public virtual void ExplicitVisit(TSqlScript node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00014BFB File Offset: 0x00012DFB
		public virtual void Visit(TSqlBatch node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00014C0C File Offset: 0x00012E0C
		public virtual void ExplicitVisit(TSqlBatch node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00014C2B File Offset: 0x00012E2B
		public virtual void Visit(TSqlStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00014C3C File Offset: 0x00012E3C
		public virtual void ExplicitVisit(TSqlStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00014C5B File Offset: 0x00012E5B
		public virtual void Visit(DataModificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00014C6C File Offset: 0x00012E6C
		public virtual void ExplicitVisit(DataModificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00014C99 File Offset: 0x00012E99
		public virtual void Visit(DataModificationSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00014CAA File Offset: 0x00012EAA
		public virtual void ExplicitVisit(DataModificationSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00014CC9 File Offset: 0x00012EC9
		public virtual void Visit(MergeStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00014CDA File Offset: 0x00012EDA
		public virtual void ExplicitVisit(MergeStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00014D0E File Offset: 0x00012F0E
		public virtual void Visit(MergeSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00014D1F File Offset: 0x00012F1F
		public virtual void ExplicitVisit(MergeSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00014D45 File Offset: 0x00012F45
		public virtual void Visit(MergeActionClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00014D56 File Offset: 0x00012F56
		public virtual void ExplicitVisit(MergeActionClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00014D75 File Offset: 0x00012F75
		public virtual void Visit(MergeAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00014D86 File Offset: 0x00012F86
		public virtual void ExplicitVisit(MergeAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00014DA5 File Offset: 0x00012FA5
		public virtual void Visit(UpdateMergeAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00014DB6 File Offset: 0x00012FB6
		public virtual void ExplicitVisit(UpdateMergeAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00014DDC File Offset: 0x00012FDC
		public virtual void Visit(DeleteMergeAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00014DED File Offset: 0x00012FED
		public virtual void ExplicitVisit(DeleteMergeAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00014E13 File Offset: 0x00013013
		public virtual void Visit(InsertMergeAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00014E24 File Offset: 0x00013024
		public virtual void ExplicitVisit(InsertMergeAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00014E4A File Offset: 0x0001304A
		public virtual void Visit(CreateTypeTableStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00014E5B File Offset: 0x0001305B
		public virtual void ExplicitVisit(CreateTypeTableStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00014E88 File Offset: 0x00013088
		public virtual void Visit(AuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00014E99 File Offset: 0x00013099
		public virtual void ExplicitVisit(AuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00014EBF File Offset: 0x000130BF
		public virtual void Visit(AuditSpecificationPart node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00014ED0 File Offset: 0x000130D0
		public virtual void ExplicitVisit(AuditSpecificationPart node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00014EEF File Offset: 0x000130EF
		public virtual void Visit(AuditSpecificationDetail node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00014F00 File Offset: 0x00013100
		public virtual void ExplicitVisit(AuditSpecificationDetail node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00014F1F File Offset: 0x0001311F
		public virtual void Visit(AuditActionSpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00014F30 File Offset: 0x00013130
		public virtual void ExplicitVisit(AuditActionSpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00014F56 File Offset: 0x00013156
		public virtual void Visit(DatabaseAuditAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00014F67 File Offset: 0x00013167
		public virtual void ExplicitVisit(DatabaseAuditAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00014F86 File Offset: 0x00013186
		public virtual void Visit(AuditActionGroupReference node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00014F97 File Offset: 0x00013197
		public virtual void ExplicitVisit(AuditActionGroupReference node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00014FBD File Offset: 0x000131BD
		public virtual void Visit(CreateDatabaseAuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00014FCE File Offset: 0x000131CE
		public virtual void ExplicitVisit(CreateDatabaseAuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00014FFB File Offset: 0x000131FB
		public virtual void Visit(AlterDatabaseAuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0001500C File Offset: 0x0001320C
		public virtual void ExplicitVisit(AlterDatabaseAuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00015039 File Offset: 0x00013239
		public virtual void Visit(DropDatabaseAuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0001504A File Offset: 0x0001324A
		public virtual void ExplicitVisit(DropDatabaseAuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00015077 File Offset: 0x00013277
		public virtual void Visit(CreateServerAuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00015088 File Offset: 0x00013288
		public virtual void ExplicitVisit(CreateServerAuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000150B5 File Offset: 0x000132B5
		public virtual void Visit(AlterServerAuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000150C6 File Offset: 0x000132C6
		public virtual void ExplicitVisit(AlterServerAuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000150F3 File Offset: 0x000132F3
		public virtual void Visit(DropServerAuditSpecificationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00015104 File Offset: 0x00013304
		public virtual void ExplicitVisit(DropServerAuditSpecificationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00015131 File Offset: 0x00013331
		public virtual void Visit(ServerAuditStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00015142 File Offset: 0x00013342
		public virtual void ExplicitVisit(ServerAuditStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00015168 File Offset: 0x00013368
		public virtual void Visit(CreateServerAuditStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00015179 File Offset: 0x00013379
		public virtual void ExplicitVisit(CreateServerAuditStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000151A6 File Offset: 0x000133A6
		public virtual void Visit(AlterServerAuditStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000151B7 File Offset: 0x000133B7
		public virtual void ExplicitVisit(AlterServerAuditStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000151E4 File Offset: 0x000133E4
		public virtual void Visit(DropServerAuditStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000151F5 File Offset: 0x000133F5
		public virtual void ExplicitVisit(DropServerAuditStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00015222 File Offset: 0x00013422
		public virtual void Visit(AuditTarget node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00015233 File Offset: 0x00013433
		public virtual void ExplicitVisit(AuditTarget node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00015252 File Offset: 0x00013452
		public virtual void Visit(AuditOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00015263 File Offset: 0x00013463
		public virtual void ExplicitVisit(AuditOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00015282 File Offset: 0x00013482
		public virtual void Visit(QueueDelayAuditOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00015293 File Offset: 0x00013493
		public virtual void ExplicitVisit(QueueDelayAuditOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000152B9 File Offset: 0x000134B9
		public virtual void Visit(AuditGuidAuditOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000152CA File Offset: 0x000134CA
		public virtual void ExplicitVisit(AuditGuidAuditOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000152F0 File Offset: 0x000134F0
		public virtual void Visit(OnFailureAuditOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00015301 File Offset: 0x00013501
		public virtual void ExplicitVisit(OnFailureAuditOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00015327 File Offset: 0x00013527
		public virtual void Visit(StateAuditOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00015338 File Offset: 0x00013538
		public virtual void ExplicitVisit(StateAuditOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001535E File Offset: 0x0001355E
		public virtual void Visit(AuditTargetOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001536F File Offset: 0x0001356F
		public virtual void ExplicitVisit(AuditTargetOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001538E File Offset: 0x0001358E
		public virtual void Visit(MaxSizeAuditTargetOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0001539F File Offset: 0x0001359F
		public virtual void ExplicitVisit(MaxSizeAuditTargetOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000153C5 File Offset: 0x000135C5
		public virtual void Visit(MaxRolloverFilesAuditTargetOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000153D6 File Offset: 0x000135D6
		public virtual void ExplicitVisit(MaxRolloverFilesAuditTargetOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000153FC File Offset: 0x000135FC
		public virtual void Visit(LiteralAuditTargetOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0001540D File Offset: 0x0001360D
		public virtual void ExplicitVisit(LiteralAuditTargetOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00015433 File Offset: 0x00013633
		public virtual void Visit(OnOffAuditTargetOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00015444 File Offset: 0x00013644
		public virtual void ExplicitVisit(OnOffAuditTargetOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001546A File Offset: 0x0001366A
		public virtual void Visit(DatabaseEncryptionKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001547B File Offset: 0x0001367B
		public virtual void ExplicitVisit(DatabaseEncryptionKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000154A1 File Offset: 0x000136A1
		public virtual void Visit(CreateDatabaseEncryptionKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000154B2 File Offset: 0x000136B2
		public virtual void ExplicitVisit(CreateDatabaseEncryptionKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000154DF File Offset: 0x000136DF
		public virtual void Visit(AlterDatabaseEncryptionKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000154F0 File Offset: 0x000136F0
		public virtual void ExplicitVisit(AlterDatabaseEncryptionKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001551D File Offset: 0x0001371D
		public virtual void Visit(DropDatabaseEncryptionKeyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0001552E File Offset: 0x0001372E
		public virtual void ExplicitVisit(DropDatabaseEncryptionKeyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00015554 File Offset: 0x00013754
		public virtual void Visit(ResourcePoolStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00015565 File Offset: 0x00013765
		public virtual void ExplicitVisit(ResourcePoolStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001558B File Offset: 0x0001378B
		public virtual void Visit(ResourcePoolParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0001559C File Offset: 0x0001379C
		public virtual void ExplicitVisit(ResourcePoolParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000155BB File Offset: 0x000137BB
		public virtual void Visit(ResourcePoolAffinitySpecification node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000155CC File Offset: 0x000137CC
		public virtual void ExplicitVisit(ResourcePoolAffinitySpecification node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000155EB File Offset: 0x000137EB
		public virtual void Visit(CreateResourcePoolStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000155FC File Offset: 0x000137FC
		public virtual void ExplicitVisit(CreateResourcePoolStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00015629 File Offset: 0x00013829
		public virtual void Visit(AlterResourcePoolStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0001563A File Offset: 0x0001383A
		public virtual void ExplicitVisit(AlterResourcePoolStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00015667 File Offset: 0x00013867
		public virtual void Visit(DropResourcePoolStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00015678 File Offset: 0x00013878
		public virtual void ExplicitVisit(DropResourcePoolStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000156A5 File Offset: 0x000138A5
		public virtual void Visit(WorkloadGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000156B6 File Offset: 0x000138B6
		public virtual void ExplicitVisit(WorkloadGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000156DC File Offset: 0x000138DC
		public virtual void Visit(WorkloadGroupResourceParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000156ED File Offset: 0x000138ED
		public virtual void ExplicitVisit(WorkloadGroupResourceParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00015713 File Offset: 0x00013913
		public virtual void Visit(WorkloadGroupImportanceParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00015724 File Offset: 0x00013924
		public virtual void ExplicitVisit(WorkloadGroupImportanceParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001574A File Offset: 0x0001394A
		public virtual void Visit(WorkloadGroupParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001575B File Offset: 0x0001395B
		public virtual void ExplicitVisit(WorkloadGroupParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001577A File Offset: 0x0001397A
		public virtual void Visit(CreateWorkloadGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001578B File Offset: 0x0001398B
		public virtual void ExplicitVisit(CreateWorkloadGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000157B8 File Offset: 0x000139B8
		public virtual void Visit(AlterWorkloadGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000157C9 File Offset: 0x000139C9
		public virtual void ExplicitVisit(AlterWorkloadGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000157F6 File Offset: 0x000139F6
		public virtual void Visit(DropWorkloadGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00015807 File Offset: 0x00013A07
		public virtual void ExplicitVisit(DropWorkloadGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00015834 File Offset: 0x00013A34
		public virtual void Visit(BrokerPriorityStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00015845 File Offset: 0x00013A45
		public virtual void ExplicitVisit(BrokerPriorityStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001586B File Offset: 0x00013A6B
		public virtual void Visit(BrokerPriorityParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001587C File Offset: 0x00013A7C
		public virtual void ExplicitVisit(BrokerPriorityParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001589B File Offset: 0x00013A9B
		public virtual void Visit(CreateBrokerPriorityStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000158AC File Offset: 0x00013AAC
		public virtual void ExplicitVisit(CreateBrokerPriorityStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000158D9 File Offset: 0x00013AD9
		public virtual void Visit(AlterBrokerPriorityStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000158EA File Offset: 0x00013AEA
		public virtual void ExplicitVisit(AlterBrokerPriorityStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00015917 File Offset: 0x00013B17
		public virtual void Visit(DropBrokerPriorityStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00015928 File Offset: 0x00013B28
		public virtual void ExplicitVisit(DropBrokerPriorityStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00015955 File Offset: 0x00013B55
		public virtual void Visit(CreateFullTextStopListStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00015966 File Offset: 0x00013B66
		public virtual void ExplicitVisit(CreateFullTextStopListStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001598C File Offset: 0x00013B8C
		public virtual void Visit(AlterFullTextStopListStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001599D File Offset: 0x00013B9D
		public virtual void ExplicitVisit(AlterFullTextStopListStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000159C3 File Offset: 0x00013BC3
		public virtual void Visit(FullTextStopListAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000159D4 File Offset: 0x00013BD4
		public virtual void ExplicitVisit(FullTextStopListAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000159F3 File Offset: 0x00013BF3
		public virtual void Visit(DropFullTextStopListStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00015A04 File Offset: 0x00013C04
		public virtual void ExplicitVisit(DropFullTextStopListStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00015A31 File Offset: 0x00013C31
		public virtual void Visit(CreateCryptographicProviderStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00015A42 File Offset: 0x00013C42
		public virtual void ExplicitVisit(CreateCryptographicProviderStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00015A68 File Offset: 0x00013C68
		public virtual void Visit(AlterCryptographicProviderStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00015A79 File Offset: 0x00013C79
		public virtual void ExplicitVisit(AlterCryptographicProviderStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00015A9F File Offset: 0x00013C9F
		public virtual void Visit(DropCryptographicProviderStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00015AB0 File Offset: 0x00013CB0
		public virtual void ExplicitVisit(DropCryptographicProviderStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00015ADD File Offset: 0x00013CDD
		public virtual void Visit(EventSessionObjectName node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00015AEE File Offset: 0x00013CEE
		public virtual void ExplicitVisit(EventSessionObjectName node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00015B0D File Offset: 0x00013D0D
		public virtual void Visit(EventSessionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00015B1E File Offset: 0x00013D1E
		public virtual void ExplicitVisit(EventSessionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00015B44 File Offset: 0x00013D44
		public virtual void Visit(CreateEventSessionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00015B55 File Offset: 0x00013D55
		public virtual void ExplicitVisit(CreateEventSessionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00015B82 File Offset: 0x00013D82
		public virtual void Visit(EventDeclaration node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00015B93 File Offset: 0x00013D93
		public virtual void ExplicitVisit(EventDeclaration node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00015BB2 File Offset: 0x00013DB2
		public virtual void Visit(EventDeclarationSetParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00015BC3 File Offset: 0x00013DC3
		public virtual void ExplicitVisit(EventDeclarationSetParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00015BE2 File Offset: 0x00013DE2
		public virtual void Visit(SourceDeclaration node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00015BF3 File Offset: 0x00013DF3
		public virtual void ExplicitVisit(SourceDeclaration node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00015C19 File Offset: 0x00013E19
		public virtual void Visit(EventDeclarationCompareFunctionParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00015C2A File Offset: 0x00013E2A
		public virtual void ExplicitVisit(EventDeclarationCompareFunctionParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00015C50 File Offset: 0x00013E50
		public virtual void Visit(TargetDeclaration node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00015C61 File Offset: 0x00013E61
		public virtual void ExplicitVisit(TargetDeclaration node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00015C80 File Offset: 0x00013E80
		public virtual void Visit(SessionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00015C91 File Offset: 0x00013E91
		public virtual void ExplicitVisit(SessionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00015CB0 File Offset: 0x00013EB0
		public virtual void Visit(EventRetentionSessionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00015CC1 File Offset: 0x00013EC1
		public virtual void ExplicitVisit(EventRetentionSessionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00015CE7 File Offset: 0x00013EE7
		public virtual void Visit(MemoryPartitionSessionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public virtual void ExplicitVisit(MemoryPartitionSessionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00015D1E File Offset: 0x00013F1E
		public virtual void Visit(LiteralSessionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00015D2F File Offset: 0x00013F2F
		public virtual void ExplicitVisit(LiteralSessionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00015D55 File Offset: 0x00013F55
		public virtual void Visit(MaxDispatchLatencySessionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00015D66 File Offset: 0x00013F66
		public virtual void ExplicitVisit(MaxDispatchLatencySessionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00015D8C File Offset: 0x00013F8C
		public virtual void Visit(OnOffSessionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00015D9D File Offset: 0x00013F9D
		public virtual void ExplicitVisit(OnOffSessionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00015DC3 File Offset: 0x00013FC3
		public virtual void Visit(AlterEventSessionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00015DD4 File Offset: 0x00013FD4
		public virtual void ExplicitVisit(AlterEventSessionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00015E01 File Offset: 0x00014001
		public virtual void Visit(DropEventSessionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00015E12 File Offset: 0x00014012
		public virtual void ExplicitVisit(DropEventSessionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00015E3F File Offset: 0x0001403F
		public virtual void Visit(AlterResourceGovernorStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00015E50 File Offset: 0x00014050
		public virtual void ExplicitVisit(AlterResourceGovernorStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00015E76 File Offset: 0x00014076
		public virtual void Visit(CreateSpatialIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00015E87 File Offset: 0x00014087
		public virtual void ExplicitVisit(CreateSpatialIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00015EAD File Offset: 0x000140AD
		public virtual void Visit(SpatialIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00015EBE File Offset: 0x000140BE
		public virtual void ExplicitVisit(SpatialIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00015EDD File Offset: 0x000140DD
		public virtual void Visit(SpatialIndexRegularOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00015EEE File Offset: 0x000140EE
		public virtual void ExplicitVisit(SpatialIndexRegularOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00015F14 File Offset: 0x00014114
		public virtual void Visit(BoundingBoxSpatialIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00015F25 File Offset: 0x00014125
		public virtual void ExplicitVisit(BoundingBoxSpatialIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00015F4B File Offset: 0x0001414B
		public virtual void Visit(BoundingBoxParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00015F5C File Offset: 0x0001415C
		public virtual void ExplicitVisit(BoundingBoxParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00015F7B File Offset: 0x0001417B
		public virtual void Visit(GridsSpatialIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00015F8C File Offset: 0x0001418C
		public virtual void ExplicitVisit(GridsSpatialIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00015FB2 File Offset: 0x000141B2
		public virtual void Visit(GridParameter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00015FC3 File Offset: 0x000141C3
		public virtual void ExplicitVisit(GridParameter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00015FE2 File Offset: 0x000141E2
		public virtual void Visit(CellsPerObjectSpatialIndexOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00015FF3 File Offset: 0x000141F3
		public virtual void ExplicitVisit(CellsPerObjectSpatialIndexOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00016019 File Offset: 0x00014219
		public virtual void Visit(AlterServerConfigurationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001602A File Offset: 0x0001422A
		public virtual void ExplicitVisit(AlterServerConfigurationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00016050 File Offset: 0x00014250
		public virtual void Visit(ProcessAffinityRange node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00016061 File Offset: 0x00014261
		public virtual void ExplicitVisit(ProcessAffinityRange node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00016087 File Offset: 0x00014287
		public virtual void Visit(AlterServerConfigurationSetBufferPoolExtensionStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00016098 File Offset: 0x00014298
		public virtual void ExplicitVisit(AlterServerConfigurationSetBufferPoolExtensionStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000160BE File Offset: 0x000142BE
		public virtual void Visit(AlterServerConfigurationBufferPoolExtensionOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000160CF File Offset: 0x000142CF
		public virtual void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000160EE File Offset: 0x000142EE
		public virtual void Visit(AlterServerConfigurationBufferPoolExtensionContainerOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000160FF File Offset: 0x000142FF
		public virtual void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionContainerOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00016125 File Offset: 0x00014325
		public virtual void Visit(AlterServerConfigurationBufferPoolExtensionSizeOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00016136 File Offset: 0x00014336
		public virtual void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionSizeOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0001615C File Offset: 0x0001435C
		public virtual void Visit(AlterServerConfigurationSetDiagnosticsLogStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0001616D File Offset: 0x0001436D
		public virtual void ExplicitVisit(AlterServerConfigurationSetDiagnosticsLogStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00016193 File Offset: 0x00014393
		public virtual void Visit(AlterServerConfigurationDiagnosticsLogOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000161A4 File Offset: 0x000143A4
		public virtual void ExplicitVisit(AlterServerConfigurationDiagnosticsLogOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000161C3 File Offset: 0x000143C3
		public virtual void Visit(AlterServerConfigurationDiagnosticsLogMaxSizeOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000161D4 File Offset: 0x000143D4
		public virtual void ExplicitVisit(AlterServerConfigurationDiagnosticsLogMaxSizeOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000161FA File Offset: 0x000143FA
		public virtual void Visit(AlterServerConfigurationSetFailoverClusterPropertyStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0001620B File Offset: 0x0001440B
		public virtual void ExplicitVisit(AlterServerConfigurationSetFailoverClusterPropertyStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00016231 File Offset: 0x00014431
		public virtual void Visit(AlterServerConfigurationFailoverClusterPropertyOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00016242 File Offset: 0x00014442
		public virtual void ExplicitVisit(AlterServerConfigurationFailoverClusterPropertyOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00016261 File Offset: 0x00014461
		public virtual void Visit(AlterServerConfigurationSetHadrClusterStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00016272 File Offset: 0x00014472
		public virtual void ExplicitVisit(AlterServerConfigurationSetHadrClusterStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00016298 File Offset: 0x00014498
		public virtual void Visit(AlterServerConfigurationHadrClusterOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000162A9 File Offset: 0x000144A9
		public virtual void ExplicitVisit(AlterServerConfigurationHadrClusterOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000162C8 File Offset: 0x000144C8
		public virtual void Visit(AvailabilityGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000162D9 File Offset: 0x000144D9
		public virtual void ExplicitVisit(AvailabilityGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000162FF File Offset: 0x000144FF
		public virtual void Visit(CreateAvailabilityGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00016310 File Offset: 0x00014510
		public virtual void ExplicitVisit(CreateAvailabilityGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0001633D File Offset: 0x0001453D
		public virtual void Visit(AlterAvailabilityGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0001634E File Offset: 0x0001454E
		public virtual void ExplicitVisit(AlterAvailabilityGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0001637B File Offset: 0x0001457B
		public virtual void Visit(AvailabilityReplica node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0001638C File Offset: 0x0001458C
		public virtual void ExplicitVisit(AvailabilityReplica node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000163AB File Offset: 0x000145AB
		public virtual void Visit(AvailabilityReplicaOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000163BC File Offset: 0x000145BC
		public virtual void ExplicitVisit(AvailabilityReplicaOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000163DB File Offset: 0x000145DB
		public virtual void Visit(LiteralReplicaOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000163EC File Offset: 0x000145EC
		public virtual void ExplicitVisit(LiteralReplicaOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00016412 File Offset: 0x00014612
		public virtual void Visit(AvailabilityModeReplicaOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00016423 File Offset: 0x00014623
		public virtual void ExplicitVisit(AvailabilityModeReplicaOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00016449 File Offset: 0x00014649
		public virtual void Visit(FailoverModeReplicaOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0001645A File Offset: 0x0001465A
		public virtual void ExplicitVisit(FailoverModeReplicaOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00016480 File Offset: 0x00014680
		public virtual void Visit(PrimaryRoleReplicaOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00016491 File Offset: 0x00014691
		public virtual void ExplicitVisit(PrimaryRoleReplicaOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000164B7 File Offset: 0x000146B7
		public virtual void Visit(SecondaryRoleReplicaOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000164C8 File Offset: 0x000146C8
		public virtual void ExplicitVisit(SecondaryRoleReplicaOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000164EE File Offset: 0x000146EE
		public virtual void Visit(AvailabilityGroupOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000164FF File Offset: 0x000146FF
		public virtual void ExplicitVisit(AvailabilityGroupOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001651E File Offset: 0x0001471E
		public virtual void Visit(LiteralAvailabilityGroupOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0001652F File Offset: 0x0001472F
		public virtual void ExplicitVisit(LiteralAvailabilityGroupOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00016555 File Offset: 0x00014755
		public virtual void Visit(AlterAvailabilityGroupAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00016566 File Offset: 0x00014766
		public virtual void ExplicitVisit(AlterAvailabilityGroupAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00016585 File Offset: 0x00014785
		public virtual void Visit(AlterAvailabilityGroupFailoverAction node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00016596 File Offset: 0x00014796
		public virtual void ExplicitVisit(AlterAvailabilityGroupFailoverAction node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000165BC File Offset: 0x000147BC
		public virtual void Visit(AlterAvailabilityGroupFailoverOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000165CD File Offset: 0x000147CD
		public virtual void ExplicitVisit(AlterAvailabilityGroupFailoverOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000165EC File Offset: 0x000147EC
		public virtual void Visit(DropAvailabilityGroupStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000165FD File Offset: 0x000147FD
		public virtual void ExplicitVisit(DropAvailabilityGroupStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001662A File Offset: 0x0001482A
		public virtual void Visit(CreateFederationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001663B File Offset: 0x0001483B
		public virtual void ExplicitVisit(CreateFederationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00016661 File Offset: 0x00014861
		public virtual void Visit(AlterFederationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00016672 File Offset: 0x00014872
		public virtual void ExplicitVisit(AlterFederationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00016698 File Offset: 0x00014898
		public virtual void Visit(DropFederationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000166A9 File Offset: 0x000148A9
		public virtual void ExplicitVisit(DropFederationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000166D6 File Offset: 0x000148D6
		public virtual void Visit(UseFederationStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000166E7 File Offset: 0x000148E7
		public virtual void ExplicitVisit(UseFederationStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001670D File Offset: 0x0001490D
		public virtual void Visit(DiskStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001671E File Offset: 0x0001491E
		public virtual void ExplicitVisit(DiskStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00016744 File Offset: 0x00014944
		public virtual void Visit(DiskStatementOption node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00016755 File Offset: 0x00014955
		public virtual void ExplicitVisit(DiskStatementOption node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00016774 File Offset: 0x00014974
		public virtual void Visit(CreateColumnStoreIndexStatement node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00016785 File Offset: 0x00014985
		public virtual void ExplicitVisit(CreateColumnStoreIndexStatement node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000167AB File Offset: 0x000149AB
		public virtual void Visit(WindowFrameClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000167BC File Offset: 0x000149BC
		public virtual void ExplicitVisit(WindowFrameClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000167DB File Offset: 0x000149DB
		public virtual void Visit(WindowDelimiter node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000167EC File Offset: 0x000149EC
		public virtual void ExplicitVisit(WindowDelimiter node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001680B File Offset: 0x00014A0B
		public virtual void Visit(WithinGroupClause node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0001681C File Offset: 0x00014A1C
		public virtual void ExplicitVisit(WithinGroupClause node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0001683B File Offset: 0x00014A3B
		public virtual void Visit(SelectiveXmlIndexPromotedPath node)
		{
			if (!this.VisitBaseType)
			{
				this.Visit(node);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001684C File Offset: 0x00014A4C
		public virtual void ExplicitVisit(SelectiveXmlIndexPromotedPath node)
		{
			if (this.VisitBaseType)
			{
				this.Visit(node);
			}
			this.Visit(node);
			node.AcceptChildren(this);
		}

		// Token: 0x04000E4E RID: 3662
		private readonly bool _visitBaseType;
	}
}
