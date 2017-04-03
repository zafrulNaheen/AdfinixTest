// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiseOfficesDetail.json"
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
using __FFrZipCode__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.ZipCode;
using __FFrCountry__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.Country;
using __FrHomeInfo__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson;
using __FrHomeInfo1__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.JsonByExample;
using __FrHomeInfo2__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input;
using __FHoName__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.Name;
using __FHoStreet__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.Street;
using __FHoNumber__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.Number;
using __FHoZipCode__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.ZipCode;
using __FHoCity__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.City;
using __FHoAddress__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.Address;
using __FHoCountry__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.Input.Country;
using __FrTransact__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson;
using __FFrAddress__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.Address;
using __FrTransact1__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson.JsonByExample;
using __FTrDate__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson.Input.Date;
using __FTrSalesPri__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson.Input.SalesPrice;
using __FTrCommissi__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson.Input.Commission;
using __Arr__ = global::Starcounter.Arr<global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson>;
using __Franchis2__ = global::TestProjectAdFinix.FranchiseOfficesDetail.Input;
using __FrHtml__ = global::TestProjectAdFinix.FranchiseOfficesDetail.Input.Html;
using __FrAddFranc__ = global::TestProjectAdFinix.FranchiseOfficesDetail.Input.AddFranchiseSettings;
using __FrAddHomeI__ = global::TestProjectAdFinix.FranchiseOfficesDetail.Input.AddHomeInformation;
using __FrAddHomeS__ = global::TestProjectAdFinix.FranchiseOfficesDetail.Input.AddHomeSaleInformation;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __FrTransact2__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson.Input;
using __FFrCity__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.City;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FFrNumber__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.Number;
using __Franchis__ = global::TestProjectAdFinix.FranchiseOfficesDetail;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::TestProjectAdFinix.FranchiseOfficesDetail.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FFrSchema__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __FHoSchema__ = global::TestProjectAdFinix.FranchiseOfficesDetail.HomeInformationJson.JsonByExample.Schema;
using __FTrSchema__ = global::TestProjectAdFinix.FranchiseOfficesDetail.TransactionInfoJson.JsonByExample.Schema;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __FrSoldHome__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __FSoSchema__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.JsonByExample.Schema;
using __FrSoldHome2__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.Input;
using __FSoDate__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.Input.Date;
using __FSoPrice__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.Input.Price;
using __FSoCommissi__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.Input.Commission;
using __FSoAddress__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.Input.Address;
using __TArray__ = global::Starcounter.Templates.TArray<global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson>;
using __Franchis1__ = global::TestProjectAdFinix.FranchiseOfficesDetail.JsonByExample;
using __FrFranchis__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson;
using __FrFranchis1__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.JsonByExample;
using __FrFranchis2__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input;
using __FFrName__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.Name;
using __FFrStreet__ = global::TestProjectAdFinix.FranchiseOfficesDetail.FranchiseSettingsJson.Input.Street;
using __FrSoldHome1__ = global::TestProjectAdFinix.FranchiseOfficesDetail.SoldHomeListElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseOfficesDetail_json : s::TemplateAttribute {
    
    #line hidden
    public class FranchiseSettings : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class HomeInformation : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class TransactionInfo : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class SoldHomeList : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class FranchiseOfficesDetail : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficesDetail() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficesDetail(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new FranchiseOffice Data { get { return (FranchiseOffice)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                ClassName = "FranchiseOfficesDetail";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/TestProjectAdFinix/FranchiseOfficesDetail.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FranchiseSettings = Add<__FFrSchema__>("FranchiseSettings");
                FranchiseSettings.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FranchiseSettings__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FranchiseSettings__ = (__FrFranchis__)_v_; }, false);
                AddFranchiseSettings = Add<__TLong__>("AddFranchiseSettings$");
                AddFranchiseSettings.DefaultValue = 0L;
                AddFranchiseSettings.Editable = true;
                AddFranchiseSettings.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AddFranchiseSettings__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AddFranchiseSettings__ = (System.Int64)_v_; }, false);
                AddFranchiseSettings.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddFranchiseSettings() { App = (FranchiseOfficesDetail)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseOfficesDetail)pup).Handle((Input.AddFranchiseSettings)input); });
                HomeInformation = Add<__FHoSchema__>("HomeInformation");
                HomeInformation.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeInformation__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeInformation__ = (__FrHomeInfo__)_v_; }, false);
                AddHomeInformation = Add<__TLong__>("AddHomeInformation$");
                AddHomeInformation.DefaultValue = 0L;
                AddHomeInformation.Editable = true;
                AddHomeInformation.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AddHomeInformation__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AddHomeInformation__ = (System.Int64)_v_; }, false);
                TransactionInfo = Add<__FTrSchema__>("TransactionInfo");
                TransactionInfo.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TransactionInfo__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TransactionInfo__ = (__FrTransact__)_v_; }, false);
                AddHomeSaleInformation = Add<__TLong__>("AddHomeSaleInformation$");
                AddHomeSaleInformation.DefaultValue = 0L;
                AddHomeSaleInformation.Editable = true;
                AddHomeSaleInformation.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AddHomeSaleInformation__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AddHomeSaleInformation__ = (System.Int64)_v_; }, false);
                AddHomeSaleInformation.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddHomeSaleInformation() { App = (FranchiseOfficesDetail)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseOfficesDetail)pup).Handle((Input.AddHomeSaleInformation)input); });
                SoldHomeList = Add<__TArray__>("SoldHomeList");
                SoldHomeList.SetCustomGetElementType((arr) => { return __FrSoldHome__.DefaultTemplate;});
                SoldHomeList.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SoldHomeList__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SoldHomeList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __FFrSchema__ FranchiseSettings;
            public __TLong__ AddFranchiseSettings;
            public __FHoSchema__ HomeInformation;
            public __TLong__ AddHomeInformation;
            public __FTrSchema__ TransactionInfo;
            public __TLong__ AddHomeSaleInformation;
            public __TArray__ SoldHomeList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __FrFranchis__ __bf__FranchiseSettings__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __FrFranchis__ FranchiseSettings {
    #line 11 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return (__FrFranchis__)Template.FranchiseSettings.Getter(this); }
        #line 11 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.FranchiseSettings.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddFranchiseSettings__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddFranchiseSettings {
    #line 12 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return Template.AddFranchiseSettings.Getter(this); }
        #line 12 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.AddFranchiseSettings.Setter(this, value); } }
        #line default
    #line hidden
    private __FrHomeInfo__ __bf__HomeInformation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __FrHomeInfo__ HomeInformation {
    #line 21 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return (__FrHomeInfo__)Template.HomeInformation.Getter(this); }
        #line 21 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.HomeInformation.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddHomeInformation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddHomeInformation {
    #line 22 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return Template.AddHomeInformation.Getter(this); }
        #line 22 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.AddHomeInformation.Setter(this, value); } }
        #line default
    #line hidden
    private __FrTransact__ __bf__TransactionInfo__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __FrTransact__ TransactionInfo {
    #line 27 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return (__FrTransact__)Template.TransactionInfo.Getter(this); }
        #line 27 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.TransactionInfo.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddHomeSaleInformation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddHomeSaleInformation {
    #line 28 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return Template.AddHomeSaleInformation.Getter(this); }
        #line 28 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.AddHomeSaleInformation.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__SoldHomeList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ SoldHomeList {
    #line 38 "ViewModels\FranchiseOfficesDetail.json"
        get {
        #line hidden
            return Template.SoldHomeList.Getter(this); }
        #line 38 "ViewModels\FranchiseOfficesDetail.json"
        set {
        #line hidden
            Template.SoldHomeList.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class FranchiseSettingsJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FFrSchema__ DefaultTemplate = new __FFrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FranchiseSettingsJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FranchiseSettingsJson(__FFrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FFrSchema__ Template { get { return (__FFrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrFranchis__);
                    ClassName = "FranchiseSettingsJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    Number = Add<__TString__>("Number$");
                    Number.DefaultValue = "";
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                    ZipCode = Add<__TString__>("ZipCode$");
                    ZipCode.DefaultValue = "";
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Address = Add<__TString__>("Address$");
                    Address.DefaultValue = "";
                    Address.Editable = true;
                    Address.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__FrFranchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__FrFranchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __FrFranchis__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ Street;
                public __TString__ Number;
                public __TString__ ZipCode;
                public __TString__ City;
                public __TString__ Address;
                public __TString__ Country;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 4 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 4 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Street {
        #line 5 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 5 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Number {
        #line 6 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 6 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipCode {
        #line 7 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 7 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 8 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 8 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Address {
        #line 9 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Address.Getter(this); }
            #line 9 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 11 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 11 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Address : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__FrFranchis__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class HomeInformationJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FHoSchema__ DefaultTemplate = new __FHoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public HomeInformationJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public HomeInformationJson(__FHoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FHoSchema__ Template { get { return (__FHoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrHomeInfo__);
                    ClassName = "HomeInformationJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    Number = Add<__TString__>("Number$");
                    Number.DefaultValue = "";
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                    ZipCode = Add<__TString__>("ZipCode$");
                    ZipCode.DefaultValue = "";
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__City__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Address = Add<__TString__>("Address$");
                    Address.DefaultValue = "";
                    Address.Editable = true;
                    Address.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__FrHomeInfo__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__FrHomeInfo__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __FrHomeInfo__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ Street;
                public __TString__ Number;
                public __TString__ ZipCode;
                public __TString__ City;
                public __TString__ Address;
                public __TString__ Country;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 14 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 14 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Street {
        #line 15 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 15 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Number {
        #line 16 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 16 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipCode {
        #line 17 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 17 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 18 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 18 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Address {
        #line 19 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Address.Getter(this); }
            #line 19 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 21 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 21 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Address : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__FrHomeInfo__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class TransactionInfoJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FTrSchema__ DefaultTemplate = new __FTrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TransactionInfoJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TransactionInfoJson(__FTrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FTrSchema__ Template { get { return (__FTrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrTransact__);
                    ClassName = "TransactionInfoJson";
                    Properties.ClearExposed();
                    Date = Add<__TString__>("Date$");
                    Date.DefaultValue = "";
                    Date.Editable = true;
                    Date.SetCustomAccessors((_p_) => { return ((__FrTransact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__FrTransact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                    SalesPrice = Add<__TDecimal__>("SalesPrice$");
                    SalesPrice.DefaultValue = 0.0m;
                    SalesPrice.Editable = true;
                    SalesPrice.SetCustomAccessors((_p_) => { return ((__FrTransact__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__FrTransact__)_p_).__bf__SalesPrice__ = (System.Decimal)_v_; }, false);
                    Commission = Add<__TDecimal__>("Commission$");
                    Commission.DefaultValue = 0.0m;
                    Commission.Editable = true;
                    Commission.SetCustomAccessors((_p_) => { return ((__FrTransact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__FrTransact__)_p_).__bf__Commission__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __FrTransact__(this) { Parent = parent }; }
                public __TString__ Date;
                public __TDecimal__ SalesPrice;
                public __TDecimal__ Commission;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Date__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Date {
        #line 24 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Date.Getter(this); }
            #line 24 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Date.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__SalesPrice__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal SalesPrice {
        #line 25 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.SalesPrice.Getter(this); }
            #line 25 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.SalesPrice.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__Commission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal Commission {
        #line 27 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Commission.Getter(this); }
            #line 27 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Commission.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Date : Input<__FrTransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class SalesPrice : Input<__FrTransact__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Commission : Input<__FrTransact__, __TDecimal__, Decimal> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class SoldHomeListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FSoSchema__ DefaultTemplate = new __FSoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SoldHomeListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SoldHomeListElementJson(__FSoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FSoSchema__ Template { get { return (__FSoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrSoldHome__);
                    ClassName = "SoldHomeListElementJson";
                    Properties.ClearExposed();
                    Date = Add<__TString__>("Date");
                    Date.DefaultValue = "";
                    Date.SetCustomAccessors((_p_) => { return ((__FrSoldHome__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__FrSoldHome__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                    Price = Add<__TDecimal__>("Price");
                    Price.DefaultValue = 0.0m;
                    Price.SetCustomAccessors((_p_) => { return ((__FrSoldHome__)_p_).__bf__Price__; }, (_p_, _v_) => { ((__FrSoldHome__)_p_).__bf__Price__ = (System.Decimal)_v_; }, false);
                    Commission = Add<__TDecimal__>("Commission");
                    Commission.DefaultValue = 0.0m;
                    Commission.SetCustomAccessors((_p_) => { return ((__FrSoldHome__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__FrSoldHome__)_p_).__bf__Commission__ = (System.Decimal)_v_; }, false);
                    Address = Add<__TString__>("Address");
                    Address.DefaultValue = "";
                    Address.SetCustomAccessors((_p_) => { return ((__FrSoldHome__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__FrSoldHome__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __FrSoldHome__(this) { Parent = parent }; }
                public __TString__ Date;
                public __TDecimal__ Price;
                public __TDecimal__ Commission;
                public __TString__ Address;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Date__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Date {
        #line 31 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Date.Getter(this); }
            #line 31 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Date.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__Price__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal Price {
        #line 32 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Price.Getter(this); }
            #line 32 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Price.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__Commission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal Commission {
        #line 33 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Commission.Getter(this); }
            #line 33 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Commission.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Address {
        #line 35 "ViewModels\FranchiseOfficesDetail.json"
            get {
            #line hidden
                return Template.Address.Getter(this); }
            #line 35 "ViewModels\FranchiseOfficesDetail.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Date : Input<__FrSoldHome__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Price : Input<__FrSoldHome__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Commission : Input<__FrSoldHome__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Address : Input<__FrSoldHome__, __TString__, string> {
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
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddFranchiseSettings : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddHomeInformation : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddHomeSaleInformation : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
