// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "MainCorporationEntry.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
#pragma warning disable 0108
#pragma warning disable 1591

namespace TestProjectAdFinix {
using __MFrNumberOf__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.Input.NumberOfHomesSold;
using __TArray1__ = global::Starcounter.Templates.TArray<global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson>;
using __MainCorp1__ = global::TestProjectAdFinix.MainCorporationEntry.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Arr1__ = global::Starcounter.Arr<global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson>;
using __MainCorp2__ = global::TestProjectAdFinix.MainCorporationEntry.Input;
using __MaHtml__ = global::TestProjectAdFinix.MainCorporationEntry.Input.Html;
using __MFrAverageC__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.Input.AverageCommission;
using __MaName__ = global::TestProjectAdFinix.MainCorporationEntry.Input.Name;
using __MaCorporat__ = global::TestProjectAdFinix.MainCorporationEntry.Input.CorporationNameView;
using __MaFranchis3__ = global::TestProjectAdFinix.MainCorporationEntry.Input.FranchiseName;
using __MaAddNewFr__ = global::TestProjectAdFinix.MainCorporationEntry.Input.AddNewFranchise;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __MaSaveTrig__ = global::TestProjectAdFinix.MainCorporationEntry.Input.SaveTrigger;
using __MFrTotalCom__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.Input.TotalCommission;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MFrName__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.Input.Name;
using __MainCorp__ = global::TestProjectAdFinix.MainCorporationEntry;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MaSchema__ = global::TestProjectAdFinix.MainCorporationEntry.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __MaFranchis__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson;
using __MFrSchema__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.JsonByExample.Schema;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __MaFranchis1__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.JsonByExample;
using __MaFranchis2__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.Input;
using __MFrLink__ = global::TestProjectAdFinix.MainCorporationEntry.FranchiseOfficesElementJson.Input.Link;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MainCorporationEntry_json : s::TemplateAttribute {
    
    #line hidden
    public class FranchiseOffices : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class MainCorporationEntry : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainCorporationEntry() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainCorporationEntry(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new MainCorporation Data { get { return (MainCorporation)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__MainCorp__);
                ClassName = "MainCorporationEntry";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/TestProjectAdFinix/MainCorporationEntry.html";
                Html.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (MainCorporationEntry)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainCorporationEntry)pup).Handle((Input.SaveTrigger)input); });
                CorporationNameView = Add<__TString__>("CorporationNameView", bind:"CorporationNameView");
                CorporationNameView.DefaultValue = "";
                CorporationNameView.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__CorporationNameView__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__CorporationNameView__ = (System.String)_v_; }, false);
                Corporations = Add<__TArray__>("Corporations");
                Corporations.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__Corporations__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__Corporations__ = (__Arr__)_v_; }, false);
                FranchiseName = Add<__TString__>("FranchiseName$");
                FranchiseName.DefaultValue = "";
                FranchiseName.Editable = true;
                FranchiseName.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                AddNewFranchise = Add<__TLong__>("AddNewFranchise$");
                AddNewFranchise.DefaultValue = 0L;
                AddNewFranchise.Editable = true;
                AddNewFranchise.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__AddNewFranchise__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__AddNewFranchise__ = (System.Int64)_v_; }, false);
                AddNewFranchise.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddNewFranchise() { App = (MainCorporationEntry)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainCorporationEntry)pup).Handle((Input.AddNewFranchise)input); });
                FranchiseOffices = Add<__TArray1__>("FranchiseOffices");
                FranchiseOffices.SetCustomGetElementType((arr) => { return __MaFranchis__.DefaultTemplate;});
                FranchiseOffices.SetCustomAccessors((_p_) => { return ((__MainCorp__)_p_).__bf__FranchiseOffices__; }, (_p_, _v_) => { ((__MainCorp__)_p_).__bf__FranchiseOffices__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __MainCorp__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ SaveTrigger;
            public __TString__ CorporationNameView;
            public __TArray__ Corporations;
            public __TString__ FranchiseName;
            public __TLong__ AddNewFranchise;
            public __TArray1__ FranchiseOffices;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 4 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 4 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CorporationNameView__;
    #line default
    #line hidden
    private __Arr__ __bf__Corporations__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Corporations {
    #line 6 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.Corporations.Getter(this); }
        #line 6 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.Corporations.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiseName {
    #line 7 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 7 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddNewFranchise__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddNewFranchise {
    #line 8 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.AddNewFranchise.Getter(this); }
        #line 8 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.AddNewFranchise.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__FranchiseOffices__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ FranchiseOffices {
    #line 18 "MainCorporationEntry.json"
        get {
        #line hidden
            return Template.FranchiseOffices.Getter(this); }
        #line 18 "MainCorporationEntry.json"
        set {
        #line hidden
            Template.FranchiseOffices.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class FranchiseOfficesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MFrSchema__ DefaultTemplate = new __MFrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FranchiseOfficesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FranchiseOfficesElementJson(__MFrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __MFrSchema__ Template { get { return (__MFrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__MaFranchis__);
                    ClassName = "FranchiseOfficesElementJson";
                    Properties.ClearExposed();
                    Link = Add<__TString__>("Link");
                    Link.DefaultValue = "";
                    Link.SetCustomAccessors((_p_) => { return ((__MaFranchis__)_p_).__bf__Link__; }, (_p_, _v_) => { ((__MaFranchis__)_p_).__bf__Link__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__MaFranchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MaFranchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    NumberOfHomesSold = Add<__TLong__>("NumberOfHomesSold");
                    NumberOfHomesSold.DefaultValue = 0L;
                    NumberOfHomesSold.SetCustomAccessors((_p_) => { return ((__MaFranchis__)_p_).__bf__NumberOfHomesSold__; }, (_p_, _v_) => { ((__MaFranchis__)_p_).__bf__NumberOfHomesSold__ = (System.Int64)_v_; }, false);
                    TotalCommission = Add<__TDecimal__>("TotalCommission");
                    TotalCommission.DefaultValue = 0.0m;
                    TotalCommission.SetCustomAccessors((_p_) => { return ((__MaFranchis__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__MaFranchis__)_p_).__bf__TotalCommission__ = (System.Decimal)_v_; }, false);
                    AverageCommission = Add<__TDecimal__>("AverageCommission");
                    AverageCommission.DefaultValue = 0.0m;
                    AverageCommission.SetCustomAccessors((_p_) => { return ((__MaFranchis__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__MaFranchis__)_p_).__bf__AverageCommission__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MaFranchis__(this) { Parent = parent }; }
                public __TString__ Link;
                public __TString__ Name;
                public __TLong__ NumberOfHomesSold;
                public __TDecimal__ TotalCommission;
                public __TDecimal__ AverageCommission;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Link__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Link {
        #line 11 "MainCorporationEntry.json"
            get {
            #line hidden
                return Template.Link.Getter(this); }
            #line 11 "MainCorporationEntry.json"
            set {
            #line hidden
                Template.Link.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 12 "MainCorporationEntry.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 12 "MainCorporationEntry.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__NumberOfHomesSold__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 NumberOfHomesSold {
        #line 13 "MainCorporationEntry.json"
            get {
            #line hidden
                return Template.NumberOfHomesSold.Getter(this); }
            #line 13 "MainCorporationEntry.json"
            set {
            #line hidden
                Template.NumberOfHomesSold.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__TotalCommission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal TotalCommission {
        #line 14 "MainCorporationEntry.json"
            get {
            #line hidden
                return Template.TotalCommission.Getter(this); }
            #line 14 "MainCorporationEntry.json"
            set {
            #line hidden
                Template.TotalCommission.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__AverageCommission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AverageCommission {
        #line 16 "MainCorporationEntry.json"
            get {
            #line hidden
                return Template.AverageCommission.Getter(this); }
            #line 16 "MainCorporationEntry.json"
            set {
            #line hidden
                Template.AverageCommission.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Link : Input<__MaFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__MaFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class NumberOfHomesSold : Input<__MaFranchis__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class TotalCommission : Input<__MaFranchis__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class AverageCommission : Input<__MaFranchis__, __TDecimal__, Decimal> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__MainCorp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__MainCorp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__MainCorp__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CorporationNameView : Input<__MainCorp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiseName : Input<__MainCorp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNewFranchise : Input<__MainCorp__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
