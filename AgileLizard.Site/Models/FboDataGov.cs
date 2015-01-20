using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileLizard.Site.Models
{
    public class FboDataGov
    {
    }



    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NOTICES
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD", typeof(NOTICESAWARD))]
        [System.Xml.Serialization.XmlElementAttribute("COMBINE", typeof(NOTICESCOMBINE))]
        [System.Xml.Serialization.XmlElementAttribute("FAIROPP", typeof(NOTICESFAIROPP))]
        [System.Xml.Serialization.XmlElementAttribute("JA", typeof(NOTICESJA))]
        [System.Xml.Serialization.XmlElementAttribute("MOD", typeof(NOTICESMOD))]
        [System.Xml.Serialization.XmlElementAttribute("PRESOL", typeof(NOTICESPRESOL))]
        [System.Xml.Serialization.XmlElementAttribute("SNOTE", typeof(NOTICESSNOTE))]
        [System.Xml.Serialization.XmlElementAttribute("SRCSGT", typeof(NOTICESSRCSGT))]
        [System.Xml.Serialization.XmlElementAttribute("SSALE", typeof(NOTICESSSALE))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private bool aWDDATEFieldSpecified;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESAWARDCHANGES cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AWDDATESpecified
        {
            get
            {
                return this.aWDDATEFieldSpecified;
            }
            set
            {
                this.aWDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGES CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGES
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD", typeof(NOTICESAWARDCHANGESAWARD))]
        [System.Xml.Serialization.XmlElementAttribute("COMBINE", typeof(NOTICESAWARDCHANGESCOMBINE))]
        [System.Xml.Serialization.XmlElementAttribute("JA", typeof(NOTICESAWARDCHANGESJA))]
        [System.Xml.Serialization.XmlElementAttribute("MOD", typeof(NOTICESAWARDCHANGESMOD))]
        [System.Xml.Serialization.XmlElementAttribute("PRESOL", typeof(NOTICESAWARDCHANGESPRESOL))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private uint zIPField;

        private bool zIPFieldSpecified;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESAWARDCHANGESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESAWARDCHANGESAWARDDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public uint ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZIPSpecified
        {
            get
            {
                return this.zIPFieldSpecified;
            }
            set
            {
                this.zIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGESAWARDDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESAWARDDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESCOMBINE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private uint aRCHDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESAWARDCHANGESCOMBINEEMAIL eMAILField;

        private string sETASIDEField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGESCOMBINEEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESCOMBINEEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private uint aWDDATEField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private string rECOVERY_ACTField;

        private NOTICESAWARDCHANGESJADOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGESJADOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESJADOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string rECOVERY_ACTField;

        private NOTICESAWARDCHANGESMODDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGESMODDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESMODDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESPRESOL
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private uint aRCHDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESAWARDCHANGESPRESOLEMAIL eMAILField;

        private string sETASIDEField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESAWARDCHANGESPRESOLEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESAWARDCHANGESPRESOLEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private string nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESCOMBINEEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESCOMBINECHANGES cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public string NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINEEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGES CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINEEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGES
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD", typeof(NOTICESCOMBINECHANGESAWARD))]
        [System.Xml.Serialization.XmlElementAttribute("FAIROPP", typeof(NOTICESCOMBINECHANGESFAIROPP))]
        [System.Xml.Serialization.XmlElementAttribute("JA", typeof(NOTICESCOMBINECHANGESJA))]
        [System.Xml.Serialization.XmlElementAttribute("MOD", typeof(NOTICESCOMBINECHANGESMOD))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private bool aWDDATEFieldSpecified;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESCOMBINECHANGESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESCOMBINECHANGESAWARDDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AWDDATESpecified
        {
            get
            {
                return this.aWDDATEFieldSpecified;
            }
            set
            {
                this.aWDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGESAWARDDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESAWARDDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESFAIROPP
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private uint zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string fOJAField;

        private string aWDNBRField;

        private uint aWDDATEField;

        private string dONBRField;

        private uint aRCHDATEField;

        private string dESCField;

        private string lINKField;

        private NOTICESCOMBINECHANGESFAIROPPEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESCOMBINECHANGESFAIROPPDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public uint ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string FOJA
        {
            get
            {
                return this.fOJAField;
            }
            set
            {
                this.fOJAField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string DONBR
        {
            get
            {
                return this.dONBRField;
            }
            set
            {
                this.dONBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGESFAIROPPEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGESFAIROPPDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESFAIROPPEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESFAIROPPDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private string mODNBRField;

        private uint aWDDATEField;

        private bool aWDDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private string rECOVERY_ACTField;

        private NOTICESCOMBINECHANGESJADOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AWDDATESpecified
        {
            get
            {
                return this.aWDDATEFieldSpecified;
            }
            set
            {
                this.aWDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGESJADOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESJADOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESCOMBINECHANGESMODEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESCOMBINECHANGESMODEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESCOMBINECHANGESMODEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESFAIROPP
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AGENCY", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ARCHDATE", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("AWDDATE", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("AWDNBR", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CHANGES", typeof(NOTICESFAIROPPCHANGES))]
        [System.Xml.Serialization.XmlElementAttribute("CLASSCOD", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CONTACT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DATE", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("DESC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DOCUMENT_PACKAGES", typeof(NOTICESFAIROPPDOCUMENT_PACKAGES))]
        [System.Xml.Serialization.XmlElementAttribute("DONBR", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("EMAIL", typeof(NOTICESFAIROPPEMAIL))]
        [System.Xml.Serialization.XmlElementAttribute("FOJA", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LINK", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LOCATION", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MODNBR", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NAICS", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("OFFADD", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("OFFICE", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("RECOVERY_ACT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SOLNBR", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SUBJECT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ZIP", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESFAIROPPCHANGES
    {

        private NOTICESFAIROPPCHANGESMOD[] mODField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MOD")]
        public NOTICESFAIROPPCHANGESMOD[] MOD
        {
            get
            {
                return this.mODField;
            }
            set
            {
                this.mODField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESFAIROPPCHANGESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private ushort pOPZIPField;

        private bool pOPZIPFieldSpecified;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public ushort POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool POPZIPSpecified
        {
            get
            {
                return this.pOPZIPFieldSpecified;
            }
            set
            {
                this.pOPZIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESFAIROPPDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESFAIROPPEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        AGENCY,

        /// <remarks/>
        ARCHDATE,

        /// <remarks/>
        AWDDATE,

        /// <remarks/>
        AWDNBR,

        /// <remarks/>
        CHANGES,

        /// <remarks/>
        CLASSCOD,

        /// <remarks/>
        CONTACT,

        /// <remarks/>
        DATE,

        /// <remarks/>
        DESC,

        /// <remarks/>
        DOCUMENT_PACKAGES,

        /// <remarks/>
        DONBR,

        /// <remarks/>
        EMAIL,

        /// <remarks/>
        FOJA,

        /// <remarks/>
        LINK,

        /// <remarks/>
        LOCATION,

        /// <remarks/>
        MODNBR,

        /// <remarks/>
        NAICS,

        /// <remarks/>
        OFFADD,

        /// <remarks/>
        OFFICE,

        /// <remarks/>
        RECOVERY_ACT,

        /// <remarks/>
        SOLNBR,

        /// <remarks/>
        SUBJECT,

        /// <remarks/>
        ZIP,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private string mODNBRField;

        private uint aWDDATEField;

        private bool aWDDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private NOTICESJAEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESJACHANGES cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AWDDATESpecified
        {
            get
            {
                return this.aWDDATEFieldSpecified;
            }
            set
            {
                this.aWDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESJAEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public NOTICESJACHANGES CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJAEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGES
    {

        private NOTICESJACHANGESMOD[] mODField;

        private NOTICESJACHANGESJA[] jaField;

        private NOTICESJACHANGESAWARD[] aWARDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MOD")]
        public NOTICESJACHANGESMOD[] MOD
        {
            get
            {
                return this.mODField;
            }
            set
            {
                this.mODField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JA")]
        public NOTICESJACHANGESJA[] JA
        {
            get
            {
                return this.jaField;
            }
            set
            {
                this.jaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD")]
        public NOTICESJACHANGESAWARD[] AWARD
        {
            get
            {
                return this.aWARDField;
            }
            set
            {
                this.aWARDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private ushort pOPZIPField;

        private bool pOPZIPFieldSpecified;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private NOTICESJACHANGESMODDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public ushort POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool POPZIPSpecified
        {
            get
            {
                return this.pOPZIPFieldSpecified;
            }
            set
            {
                this.pOPZIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESJACHANGESMODDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESMODDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private string mODNBRField;

        private uint aWDDATEField;

        private uint aRCHDATEField;

        private string dESCField;

        private string lINKField;

        private NOTICESJACHANGESJAEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESJACHANGESJADOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESJACHANGESJAEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESJACHANGESJADOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESJAEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESJADOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESJACHANGESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESJACHANGESAWARDDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESJACHANGESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESJACHANGESAWARDDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESJACHANGESAWARDDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private uint pOPZIPField;

        private bool pOPZIPFieldSpecified;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public uint POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool POPZIPSpecified
        {
            get
            {
                return this.pOPZIPFieldSpecified;
            }
            set
            {
                this.pOPZIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOL
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private string nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESPRESOLEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESPRESOLCHANGES cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public string NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGES CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGES
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD", typeof(NOTICESPRESOLCHANGESAWARD))]
        [System.Xml.Serialization.XmlElementAttribute("COMBINE", typeof(NOTICESPRESOLCHANGESCOMBINE))]
        [System.Xml.Serialization.XmlElementAttribute("FAIROPP", typeof(NOTICESPRESOLCHANGESFAIROPP))]
        [System.Xml.Serialization.XmlElementAttribute("JA", typeof(NOTICESPRESOLCHANGESJA))]
        [System.Xml.Serialization.XmlElementAttribute("MOD", typeof(NOTICESPRESOLCHANGESMOD))]
        [System.Xml.Serialization.XmlElementAttribute("PRESOL", typeof(NOTICESPRESOLCHANGESPRESOL))]
        [System.Xml.Serialization.XmlElementAttribute("SNOTE", typeof(NOTICESPRESOLCHANGESSNOTE))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESPRESOLCHANGESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESPRESOLCHANGESAWARDDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        private string cORRECTIONField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGESAWARDDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public string CORRECTION
        {
            get
            {
                return this.cORRECTIONField;
            }
            set
            {
                this.cORRECTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESAWARDDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESCOMBINE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESPRESOLCHANGESCOMBINEEMAIL eMAILField;

        private string sETASIDEField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGESCOMBINEEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESCOMBINEEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESFAIROPP
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private byte cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string fOJAField;

        private string aWDNBRField;

        private uint aWDDATEField;

        private string dONBRField;

        private uint aRCHDATEField;

        private string dESCField;

        private string lINKField;

        private string rECOVERY_ACTField;

        private NOTICESPRESOLCHANGESFAIROPPDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public byte CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string FOJA
        {
            get
            {
                return this.fOJAField;
            }
            set
            {
                this.fOJAField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string DONBR
        {
            get
            {
                return this.dONBRField;
            }
            set
            {
                this.dONBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGESFAIROPPDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESFAIROPPDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private string mODNBRField;

        private uint aWDDATEField;

        private bool aWDDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private NOTICESPRESOLCHANGESJAEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private string cORRECTIONField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AWDDATESpecified
        {
            get
            {
                return this.aWDDATEFieldSpecified;
            }
            set
            {
                this.aWDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGESJAEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public string CORRECTION
        {
            get
            {
                return this.cORRECTIONField;
            }
            set
            {
                this.cORRECTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESJAEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private string nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESPRESOLCHANGESMODEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public string NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESPRESOLCHANGESMODEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESMODEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESPRESOL
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private uint zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public uint ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESPRESOLCHANGESSNOTE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESSNOTEEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESSNOTECHANGES cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTEEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGES CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTEEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGES
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD", typeof(NOTICESSNOTECHANGESAWARD))]
        [System.Xml.Serialization.XmlElementAttribute("FAIROPP", typeof(NOTICESSNOTECHANGESFAIROPP))]
        [System.Xml.Serialization.XmlElementAttribute("JA", typeof(NOTICESSNOTECHANGESJA))]
        [System.Xml.Serialization.XmlElementAttribute("MOD", typeof(NOTICESSNOTECHANGESMOD))]
        [System.Xml.Serialization.XmlElementAttribute("SNOTE", typeof(NOTICESSNOTECHANGESSNOTE))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESSNOTECHANGESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESSNOTECHANGESAWARDDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGESAWARDDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESAWARDDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESFAIROPP
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private uint zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string fOJAField;

        private string aWDNBRField;

        private uint aWDDATEField;

        private string dONBRField;

        private string mODNBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private NOTICESSNOTECHANGESFAIROPPEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESSNOTECHANGESFAIROPPDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public uint ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string FOJA
        {
            get
            {
                return this.fOJAField;
            }
            set
            {
                this.fOJAField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string DONBR
        {
            get
            {
                return this.dONBRField;
            }
            set
            {
                this.dONBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGESFAIROPPEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGESFAIROPPDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESFAIROPPEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESFAIROPPDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private string mODNBRField;

        private uint aWDDATEField;

        private bool aWDDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private NOTICESSNOTECHANGESJAEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESSNOTECHANGESJADOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AWDDATESpecified
        {
            get
            {
                return this.aWDDATEFieldSpecified;
            }
            set
            {
                this.aWDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGESJAEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSNOTECHANGESJADOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESJAEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESJADOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESMOD
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AGENCY", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ARCHDATE", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("CLASSCOD", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CONTACT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DATE", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("DESC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DOCUMENT_PACKAGES", typeof(NOTICESSNOTECHANGESMODDOCUMENT_PACKAGES))]
        [System.Xml.Serialization.XmlElementAttribute("EMAIL", typeof(NOTICESSNOTECHANGESMODEMAIL))]
        [System.Xml.Serialization.XmlElementAttribute("LINK", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LOCATION", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NAICS", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("OFFADD", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("OFFICE", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("POPADDRESS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("POPCOUNTRY", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("POPZIP", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("RECOVERY_ACT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("RESPDATE", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("SETASIDE", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SOLNBR", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SUBJECT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ZIP", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESMODDOCUMENT_PACKAGES
    {

        private string[] pACKAGEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACKAGE")]
        public string[] PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESMODEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        AGENCY,

        /// <remarks/>
        ARCHDATE,

        /// <remarks/>
        CLASSCOD,

        /// <remarks/>
        CONTACT,

        /// <remarks/>
        DATE,

        /// <remarks/>
        DESC,

        /// <remarks/>
        DOCUMENT_PACKAGES,

        /// <remarks/>
        EMAIL,

        /// <remarks/>
        LINK,

        /// <remarks/>
        LOCATION,

        /// <remarks/>
        NAICS,

        /// <remarks/>
        OFFADD,

        /// <remarks/>
        OFFICE,

        /// <remarks/>
        POPADDRESS,

        /// <remarks/>
        POPCOUNTRY,

        /// <remarks/>
        POPZIP,

        /// <remarks/>
        RECOVERY_ACT,

        /// <remarks/>
        RESPDATE,

        /// <remarks/>
        SETASIDE,

        /// <remarks/>
        SOLNBR,

        /// <remarks/>
        SUBJECT,

        /// <remarks/>
        ZIP,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSNOTECHANGESSNOTE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private ushort zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGT
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESSRCSGTEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESSRCSGTCHANGES cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGES CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGES
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AWARD", typeof(NOTICESSRCSGTCHANGESAWARD))]
        [System.Xml.Serialization.XmlElementAttribute("FAIROPP", typeof(NOTICESSRCSGTCHANGESFAIROPP))]
        [System.Xml.Serialization.XmlElementAttribute("JA", typeof(NOTICESSRCSGTCHANGESJA))]
        [System.Xml.Serialization.XmlElementAttribute("MOD", typeof(NOTICESSRCSGTCHANGESMOD))]
        [System.Xml.Serialization.XmlElementAttribute("PRESOL", typeof(NOTICESSRCSGTCHANGESPRESOL))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESAWARD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string aWDNBRField;

        private string aWDAMTField;

        private uint aWDDATEField;

        private string lINENBRField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string aWARDEEField;

        private string dESCField;

        private string lINKField;

        private NOTICESSRCSGTCHANGESAWARDEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESSRCSGTCHANGESAWARDDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string AWDAMT
        {
            get
            {
                return this.aWDAMTField;
            }
            set
            {
                this.aWDAMTField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string LINENBR
        {
            get
            {
                return this.lINENBRField;
            }
            set
            {
                this.lINENBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AWARDEE
        {
            get
            {
                return this.aWARDEEField;
            }
            set
            {
                this.aWARDEEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESAWARDEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESAWARDDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESAWARDEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESAWARDDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESFAIROPP
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string fOJAField;

        private string aWDNBRField;

        private uint aWDDATEField;

        private string dONBRField;

        private uint aRCHDATEField;

        private string dESCField;

        private string lINKField;

        private NOTICESSRCSGTCHANGESFAIROPPEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESSRCSGTCHANGESFAIROPPDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string FOJA
        {
            get
            {
                return this.fOJAField;
            }
            set
            {
                this.fOJAField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public string DONBR
        {
            get
            {
                return this.dONBRField;
            }
            set
            {
                this.dONBRField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESFAIROPPEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESFAIROPPDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESFAIROPPEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESFAIROPPDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESJA
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private string cONTACTField;

        private string sTAUTHField;

        private string aWDNBRField;

        private string mODNBRField;

        private uint aWDDATEField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string dESCField;

        private string lINKField;

        private NOTICESSRCSGTCHANGESJAEMAIL eMAILField;

        private string rECOVERY_ACTField;

        private NOTICESSRCSGTCHANGESJADOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string STAUTH
        {
            get
            {
                return this.sTAUTHField;
            }
            set
            {
                this.sTAUTHField = value;
            }
        }

        /// <remarks/>
        public string AWDNBR
        {
            get
            {
                return this.aWDNBRField;
            }
            set
            {
                this.aWDNBRField = value;
            }
        }

        /// <remarks/>
        public string MODNBR
        {
            get
            {
                return this.mODNBRField;
            }
            set
            {
                this.mODNBRField = value;
            }
        }

        /// <remarks/>
        public uint AWDDATE
        {
            get
            {
                return this.aWDDATEField;
            }
            set
            {
                this.aWDDATEField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESJAEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESJADOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESJAEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESJADOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private bool nAICSFieldSpecified;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private bool rESPDATEFieldSpecified;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private NOTICESSRCSGTCHANGESMODEMAIL eMAILField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private string pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NAICSSpecified
        {
            get
            {
                return this.nAICSFieldSpecified;
            }
            set
            {
                this.nAICSFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RESPDATESpecified
        {
            get
            {
                return this.rESPDATEFieldSpecified;
            }
            set
            {
                this.rESPDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public NOTICESSRCSGTCHANGESMODEMAIL EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESMODEMAIL
    {

        private string aDDRESSField;

        private string dESCField;

        /// <remarks/>
        public string ADDRESS
        {
            get
            {
                return this.aDDRESSField;
            }
            set
            {
                this.aDDRESSField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSRCSGTCHANGESPRESOL
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private uint pOPZIPField;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private object dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public uint POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public object DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSSALE
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private uint aRCHDATEField;

        private bool aRCHDATEFieldSpecified;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private uint pOPZIPField;

        private bool pOPZIPFieldSpecified;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private string[] dOCUMENT_PACKAGESField;

        private NOTICESSSALEMOD[] cHANGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public uint ARCHDATE
        {
            get
            {
                return this.aRCHDATEField;
            }
            set
            {
                this.aRCHDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARCHDATESpecified
        {
            get
            {
                return this.aRCHDATEFieldSpecified;
            }
            set
            {
                this.aRCHDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public uint POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool POPZIPSpecified
        {
            get
            {
                return this.pOPZIPFieldSpecified;
            }
            set
            {
                this.pOPZIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PACKAGE", IsNullable = false)]
        public string[] DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MOD", IsNullable = false)]
        public NOTICESSSALEMOD[] CHANGES
        {
            get
            {
                return this.cHANGESField;
            }
            set
            {
                this.cHANGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSSALEMOD
    {

        private uint dATEField;

        private string aGENCYField;

        private string oFFICEField;

        private string lOCATIONField;

        private string zIPField;

        private string cLASSCODField;

        private uint nAICSField;

        private string oFFADDField;

        private string sUBJECTField;

        private string sOLNBRField;

        private uint rESPDATEField;

        private string cONTACTField;

        private string dESCField;

        private string lINKField;

        private string sETASIDEField;

        private string pOPCOUNTRYField;

        private ushort pOPZIPField;

        private bool pOPZIPFieldSpecified;

        private string pOPADDRESSField;

        private string rECOVERY_ACTField;

        private NOTICESSSALEMODDOCUMENT_PACKAGES dOCUMENT_PACKAGESField;

        /// <remarks/>
        public uint DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AGENCY
        {
            get
            {
                return this.aGENCYField;
            }
            set
            {
                this.aGENCYField = value;
            }
        }

        /// <remarks/>
        public string OFFICE
        {
            get
            {
                return this.oFFICEField;
            }
            set
            {
                this.oFFICEField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string CLASSCOD
        {
            get
            {
                return this.cLASSCODField;
            }
            set
            {
                this.cLASSCODField = value;
            }
        }

        /// <remarks/>
        public uint NAICS
        {
            get
            {
                return this.nAICSField;
            }
            set
            {
                this.nAICSField = value;
            }
        }

        /// <remarks/>
        public string OFFADD
        {
            get
            {
                return this.oFFADDField;
            }
            set
            {
                this.oFFADDField = value;
            }
        }

        /// <remarks/>
        public string SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string SOLNBR
        {
            get
            {
                return this.sOLNBRField;
            }
            set
            {
                this.sOLNBRField = value;
            }
        }

        /// <remarks/>
        public uint RESPDATE
        {
            get
            {
                return this.rESPDATEField;
            }
            set
            {
                this.rESPDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public string DESC
        {
            get
            {
                return this.dESCField;
            }
            set
            {
                this.dESCField = value;
            }
        }

        /// <remarks/>
        public string LINK
        {
            get
            {
                return this.lINKField;
            }
            set
            {
                this.lINKField = value;
            }
        }

        /// <remarks/>
        public string SETASIDE
        {
            get
            {
                return this.sETASIDEField;
            }
            set
            {
                this.sETASIDEField = value;
            }
        }

        /// <remarks/>
        public string POPCOUNTRY
        {
            get
            {
                return this.pOPCOUNTRYField;
            }
            set
            {
                this.pOPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        public ushort POPZIP
        {
            get
            {
                return this.pOPZIPField;
            }
            set
            {
                this.pOPZIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool POPZIPSpecified
        {
            get
            {
                return this.pOPZIPFieldSpecified;
            }
            set
            {
                this.pOPZIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string POPADDRESS
        {
            get
            {
                return this.pOPADDRESSField;
            }
            set
            {
                this.pOPADDRESSField = value;
            }
        }

        /// <remarks/>
        public string RECOVERY_ACT
        {
            get
            {
                return this.rECOVERY_ACTField;
            }
            set
            {
                this.rECOVERY_ACTField = value;
            }
        }

        /// <remarks/>
        public NOTICESSSALEMODDOCUMENT_PACKAGES DOCUMENT_PACKAGES
        {
            get
            {
                return this.dOCUMENT_PACKAGESField;
            }
            set
            {
                this.dOCUMENT_PACKAGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NOTICESSSALEMODDOCUMENT_PACKAGES
    {

        private string pACKAGEField;

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }
}