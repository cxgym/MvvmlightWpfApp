namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Diagnostics;

    public partial class FycszmDbContext : DbContext
    {
        public FycszmDbContext()
            : base("name=FycszmDbContext")
        {
            if (Debugger.IsAttached)
            {
                Database.Log = i => Debug.WriteLine(i);
            }
        }

        public virtual DbSet<SYS_GBZCJG> SYS_GBZCJG { get; set; }
        public virtual DbSet<SYS_GENERATE_NUMBER> SYS_GENERATE_NUMBER { get; set; }
        public virtual DbSet<TB_CSZM_BFDJ> TB_CSZM_BFDJ { get; set; }
        public virtual DbSet<TB_CSZM_CSZMXX> TB_CSZM_CSZMXX { get; set; }
        public virtual DbSet<TB_CSZM_FLOW> TB_CSZM_FLOW { get; set; }
        public virtual DbSet<TB_CSZM_FZDJ> TB_CSZM_FZDJ { get; set; }
        public virtual DbSet<TB_CSZM_HDQD> TB_CSZM_HDQD { get; set; }
        public virtual DbSet<TB_CSZM_HDQDMX> TB_CSZM_HDQDMX { get; set; }
        public virtual DbSet<TB_CSZM_JDFZ> TB_CSZM_JDFZ { get; set; }
        public virtual DbSet<TB_CSZM_JDFZMX> TB_CSZM_JDFZMX { get; set; }
        public virtual DbSet<TB_CSZM_JDSY> TB_CSZM_JDSY { get; set; }
        public virtual DbSet<TB_CSZM_KCMX> TB_CSZM_KCMX { get; set; }
        public virtual DbSet<TB_CSZM_KCRCKFZYS> TB_CSZM_KCRCKFZYS { get; set; }
        public virtual DbSet<TB_CSZM_NDSY> TB_CSZM_NDSY { get; set; }
        public virtual DbSet<TB_CSZM_RCKDJ> TB_CSZM_RCKDJ { get; set; }
        public virtual DbSet<TB_CSZM_SJDJ> TB_CSZM_SJDJ { get; set; }
        public virtual DbSet<TB_CSZM_SLDJ> TB_CSZM_SLDJ { get; set; }
        public virtual DbSet<TB_CSZM_SQXGDJ> TB_CSZM_SQXGDJ { get; set; }
        public virtual DbSet<TB_CSZM_XSEXX> TB_CSZM_XSEXX { get; set; }
        public virtual DbSet<TB_LXQKJLB> TB_LXQKJLB { get; set; }
        public virtual DbSet<TB_Y_CSZMXX> TB_Y_CSZMXX { get; set; }
        public virtual DbSet<TB_Y_YQJGDZB> TB_Y_YQJGDZB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.AREANAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YLJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YLJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.MCQR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YJGDZ)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.GBNF)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.BSBCJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.BSBCJG)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YLJGTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GBZCJG>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.YWDM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.QXDM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.JGDM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.NF)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.YF)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_GENERATE_NUMBER>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.BFDJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.XSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.YZ_BH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.XSEXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.CSDDSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.CSDDSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.CSDDQU)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FMDDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FMDDQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.YLJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.YLJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.BAH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_GJQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_MZQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_HJSJDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_HJSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_DYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_DYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_DYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_ZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_GJQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_MZQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_DYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_DYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_DYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_ZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.JCZXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.SQQX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.SQJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.SQJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.SQRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.SQRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.QFLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.QFLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.BFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.BFDJDYZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.CSZMDYZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.BFZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.TY_DJJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.TY_DJJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.LXBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.MQ_ZJLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_BFDJ>()
                .Property(e => e.FQ_ZJLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.XSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.XSEXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.CSDDSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.CSDDSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.CSDDQU)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FMDDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FMDDQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YLJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YLJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.BAH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_GJQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_MZQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_HJSJDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_HJSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_DYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_DYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_DYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_DYDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_GJQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_MZQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_DYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_DYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_DYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_DYDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.JCZXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_YXSEGX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_YXSEGXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_SFZJLB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_SFZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_ZMCL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_QZJD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LZR_ZMCLQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YZ_BH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YZ_JHQK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.HFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.BFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFJGNM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.CSZQF_MC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFRYID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFRYMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.SFFZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FZYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.QFZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.SJQFRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.SJQFRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.TYYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.LXBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.HYZK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.MQ_ZJLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_CSZMXX>()
                .Property(e => e.FQ_ZJLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.XSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZYM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CZNR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FLOW>()
                .Property(e => e.LXBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZDJ_LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QSBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_ZZBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_YY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QTYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_JBRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_JBRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_DJJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_DJJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_QJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_SJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_SJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_SJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_SJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_SJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_SHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_DJQX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.FZ_DJQXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_FZDJ>()
                .Property(e => e.LXBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDQDLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.NF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.JD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HD_QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HD_QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDFZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDCZJQCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDCZJQMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDCZRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.HDCZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.SJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.SJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.SJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.SJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.SJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQD>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.HDQDLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.HDJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.HDJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.YBHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.HDBHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_HDQDMX>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.FZQKLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.NF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.JD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QFJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QFJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SBRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SBRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.QJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.SHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZQKLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_JBRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_YY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_JBRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_DJJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_DJJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_DJQX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.FZ_DJQXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDFZMX>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.NF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.JD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QFJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QFJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SBRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SBRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.QJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.SHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_JDSY>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.RK_QXDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.RK_QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.RK_JGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.RK_JGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.RK_CZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.RK_CZRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.BHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.FZYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.QFLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.CZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.CZRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.SHRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.SHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.CZJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.CZJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCMX>()
                .Property(e => e.SDZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.RCKLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.FZDJ_LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.SJDJ_LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_KCRCKFZYS>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.NF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QFJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QFJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SBRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SBRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.QJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SJSHRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SJSHRMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SJSHJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SJSHJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SJSHBTGYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.SHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_NDSY>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RCKLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_CKMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_ZZCKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_BHQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_QSBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_ZZBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_ZJPC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_LX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_CZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.RK_CZRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SLDJ_LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SLSDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SL_SMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SL_QXDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SL_QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SL_JGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.SL_JGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_ZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_ZZQXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_ZZQXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_ZZJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_ZZJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_BHQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_QSBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_ZZBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_LX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_CZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CK_CZRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.FZ_YY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.FZ_QTYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.FZ_JBRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.FZ_JBRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.TB_MC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.TB_ZZJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.TB_QHDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.GL_RCKLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CRK_BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_RCKDJ>()
                .Property(e => e.LXBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJDJ_LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.CSZMBHFROM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.CSZMBHTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJ_QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJ_QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJ_JGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJ_JGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.BHZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.CZRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.CZRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJRKRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.SJRKRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SJDJ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SLDJ_LSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SL_QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SL_QXMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SL_JGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SL_JGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SLRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SLRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SL_YY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.SLZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SLDJ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.SQXGLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.XSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.SQRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.SQRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.SQXGNR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.XGZID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.XGZXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.XGZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.SQJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.SQJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_SQXGDJ>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.XSE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.XSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.WCE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.XSEXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.CSDDSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.CSDDSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.CSDDQU)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FMDDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FMDDQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YLJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YLJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.BAH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_GJQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_MZQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_HJSJDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_HJSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_HJDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_HJDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_YBHJDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_SFZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_JZDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_JZDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_JZDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_YBJZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_DYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_DYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_DYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_DYDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_GJQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_MZQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_HJDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_HJDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_HJDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_YBHJDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_SFZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_DYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_DYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_DYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_DYDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.JCZXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_YXSEGX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_YXSEGXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_SFZJLB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_SFZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_ZMCL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_QZJD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LZR_ZMCLQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YZ_BH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YZ_JHQK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.HFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.BFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFJGNM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.CSZQF_MC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFRYID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFRYMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.DJRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.DJRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.DJJGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.DJJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.DYZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.QFZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.SJQFRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.SJQFRXM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.CSZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.SQXGZT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.SQXGLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.BFDJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.SJLY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.LXBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_HJDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.HYZK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.MQ_ZJLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CSZM_XSEXX>()
                .Property(e => e.FQ_ZJLXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.LXQK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.QXDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.YLJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.YLJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.YL1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.YL2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.YL3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LXQKJLB>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.XSE_BM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSYXZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.XSE_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.XSE_XB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSDD_S)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSDD_SD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSDD_XQ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSD_QHDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSD_CSDLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.YLJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.YLJGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSDDQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.JSRY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_BAH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_NL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_HJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_HJSJDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_ZZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_ZZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_ZZQU)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_ZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_SFZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.MQ_SFZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_NL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_GJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_ZZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_ZZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_ZZQU)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_ZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_SFZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.FQ_SFZHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.LZR_XM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.LZR_YXSEGX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.LZR_SFZJLB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.LZR_SFZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.LZR_ZMCL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.LZR_ZMCLQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QFJG_MC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QFJG_QHDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QFJG_ZZJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QFJG_LBDM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QF_RY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QF_LX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QF_LXQT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.YZ_BH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.YZ_JHQK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.HFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.BFYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.QF_BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSTC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.CSTX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.TYBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_CSZMXX>()
                .Property(e => e.TYYY)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_YQJGDZB>()
                .Property(e => e.YQJG_DM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_YQJGDZB>()
                .Property(e => e.YQJG_MC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_YQJGDZB>()
                .Property(e => e.EQJG_DM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Y_YQJGDZB>()
                .Property(e => e.EQJG_MC)
                .IsUnicode(false);
        }
    }
}
