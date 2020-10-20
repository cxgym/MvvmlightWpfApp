namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Diagnostics;

    public partial class FysiteDbContext : DbContext
    {
        public FysiteDbContext()
            : base("name=FysiteDbContext")
        {
            if (Debugger.IsAttached)
            {
                Database.Log = i => Debug.WriteLine(i);
            }
        }

        public virtual DbSet<SYS_AREA> SYS_AREA { get; set; }
        public virtual DbSet<SYS_CODE> SYS_CODE { get; set; }
        public virtual DbSet<SYS_LOG> SYS_LOG { get; set; }
        public virtual DbSet<SYS_MENU> SYS_MENU { get; set; }
        public virtual DbSet<SYS_OFFICE> SYS_OFFICE { get; set; }
        public virtual DbSet<SYS_PROXY_URL> SYS_PROXY_URL { get; set; }
        public virtual DbSet<SYS_ROLE> SYS_ROLE { get; set; }
        public virtual DbSet<SYS_ROLE_MENU> SYS_ROLE_MENU { get; set; }
        public virtual DbSet<SYS_USER> SYS_USER { get; set; }
        public virtual DbSet<SYS_USER_MENU> SYS_USER_MENU { get; set; }
        public virtual DbSet<SYS_USER_ROLE> SYS_USER_ROLE { get; set; }
        public virtual DbSet<Y_FANGSHI_YUNFU> Y_FANGSHI_YUNFU { get; set; }
        public virtual DbSet<Y_FENMIAN> Y_FENMIAN { get; set; }
        public virtual DbSet<Y_WEICHAN> Y_WEICHAN { get; set; }
        public virtual DbSet<Y_YUNCHANFU> Y_YUNCHANFU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.PARENT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AREA>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.COMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.PARENT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CODE>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.REMOTE_ADDR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.USER_AGENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.REQUEST_URI)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_LOG>()
                .Property(e => e.METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.PARENT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.HREF)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.TARGET)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.ICON)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.PERMISSION)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.SYSFLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.PARENT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.AREA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.GRADE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.ZIP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.MASTER)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.LV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CSZX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.ZDZX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.ZCJG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CODE22)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CODE9)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CODE11)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.GFZZJGLB)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.CSZM_QFJG)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.XSEWZZY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.WZYCFZY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.HJJG)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.JGLB)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.FNBPC)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.JHSY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.GNQJG)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.RSMDDD)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.XTMDDD)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.ZYFMMYYLB)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OFFICE>()
                .Property(e => e.WCECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.S_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.S_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.S_URL)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.S_COUNTY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.S_PARAMETER)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.S_ORG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PROXY_URL>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.OFFICE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.ENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.ROLE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.DATA_SCOPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.IS_SYS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.USEABLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.M_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.M_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.M_TYPE_S)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.OFF_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE_MENU>()
                .Property(e => e.ROLE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE_MENU>()
                .Property(e => e.MENU_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.LOGIN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.OFFICE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.NO)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.USER_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.PHOTO)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.LOGIN_IP)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.LOGIN_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.YONGHU_SIGN_ML)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER>()
                .Property(e => e.YONGHU_SIGN_WJM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER_MENU>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER_MENU>()
                .Property(e => e.MENU_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER_ROLE>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_USER_ROLE>()
                .Property(e => e.ROLE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.YID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.SFLSH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.JGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.CHANHOUDAYS)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.TIWEN)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.XUEYA1)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.XUEYA2)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUZHI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUFANGZHANGTONG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.HONGZHONG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUTOU)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUFANGZHANGTONG_R)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.HONGZHONG_R)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUTOU_R)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.GONGDI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.CHIGU)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.YATONG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZHIDI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ELOU)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ELOUSE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ELOULIANG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ELOUWEI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUFANG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZIGONG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZIGONGREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.SHANGKOU)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.SHANGKOUREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.FENLEI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.FENLEIREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.HUIYIN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.HUIYINREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.CFJGZC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.CFJGQTREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDWS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDWSREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDXL)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDXLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDYY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDYYREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDMR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDMRREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDHL)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDHLREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDQT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDQTREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZHUANZHEN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.JGKS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.KS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.JIANKANGINFO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.XINLIINFO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.LASTSUIFANG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.SUIFANGRENCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.QTZZYY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUZHI_R)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.RUFANG_R)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDYD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDYDREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDZWJC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDZWJCREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDXBJ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDXBJREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDBY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FANGSHI_YUNFU>()
                .Property(e => e.ZDBYREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.YID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMYZCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMFS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMFSTC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ZYFM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ZYFMSM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.XSS)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CJCS)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.TSNUM)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.TP)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.SSMC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.SSMCTC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMDDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMDD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PGCZZCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PGCZZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CFYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.QTCFYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.TEYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.QTTEYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.SZYCQK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.RSHBZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.RSHBZQT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CRGR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HIVZX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HIVKTJC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.DZD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.KYXQXSY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.MDDZD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HBSAGJC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HBSQG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ZDZXQQ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ZGPL)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CHCX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CHCXYY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CHCXYYQT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.YCFSW)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HSYCMY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.JKDAH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.BAH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.NCZSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.NCZS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMZTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMZT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PBCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PB)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HYLSCDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HYLSCD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.HYQK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CCSJ1S)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CCSJ1F)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CCSJ2S)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CCSJ2F)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CCSJ3S)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CCSJ3F)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMYCQK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.JCZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ZGCQ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.SHYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PGQTYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.ZYH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CH2XSSSY)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CH2XSSZY)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PGCSJH)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.PGCSJF)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.JGCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.QXCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.BGYSID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Y_FENMIAN>()
                .Property(e => e.FMFSDFL)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.YID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.BIRTHORDER)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.TZ)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.TC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.TFW)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XSEJB)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.JBSCJJ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.JBSCBB)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.SSXPZZSZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.BJJBSC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.SSCR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.TLSCZE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.TLSCYE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.TLSCR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.ZK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.CSQX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XSESW)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.APGAR1)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.APGAR2)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.APGAR3)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.WCEXM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.CSYXZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XXSC)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XZSCR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.ISSJA)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.ISSJE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.SWYY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.JTJG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.CXTXM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.CXSCR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.WZLRR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_WEICHAN>()
                .Property(e => e.XSEJBQT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.GJ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HJDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HJDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HJDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HJDZJIEDAO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HJDZJUWEI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ADDRESS_HUJI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JZDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JZDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JZDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JZDZJIEDAO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JZDZJUWEI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ADDRESS_JUZHU)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYDZJIEDAO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYDZJUWEI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ADDRESS_XIUYANG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYSQ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HJLX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JYCD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.SJHM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.MARITAL)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.MZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.QTMZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JJZK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JHNL)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CCNL)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFXM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFNL)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFZY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFJK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFSJ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFXX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFRH)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.POWHCD)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YZJZYY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.SG)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YQTZ)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZRLCC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.RGLCC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YCSYS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZCCS)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ST)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.SC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XSRSW)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CSQX)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XTCJ)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YWRE)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YCCS)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YCSYSQT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZYC)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.XYZNS)
                .HasPrecision(29, 0);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.JAZT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.GREENCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.YELLOWCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.REDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZDYF)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.WZYF)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.BYJXRS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.GLQX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.GLSQ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.X_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CREATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.UPDATE_BY)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.DEL_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZDNR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZDNRQT)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.PGNR)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CHFSBJ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFZJLX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFGJ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFMZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFQTMZ)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFHJDZSHEN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFHJDZSHI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFHJDZXIAN)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFHJDZJIEDAO)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFHJDZJUWEI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFADDRESS_HUJI)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.HBLX)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.CYZK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFCYZK)
                .IsUnicode(false);

            modelBuilder.Entity<Y_YUNCHANFU>()
                .Property(e => e.ZFDW)
                .IsUnicode(false);
        }
    }
}
